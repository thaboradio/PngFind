namespace PngFind
{
    partial class frmMain
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
            this.crdImage = new MaterialSkin.Controls.MaterialCard();
            this.btnOpenFolder = new MaterialSkin.Controls.MaterialButton();
            this.mtxtFolderName = new MaterialSkin.Controls.MaterialTextBox();
            this.dvdMain = new MaterialSkin.Controls.MaterialDivider();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.pbMain = new MaterialSkin.Controls.MaterialProgressBar();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFind = new MaterialSkin.Controls.MaterialButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.crdImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // crdImage
            // 
            this.crdImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crdImage.Controls.Add(this.pbImage);
            this.crdImage.Depth = 0;
            this.crdImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crdImage.Location = new System.Drawing.Point(15, 513);
            this.crdImage.Margin = new System.Windows.Forms.Padding(14);
            this.crdImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.crdImage.Name = "crdImage";
            this.crdImage.Padding = new System.Windows.Forms.Padding(14);
            this.crdImage.Size = new System.Drawing.Size(760, 320);
            this.crdImage.TabIndex = 0;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSize = false;
            this.btnOpenFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFolder.Depth = 0;
            this.btnOpenFolder.DrawShadows = true;
            this.btnOpenFolder.HighEmphasis = true;
            this.btnOpenFolder.Icon = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(28, 104);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(182, 48);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenFolder.UseAccentColor = false;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // mtxtFolderName
            // 
            this.mtxtFolderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtFolderName.Depth = 0;
            this.mtxtFolderName.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxtFolderName.Location = new System.Drawing.Point(235, 104);
            this.mtxtFolderName.MaxLength = 50;
            this.mtxtFolderName.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtFolderName.Multiline = false;
            this.mtxtFolderName.Name = "mtxtFolderName";
            this.mtxtFolderName.ReadOnly = true;
            this.mtxtFolderName.Size = new System.Drawing.Size(553, 50);
            this.mtxtFolderName.TabIndex = 2;
            this.mtxtFolderName.Text = "";
            // 
            // dvdMain
            // 
            this.dvdMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dvdMain.Depth = 0;
            this.dvdMain.Location = new System.Drawing.Point(12, 257);
            this.dvdMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.dvdMain.Name = "dvdMain";
            this.dvdMain.Size = new System.Drawing.Size(763, 23);
            this.dvdMain.TabIndex = 3;
            this.dvdMain.Text = "materialDivider1";
            // 
            // lstImages
            // 
            this.lstImages.FormattingEnabled = true;
            this.lstImages.ItemHeight = 16;
            this.lstImages.Location = new System.Drawing.Point(15, 300);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(760, 196);
            this.lstImages.TabIndex = 4;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // pbMain
            // 
            this.pbMain.Depth = 0;
            this.pbMain.Location = new System.Drawing.Point(37, 850);
            this.pbMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(738, 5);
            this.pbMain.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = false;
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.Depth = 0;
            this.btnFind.DrawShadows = true;
            this.btnFind.HighEmphasis = true;
            this.btnFind.Icon = null;
            this.btnFind.Location = new System.Drawing.Point(305, 196);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(241, 52);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Search";
            this.btnFind.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFind.UseAccentColor = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(13, 17);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(730, 286);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 889);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lstImages);
            this.Controls.Add(this.dvdMain);
            this.Controls.Add(this.mtxtFolderName);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.crdImage);
            this.Name = "frmMain";
            this.Text = "Png Finder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.crdImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard crdImage;
        private MaterialSkin.Controls.MaterialButton btnOpenFolder;
        private MaterialSkin.Controls.MaterialTextBox mtxtFolderName;
        private MaterialSkin.Controls.MaterialDivider dvdMain;
        private System.Windows.Forms.ListBox lstImages;
        private MaterialSkin.Controls.MaterialProgressBar pbMain;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private MaterialSkin.Controls.MaterialButton btnFind;
        private System.Windows.Forms.PictureBox pbImage;
    }
}

