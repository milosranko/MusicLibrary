
namespace MusicLibrary.Forms
{
    partial class ConvertFilesForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBitRate = new System.Windows.Forms.Label();
            this.cbBitRate = new System.Windows.Forms.ComboBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.lblConversionStatus = new System.Windows.Forms.Label();
            this.btnStopConversion = new System.Windows.Forms.Button();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(13, 203);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 23);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(13, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBitRate
            // 
            this.lblBitRate.AutoSize = true;
            this.lblBitRate.Location = new System.Drawing.Point(13, 43);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(102, 15);
            this.lblBitRate.TabIndex = 15;
            this.lblBitRate.Text = "Select MP3 bitrate";
            // 
            // cbBitRate
            // 
            this.cbBitRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBitRate.DisplayMember = "128";
            this.cbBitRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBitRate.FormattingEnabled = true;
            this.cbBitRate.Location = new System.Drawing.Point(13, 62);
            this.cbBitRate.Name = "cbBitRate";
            this.cbBitRate.Size = new System.Drawing.Size(121, 23);
            this.cbBitRate.TabIndex = 16;
            // 
            // lvFiles
            // 
            this.lvFiles.BackColor = System.Drawing.SystemColors.Control;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(162, 12);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(531, 353);
            this.lvFiles.TabIndex = 17;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.List;
            // 
            // lblConversionStatus
            // 
            this.lblConversionStatus.AutoSize = true;
            this.lblConversionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConversionStatus.Location = new System.Drawing.Point(162, 398);
            this.lblConversionStatus.Name = "lblConversionStatus";
            this.lblConversionStatus.Size = new System.Drawing.Size(0, 15);
            this.lblConversionStatus.TabIndex = 18;
            // 
            // btnStopConversion
            // 
            this.btnStopConversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopConversion.Location = new System.Drawing.Point(13, 203);
            this.btnStopConversion.Name = "btnStopConversion";
            this.btnStopConversion.Size = new System.Drawing.Size(121, 23);
            this.btnStopConversion.TabIndex = 19;
            this.btnStopConversion.Text = "Terminate";
            this.btnStopConversion.UseVisualStyleBackColor = true;
            this.btnStopConversion.Visible = false;
            this.btnStopConversion.Click += new System.EventHandler(this.btnStopConversion_Click);
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(13, 98);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(104, 15);
            this.lblDestinationFolder.TabIndex = 20;
            this.lblDestinationFolder.Text = "Destination folder:";
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationFolder.Location = new System.Drawing.Point(13, 135);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(121, 23);
            this.btnDestinationFolder.TabIndex = 21;
            this.btnDestinationFolder.Text = "Select folder";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedFolder.Location = new System.Drawing.Point(13, 117);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(118, 15);
            this.lblSelectedFolder.TabIndex = 22;
            this.lblSelectedFolder.Text = "< Same as original >";
            // 
            // ConvertFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(705, 425);
            this.Controls.Add(this.lblSelectedFolder);
            this.Controls.Add(this.btnDestinationFolder);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnStopConversion);
            this.Controls.Add(this.lblConversionStatus);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.cbBitRate);
            this.Controls.Add(this.lblBitRate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert files";
            this.Load += new System.EventHandler(this.ConvertFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBitRate;
        private System.Windows.Forms.ComboBox cbBitRate;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Label lblConversionStatus;
        private System.Windows.Forms.Button btnStopConversion;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.Label lblSelectedFolder;
    }
}