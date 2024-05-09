
namespace MusicLibrary.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            pbLogo = new PictureBox();
            btnMinimize = new Button();
            lblFormTitle = new Label();
            btnCloseForm = new Button();
            pnlIndex = new Panel();
            gbIndexSharing = new GroupBox();
            lblDefaultIndex = new Label();
            cmbAvailableIndexes = new ComboBox();
            btnLoadIndex = new Button();
            btnIndexShare = new Button();
            lblIndex = new Label();
            gbIndexScanner = new GroupBox();
            btnIndexNewFiles = new Button();
            btnIndex = new Button();
            lblIndexFolder = new Label();
            btnIndexFolder = new Button();
            btnScan = new Button();
            gbIndexMaintenance = new GroupBox();
            btnStopOptimize = new Button();
            btnOptimize = new Button();
            btnClearIndex = new Button();
            pnlLeft = new Panel();
            btnLists = new Button();
            btnMainMenuDashboard = new Button();
            btnMainMenuSearch = new Button();
            btnMainMenuIndex = new Button();
            pnlDashboard = new Panel();
            lblLatestAdditions = new Label();
            lblTotalByReleaseYear = new Label();
            lblTotalByGenre = new Label();
            lblTotalByExtension = new Label();
            lvReleaseYears = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lvExtensionsTotal = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lvGenres = new ListView();
            columnExtension = new ColumnHeader();
            columnExtensionCount = new ColumnHeader();
            lblTotalTracksValue = new Label();
            lblTotalTracks = new Label();
            lblDashboard = new Label();
            lvLatestAdditions = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            pnlSearch = new Panel();
            btnClearSearch = new Button();
            dgSearchResult = new DataGridView();
            btnSearchIndex = new Button();
            txtSearchField = new TextBox();
            lblSearchQuery = new Label();
            lblSearch = new Label();
            toolTipBtnClose = new ToolTip(components);
            toolTipBtnMinimize = new ToolTip(components);
            ctxFileOptions = new ContextMenuStrip(components);
            toolStripShowFileInfo = new ToolStripMenuItem();
            toolStripShowMoreFromArtist = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripEditMetaTags = new ToolStripMenuItem();
            toolStripConvertSelectedFiles = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripOpenFileLocation = new ToolStripMenuItem();
            toolStripPlayFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSearchRuTracker = new ToolStripMenuItem();
            toolStripSearchAllMusic = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripAddToList = new ToolStripMenuItem();
            toolStripTbAddNewList = new ToolStripTextBox();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripRemoveFromIndex = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            pnlLists = new Panel();
            dgLists = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            gbLists = new GroupBox();
            btnSaveList = new Button();
            lblListName = new Label();
            lblSelectList = new Label();
            btnNewList = new Button();
            txtListName = new TextBox();
            cmbLists = new ComboBox();
            lblLists = new Label();
            Id = new DataGridViewTextBoxColumn();
            Artist = new DataGridViewTextBoxColumn();
            Album = new DataGridViewTextBoxColumn();
            Track = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            TrackNumber = new DataGridViewTextBoxColumn();
            Tags = new DataGridViewTextBoxColumn();
            Path = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Drive = new DataGridViewTextBoxColumn();
            FullFilePath = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlIndex.SuspendLayout();
            gbIndexSharing.SuspendLayout();
            gbIndexScanner.SuspendLayout();
            gbIndexMaintenance.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlDashboard.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSearchResult).BeginInit();
            ctxFileOptions.SuspendLayout();
            pnlLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLists).BeginInit();
            gbLists.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Navy;
            pnlTop.Controls.Add(pbLogo);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(lblFormTitle);
            pnlTop.Controls.Add(btnCloseForm);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1120, 34);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(40, 31);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1043, 2);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 27);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "─";
            toolTipBtnMinimize.SetToolTip(btnMinimize, "Minimize");
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Century Gothic", 16F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.WhiteSmoke;
            lblFormTitle.Location = new Point(43, 4);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(146, 26);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "MusicLibrary";
            // 
            // btnCloseForm
            // 
            btnCloseForm.Cursor = Cursors.Hand;
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCloseForm.FlatStyle = FlatStyle.Flat;
            btnCloseForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCloseForm.ForeColor = Color.WhiteSmoke;
            btnCloseForm.Location = new Point(1081, 3);
            btnCloseForm.Margin = new Padding(3, 2, 3, 2);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(32, 27);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "X";
            toolTipBtnClose.SetToolTip(btnCloseForm, "Close");
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // pnlIndex
            // 
            pnlIndex.BackColor = Color.LightBlue;
            pnlIndex.Controls.Add(gbIndexSharing);
            pnlIndex.Controls.Add(lblIndex);
            pnlIndex.Controls.Add(gbIndexScanner);
            pnlIndex.Controls.Add(gbIndexMaintenance);
            pnlIndex.Location = new Point(228, 34);
            pnlIndex.Margin = new Padding(3, 2, 3, 2);
            pnlIndex.Name = "pnlIndex";
            pnlIndex.Size = new Size(892, 544);
            pnlIndex.TabIndex = 4;
            // 
            // gbIndexSharing
            // 
            gbIndexSharing.Controls.Add(lblDefaultIndex);
            gbIndexSharing.Controls.Add(cmbAvailableIndexes);
            gbIndexSharing.Controls.Add(btnLoadIndex);
            gbIndexSharing.Controls.Add(btnIndexShare);
            gbIndexSharing.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbIndexSharing.Location = new Point(170, 391);
            gbIndexSharing.Margin = new Padding(3, 2, 3, 2);
            gbIndexSharing.Name = "gbIndexSharing";
            gbIndexSharing.Padding = new Padding(3, 2, 3, 2);
            gbIndexSharing.Size = new Size(489, 113);
            gbIndexSharing.TabIndex = 17;
            gbIndexSharing.TabStop = false;
            gbIndexSharing.Text = "Index sharing";
            // 
            // lblDefaultIndex
            // 
            lblDefaultIndex.AutoSize = true;
            lblDefaultIndex.Location = new Point(242, 26);
            lblDefaultIndex.Margin = new Padding(2, 0, 2, 0);
            lblDefaultIndex.Name = "lblDefaultIndex";
            lblDefaultIndex.Size = new Size(122, 15);
            lblDefaultIndex.TabIndex = 3;
            lblDefaultIndex.Text = "Select default index:";
            // 
            // cmbAvailableIndexes
            // 
            cmbAvailableIndexes.Cursor = Cursors.Hand;
            cmbAvailableIndexes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailableIndexes.FlatStyle = FlatStyle.Flat;
            cmbAvailableIndexes.FormattingEnabled = true;
            cmbAvailableIndexes.Location = new Point(242, 44);
            cmbAvailableIndexes.Margin = new Padding(2, 2, 2, 2);
            cmbAvailableIndexes.Name = "cmbAvailableIndexes";
            cmbAvailableIndexes.Size = new Size(244, 23);
            cmbAvailableIndexes.TabIndex = 2;
            cmbAvailableIndexes.SelectedIndexChanged += cmbAvailableIndexes_SelectedIndexChanged;
            // 
            // btnLoadIndex
            // 
            btnLoadIndex.Cursor = Cursors.Hand;
            btnLoadIndex.FlatStyle = FlatStyle.Flat;
            btnLoadIndex.Location = new Point(133, 26);
            btnLoadIndex.Margin = new Padding(3, 2, 3, 2);
            btnLoadIndex.Name = "btnLoadIndex";
            btnLoadIndex.Size = new Size(88, 75);
            btnLoadIndex.TabIndex = 1;
            btnLoadIndex.Text = "Import index";
            btnLoadIndex.UseVisualStyleBackColor = true;
            btnLoadIndex.Click += btnLoadIndex_Click;
            // 
            // btnIndexShare
            // 
            btnIndexShare.Cursor = Cursors.Hand;
            btnIndexShare.FlatStyle = FlatStyle.Flat;
            btnIndexShare.Location = new Point(18, 26);
            btnIndexShare.Margin = new Padding(3, 2, 3, 2);
            btnIndexShare.Name = "btnIndexShare";
            btnIndexShare.Size = new Size(88, 75);
            btnIndexShare.TabIndex = 0;
            btnIndexShare.Text = "Export index";
            btnIndexShare.UseVisualStyleBackColor = true;
            btnIndexShare.Click += btnIndexShare_Click;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Century Gothic", 45F, FontStyle.Bold);
            lblIndex.Location = new Point(9, 13);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(195, 70);
            lblIndex.TabIndex = 16;
            lblIndex.Text = "Index";
            // 
            // gbIndexScanner
            // 
            gbIndexScanner.BackColor = Color.LightBlue;
            gbIndexScanner.Controls.Add(btnIndexNewFiles);
            gbIndexScanner.Controls.Add(btnIndex);
            gbIndexScanner.Controls.Add(lblIndexFolder);
            gbIndexScanner.Controls.Add(btnIndexFolder);
            gbIndexScanner.Controls.Add(btnScan);
            gbIndexScanner.FlatStyle = FlatStyle.Flat;
            gbIndexScanner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbIndexScanner.Location = new Point(22, 115);
            gbIndexScanner.Name = "gbIndexScanner";
            gbIndexScanner.Size = new Size(397, 231);
            gbIndexScanner.TabIndex = 15;
            gbIndexScanner.TabStop = false;
            gbIndexScanner.Text = "Index scanner";
            // 
            // btnIndexNewFiles
            // 
            btnIndexNewFiles.Cursor = Cursors.Hand;
            btnIndexNewFiles.Enabled = false;
            btnIndexNewFiles.FlatStyle = FlatStyle.Popup;
            btnIndexNewFiles.Location = new Point(148, 93);
            btnIndexNewFiles.Name = "btnIndexNewFiles";
            btnIndexNewFiles.Size = new Size(91, 79);
            btnIndexNewFiles.TabIndex = 14;
            btnIndexNewFiles.Text = "Index new files only";
            btnIndexNewFiles.UseVisualStyleBackColor = true;
            btnIndexNewFiles.Click += btnIndexNewFiles_Click;
            // 
            // btnIndex
            // 
            btnIndex.Cursor = Cursors.Hand;
            btnIndex.Enabled = false;
            btnIndex.FlatStyle = FlatStyle.Popup;
            btnIndex.Location = new Point(281, 93);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(91, 79);
            btnIndex.TabIndex = 10;
            btnIndex.Text = "Index all files";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click_1;
            // 
            // lblIndexFolder
            // 
            lblIndexFolder.AutoSize = true;
            lblIndexFolder.BackColor = Color.LightBlue;
            lblIndexFolder.Font = new Font("Segoe UI", 9F);
            lblIndexFolder.Location = new Point(26, 26);
            lblIndexFolder.Name = "lblIndexFolder";
            lblIndexFolder.Size = new Size(138, 15);
            lblIndexFolder.TabIndex = 13;
            lblIndexFolder.Text = "Select root folder to scan";
            // 
            // btnIndexFolder
            // 
            btnIndexFolder.Cursor = Cursors.Hand;
            btnIndexFolder.FlatStyle = FlatStyle.Popup;
            btnIndexFolder.Font = new Font("Segoe UI", 9F);
            btnIndexFolder.Location = new Point(26, 48);
            btnIndexFolder.Name = "btnIndexFolder";
            btnIndexFolder.Size = new Size(88, 23);
            btnIndexFolder.TabIndex = 12;
            btnIndexFolder.Text = "Select folder";
            btnIndexFolder.UseVisualStyleBackColor = true;
            btnIndexFolder.Click += btnIndexFolder_Click;
            // 
            // btnScan
            // 
            btnScan.Cursor = Cursors.Hand;
            btnScan.Enabled = false;
            btnScan.FlatStyle = FlatStyle.Popup;
            btnScan.Location = new Point(26, 93);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(88, 79);
            btnScan.TabIndex = 11;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // gbIndexMaintenance
            // 
            gbIndexMaintenance.Controls.Add(btnStopOptimize);
            gbIndexMaintenance.Controls.Add(btnOptimize);
            gbIndexMaintenance.Controls.Add(btnClearIndex);
            gbIndexMaintenance.FlatStyle = FlatStyle.Flat;
            gbIndexMaintenance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbIndexMaintenance.Location = new Point(500, 115);
            gbIndexMaintenance.Name = "gbIndexMaintenance";
            gbIndexMaintenance.Size = new Size(317, 231);
            gbIndexMaintenance.TabIndex = 14;
            gbIndexMaintenance.TabStop = false;
            gbIndexMaintenance.Text = "Index maintenance";
            // 
            // btnStopOptimize
            // 
            btnStopOptimize.Cursor = Cursors.Hand;
            btnStopOptimize.FlatStyle = FlatStyle.Flat;
            btnStopOptimize.Location = new Point(28, 93);
            btnStopOptimize.Name = "btnStopOptimize";
            btnStopOptimize.Size = new Size(88, 79);
            btnStopOptimize.TabIndex = 16;
            btnStopOptimize.Text = "Stop";
            btnStopOptimize.UseVisualStyleBackColor = true;
            btnStopOptimize.Visible = false;
            btnStopOptimize.Click += btnStopOptimize_Click;
            // 
            // btnOptimize
            // 
            btnOptimize.Cursor = Cursors.Hand;
            btnOptimize.FlatStyle = FlatStyle.Flat;
            btnOptimize.Location = new Point(28, 93);
            btnOptimize.Name = "btnOptimize";
            btnOptimize.Size = new Size(88, 79);
            btnOptimize.TabIndex = 14;
            btnOptimize.Text = "Optimize";
            btnOptimize.UseVisualStyleBackColor = true;
            btnOptimize.Click += btnOptimize_Click;
            // 
            // btnClearIndex
            // 
            btnClearIndex.Cursor = Cursors.Hand;
            btnClearIndex.FlatStyle = FlatStyle.Popup;
            btnClearIndex.Location = new Point(198, 93);
            btnClearIndex.Name = "btnClearIndex";
            btnClearIndex.Size = new Size(88, 79);
            btnClearIndex.TabIndex = 15;
            btnClearIndex.Text = "Clear index";
            btnClearIndex.UseVisualStyleBackColor = true;
            btnClearIndex.Click += btnClearIndex_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.RoyalBlue;
            pnlLeft.Controls.Add(btnLists);
            pnlLeft.Controls.Add(btnMainMenuDashboard);
            pnlLeft.Controls.Add(btnMainMenuSearch);
            pnlLeft.Controls.Add(btnMainMenuIndex);
            pnlLeft.Location = new Point(0, 34);
            pnlLeft.Margin = new Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(232, 550);
            pnlLeft.TabIndex = 1;
            // 
            // btnLists
            // 
            btnLists.BackColor = Color.LightGreen;
            btnLists.Cursor = Cursors.Hand;
            btnLists.FlatStyle = FlatStyle.Flat;
            btnLists.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnLists.Location = new Point(19, 240);
            btnLists.Margin = new Padding(3, 2, 3, 2);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(191, 61);
            btnLists.TabIndex = 3;
            btnLists.Text = "Lists";
            btnLists.UseVisualStyleBackColor = false;
            btnLists.Click += btnLists_Click;
            // 
            // btnMainMenuDashboard
            // 
            btnMainMenuDashboard.BackColor = Color.LightGreen;
            btnMainMenuDashboard.Cursor = Cursors.Hand;
            btnMainMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMainMenuDashboard.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnMainMenuDashboard.Location = new Point(19, 90);
            btnMainMenuDashboard.Margin = new Padding(3, 2, 3, 2);
            btnMainMenuDashboard.Name = "btnMainMenuDashboard";
            btnMainMenuDashboard.Size = new Size(191, 58);
            btnMainMenuDashboard.TabIndex = 2;
            btnMainMenuDashboard.Text = "Dashboard";
            btnMainMenuDashboard.UseVisualStyleBackColor = false;
            btnMainMenuDashboard.Click += btnDashboard_Click;
            // 
            // btnMainMenuSearch
            // 
            btnMainMenuSearch.BackColor = Color.LightGreen;
            btnMainMenuSearch.Cursor = Cursors.Hand;
            btnMainMenuSearch.FlatStyle = FlatStyle.Flat;
            btnMainMenuSearch.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnMainMenuSearch.Location = new Point(19, 163);
            btnMainMenuSearch.Margin = new Padding(3, 2, 3, 2);
            btnMainMenuSearch.Name = "btnMainMenuSearch";
            btnMainMenuSearch.Size = new Size(191, 58);
            btnMainMenuSearch.TabIndex = 1;
            btnMainMenuSearch.Text = "Search";
            btnMainMenuSearch.UseVisualStyleBackColor = false;
            btnMainMenuSearch.Click += btnSearch_Click;
            // 
            // btnMainMenuIndex
            // 
            btnMainMenuIndex.BackColor = Color.RoyalBlue;
            btnMainMenuIndex.BackgroundImageLayout = ImageLayout.Center;
            btnMainMenuIndex.CausesValidation = false;
            btnMainMenuIndex.Cursor = Cursors.Hand;
            btnMainMenuIndex.FlatAppearance.BorderSize = 0;
            btnMainMenuIndex.FlatStyle = FlatStyle.Flat;
            btnMainMenuIndex.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnMainMenuIndex.Image = Properties.Resources.settings_3110__1_;
            btnMainMenuIndex.Location = new Point(178, 500);
            btnMainMenuIndex.Margin = new Padding(3, 2, 3, 2);
            btnMainMenuIndex.Name = "btnMainMenuIndex";
            btnMainMenuIndex.Size = new Size(33, 33);
            btnMainMenuIndex.TabIndex = 0;
            btnMainMenuIndex.UseVisualStyleBackColor = false;
            btnMainMenuIndex.Click += btnIndex_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.LightBlue;
            pnlDashboard.Controls.Add(lblLatestAdditions);
            pnlDashboard.Controls.Add(lblTotalByReleaseYear);
            pnlDashboard.Controls.Add(lblTotalByGenre);
            pnlDashboard.Controls.Add(lblTotalByExtension);
            pnlDashboard.Controls.Add(lvReleaseYears);
            pnlDashboard.Controls.Add(lvExtensionsTotal);
            pnlDashboard.Controls.Add(lvGenres);
            pnlDashboard.Controls.Add(lblTotalTracksValue);
            pnlDashboard.Controls.Add(lblTotalTracks);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(lvLatestAdditions);
            pnlDashboard.Location = new Point(228, 34);
            pnlDashboard.Margin = new Padding(3, 2, 3, 2);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(892, 544);
            pnlDashboard.TabIndex = 3;
            // 
            // lblLatestAdditions
            // 
            lblLatestAdditions.AutoSize = true;
            lblLatestAdditions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLatestAdditions.Location = new Point(614, 138);
            lblLatestAdditions.Name = "lblLatestAdditions";
            lblLatestAdditions.Size = new Size(94, 15);
            lblLatestAdditions.TabIndex = 11;
            lblLatestAdditions.Text = "Latest additions";
            // 
            // lblTotalByReleaseYear
            // 
            lblTotalByReleaseYear.AutoSize = true;
            lblTotalByReleaseYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalByReleaseYear.Location = new Point(368, 138);
            lblTotalByReleaseYear.Name = "lblTotalByReleaseYear";
            lblTotalByReleaseYear.Size = new Size(120, 15);
            lblTotalByReleaseYear.TabIndex = 9;
            lblTotalByReleaseYear.Text = "Total by release year";
            // 
            // lblTotalByGenre
            // 
            lblTotalByGenre.AutoSize = true;
            lblTotalByGenre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalByGenre.Location = new Point(215, 138);
            lblTotalByGenre.Name = "lblTotalByGenre";
            lblTotalByGenre.Size = new Size(86, 15);
            lblTotalByGenre.TabIndex = 8;
            lblTotalByGenre.Text = "Total by genre";
            // 
            // lblTotalByExtension
            // 
            lblTotalByExtension.AutoSize = true;
            lblTotalByExtension.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalByExtension.Location = new Point(46, 138);
            lblTotalByExtension.Name = "lblTotalByExtension";
            lblTotalByExtension.Size = new Size(92, 15);
            lblTotalByExtension.TabIndex = 7;
            lblTotalByExtension.Text = "Total by format";
            // 
            // lvReleaseYears
            // 
            lvReleaseYears.BackColor = Color.LightBlue;
            lvReleaseYears.BorderStyle = BorderStyle.None;
            lvReleaseYears.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lvReleaseYears.FullRowSelect = true;
            lvReleaseYears.Location = new Point(368, 159);
            lvReleaseYears.MultiSelect = false;
            lvReleaseYears.Name = "lvReleaseYears";
            lvReleaseYears.Size = new Size(127, 373);
            lvReleaseYears.Sorting = SortOrder.Ascending;
            lvReleaseYears.TabIndex = 6;
            lvReleaseYears.UseCompatibleStateImageBehavior = false;
            lvReleaseYears.View = View.Details;
            lvReleaseYears.ColumnClick += lvReleaseYears_ColumnClick;
            lvReleaseYears.DoubleClick += lvReleaseYears_DoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Name = "columnHeader3";
            columnHeader3.Text = "Year";
            columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            columnHeader4.Name = "columnHeader4";
            columnHeader4.Text = "Tracks";
            columnHeader4.Width = 55;
            // 
            // lvExtensionsTotal
            // 
            lvExtensionsTotal.BackColor = Color.LightBlue;
            lvExtensionsTotal.BorderStyle = BorderStyle.None;
            lvExtensionsTotal.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvExtensionsTotal.FullRowSelect = true;
            lvExtensionsTotal.Location = new Point(28, 159);
            lvExtensionsTotal.MultiSelect = false;
            lvExtensionsTotal.Name = "lvExtensionsTotal";
            lvExtensionsTotal.Size = new Size(126, 373);
            lvExtensionsTotal.Sorting = SortOrder.Ascending;
            lvExtensionsTotal.TabIndex = 4;
            lvExtensionsTotal.UseCompatibleStateImageBehavior = false;
            lvExtensionsTotal.View = View.Details;
            lvExtensionsTotal.ColumnClick += lvExtensionsTotal_ColumnClick;
            lvExtensionsTotal.DoubleClick += lvExtensionsTotal_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Name = "columnHeader1";
            columnHeader1.Text = "Format";
            // 
            // columnHeader2
            // 
            columnHeader2.Name = "columnHeader2";
            columnHeader2.Text = "Tracks";
            columnHeader2.Width = 66;
            // 
            // lvGenres
            // 
            lvGenres.BackColor = Color.LightBlue;
            lvGenres.BorderStyle = BorderStyle.None;
            lvGenres.Columns.AddRange(new ColumnHeader[] { columnExtension, columnExtensionCount });
            lvGenres.FullRowSelect = true;
            lvGenres.Location = new Point(159, 159);
            lvGenres.MultiSelect = false;
            lvGenres.Name = "lvGenres";
            lvGenres.Size = new Size(203, 373);
            lvGenres.Sorting = SortOrder.Ascending;
            lvGenres.TabIndex = 5;
            lvGenres.UseCompatibleStateImageBehavior = false;
            lvGenres.View = View.Details;
            lvGenres.ColumnClick += lvGenres_ColumnClick;
            lvGenres.DoubleClick += lvGenres_DoubleClick;
            // 
            // columnExtension
            // 
            columnExtension.Name = "columnExtension";
            columnExtension.Text = "Genre";
            columnExtension.Width = 120;
            // 
            // columnExtensionCount
            // 
            columnExtensionCount.Name = "columnExtensionCount";
            columnExtensionCount.Text = "Tracks";
            columnExtensionCount.TextAlign = HorizontalAlignment.Center;
            columnExtensionCount.Width = 66;
            // 
            // lblTotalTracksValue
            // 
            lblTotalTracksValue.AutoSize = true;
            lblTotalTracksValue.Location = new Point(103, 110);
            lblTotalTracksValue.Name = "lblTotalTracksValue";
            lblTotalTracksValue.Size = new Size(13, 15);
            lblTotalTracksValue.TabIndex = 3;
            lblTotalTracksValue.Text = "0";
            // 
            // lblTotalTracks
            // 
            lblTotalTracks.AutoSize = true;
            lblTotalTracks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalTracks.Location = new Point(28, 110);
            lblTotalTracks.Name = "lblTotalTracks";
            lblTotalTracks.Size = new Size(74, 15);
            lblTotalTracks.TabIndex = 2;
            lblTotalTracks.Text = "Total tracks:";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Century Gothic", 45F, FontStyle.Bold);
            lblDashboard.Location = new Point(9, 4);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(351, 70);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            // 
            // lvLatestAdditions
            // 
            lvLatestAdditions.BackColor = Color.LightBlue;
            lvLatestAdditions.BorderStyle = BorderStyle.None;
            lvLatestAdditions.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            lvLatestAdditions.FullRowSelect = true;
            lvLatestAdditions.Location = new Point(500, 159);
            lvLatestAdditions.MultiSelect = false;
            lvLatestAdditions.Name = "lvLatestAdditions";
            lvLatestAdditions.Size = new Size(381, 373);
            lvLatestAdditions.TabIndex = 10;
            lvLatestAdditions.UseCompatibleStateImageBehavior = false;
            lvLatestAdditions.View = View.Details;
            lvLatestAdditions.DoubleClick += lvLatestAdditions_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Name = "columnHeader5";
            columnHeader5.Text = "Artist";
            columnHeader5.Width = 164;
            // 
            // columnHeader6
            // 
            columnHeader6.Name = "columnHeader6";
            columnHeader6.Text = "Release";
            columnHeader6.Width = 200;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Navy;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 578);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1120, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripStatusLabel1.ForeColor = Color.WhiteSmoke;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(49, 17);
            toolStripStatusLabel1.Text = "Status |";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = Color.WhiteSmoke;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(20, 17);
            toolStripStatusLabel2.Text = "ok";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.LightBlue;
            pnlSearch.Controls.Add(btnClearSearch);
            pnlSearch.Controls.Add(dgSearchResult);
            pnlSearch.Controls.Add(btnSearchIndex);
            pnlSearch.Controls.Add(txtSearchField);
            pnlSearch.Controls.Add(lblSearchQuery);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new Point(228, 34);
            pnlSearch.Margin = new Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(892, 544);
            pnlSearch.TabIndex = 6;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Location = new Point(319, 103);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(75, 23);
            btnClearSearch.TabIndex = 15;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // dgSearchResult
            // 
            dgSearchResult.AllowUserToAddRows = false;
            dgSearchResult.AllowUserToDeleteRows = false;
            dgSearchResult.AllowUserToResizeColumns = false;
            dgSearchResult.AllowUserToResizeRows = false;
            dgSearchResult.BackgroundColor = Color.LightBlue;
            dgSearchResult.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearchResult.Columns.AddRange(new DataGridViewColumn[] { Id, Artist, Album, Track, Year, TrackNumber, Tags, Path, FileName, Genre, Drive, FullFilePath });
            dgSearchResult.Cursor = Cursors.Hand;
            dgSearchResult.Location = new Point(28, 134);
            dgSearchResult.Name = "dgSearchResult";
            dgSearchResult.ReadOnly = true;
            dgSearchResult.RowHeadersWidth = 51;
            dgSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSearchResult.Size = new Size(852, 398);
            dgSearchResult.TabIndex = 14;
            dgSearchResult.Visible = false;
            dgSearchResult.CellDoubleClick += dgSearchResult_CellDoubleClick;
            dgSearchResult.RowContextMenuStripNeeded += dgSearchResult_RowContextMenuStripNeeded;
            // 
            // btnSearchIndex
            // 
            btnSearchIndex.Cursor = Cursors.Hand;
            btnSearchIndex.FlatStyle = FlatStyle.Popup;
            btnSearchIndex.Location = new Point(225, 103);
            btnSearchIndex.Name = "btnSearchIndex";
            btnSearchIndex.Size = new Size(75, 23);
            btnSearchIndex.TabIndex = 13;
            btnSearchIndex.Text = "Search";
            btnSearchIndex.UseVisualStyleBackColor = true;
            btnSearchIndex.Click += btnSearchIndex_Click;
            // 
            // txtSearchField
            // 
            txtSearchField.Location = new Point(28, 103);
            txtSearchField.Name = "txtSearchField";
            txtSearchField.Size = new Size(190, 23);
            txtSearchField.TabIndex = 12;
            txtSearchField.KeyPress += txtSearchField_KeyPress;
            // 
            // lblSearchQuery
            // 
            lblSearchQuery.AutoSize = true;
            lblSearchQuery.Location = new Point(28, 83);
            lblSearchQuery.Name = "lblSearchQuery";
            lblSearchQuery.Size = new Size(124, 15);
            lblSearchQuery.TabIndex = 11;
            lblSearchQuery.Text = "Enter search keywords";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Century Gothic", 45F, FontStyle.Bold);
            lblSearch.Location = new Point(9, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(232, 70);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // ctxFileOptions
            // 
            ctxFileOptions.ImageScalingSize = new Size(20, 20);
            ctxFileOptions.Items.AddRange(new ToolStripItem[] { toolStripShowFileInfo, toolStripShowMoreFromArtist, toolStripSeparator5, toolStripEditMetaTags, toolStripConvertSelectedFiles, toolStripSeparator3, toolStripOpenFileLocation, toolStripPlayFile, toolStripSeparator1, toolStripSearchRuTracker, toolStripSearchAllMusic, toolStripSeparator2, toolStripAddToList, toolStripSeparator4, toolStripRemoveFromIndex });
            ctxFileOptions.Name = "ctxFileOptions";
            ctxFileOptions.ShowImageMargin = false;
            ctxFileOptions.Size = new Size(170, 254);
            ctxFileOptions.ItemClicked += ctxFileOptions_ItemClicked;
            // 
            // toolStripShowFileInfo
            // 
            toolStripShowFileInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripShowFileInfo.Name = "toolStripShowFileInfo";
            toolStripShowFileInfo.Size = new Size(169, 22);
            toolStripShowFileInfo.Text = "Show file info";
            // 
            // toolStripShowMoreFromArtist
            // 
            toolStripShowMoreFromArtist.Name = "toolStripShowMoreFromArtist";
            toolStripShowMoreFromArtist.Size = new Size(169, 22);
            toolStripShowMoreFromArtist.Text = "All from this artist";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(166, 6);
            // 
            // toolStripEditMetaTags
            // 
            toolStripEditMetaTags.Name = "toolStripEditMetaTags";
            toolStripEditMetaTags.Size = new Size(169, 22);
            toolStripEditMetaTags.Text = "Edit meta tags";
            // 
            // toolStripConvertSelectedFiles
            // 
            toolStripConvertSelectedFiles.Name = "toolStripConvertSelectedFiles";
            toolStripConvertSelectedFiles.Size = new Size(169, 22);
            toolStripConvertSelectedFiles.Text = "Convert selected file(s)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(166, 6);
            // 
            // toolStripOpenFileLocation
            // 
            toolStripOpenFileLocation.Name = "toolStripOpenFileLocation";
            toolStripOpenFileLocation.Size = new Size(169, 22);
            toolStripOpenFileLocation.Text = "Open file location";
            // 
            // toolStripPlayFile
            // 
            toolStripPlayFile.Name = "toolStripPlayFile";
            toolStripPlayFile.Size = new Size(169, 22);
            toolStripPlayFile.Text = "Play file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(166, 6);
            // 
            // toolStripSearchRuTracker
            // 
            toolStripSearchRuTracker.Name = "toolStripSearchRuTracker";
            toolStripSearchRuTracker.Size = new Size(169, 22);
            toolStripSearchRuTracker.Text = "Search ruTracker";
            // 
            // toolStripSearchAllMusic
            // 
            toolStripSearchAllMusic.Name = "toolStripSearchAllMusic";
            toolStripSearchAllMusic.Size = new Size(169, 22);
            toolStripSearchAllMusic.Text = "Search AllMusic";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(166, 6);
            // 
            // toolStripAddToList
            // 
            toolStripAddToList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripAddToList.DropDownItems.AddRange(new ToolStripItem[] { toolStripTbAddNewList });
            toolStripAddToList.Name = "toolStripAddToList";
            toolStripAddToList.Size = new Size(169, 22);
            toolStripAddToList.Text = "Add to list";
            toolStripAddToList.TextAlign = ContentAlignment.MiddleLeft;
            toolStripAddToList.DropDownItemClicked += toolStripAddToList_DropDownItemClicked;
            // 
            // toolStripTbAddNewList
            // 
            toolStripTbAddNewList.Name = "toolStripTbAddNewList";
            toolStripTbAddNewList.Size = new Size(100, 23);
            toolStripTbAddNewList.KeyPress += toolStripTbNewList_KeyPress;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(166, 6);
            // 
            // toolStripRemoveFromIndex
            // 
            toolStripRemoveFromIndex.Name = "toolStripRemoveFromIndex";
            toolStripRemoveFromIndex.Size = new Size(169, 22);
            toolStripRemoveFromIndex.Text = "Remove from index";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.DefaultExt = "mla";
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // pnlLists
            // 
            pnlLists.BackColor = Color.LightBlue;
            pnlLists.Controls.Add(dgLists);
            pnlLists.Controls.Add(gbLists);
            pnlLists.Controls.Add(lblLists);
            pnlLists.Location = new Point(228, 34);
            pnlLists.Margin = new Padding(3, 2, 3, 2);
            pnlLists.Name = "pnlLists";
            pnlLists.Size = new Size(892, 544);
            pnlLists.TabIndex = 20;
            // 
            // dgLists
            // 
            dgLists.AllowUserToAddRows = false;
            dgLists.AllowUserToDeleteRows = false;
            dgLists.AllowUserToResizeColumns = false;
            dgLists.AllowUserToResizeRows = false;
            dgLists.BackgroundColor = Color.LightBlue;
            dgLists.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLists.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgLists.Cursor = Cursors.Hand;
            dgLists.Location = new Point(20, 113);
            dgLists.Name = "dgLists";
            dgLists.ReadOnly = true;
            dgLists.RowHeadersWidth = 51;
            dgLists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLists.Size = new Size(852, 398);
            dgLists.TabIndex = 21;
            dgLists.Visible = false;
            dgLists.CellDoubleClick += dgSearchResult_CellDoubleClick;
            dgLists.RowContextMenuStripNeeded += dgSearchResult_RowContextMenuStripNeeded;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Artist";
            dataGridViewTextBoxColumn2.FillWeight = 99.49239F;
            dataGridViewTextBoxColumn2.HeaderText = "Artist";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Album";
            dataGridViewTextBoxColumn3.FillWeight = 99.49239F;
            dataGridViewTextBoxColumn3.HeaderText = "Album";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "TrackName";
            dataGridViewTextBoxColumn4.FillWeight = 99.49239F;
            dataGridViewTextBoxColumn4.HeaderText = "Track";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 270;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn5.FillWeight = 101.5228F;
            dataGridViewTextBoxColumn5.HeaderText = "Year";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 48;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "TrackNumber";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn6.HeaderText = "Track no";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 45;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Tags";
            dataGridViewTextBoxColumn7.HeaderText = "Tags";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Path";
            dataGridViewTextBoxColumn8.HeaderText = "Path";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Visible = false;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "FileName";
            dataGridViewTextBoxColumn9.HeaderText = "FileName";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Genre";
            dataGridViewTextBoxColumn10.HeaderText = "Genre";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // gbLists
            // 
            gbLists.Controls.Add(btnSaveList);
            gbLists.Controls.Add(lblListName);
            gbLists.Controls.Add(lblSelectList);
            gbLists.Controls.Add(btnNewList);
            gbLists.Controls.Add(txtListName);
            gbLists.Controls.Add(cmbLists);
            gbLists.Location = new Point(170, 26);
            gbLists.Margin = new Padding(2, 2, 2, 2);
            gbLists.Name = "gbLists";
            gbLists.Padding = new Padding(2, 2, 2, 2);
            gbLists.Size = new Size(702, 73);
            gbLists.TabIndex = 20;
            gbLists.TabStop = false;
            gbLists.Text = "Actions";
            // 
            // btnSaveList
            // 
            btnSaveList.FlatStyle = FlatStyle.Flat;
            btnSaveList.Location = new Point(513, 40);
            btnSaveList.Margin = new Padding(2, 2, 2, 2);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(79, 26);
            btnSaveList.TabIndex = 24;
            btnSaveList.Text = "Save";
            btnSaveList.UseVisualStyleBackColor = true;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new Point(223, 23);
            lblListName.Margin = new Padding(2, 0, 2, 0);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(58, 15);
            lblListName.TabIndex = 21;
            lblListName.Text = "List name";
            // 
            // lblSelectList
            // 
            lblSelectList.AutoSize = true;
            lblSelectList.Location = new Point(12, 25);
            lblSelectList.Margin = new Padding(2, 0, 2, 0);
            lblSelectList.Name = "lblSelectList";
            lblSelectList.Size = new Size(56, 15);
            lblSelectList.TabIndex = 23;
            lblSelectList.Text = "Select list";
            // 
            // btnNewList
            // 
            btnNewList.FlatStyle = FlatStyle.Flat;
            btnNewList.Location = new Point(422, 40);
            btnNewList.Margin = new Padding(2, 2, 2, 2);
            btnNewList.Name = "btnNewList";
            btnNewList.Size = new Size(79, 26);
            btnNewList.TabIndex = 22;
            btnNewList.Text = "New";
            btnNewList.UseVisualStyleBackColor = true;
            btnNewList.Click += btnNewList_Click;
            // 
            // txtListName
            // 
            txtListName.Location = new Point(223, 43);
            txtListName.Margin = new Padding(2, 2, 2, 2);
            txtListName.Name = "txtListName";
            txtListName.Size = new Size(175, 23);
            txtListName.TabIndex = 21;
            txtListName.KeyPress += txtListName_Enter;
            // 
            // cmbLists
            // 
            cmbLists.FlatStyle = FlatStyle.Flat;
            cmbLists.FormattingEnabled = true;
            cmbLists.Location = new Point(12, 41);
            cmbLists.Margin = new Padding(2, 2, 2, 2);
            cmbLists.Name = "cmbLists";
            cmbLists.Size = new Size(189, 23);
            cmbLists.Sorted = true;
            cmbLists.TabIndex = 18;
            cmbLists.SelectedIndexChanged += cmbLists_SelectedIndexChanged;
            // 
            // lblLists
            // 
            lblLists.AutoSize = true;
            lblLists.Font = new Font("Century Gothic", 45F, FontStyle.Bold);
            lblLists.Location = new Point(23, 13);
            lblLists.Name = "lblLists";
            lblLists.Size = new Size(140, 70);
            lblLists.TabIndex = 17;
            lblLists.Text = "Lists";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Artist
            // 
            Artist.DataPropertyName = "Artist";
            Artist.FillWeight = 99.49239F;
            Artist.HeaderText = "Artist";
            Artist.MinimumWidth = 6;
            Artist.Name = "Artist";
            Artist.ReadOnly = true;
            Artist.Width = 200;
            // 
            // Album
            // 
            Album.DataPropertyName = "Album";
            Album.FillWeight = 99.49239F;
            Album.HeaderText = "Album";
            Album.MinimumWidth = 6;
            Album.Name = "Album";
            Album.ReadOnly = true;
            Album.Width = 220;
            // 
            // Track
            // 
            Track.DataPropertyName = "TrackName";
            Track.FillWeight = 99.49239F;
            Track.HeaderText = "Track";
            Track.MinimumWidth = 6;
            Track.Name = "Track";
            Track.ReadOnly = true;
            Track.Width = 270;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Year.DefaultCellStyle = dataGridViewCellStyle2;
            Year.FillWeight = 101.5228F;
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 48;
            // 
            // TrackNumber
            // 
            TrackNumber.DataPropertyName = "TrackNumber";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TrackNumber.DefaultCellStyle = dataGridViewCellStyle3;
            TrackNumber.HeaderText = "Track no";
            TrackNumber.MinimumWidth = 6;
            TrackNumber.Name = "TrackNumber";
            TrackNumber.ReadOnly = true;
            TrackNumber.Width = 45;
            // 
            // Tags
            // 
            Tags.DataPropertyName = "Tags";
            Tags.HeaderText = "Tags";
            Tags.MinimumWidth = 6;
            Tags.Name = "Tags";
            Tags.ReadOnly = true;
            Tags.Visible = false;
            Tags.Width = 125;
            // 
            // Path
            // 
            Path.DataPropertyName = "Path";
            Path.HeaderText = "Path";
            Path.MinimumWidth = 6;
            Path.Name = "Path";
            Path.ReadOnly = true;
            Path.Visible = false;
            Path.Width = 125;
            // 
            // FileName
            // 
            FileName.DataPropertyName = "FileName";
            FileName.HeaderText = "FileName";
            FileName.MinimumWidth = 6;
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Visible = false;
            FileName.Width = 125;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            Genre.Visible = false;
            Genre.Width = 125;
            // 
            // Drive
            // 
            Drive.DataPropertyName = "Drive";
            Drive.HeaderText = "Drive";
            Drive.MinimumWidth = 8;
            Drive.Name = "Drive";
            Drive.ReadOnly = true;
            Drive.Visible = false;
            Drive.Width = 150;
            // 
            // FullFilePath
            // 
            FullFilePath.DataPropertyName = "FullFilePath";
            FullFilePath.HeaderText = "FullFilePath";
            FullFilePath.Name = "FullFilePath";
            FullFilePath.ReadOnly = true;
            FullFilePath.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1120, 600);
            Controls.Add(pnlSearch);
            Controls.Add(pnlIndex);
            Controls.Add(pnlLists);
            Controls.Add(statusStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTop);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicLibrary";
            Load += MainForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlIndex.ResumeLayout(false);
            pnlIndex.PerformLayout();
            gbIndexSharing.ResumeLayout(false);
            gbIndexSharing.PerformLayout();
            gbIndexScanner.ResumeLayout(false);
            gbIndexScanner.PerformLayout();
            gbIndexMaintenance.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSearchResult).EndInit();
            ctxFileOptions.ResumeLayout(false);
            pnlLists.ResumeLayout(false);
            pnlLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLists).EndInit();
            gbLists.ResumeLayout(false);
            gbLists.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnMainMenuSearch;
        private System.Windows.Forms.Button btnMainMenuIndex;
        private System.Windows.Forms.Button btnMainMenuDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolTip toolTipBtnClose;
        private System.Windows.Forms.ToolTip toolTipBtnMinimize;
        private System.Windows.Forms.Label lblTotalTracks;
        private System.Windows.Forms.Label lblTotalTracksValue;
        private System.Windows.Forms.ListView lvExtensionsTotal;
        private System.Windows.Forms.ColumnHeader columnExtension;
        private System.Windows.Forms.ColumnHeader columnExtensionCount;
        private System.Windows.Forms.Button btnSearchIndex;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.Label lblSearchQuery;
        private System.Windows.Forms.DataGridView dgSearchResult;
        private System.Windows.Forms.ContextMenuStrip ctxFileOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditMetaTags;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListView lvReleaseYears;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblTotalByReleaseYear;
        private System.Windows.Forms.Label lblTotalByGenre;
        private System.Windows.Forms.Label lblTotalByExtension;
        private System.Windows.Forms.Label lblLatestAdditions;
        private System.Windows.Forms.ListView lvLatestAdditions;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.GroupBox gbIndexScanner;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblIndexFolder;
        private System.Windows.Forms.Button btnIndexFolder;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox gbIndexMaintenance;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Button btnClearIndex;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStopOptimize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnIndexNewFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripConvertSelectedFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenFileLocation;
        private System.Windows.Forms.ToolStripMenuItem toolStripSearchRuTracker;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemoveFromIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripPlayFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowFileInfo;
        private System.Windows.Forms.GroupBox gbIndexSharing;
        private System.Windows.Forms.Button btnIndexShare;
        private System.Windows.Forms.Button btnLoadIndex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox cmbAvailableIndexes;
        private System.Windows.Forms.Label lblDefaultIndex;
        private System.Windows.Forms.ToolStripMenuItem toolStripSearchAllMusic;
        private System.Windows.Forms.Button btnLists;
        private System.Windows.Forms.Panel pnlLists;
        private System.Windows.Forms.Label lblLists;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.GroupBox gbLists;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowMoreFromArtist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddToList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFile;
        private System.Windows.Forms.DataGridView dgLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripTextBox toolStripTbAddNewList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Artist;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Track;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn TrackNumber;
        private DataGridViewTextBoxColumn Tags;
        private DataGridViewTextBoxColumn Path;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Drive;
        private DataGridViewTextBoxColumn FullFilePath;
    }
}