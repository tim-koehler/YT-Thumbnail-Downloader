namespace YouTubeThumbnailDownloader
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelUrl = new System.Windows.Forms.Label();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(12, 26);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(271, 20);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(13, 239);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(218, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(237, 236);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(78, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 265);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(303, 23);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPEG (*.jpg)|*.jpg";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(10, 10);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(60, 13);
            this.labelUrl.TabIndex = 5;
            this.labelUrl.Text = "Enter URL:";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.LinkVisited = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(211, 291);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(104, 13);
            this.linkLabelGitHub.TabIndex = 6;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub/RaZorfalkon";
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Image = global::YouTubeThumbnailDownloader.Properties.Resources.copy_icon;
            this.buttonPaste.Location = new System.Drawing.Point(291, 24);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(25, 23);
            this.buttonPaste.TabIndex = 7;
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.ErrorImage = global::YouTubeThumbnailDownloader.Properties.Resources.NoUrlImage;
            this.pictureBoxPreview.Image = global::YouTubeThumbnailDownloader.Properties.Resources.NoUrlImage;
            this.pictureBoxPreview.InitialImage = null;
            this.pictureBoxPreview.Location = new System.Drawing.Point(13, 53);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(303, 179);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "YouTube Thumbnail Downloader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Button buttonPaste;
    }
}
