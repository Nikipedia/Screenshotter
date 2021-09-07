namespace Screenshotter_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.FolderName = new System.Windows.Forms.TextBox();
            this.StartMonitoring = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.NotStarted = new System.Windows.Forms.ListView();
            this.InProgress = new System.Windows.Forms.ListView();
            this.Done = new System.Windows.Forms.ListView();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.AddNotStarted = new System.Windows.Forms.Button();
            this.AddInProgress = new System.Windows.Forms.Button();
            this.AddDone = new System.Windows.Forms.Button();
            this.RemoveNotStarted = new System.Windows.Forms.Button();
            this.RemoveInProgress = new System.Windows.Forms.Button();
            this.RemoveDone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.BackColor = System.Drawing.Color.Gray;
            this.ChooseFolder.FlatAppearance.BorderSize = 0;
            this.ChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFolder.Location = new System.Drawing.Point(15, 38);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(103, 23);
            this.ChooseFolder.TabIndex = 0;
            this.ChooseFolder.Text = "Choose Folder";
            this.ChooseFolder.UseVisualStyleBackColor = false;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // FolderName
            // 
            this.FolderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FolderName.Location = new System.Drawing.Point(127, 41);
            this.FolderName.Name = "FolderName";
            this.FolderName.Size = new System.Drawing.Size(237, 20);
            this.FolderName.TabIndex = 1;
            // 
            // StartMonitoring
            // 
            this.StartMonitoring.BackColor = System.Drawing.Color.Gray;
            this.StartMonitoring.FlatAppearance.BorderSize = 0;
            this.StartMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartMonitoring.Font = new System.Drawing.Font("Impact", 20F);
            this.StartMonitoring.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartMonitoring.Location = new System.Drawing.Point(578, 18);
            this.StartMonitoring.Name = "StartMonitoring";
            this.StartMonitoring.Size = new System.Drawing.Size(153, 62);
            this.StartMonitoring.TabIndex = 2;
            this.StartMonitoring.Text = "Start";
            this.StartMonitoring.UseVisualStyleBackColor = false;
            this.StartMonitoring.Click += new System.EventHandler(this.StartMonitoring_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Impact", 9.75F);
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Output.Location = new System.Drawing.Point(15, 70);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 17);
            this.Output.TabIndex = 3;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageLabel.Location = new System.Drawing.Point(378, 43);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 17);
            this.MessageLabel.TabIndex = 4;
            // 
            // NotStarted
            // 
            this.NotStarted.AllowDrop = true;
            this.NotStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NotStarted.HideSelection = false;
            this.NotStarted.Location = new System.Drawing.Point(15, 69);
            this.NotStarted.Name = "NotStarted";
            this.NotStarted.Size = new System.Drawing.Size(208, 256);
            this.NotStarted.TabIndex = 5;
            this.NotStarted.TileSize = new System.Drawing.Size(185, 30);
            this.NotStarted.UseCompatibleStateImageBehavior = false;
            this.NotStarted.View = System.Windows.Forms.View.Tile;
            this.NotStarted.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.NotStarted_ItemDrag);
            this.NotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.NotStarted_DragDrop);
            this.NotStarted.DragOver += new System.Windows.Forms.DragEventHandler(this.NotStarted_DragOver);
            // 
            // InProgress
            // 
            this.InProgress.AllowDrop = true;
            this.InProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.InProgress.HideSelection = false;
            this.InProgress.Location = new System.Drawing.Point(269, 69);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(208, 256);
            this.InProgress.TabIndex = 6;
            this.InProgress.TileSize = new System.Drawing.Size(185, 30);
            this.InProgress.UseCompatibleStateImageBehavior = false;
            this.InProgress.View = System.Windows.Forms.View.Tile;
            this.InProgress.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.InProgress_ItemDrag);
            this.InProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.InProgress_DragDrop);
            this.InProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.InProgress_DragOver);
            // 
            // Done
            // 
            this.Done.AllowColumnReorder = true;
            this.Done.AllowDrop = true;
            this.Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Done.HideSelection = false;
            this.Done.Location = new System.Drawing.Point(523, 69);
            this.Done.MultiSelect = false;
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(208, 256);
            this.Done.TabIndex = 7;
            this.Done.TileSize = new System.Drawing.Size(185, 30);
            this.Done.UseCompatibleStateImageBehavior = false;
            this.Done.View = System.Windows.Forms.View.Tile;
            this.Done.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Done_ItemDrag);
            this.Done.DragDrop += new System.Windows.Forms.DragEventHandler(this.Done_DragDrop);
            this.Done.DragOver += new System.Windows.Forms.DragEventHandler(this.Done_DragOver);
            // 
            // ChooseFile
            // 
            this.ChooseFile.BackColor = System.Drawing.Color.Gray;
            this.ChooseFile.FlatAppearance.BorderSize = 0;
            this.ChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ChooseFile.Location = new System.Drawing.Point(15, 38);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(103, 23);
            this.ChooseFile.TabIndex = 8;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = false;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName.Location = new System.Drawing.Point(127, 39);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(237, 20);
            this.FileName.TabIndex = 9;
            // 
            // AddNotStarted
            // 
            this.AddNotStarted.BackColor = System.Drawing.Color.Gray;
            this.AddNotStarted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNotStarted.BackgroundImage")));
            this.AddNotStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddNotStarted.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddNotStarted.FlatAppearance.BorderSize = 0;
            this.AddNotStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNotStarted.Location = new System.Drawing.Point(65, 331);
            this.AddNotStarted.Name = "AddNotStarted";
            this.AddNotStarted.Size = new System.Drawing.Size(36, 36);
            this.AddNotStarted.TabIndex = 10;
            this.AddNotStarted.UseVisualStyleBackColor = false;
            this.AddNotStarted.Click += new System.EventHandler(this.AddNotStarted_Click);
            // 
            // AddInProgress
            // 
            this.AddInProgress.BackColor = System.Drawing.Color.Gray;
            this.AddInProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddInProgress.BackgroundImage")));
            this.AddInProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddInProgress.FlatAppearance.BorderSize = 0;
            this.AddInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInProgress.Location = new System.Drawing.Point(319, 331);
            this.AddInProgress.Name = "AddInProgress";
            this.AddInProgress.Size = new System.Drawing.Size(36, 36);
            this.AddInProgress.TabIndex = 11;
            this.AddInProgress.UseVisualStyleBackColor = false;
            this.AddInProgress.Click += new System.EventHandler(this.AddInProgress_Click);
            // 
            // AddDone
            // 
            this.AddDone.BackColor = System.Drawing.Color.Gray;
            this.AddDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddDone.BackgroundImage")));
            this.AddDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddDone.FlatAppearance.BorderSize = 0;
            this.AddDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDone.Location = new System.Drawing.Point(573, 331);
            this.AddDone.Name = "AddDone";
            this.AddDone.Size = new System.Drawing.Size(36, 36);
            this.AddDone.TabIndex = 12;
            this.AddDone.UseVisualStyleBackColor = false;
            this.AddDone.Click += new System.EventHandler(this.AddDone_Click);
            // 
            // RemoveNotStarted
            // 
            this.RemoveNotStarted.BackColor = System.Drawing.Color.Gray;
            this.RemoveNotStarted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveNotStarted.BackgroundImage")));
            this.RemoveNotStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveNotStarted.FlatAppearance.BorderSize = 0;
            this.RemoveNotStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveNotStarted.Location = new System.Drawing.Point(127, 331);
            this.RemoveNotStarted.Name = "RemoveNotStarted";
            this.RemoveNotStarted.Size = new System.Drawing.Size(36, 36);
            this.RemoveNotStarted.TabIndex = 13;
            this.RemoveNotStarted.UseVisualStyleBackColor = false;
            this.RemoveNotStarted.Click += new System.EventHandler(this.RemoveNotStarted_Click);
            // 
            // RemoveInProgress
            // 
            this.RemoveInProgress.BackColor = System.Drawing.Color.Gray;
            this.RemoveInProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveInProgress.BackgroundImage")));
            this.RemoveInProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveInProgress.FlatAppearance.BorderSize = 0;
            this.RemoveInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveInProgress.Location = new System.Drawing.Point(381, 331);
            this.RemoveInProgress.Name = "RemoveInProgress";
            this.RemoveInProgress.Size = new System.Drawing.Size(36, 36);
            this.RemoveInProgress.TabIndex = 14;
            this.RemoveInProgress.UseVisualStyleBackColor = false;
            this.RemoveInProgress.Click += new System.EventHandler(this.RemoveInProgress_Click);
            // 
            // RemoveDone
            // 
            this.RemoveDone.BackColor = System.Drawing.Color.Gray;
            this.RemoveDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveDone.BackgroundImage")));
            this.RemoveDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveDone.FlatAppearance.BorderSize = 0;
            this.RemoveDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveDone.Location = new System.Drawing.Point(635, 331);
            this.RemoveDone.Name = "RemoveDone";
            this.RemoveDone.Size = new System.Drawing.Size(36, 36);
            this.RemoveDone.TabIndex = 15;
            this.RemoveDone.UseVisualStyleBackColor = false;
            this.RemoveDone.Click += new System.EventHandler(this.RemoveDone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pictureBox1.Location = new System.Drawing.Point(784, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pictureBox2.Location = new System.Drawing.Point(784, 521);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(624, 431);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.PictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pictureBox3.Location = new System.Drawing.Point(17, 521);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(753, 431);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.PictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.PictureBox3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.ChooseFile);
            this.panel1.Controls.Add(this.Done);
            this.panel1.Controls.Add(this.InProgress);
            this.panel1.Controls.Add(this.RemoveDone);
            this.panel1.Controls.Add(this.NotStarted);
            this.panel1.Controls.Add(this.AddDone);
            this.panel1.Controls.Add(this.RemoveInProgress);
            this.panel1.Controls.Add(this.AddNotStarted);
            this.panel1.Controls.Add(this.RemoveNotStarted);
            this.panel1.Controls.Add(this.AddInProgress);
            this.panel1.Location = new System.Drawing.Point(17, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(753, 381);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MessageLabel);
            this.panel2.Controls.Add(this.Output);
            this.panel2.Controls.Add(this.StartMonitoring);
            this.panel2.Controls.Add(this.FolderName);
            this.panel2.Controls.Add(this.ChooseFolder);
            this.panel2.Location = new System.Drawing.Point(17, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 101);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(1420, 972);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clipboard Monitoring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "To-Do-List";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1420, 984);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Helpful Apps";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.TextBox FolderName;
        private System.Windows.Forms.Button StartMonitoring;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ListView NotStarted;
        private System.Windows.Forms.ListView InProgress;
        private System.Windows.Forms.ListView Done;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button AddNotStarted;
        private System.Windows.Forms.Button AddInProgress;
        private System.Windows.Forms.Button AddDone;
        private System.Windows.Forms.Button RemoveNotStarted;
        private System.Windows.Forms.Button RemoveInProgress;
        private System.Windows.Forms.Button RemoveDone;
        private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

