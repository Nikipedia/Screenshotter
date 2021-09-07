using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Windows;
using WK.Libraries.SharpClipboardNS;
using static WK.Libraries.SharpClipboardNS.SharpClipboard;
using System.IO;

namespace Screenshotter_Form
{
    
    public partial class Form1 : Form
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        private bool _Moving = false;
        private Point _Offset;
        private Hotkeys.GlobalHotkey ghk;
        private bool writingEnabled;
        private IDataObject oldData = null;
        public bool startWriting = false;
        static string message;
        private Image oldIMG = null;
        private float timeSinceLast = 0;
        SharpClipboard clipboard = null;
        private bool isVisible = true;
        public Form1()
        {
            InitializeComponent();
            ghk = new Hotkeys.GlobalHotkey(Hotkeys.Constants.SHIFT + Hotkeys.Constants.CTRL, Keys.Y, this);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            if (isVisible)
            {
                this.Hide();
                pictureBox1.Image.Dispose();
                pictureBox2.Image.Dispose();
                pictureBox3.Image.Dispose();
            }
            else
            {
                this.Show();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                this.Refresh();
                pictureBox1.WaitOnLoad = false;
                pictureBox2.WaitOnLoad = false;
                pictureBox3.WaitOnLoad = false;
                if (File.Exists(Properties.Settings.Default.PicturePath1) && File.Exists(Properties.Settings.Default.PicturePath2) && File.Exists(Properties.Settings.Default.PicturePath3))
                {
                    pictureBox1.LoadAsync(Properties.Settings.Default.PicturePath1);
                    pictureBox2.LoadAsync(Properties.Settings.Default.PicturePath2);
                    pictureBox3.LoadAsync(Properties.Settings.Default.PicturePath3);
                }
            }
            isVisible = !isVisible;
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult res = FolderBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                FolderName.Text = FolderBrowser.SelectedPath;
            }
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult res = FileBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileName.Text = FileBrowser.FileName;
                LoadListFromFile(FileName.Text);
            }
        }

        private void LoadListFromFile(string fileName)
        {
            if (System.IO.File.Exists(fileName))
            {
                Properties.Settings.Default.GoalPath = fileName;
                Properties.Settings.Default.Save();
                NotStarted.Clear();
                InProgress.Clear();
                Done.Clear();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                bool inprogress = false;
                bool done = false;
                foreach (string line in lines)
                {
                    if (!inprogress && !done)
                    {
                        if (line == "-InProgress-") inprogress = true; 
                        else NotStarted.Items.Add(line);
                        continue;
                    }
                    if(inprogress && !done)
                    {
                        if (line == "-Done-") done = true;
                        else InProgress.Items.Add(line);
                        continue;
                    }
                    else if(inprogress && done)
                    {
                        Done.Items.Add(line);
                    }
                }
            }
        }

        /*
kochen
-InProgress-
schlafen
-Done-
Klavier spielen
         */
        private void WriteListsToFile()
        {
            if (System.IO.File.Exists(FileName.Text) || MessageBox.Show("This will create a new file, " + FileName.Text + ".", "Create New File", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ListViewItem[] lines = new ListViewItem[NotStarted.Items.Count + InProgress.Items.Count + Done.Items.Count + 2];
                NotStarted.Items.CopyTo(lines, 0);
                lines[NotStarted.Items.Count] = new ListViewItem("-InProgress-");
                InProgress.Items.CopyTo(lines, NotStarted.Items.Count + 1);
                lines[NotStarted.Items.Count + InProgress.Items.Count + 1] = new ListViewItem("-Done-");
                Done.Items.CopyTo(lines, NotStarted.Items.Count + InProgress.Items.Count + 2);
                Converter<ListViewItem, string> convert = x => x.Text;
                System.IO.File.WriteAllLines(FileName.Text, lines.ToList().ConvertAll(convert).ToArray());
                Properties.Settings.Default.GoalPath = FileName.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                FileName.Text = Properties.Settings.Default.GoalPath;
                WriteListsToFile();
            }
        }

        private void StartMonitoring_Click(object sender, EventArgs e)
        {
            if (!writingEnabled && System.IO.Directory.Exists(FolderName.Text))
            {
                writingEnabled = true;
                startWriting = true;
                Properties.Settings.Default.FilePath = FolderName.Text;
                Properties.Settings.Default.Save();
                StartMonitoringMethod();
            }
            else
            {
                if (writingEnabled)
                {
                    StopMonitoring();
                    writingEnabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderName.Text = Properties.Settings.Default.FilePath;
            FileName.Text = Properties.Settings.Default.GoalPath;
            LoadListFromFile(FileName.Text);
            if (File.Exists(Properties.Settings.Default.PicturePath1) && File.Exists(Properties.Settings.Default.PicturePath2) && File.Exists(Properties.Settings.Default.PicturePath3))
            {
                pictureBox1.Image = Image.FromFile(Properties.Settings.Default.PicturePath1);
                pictureBox2.Image = Image.FromFile(Properties.Settings.Default.PicturePath2);
                pictureBox3.Image = Image.FromFile(Properties.Settings.Default.PicturePath3);
            }
            if (!ghk.Register())
            {
                MessageLabel.Text = "Could not register hotkey!";
            }
        }

        private void ClipboardChanged(Object sender, ClipboardChangedEventArgs e)
        {
            if (e.ContentType == SharpClipboard.ContentTypes.Image)
            {
                // Get the cut/copied image.
                Image img = clipboard.ClipboardImage;
                if (oldIMG == null || !oldIMG.Equals(img))
                {
                    img.Save(Properties.Settings.Default.FilePath + "\\" + DateTime.Now.ToFileTime() + ".png");
                    message = "Saved as " + Properties.Settings.Default.FilePath + "\\" + DateTime.Now.ToFileTime() + ".png";
                    Output.Text = message;
                    oldIMG = img;
                }
            }
            else
            {
                Output.Text = "Not a picture";
            }
        }

        void StopMonitoring()
        {
            clipboard.StopMonitoring();
            message = "Stopped Monitoring";
            Output.Text = message;

            StartMonitoring.Text = "Start";
        }


        public void StartMonitoringMethod()
        {
            clipboard = new SharpClipboard();

            clipboard.ObservableFormats.Texts = false;
            clipboard.ObservableFormats.Files = false;
            clipboard.ObservableFormats.Images = true;
            clipboard.ObservableFormats.Others = false;

            clipboard.StartMonitoring(); 

            clipboard.ClipboardChanged += ClipboardChanged;

            message = "Started Monitoring";
            Output.Text = message;

            StartMonitoring.Text = "Stop";
        }

        void ListenForClipboardChange()
        {
            if (startWriting)
            {
                while (true)
                {
                    message = "Listening  " + DateTime.Now.ToString();
                    var data = Clipboard.GetDataObject();
                    if (data != null)
                    {
                        message = "Data is there";
                        if (!data.Equals(oldData))
                        {
                            message = "New data is there";
                            oldData = data;
                            if (Clipboard.ContainsImage())
                            {
                                Image img = Clipboard.GetImage();
                                img.Save(Properties.Settings.Default.FilePath + DateTime.Now.ToString());
                                message = "Wrote to " + Properties.Settings.Default.FilePath + DateTime.Now.ToString();
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ghk.Unregiser();
        }

        private void AddNotStarted_Click(object sender, EventArgs e)
        {
            string f = Prompt.ShowDialog("Enter new goal", "");
            if (f != "")
            {
                NotStarted.Items.Add(f);
                WriteListsToFile();
            }
        }

        private void AddInProgress_Click(object sender, EventArgs e)
        {
            string f = Prompt.ShowDialog("Enter new goal", "");
            if (f != "")
            {
                InProgress.Items.Add(f);
                WriteListsToFile();
            }
        }

        private void AddDone_Click(object sender, EventArgs e)
        {
            string f = Prompt.ShowDialog("Enter new goal", "");
            if (f != "")
            {
                Done.Items.Add(f);
                WriteListsToFile();
            }
        }

        private void RemoveDone_Click(object sender, EventArgs e)
        {
            if(Done.SelectedItems.Count == 1)
            {
                var result = MessageBox.Show("Do you really want to remove " + Done.SelectedItems[0].Text + "?", "Removing Goal", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Done.Items.Remove(Done.SelectedItems[0]);
                    WriteListsToFile();
                }
            }
        }

        private void RemoveInProgress_Click(object sender, EventArgs e)
        {
            if (InProgress.SelectedItems.Count == 1)
            {
                var result = MessageBox.Show("Do you really want to remove " + InProgress.SelectedItems[0].Text + "?", "Removing Goal", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InProgress.Items.Remove(InProgress.SelectedItems[0]);
                    WriteListsToFile();
                }
            }
        }

        private void RemoveNotStarted_Click(object sender, EventArgs e)
        {
            if (NotStarted.SelectedItems.Count == 1)
            {
                var result = MessageBox.Show("Do you really want to remove " + NotStarted.SelectedItems[0].Text + "?", "Removing Goal", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NotStarted.Items.Remove(NotStarted.SelectedItems[0]);
                    WriteListsToFile();
                }
            }
        }

        private void InProgress_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void InProgress_DragDrop(object sender, DragEventArgs e)
        {
            InProgress.Items.Add(new ListViewItem((string)e.Data.GetData("Text")));
        }

        private void NotStarted_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //Label x = new Label();
            //x.Text = NotStarted.SelectedItems[0].Text;
            ((ListView)sender).DoDragDrop(NotStarted.SelectedItems[0].Text, DragDropEffects.Move);
            NotStarted.Items.Remove(NotStarted.SelectedItems[0]);
            WriteListsToFile();
        }

        private void NotStarted_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void NotStarted_DragDrop(object sender, DragEventArgs e)
        {
            NotStarted.Items.Add(new ListViewItem((string)e.Data.GetData("Text")));
        }

        private void InProgress_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ((ListView)sender).DoDragDrop(InProgress.SelectedItems[0].Text, DragDropEffects.Move);
            InProgress.Items.Remove(InProgress.SelectedItems[0]);
            WriteListsToFile();
        }

        private void Done_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ((ListView)sender).DoDragDrop(Done.SelectedItems[0].Text, DragDropEffects.Move);
            Done.Items.Remove(Done.SelectedItems[0]);
            WriteListsToFile();
        }

        private void Done_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void Done_DragDrop(object sender, DragEventArgs e)
        {
            Done.Items.Add(new ListViewItem((string)e.Data.GetData("Text")));
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox overlay = new PictureBox();

            overlay.Dock = DockStyle.Fill;
            overlay.BackColor = Color.FromArgb(20, Color.Black);
            overlay.Enabled = false;

            /*Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = "+";
            l.Font = new Font("Microsoft Sans Serif", 50);
            l.Enabled = false;
            l.AutoSize = true;

            pictureBox1.Controls.Add(l);*/
            pictureBox1.Controls.Add(overlay);

        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = FileBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (ImageExtensions.Contains(Path.GetExtension(FileBrowser.FileName).ToUpperInvariant()))
                {
                    if(pictureBox1.Image !=null)
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(FileBrowser.FileName);
                    Properties.Settings.Default.PicturePath1 = FileBrowser.FileName;
                    Properties.Settings.Default.Save();
                    GC.Collect();
                }
            }
            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult res = FileBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (ImageExtensions.Contains(Path.GetExtension(FileBrowser.FileName).ToUpperInvariant()))
                {
                    if (pictureBox3.Image != null)
                        pictureBox3.Image.Dispose();
                    pictureBox3.Image = Image.FromFile(FileBrowser.FileName);
                    Properties.Settings.Default.PicturePath3 = FileBrowser.FileName;
                    Properties.Settings.Default.Save();
                    GC.Collect();
                }
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult res = FileBrowser.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (ImageExtensions.Contains(Path.GetExtension(FileBrowser.FileName).ToUpperInvariant()))
                {
                    if (pictureBox2.Image != null)
                        pictureBox2.Image.Dispose();
                    pictureBox2.Image = Image.FromFile(FileBrowser.FileName);
                    Properties.Settings.Default.PicturePath2 = FileBrowser.FileName;
                    Properties.Settings.Default.Save();
                    GC.Collect();
                }
            }
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            PictureBox overlay = new PictureBox();

            overlay.Dock = DockStyle.Fill;
            overlay.BackColor = Color.FromArgb(15, Color.Black);
            overlay.Enabled = false;

            /*Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = "+";
            l.Font = new Font("Microsoft Sans Serif", 50);
            l.Enabled = false;
            l.AutoSize = true;

            pictureBox1.Controls.Add(l);*/
            pictureBox3.Controls.Add(overlay);
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Controls.Clear();
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox overlay = new PictureBox();

            overlay.Dock = DockStyle.Fill;
            overlay.BackColor = Color.FromArgb(15, Color.Black);
            overlay.Enabled = false;

            /*Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Text = "+";
            l.Font = new Font("Microsoft Sans Serif", 50);
            l.Enabled = false;
            l.AutoSize = true;

            pictureBox1.Controls.Add(l);*/
            pictureBox2.Controls.Add(overlay);
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Controls.Clear();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _Moving = true;
            _Offset = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                Point newlocation = this.Location;
                newlocation.X += e.X - _Offset.X;
                newlocation.Y += e.Y - _Offset.Y;
                this.Location = newlocation;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                _Moving = false;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
