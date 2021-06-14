
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
            this.dgFilesSelected = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetMetadata = new System.Windows.Forms.Button();
            this.gbMetadataOnline = new System.Windows.Forms.GroupBox();
            this.btnUseCurrent = new System.Windows.Forms.Button();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.gbMetaTags = new System.Windows.Forms.GroupBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.lblTrackNumber = new System.Windows.Forms.Label();
            this.txtTrackTitle = new System.Windows.Forms.TextBox();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilesSelected)).BeginInit();
            this.gbMetadataOnline.SuspendLayout();
            this.gbMetaTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFilesSelected
            // 
            this.dgFilesSelected.AllowUserToAddRows = false;
            this.dgFilesSelected.AllowUserToDeleteRows = false;
            this.dgFilesSelected.AllowUserToResizeColumns = false;
            this.dgFilesSelected.AllowUserToResizeRows = false;
            this.dgFilesSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFilesSelected.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgFilesSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilesSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Artist,
            this.Path,
            this.FileName,
            this.TrackName,
            this.Album,
            this.TrackNumber,
            this.Tags,
            this.Year,
            this.Genre});
            this.dgFilesSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgFilesSelected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgFilesSelected.Location = new System.Drawing.Point(235, 17);
            this.dgFilesSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgFilesSelected.Name = "dgFilesSelected";
            this.dgFilesSelected.RowHeadersWidth = 51;
            this.dgFilesSelected.RowTemplate.Height = 25;
            this.dgFilesSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFilesSelected.Size = new System.Drawing.Size(557, 533);
            this.dgFilesSelected.TabIndex = 12;
            this.dgFilesSelected.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFilesSelected_CellDoubleClick);
            this.dgFilesSelected.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFilesSelected_CellEndEdit);
            this.dgFilesSelected.SelectionChanged += new System.EventHandler(this.dgFilesSelected_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.Visible = false;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.Visible = false;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.FillWeight = 86.85168F;
            this.FileName.HeaderText = "File name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // TrackName
            // 
            this.TrackName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackName.DataPropertyName = "TrackName";
            this.TrackName.HeaderText = "Title";
            this.TrackName.MinimumWidth = 6;
            this.TrackName.Name = "TrackName";
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.Visible = false;
            // 
            // TrackNumber
            // 
            this.TrackNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrackNumber.DataPropertyName = "TrackNumber";
            this.TrackNumber.FillWeight = 60.9137F;
            this.TrackNumber.HeaderText = "Track no";
            this.TrackNumber.MinimumWidth = 6;
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.Width = 93;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.HeaderText = "Tags";
            this.Tags.MinimumWidth = 6;
            this.Tags.Name = "Tags";
            this.Tags.Visible = false;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Visible = false;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.Visible = false;
            // 
            // btnGetMetadata
            // 
            this.btnGetMetadata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetMetadata.Location = new System.Drawing.Point(121, 131);
            this.btnGetMetadata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetMetadata.Name = "btnGetMetadata";
            this.btnGetMetadata.Size = new System.Drawing.Size(86, 31);
            this.btnGetMetadata.TabIndex = 16;
            this.btnGetMetadata.Text = "Get";
            this.btnGetMetadata.UseVisualStyleBackColor = true;
            this.btnGetMetadata.Click += new System.EventHandler(this.btnGetMetadata_Click);
            // 
            // gbMetadataOnline
            // 
            this.gbMetadataOnline.Controls.Add(this.btnUseCurrent);
            this.gbMetadataOnline.Controls.Add(this.txtReleaseYear);
            this.gbMetadataOnline.Controls.Add(this.txtArtistName);
            this.gbMetadataOnline.Controls.Add(this.txtAlbumName);
            this.gbMetadataOnline.Controls.Add(this.btnGetMetadata);
            this.gbMetadataOnline.Location = new System.Drawing.Point(14, 377);
            this.gbMetadataOnline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMetadataOnline.Name = "gbMetadataOnline";
            this.gbMetadataOnline.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMetadataOnline.Size = new System.Drawing.Size(215, 173);
            this.gbMetadataOnline.TabIndex = 17;
            this.gbMetadataOnline.TabStop = false;
            this.gbMetadataOnline.Text = "Get metadata online";
            // 
            // btnUseCurrent
            // 
            this.btnUseCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseCurrent.Location = new System.Drawing.Point(7, 131);
            this.btnUseCurrent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUseCurrent.Name = "btnUseCurrent";
            this.btnUseCurrent.Size = new System.Drawing.Size(86, 31);
            this.btnUseCurrent.TabIndex = 20;
            this.btnUseCurrent.Text = "Use";
            this.btnUseCurrent.UseVisualStyleBackColor = true;
            this.btnUseCurrent.Click += new System.EventHandler(this.btnUseCurrent_Click);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReleaseYear.Location = new System.Drawing.Point(8, 91);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.PlaceholderText = "Release year";
            this.txtReleaseYear.Size = new System.Drawing.Size(199, 20);
            this.txtReleaseYear.TabIndex = 19;
            // 
            // txtArtistName
            // 
            this.txtArtistName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtistName.Location = new System.Drawing.Point(8, 31);
            this.txtArtistName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.PlaceholderText = "Artist name";
            this.txtArtistName.Size = new System.Drawing.Size(199, 20);
            this.txtArtistName.TabIndex = 18;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlbumName.Location = new System.Drawing.Point(7, 60);
            this.txtAlbumName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.PlaceholderText = "Album name";
            this.txtAlbumName.Size = new System.Drawing.Size(200, 20);
            this.txtAlbumName.TabIndex = 17;
            // 
            // gbMetaTags
            // 
            this.gbMetaTags.Controls.Add(this.lblArtist);
            this.gbMetaTags.Controls.Add(this.btnCancel);
            this.gbMetaTags.Controls.Add(this.btnSave);
            this.gbMetaTags.Controls.Add(this.txtGenre);
            this.gbMetaTags.Controls.Add(this.lblGenre);
            this.gbMetaTags.Controls.Add(this.txtTrackNumber);
            this.gbMetaTags.Controls.Add(this.lblTrackNumber);
            this.gbMetaTags.Controls.Add(this.txtTrackTitle);
            this.gbMetaTags.Controls.Add(this.lblTrackTitle);
            this.gbMetaTags.Controls.Add(this.txtYear);
            this.gbMetaTags.Controls.Add(this.lblYear);
            this.gbMetaTags.Controls.Add(this.txtAlbum);
            this.gbMetaTags.Controls.Add(this.lblAlbum);
            this.gbMetaTags.Controls.Add(this.txtArtist);
            this.gbMetaTags.Location = new System.Drawing.Point(14, 17);
            this.gbMetaTags.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMetaTags.Name = "gbMetaTags";
            this.gbMetaTags.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMetaTags.Size = new System.Drawing.Size(215, 352);
            this.gbMetaTags.TabIndex = 18;
            this.gbMetaTags.TabStop = false;
            this.gbMetaTags.Text = "Meta tags";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.Location = new System.Drawing.Point(7, 25);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(44, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(127, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(7, 308);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Location = new System.Drawing.Point(7, 247);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(168, 20);
            this.txtGenre.TabIndex = 14;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(7, 223);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 20);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Genre";
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrackNumber.Location = new System.Drawing.Point(94, 197);
            this.txtTrackNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(81, 20);
            this.txtTrackNumber.TabIndex = 12;
            this.txtTrackNumber.TextChanged += new System.EventHandler(this.txtTrackNumber_TextChanged);
            // 
            // lblTrackNumber
            // 
            this.lblTrackNumber.AutoSize = true;
            this.lblTrackNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrackNumber.Location = new System.Drawing.Point(94, 173);
            this.lblTrackNumber.Name = "lblTrackNumber";
            this.lblTrackNumber.Size = new System.Drawing.Size(64, 20);
            this.lblTrackNumber.TabIndex = 11;
            this.lblTrackNumber.Text = "Track no";
            // 
            // txtTrackTitle
            // 
            this.txtTrackTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrackTitle.Location = new System.Drawing.Point(7, 148);
            this.txtTrackTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrackTitle.Name = "txtTrackTitle";
            this.txtTrackTitle.Size = new System.Drawing.Size(201, 20);
            this.txtTrackTitle.TabIndex = 8;
            this.txtTrackTitle.TextChanged += new System.EventHandler(this.txtTrackTitle_TextChanged);
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.AutoSize = true;
            this.lblTrackTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrackTitle.Location = new System.Drawing.Point(7, 124);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTrackTitle.TabIndex = 7;
            this.lblTrackTitle.Text = "Title";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Location = new System.Drawing.Point(7, 197);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(80, 20);
            this.txtYear.TabIndex = 6;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(7, 173);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 20);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // txtAlbum
            // 
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlbum.Location = new System.Drawing.Point(7, 99);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(201, 20);
            this.txtAlbum.TabIndex = 4;
            this.txtAlbum.TextChanged += new System.EventHandler(this.txtAlbum_TextChanged);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(7, 75);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 20);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Album";
            // 
            // txtArtist
            // 
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtist.Location = new System.Drawing.Point(7, 49);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(201, 20);
            this.txtArtist.TabIndex = 2;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtArtist_TextChanged);
            // 
            // MetaTagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(806, 567);
            this.Controls.Add(this.gbMetaTags);
            this.Controls.Add(this.gbMetadataOnline);
            this.Controls.Add(this.dgFilesSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetaTagsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit meta tags";
            this.Load += new System.EventHandler(this.MetaTagsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFilesSelected)).EndInit();
            this.gbMetadataOnline.ResumeLayout(false);
            this.gbMetadataOnline.PerformLayout();
            this.gbMetaTags.ResumeLayout(false);
            this.gbMetaTags.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}