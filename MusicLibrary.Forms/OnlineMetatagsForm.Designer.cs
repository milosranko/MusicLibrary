
namespace MusicLibrary.Forms
{
    partial class OnlineMetatagsForm
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
            this.pnlReleases = new System.Windows.Forms.Panel();
            this.lblReleasesFound = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lvReleases = new System.Windows.Forms.ListView();
            this.pnlTracks = new System.Windows.Forms.Panel();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lvTracks = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlReleases.SuspendLayout();
            this.pnlTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReleases
            // 
            this.pnlReleases.Controls.Add(this.lblReleasesFound);
            this.pnlReleases.Controls.Add(this.btnNext);
            this.pnlReleases.Controls.Add(this.lvReleases);
            this.pnlReleases.Location = new System.Drawing.Point(5, 6);
            this.pnlReleases.Name = "pnlReleases";
            this.pnlReleases.Size = new System.Drawing.Size(788, 434);
            this.pnlReleases.TabIndex = 0;
            // 
            // lblReleasesFound
            // 
            this.lblReleasesFound.AutoSize = true;
            this.lblReleasesFound.Location = new System.Drawing.Point(58, 77);
            this.lblReleasesFound.Name = "lblReleasesFound";
            this.lblReleasesFound.Size = new System.Drawing.Size(89, 15);
            this.lblReleasesFound.TabIndex = 2;
            this.lblReleasesFound.Text = "Releases found:";
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(615, 399);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lvReleases
            // 
            this.lvReleases.HideSelection = false;
            this.lvReleases.Location = new System.Drawing.Point(58, 95);
            this.lvReleases.Name = "lvReleases";
            this.lvReleases.Size = new System.Drawing.Size(633, 225);
            this.lvReleases.TabIndex = 0;
            this.lvReleases.UseCompatibleStateImageBehavior = false;
            this.lvReleases.View = System.Windows.Forms.View.List;
            this.lvReleases.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvReleases_ItemSelectionChanged);
            // 
            // pnlTracks
            // 
            this.pnlTracks.Controls.Add(this.label4);
            this.pnlTracks.Controls.Add(this.label3);
            this.pnlTracks.Controls.Add(this.label2);
            this.pnlTracks.Controls.Add(this.label1);
            this.pnlTracks.Controls.Add(this.lblGenre);
            this.pnlTracks.Controls.Add(this.lblYear);
            this.pnlTracks.Controls.Add(this.lblRelease);
            this.pnlTracks.Controls.Add(this.lblArtist);
            this.pnlTracks.Controls.Add(this.btnBack);
            this.pnlTracks.Controls.Add(this.btnApply);
            this.pnlTracks.Controls.Add(this.lvTracks);
            this.pnlTracks.Location = new System.Drawing.Point(6, 8);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(788, 434);
            this.pnlTracks.TabIndex = 4;
            this.pnlTracks.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(152, 75);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 15);
            this.lblGenre.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(152, 52);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 15);
            this.lblYear.TabIndex = 5;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRelease.Location = new System.Drawing.Point(152, 33);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(0, 15);
            this.lblRelease.TabIndex = 4;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.Location = new System.Drawing.Point(152, 12);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 15);
            this.lblArtist.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(534, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(615, 396);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lvTracks
            // 
            this.lvTracks.HideSelection = false;
            this.lvTracks.Location = new System.Drawing.Point(58, 95);
            this.lvTracks.Name = "lvTracks";
            this.lvTracks.Size = new System.Drawing.Size(633, 275);
            this.lvTracks.TabIndex = 0;
            this.lvTracks.UseCompatibleStateImageBehavior = false;
            this.lvTracks.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Release:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genre:";
            // 
            // OnlineMetatagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.pnlReleases);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlineMetatagsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Online metatags";
            this.Load += new System.EventHandler(this.OnlineMetatagsForm_Load);
            this.pnlReleases.ResumeLayout(false);
            this.pnlReleases.PerformLayout();
            this.pnlTracks.ResumeLayout(false);
            this.pnlTracks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReleases;
        private System.Windows.Forms.Label lblReleasesFound;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView lvReleases;
        private System.Windows.Forms.Panel pnlTracks;
        private System.Windows.Forms.ListView lvTracks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}