
namespace MusicLibrary.Forms
{
    partial class MetaTagsForm
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
            dgFilesSelected = new DataGridView();
            btnGetMetadata = new Button();
            gbMetadataOnline = new GroupBox();
            btnUseCurrent = new Button();
            txtReleaseYear = new TextBox();
            txtArtistName = new TextBox();
            txtAlbumName = new TextBox();
            gbMetaTags = new GroupBox();
            lblArtist = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtGenre = new TextBox();
            lblGenre = new Label();
            txtTrackNumber = new TextBox();
            lblTrackNumber = new Label();
            txtTrackTitle = new TextBox();
            lblTrackTitle = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtAlbum = new TextBox();
            lblAlbum = new Label();
            txtArtist = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            Drive = new DataGridViewTextBoxColumn();
            FullFilePath = new DataGridViewTextBoxColumn();
            Artist = new DataGridViewTextBoxColumn();
            Path = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            TrackName = new DataGridViewTextBoxColumn();
            Album = new DataGridViewTextBoxColumn();
            TrackNumber = new DataGridViewTextBoxColumn();
            Tags = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgFilesSelected).BeginInit();
            gbMetadataOnline.SuspendLayout();
            gbMetaTags.SuspendLayout();
            SuspendLayout();
            // 
            // dgFilesSelected
            // 
            dgFilesSelected.AllowUserToAddRows = false;
            dgFilesSelected.AllowUserToDeleteRows = false;
            dgFilesSelected.AllowUserToResizeColumns = false;
            dgFilesSelected.AllowUserToResizeRows = false;
            dgFilesSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgFilesSelected.BackgroundColor = SystemColors.Control;
            dgFilesSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFilesSelected.Columns.AddRange(new DataGridViewColumn[] { Id, Drive, FullFilePath, Artist, Path, FileName, TrackName, Album, TrackNumber, Tags, Year, Genre });
            dgFilesSelected.Cursor = Cursors.Hand;
            dgFilesSelected.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgFilesSelected.Location = new Point(206, 13);
            dgFilesSelected.Name = "dgFilesSelected";
            dgFilesSelected.RowHeadersWidth = 51;
            dgFilesSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFilesSelected.Size = new Size(487, 400);
            dgFilesSelected.TabIndex = 12;
            dgFilesSelected.CellDoubleClick += dgFilesSelected_CellDoubleClick;
            dgFilesSelected.CellEndEdit += dgFilesSelected_CellEndEdit;
            dgFilesSelected.SelectionChanged += dgFilesSelected_SelectionChanged;
            // 
            // btnGetMetadata
            // 
            btnGetMetadata.Cursor = Cursors.Hand;
            btnGetMetadata.FlatStyle = FlatStyle.Flat;
            btnGetMetadata.Location = new Point(106, 98);
            btnGetMetadata.Name = "btnGetMetadata";
            btnGetMetadata.Size = new Size(75, 23);
            btnGetMetadata.TabIndex = 16;
            btnGetMetadata.Text = "Get";
            btnGetMetadata.UseVisualStyleBackColor = true;
            btnGetMetadata.Click += btnGetMetadata_Click;
            // 
            // gbMetadataOnline
            // 
            gbMetadataOnline.Controls.Add(btnUseCurrent);
            gbMetadataOnline.Controls.Add(txtReleaseYear);
            gbMetadataOnline.Controls.Add(txtArtistName);
            gbMetadataOnline.Controls.Add(txtAlbumName);
            gbMetadataOnline.Controls.Add(btnGetMetadata);
            gbMetadataOnline.Location = new Point(12, 283);
            gbMetadataOnline.Name = "gbMetadataOnline";
            gbMetadataOnline.Size = new Size(188, 130);
            gbMetadataOnline.TabIndex = 17;
            gbMetadataOnline.TabStop = false;
            gbMetadataOnline.Text = "Get metadata online";
            // 
            // btnUseCurrent
            // 
            btnUseCurrent.Cursor = Cursors.Hand;
            btnUseCurrent.FlatStyle = FlatStyle.Flat;
            btnUseCurrent.Location = new Point(6, 98);
            btnUseCurrent.Name = "btnUseCurrent";
            btnUseCurrent.Size = new Size(75, 23);
            btnUseCurrent.TabIndex = 20;
            btnUseCurrent.Text = "Use";
            btnUseCurrent.UseVisualStyleBackColor = true;
            btnUseCurrent.Click += btnUseCurrent_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BorderStyle = BorderStyle.None;
            txtReleaseYear.Location = new Point(7, 68);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.PlaceholderText = "Release year";
            txtReleaseYear.Size = new Size(174, 16);
            txtReleaseYear.TabIndex = 19;
            // 
            // txtArtistName
            // 
            txtArtistName.BorderStyle = BorderStyle.None;
            txtArtistName.Location = new Point(7, 23);
            txtArtistName.Name = "txtArtistName";
            txtArtistName.PlaceholderText = "Artist name";
            txtArtistName.Size = new Size(174, 16);
            txtArtistName.TabIndex = 18;
            // 
            // txtAlbumName
            // 
            txtAlbumName.BorderStyle = BorderStyle.None;
            txtAlbumName.Location = new Point(6, 45);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.PlaceholderText = "Album name";
            txtAlbumName.Size = new Size(175, 16);
            txtAlbumName.TabIndex = 17;
            // 
            // gbMetaTags
            // 
            gbMetaTags.Controls.Add(lblArtist);
            gbMetaTags.Controls.Add(btnCancel);
            gbMetaTags.Controls.Add(btnSave);
            gbMetaTags.Controls.Add(txtGenre);
            gbMetaTags.Controls.Add(lblGenre);
            gbMetaTags.Controls.Add(txtTrackNumber);
            gbMetaTags.Controls.Add(lblTrackNumber);
            gbMetaTags.Controls.Add(txtTrackTitle);
            gbMetaTags.Controls.Add(lblTrackTitle);
            gbMetaTags.Controls.Add(txtYear);
            gbMetaTags.Controls.Add(lblYear);
            gbMetaTags.Controls.Add(txtAlbum);
            gbMetaTags.Controls.Add(lblAlbum);
            gbMetaTags.Controls.Add(txtArtist);
            gbMetaTags.Location = new Point(12, 13);
            gbMetaTags.Name = "gbMetaTags";
            gbMetaTags.Size = new Size(188, 264);
            gbMetaTags.TabIndex = 18;
            gbMetaTags.TabStop = false;
            gbMetaTags.Text = "Meta tags";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 9F);
            lblArtist.Location = new Point(6, 19);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(35, 15);
            lblArtist.TabIndex = 1;
            lblArtist.Text = "Artist";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(111, 231);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(6, 231);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtGenre
            // 
            txtGenre.BorderStyle = BorderStyle.None;
            txtGenre.Location = new Point(6, 185);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(147, 16);
            txtGenre.TabIndex = 14;
            txtGenre.TextChanged += txtGenre_TextChanged;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 9F);
            lblGenre.Location = new Point(6, 167);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 13;
            lblGenre.Text = "Genre";
            // 
            // txtTrackNumber
            // 
            txtTrackNumber.BorderStyle = BorderStyle.None;
            txtTrackNumber.Location = new Point(82, 148);
            txtTrackNumber.Name = "txtTrackNumber";
            txtTrackNumber.Size = new Size(71, 16);
            txtTrackNumber.TabIndex = 12;
            txtTrackNumber.TextChanged += txtTrackNumber_TextChanged;
            // 
            // lblTrackNumber
            // 
            lblTrackNumber.AutoSize = true;
            lblTrackNumber.Font = new Font("Segoe UI", 9F);
            lblTrackNumber.Location = new Point(82, 130);
            lblTrackNumber.Name = "lblTrackNumber";
            lblTrackNumber.Size = new Size(51, 15);
            lblTrackNumber.TabIndex = 11;
            lblTrackNumber.Text = "Track no";
            // 
            // txtTrackTitle
            // 
            txtTrackTitle.BorderStyle = BorderStyle.None;
            txtTrackTitle.Location = new Point(6, 111);
            txtTrackTitle.Name = "txtTrackTitle";
            txtTrackTitle.Size = new Size(176, 16);
            txtTrackTitle.TabIndex = 8;
            txtTrackTitle.TextChanged += txtTrackTitle_TextChanged;
            // 
            // lblTrackTitle
            // 
            lblTrackTitle.AutoSize = true;
            lblTrackTitle.Font = new Font("Segoe UI", 9F);
            lblTrackTitle.Location = new Point(6, 93);
            lblTrackTitle.Name = "lblTrackTitle";
            lblTrackTitle.Size = new Size(29, 15);
            lblTrackTitle.TabIndex = 7;
            lblTrackTitle.Text = "Title";
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.None;
            txtYear.Location = new Point(6, 148);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(70, 16);
            txtYear.TabIndex = 6;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.Location = new Point(6, 130);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year";
            // 
            // txtAlbum
            // 
            txtAlbum.BorderStyle = BorderStyle.None;
            txtAlbum.Location = new Point(6, 74);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(176, 16);
            txtAlbum.TabIndex = 4;
            txtAlbum.TextChanged += txtAlbum_TextChanged;
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.Font = new Font("Segoe UI", 9F);
            lblAlbum.Location = new Point(6, 56);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(43, 15);
            lblAlbum.TabIndex = 3;
            lblAlbum.Text = "Album";
            // 
            // txtArtist
            // 
            txtArtist.BorderStyle = BorderStyle.None;
            txtArtist.Location = new Point(6, 37);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(176, 16);
            txtArtist.TabIndex = 2;
            txtArtist.TextChanged += txtArtist_TextChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Drive
            // 
            Drive.DataPropertyName = "Drive";
            Drive.HeaderText = "Drive";
            Drive.Name = "Drive";
            Drive.Visible = false;
            // 
            // FullFilePath
            // 
            FullFilePath.DataPropertyName = "FullFilePath";
            FullFilePath.HeaderText = "FullFilePath";
            FullFilePath.Name = "FullFilePath";
            FullFilePath.Visible = false;
            // 
            // Artist
            // 
            Artist.DataPropertyName = "Artist";
            Artist.HeaderText = "Artist";
            Artist.MinimumWidth = 6;
            Artist.Name = "Artist";
            Artist.Visible = false;
            // 
            // Path
            // 
            Path.DataPropertyName = "Path";
            Path.HeaderText = "Path";
            Path.MinimumWidth = 6;
            Path.Name = "Path";
            Path.Visible = false;
            // 
            // FileName
            // 
            FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FileName.DataPropertyName = "FileName";
            FileName.FillWeight = 86.85168F;
            FileName.HeaderText = "File name";
            FileName.MinimumWidth = 6;
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            // 
            // TrackName
            // 
            TrackName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrackName.DataPropertyName = "TrackName";
            TrackName.HeaderText = "Title";
            TrackName.MinimumWidth = 6;
            TrackName.Name = "TrackName";
            // 
            // Album
            // 
            Album.DataPropertyName = "Album";
            Album.HeaderText = "Album";
            Album.MinimumWidth = 6;
            Album.Name = "Album";
            Album.Visible = false;
            // 
            // TrackNumber
            // 
            TrackNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TrackNumber.DataPropertyName = "TrackNumber";
            TrackNumber.FillWeight = 60.9137F;
            TrackNumber.HeaderText = "Track no";
            TrackNumber.MinimumWidth = 6;
            TrackNumber.Name = "TrackNumber";
            TrackNumber.Width = 76;
            // 
            // Tags
            // 
            Tags.DataPropertyName = "Tags";
            Tags.HeaderText = "Tags";
            Tags.MinimumWidth = 6;
            Tags.Name = "Tags";
            Tags.Visible = false;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Visible = false;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Visible = false;
            // 
            // MetaTagsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(705, 425);
            Controls.Add(gbMetaTags);
            Controls.Add(gbMetadataOnline);
            Controls.Add(dgFilesSelected);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MetaTagsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit meta tags";
            Load += MetaTagsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgFilesSelected).EndInit();
            gbMetadataOnline.ResumeLayout(false);
            gbMetadataOnline.PerformLayout();
            gbMetaTags.ResumeLayout(false);
            gbMetaTags.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgFilesSelected;
        private System.Windows.Forms.Button btnGetMetadata;
        private System.Windows.Forms.GroupBox gbMetadataOnline;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.GroupBox gbMetaTags;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTrackNumber;
        private System.Windows.Forms.Label lblTrackNumber;
        private System.Windows.Forms.TextBox txtTrackTitle;
        private System.Windows.Forms.Label lblTrackTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnUseCurrent;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Drive;
        private DataGridViewTextBoxColumn FullFilePath;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Path;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn TrackName;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn TrackNumber;
        private DataGridViewTextBoxColumn Tags;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Genre;
    }
}