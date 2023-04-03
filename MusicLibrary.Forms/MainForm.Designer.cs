
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlTop = new System.Windows.Forms.Panel();
            pbLogo = new System.Windows.Forms.PictureBox();
            btnMinimize = new System.Windows.Forms.Button();
            lblFormTitle = new System.Windows.Forms.Label();
            btnCloseForm = new System.Windows.Forms.Button();
            pnlIndex = new System.Windows.Forms.Panel();
            gbIndexSharing = new System.Windows.Forms.GroupBox();
            lblDefaultIndex = new System.Windows.Forms.Label();
            cmbAvailableIndexes = new System.Windows.Forms.ComboBox();
            btnLoadIndex = new System.Windows.Forms.Button();
            btnIndexShare = new System.Windows.Forms.Button();
            lblIndex = new System.Windows.Forms.Label();
            gbIndexScanner = new System.Windows.Forms.GroupBox();
            btnIndexNewFiles = new System.Windows.Forms.Button();
            btnIndex = new System.Windows.Forms.Button();
            lblIndexFolder = new System.Windows.Forms.Label();
            btnIndexFolder = new System.Windows.Forms.Button();
            btnScan = new System.Windows.Forms.Button();
            gbIndexMaintenance = new System.Windows.Forms.GroupBox();
            btnStopOptimize = new System.Windows.Forms.Button();
            btnOptimize = new System.Windows.Forms.Button();
            btnClearIndex = new System.Windows.Forms.Button();
            pnlLeft = new System.Windows.Forms.Panel();
            btnLists = new System.Windows.Forms.Button();
            btnMainMenuDashboard = new System.Windows.Forms.Button();
            btnMainMenuSearch = new System.Windows.Forms.Button();
            btnMainMenuIndex = new System.Windows.Forms.Button();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblLatestAdditions = new System.Windows.Forms.Label();
            lblTotalByReleaseYear = new System.Windows.Forms.Label();
            lblTotalByGenre = new System.Windows.Forms.Label();
            lblTotalByExtension = new System.Windows.Forms.Label();
            lvReleaseYears = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            lvExtensionsTotal = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            lvGenres = new System.Windows.Forms.ListView();
            columnExtension = new System.Windows.Forms.ColumnHeader();
            columnExtensionCount = new System.Windows.Forms.ColumnHeader();
            lblTotalTracksValue = new System.Windows.Forms.Label();
            lblTotalTracks = new System.Windows.Forms.Label();
            lblDashboard = new System.Windows.Forms.Label();
            lvLatestAdditions = new System.Windows.Forms.ListView();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            pnlSearch = new System.Windows.Forms.Panel();
            btnClearSearch = new System.Windows.Forms.Button();
            dgSearchResult = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnSearchIndex = new System.Windows.Forms.Button();
            txtSearchField = new System.Windows.Forms.TextBox();
            lblSearchQuery = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            toolTipBtnClose = new System.Windows.Forms.ToolTip(components);
            toolTipBtnMinimize = new System.Windows.Forms.ToolTip(components);
            ctxFileOptions = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripShowFileInfo = new System.Windows.Forms.ToolStripMenuItem();
            toolStripShowMoreFromArtist = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripEditMetaTags = new System.Windows.Forms.ToolStripMenuItem();
            toolStripConvertSelectedFiles = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            toolStripPlayFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSearchRuTracker = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSearchAllMusic = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripAddToList = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripRemoveFromIndex = new System.Windows.Forms.ToolStripMenuItem();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            pnlLists = new System.Windows.Forms.Panel();
            gbLists = new System.Windows.Forms.GroupBox();
            btnSaveList = new System.Windows.Forms.Button();
            lblListName = new System.Windows.Forms.Label();
            lblSelectList = new System.Windows.Forms.Label();
            btnNewList = new System.Windows.Forms.Button();
            txtListName = new System.Windows.Forms.TextBox();
            cmbLists = new System.Windows.Forms.ComboBox();
            dgvList = new System.Windows.Forms.DataGridView();
            colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblLists = new System.Windows.Forms.Label();
            ctxLists = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripTbNewList = new System.Windows.Forms.ToolStripTextBox();
            toolStripCbLists = new System.Windows.Forms.ToolStripComboBox();
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
            gbLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ctxLists.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = System.Drawing.Color.Navy;
            pnlTop.Controls.Add(pbLogo);
            pnlTop.Controls.Add(btnMinimize);
            pnlTop.Controls.Add(lblFormTitle);
            pnlTop.Controls.Add(btnCloseForm);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1120, 34);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // pbLogo
            // 
            pbLogo.Image = (System.Drawing.Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new System.Drawing.Point(0, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(40, 31);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMinimize.ForeColor = System.Drawing.Color.White;
            btnMinimize.Location = new System.Drawing.Point(1043, 2);
            btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(32, 27);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "─";
            toolTipBtnMinimize.SetToolTip(btnMinimize, "Minimize");
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblFormTitle.Location = new System.Drawing.Point(43, 4);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new System.Drawing.Size(146, 26);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "MusicLibrary";
            // 
            // btnCloseForm
            // 
            btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCloseForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnCloseForm.Location = new System.Drawing.Point(1081, 3);
            btnCloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new System.Drawing.Size(32, 27);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "X";
            toolTipBtnClose.SetToolTip(btnCloseForm, "Close");
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // pnlIndex
            // 
            pnlIndex.BackColor = System.Drawing.Color.LightBlue;
            pnlIndex.Controls.Add(gbIndexSharing);
            pnlIndex.Controls.Add(lblIndex);
            pnlIndex.Controls.Add(gbIndexScanner);
            pnlIndex.Controls.Add(gbIndexMaintenance);
            pnlIndex.Location = new System.Drawing.Point(228, 34);
            pnlIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlIndex.Name = "pnlIndex";
            pnlIndex.Size = new System.Drawing.Size(892, 544);
            pnlIndex.TabIndex = 4;
            // 
            // gbIndexSharing
            // 
            gbIndexSharing.Controls.Add(lblDefaultIndex);
            gbIndexSharing.Controls.Add(cmbAvailableIndexes);
            gbIndexSharing.Controls.Add(btnLoadIndex);
            gbIndexSharing.Controls.Add(btnIndexShare);
            gbIndexSharing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbIndexSharing.Location = new System.Drawing.Point(170, 391);
            gbIndexSharing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbIndexSharing.Name = "gbIndexSharing";
            gbIndexSharing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gbIndexSharing.Size = new System.Drawing.Size(489, 113);
            gbIndexSharing.TabIndex = 17;
            gbIndexSharing.TabStop = false;
            gbIndexSharing.Text = "Index sharing";
            // 
            // lblDefaultIndex
            // 
            lblDefaultIndex.AutoSize = true;
            lblDefaultIndex.Location = new System.Drawing.Point(242, 26);
            lblDefaultIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDefaultIndex.Name = "lblDefaultIndex";
            lblDefaultIndex.Size = new System.Drawing.Size(122, 15);
            lblDefaultIndex.TabIndex = 3;
            lblDefaultIndex.Text = "Select default index:";
            // 
            // cmbAvailableIndexes
            // 
            cmbAvailableIndexes.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbAvailableIndexes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAvailableIndexes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbAvailableIndexes.FormattingEnabled = true;
            cmbAvailableIndexes.Location = new System.Drawing.Point(242, 44);
            cmbAvailableIndexes.Margin = new System.Windows.Forms.Padding(2);
            cmbAvailableIndexes.Name = "cmbAvailableIndexes";
            cmbAvailableIndexes.Size = new System.Drawing.Size(244, 23);
            cmbAvailableIndexes.TabIndex = 2;
            // 
            // btnLoadIndex
            // 
            btnLoadIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoadIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoadIndex.Location = new System.Drawing.Point(133, 26);
            btnLoadIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoadIndex.Name = "btnLoadIndex";
            btnLoadIndex.Size = new System.Drawing.Size(88, 75);
            btnLoadIndex.TabIndex = 1;
            btnLoadIndex.Text = "Import index";
            btnLoadIndex.UseVisualStyleBackColor = true;
            btnLoadIndex.Click += btnLoadIndex_Click;
            // 
            // btnIndexShare
            // 
            btnIndexShare.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIndexShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIndexShare.Location = new System.Drawing.Point(18, 26);
            btnIndexShare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnIndexShare.Name = "btnIndexShare";
            btnIndexShare.Size = new System.Drawing.Size(88, 75);
            btnIndexShare.TabIndex = 0;
            btnIndexShare.Text = "Export index";
            btnIndexShare.UseVisualStyleBackColor = true;
            btnIndexShare.Click += btnIndexShare_Click;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblIndex.Location = new System.Drawing.Point(9, 13);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new System.Drawing.Size(195, 70);
            lblIndex.TabIndex = 16;
            lblIndex.Text = "Index";
            // 
            // gbIndexScanner
            // 
            gbIndexScanner.BackColor = System.Drawing.Color.LightBlue;
            gbIndexScanner.Controls.Add(btnIndexNewFiles);
            gbIndexScanner.Controls.Add(btnIndex);
            gbIndexScanner.Controls.Add(lblIndexFolder);
            gbIndexScanner.Controls.Add(btnIndexFolder);
            gbIndexScanner.Controls.Add(btnScan);
            gbIndexScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbIndexScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbIndexScanner.Location = new System.Drawing.Point(22, 115);
            gbIndexScanner.Name = "gbIndexScanner";
            gbIndexScanner.Size = new System.Drawing.Size(397, 231);
            gbIndexScanner.TabIndex = 15;
            gbIndexScanner.TabStop = false;
            gbIndexScanner.Text = "Index scanner";
            // 
            // btnIndexNewFiles
            // 
            btnIndexNewFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIndexNewFiles.Enabled = false;
            btnIndexNewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIndexNewFiles.Location = new System.Drawing.Point(148, 93);
            btnIndexNewFiles.Name = "btnIndexNewFiles";
            btnIndexNewFiles.Size = new System.Drawing.Size(91, 79);
            btnIndexNewFiles.TabIndex = 14;
            btnIndexNewFiles.Text = "Index new files only";
            btnIndexNewFiles.UseVisualStyleBackColor = true;
            btnIndexNewFiles.Click += btnIndexNewFiles_Click;
            // 
            // btnIndex
            // 
            btnIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIndex.Enabled = false;
            btnIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIndex.Location = new System.Drawing.Point(281, 93);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new System.Drawing.Size(91, 79);
            btnIndex.TabIndex = 10;
            btnIndex.Text = "Index all files";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click_1;
            // 
            // lblIndexFolder
            // 
            lblIndexFolder.AutoSize = true;
            lblIndexFolder.BackColor = System.Drawing.Color.LightBlue;
            lblIndexFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIndexFolder.Location = new System.Drawing.Point(26, 26);
            lblIndexFolder.Name = "lblIndexFolder";
            lblIndexFolder.Size = new System.Drawing.Size(138, 15);
            lblIndexFolder.TabIndex = 13;
            lblIndexFolder.Text = "Select root folder to scan";
            // 
            // btnIndexFolder
            // 
            btnIndexFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIndexFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIndexFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnIndexFolder.Location = new System.Drawing.Point(26, 48);
            btnIndexFolder.Name = "btnIndexFolder";
            btnIndexFolder.Size = new System.Drawing.Size(88, 23);
            btnIndexFolder.TabIndex = 12;
            btnIndexFolder.Text = "Select folder";
            btnIndexFolder.UseVisualStyleBackColor = true;
            btnIndexFolder.Click += btnIndexFolder_Click;
            // 
            // btnScan
            // 
            btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnScan.Enabled = false;
            btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnScan.Location = new System.Drawing.Point(26, 93);
            btnScan.Name = "btnScan";
            btnScan.Size = new System.Drawing.Size(88, 79);
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
            gbIndexMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbIndexMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbIndexMaintenance.Location = new System.Drawing.Point(500, 115);
            gbIndexMaintenance.Name = "gbIndexMaintenance";
            gbIndexMaintenance.Size = new System.Drawing.Size(317, 231);
            gbIndexMaintenance.TabIndex = 14;
            gbIndexMaintenance.TabStop = false;
            gbIndexMaintenance.Text = "Index maintenance";
            // 
            // btnStopOptimize
            // 
            btnStopOptimize.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStopOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStopOptimize.Location = new System.Drawing.Point(28, 93);
            btnStopOptimize.Name = "btnStopOptimize";
            btnStopOptimize.Size = new System.Drawing.Size(88, 79);
            btnStopOptimize.TabIndex = 16;
            btnStopOptimize.Text = "Stop";
            btnStopOptimize.UseVisualStyleBackColor = true;
            btnStopOptimize.Visible = false;
            btnStopOptimize.Click += btnStopOptimize_Click;
            // 
            // btnOptimize
            // 
            btnOptimize.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOptimize.Location = new System.Drawing.Point(28, 93);
            btnOptimize.Name = "btnOptimize";
            btnOptimize.Size = new System.Drawing.Size(88, 79);
            btnOptimize.TabIndex = 14;
            btnOptimize.Text = "Optimize";
            btnOptimize.UseVisualStyleBackColor = true;
            btnOptimize.Click += btnOptimize_Click;
            // 
            // btnClearIndex
            // 
            btnClearIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnClearIndex.Location = new System.Drawing.Point(198, 93);
            btnClearIndex.Name = "btnClearIndex";
            btnClearIndex.Size = new System.Drawing.Size(88, 79);
            btnClearIndex.TabIndex = 15;
            btnClearIndex.Text = "Clear index";
            btnClearIndex.UseVisualStyleBackColor = true;
            btnClearIndex.Click += btnClearIndex_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = System.Drawing.Color.RoyalBlue;
            pnlLeft.Controls.Add(btnLists);
            pnlLeft.Controls.Add(btnMainMenuDashboard);
            pnlLeft.Controls.Add(btnMainMenuSearch);
            pnlLeft.Controls.Add(btnMainMenuIndex);
            pnlLeft.Location = new System.Drawing.Point(0, 34);
            pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new System.Drawing.Size(232, 550);
            pnlLeft.TabIndex = 1;
            // 
            // btnLists
            // 
            btnLists.BackColor = System.Drawing.Color.LightGreen;
            btnLists.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLists.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLists.Location = new System.Drawing.Point(19, 240);
            btnLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLists.Name = "btnLists";
            btnLists.Size = new System.Drawing.Size(191, 61);
            btnLists.TabIndex = 3;
            btnLists.Text = "Lists";
            btnLists.UseVisualStyleBackColor = false;
            btnLists.Click += btnLists_Click;
            // 
            // btnMainMenuDashboard
            // 
            btnMainMenuDashboard.BackColor = System.Drawing.Color.LightGreen;
            btnMainMenuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainMenuDashboard.Location = new System.Drawing.Point(19, 90);
            btnMainMenuDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMainMenuDashboard.Name = "btnMainMenuDashboard";
            btnMainMenuDashboard.Size = new System.Drawing.Size(191, 58);
            btnMainMenuDashboard.TabIndex = 2;
            btnMainMenuDashboard.Text = "Dashboard";
            btnMainMenuDashboard.UseVisualStyleBackColor = false;
            btnMainMenuDashboard.Click += btnDashboard_Click;
            // 
            // btnMainMenuSearch
            // 
            btnMainMenuSearch.BackColor = System.Drawing.Color.LightGreen;
            btnMainMenuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainMenuSearch.Location = new System.Drawing.Point(19, 163);
            btnMainMenuSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMainMenuSearch.Name = "btnMainMenuSearch";
            btnMainMenuSearch.Size = new System.Drawing.Size(191, 58);
            btnMainMenuSearch.TabIndex = 1;
            btnMainMenuSearch.Text = "Search";
            btnMainMenuSearch.UseVisualStyleBackColor = false;
            btnMainMenuSearch.Click += btnSearch_Click;
            // 
            // btnMainMenuIndex
            // 
            btnMainMenuIndex.BackColor = System.Drawing.Color.RoyalBlue;
            btnMainMenuIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainMenuIndex.CausesValidation = false;
            btnMainMenuIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainMenuIndex.FlatAppearance.BorderSize = 0;
            btnMainMenuIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuIndex.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainMenuIndex.Image = Properties.Resources.settings_3110__1_;
            btnMainMenuIndex.Location = new System.Drawing.Point(178, 500);
            btnMainMenuIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnMainMenuIndex.Name = "btnMainMenuIndex";
            btnMainMenuIndex.Size = new System.Drawing.Size(32, 32);
            btnMainMenuIndex.TabIndex = 0;
            btnMainMenuIndex.UseVisualStyleBackColor = false;
            btnMainMenuIndex.Click += btnIndex_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = System.Drawing.Color.LightBlue;
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
            pnlDashboard.Location = new System.Drawing.Point(228, 34);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(892, 548);
            pnlDashboard.TabIndex = 3;
            // 
            // lblLatestAdditions
            // 
            lblLatestAdditions.AutoSize = true;
            lblLatestAdditions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLatestAdditions.Location = new System.Drawing.Point(613, 137);
            lblLatestAdditions.Name = "lblLatestAdditions";
            lblLatestAdditions.Size = new System.Drawing.Size(94, 15);
            lblLatestAdditions.TabIndex = 11;
            lblLatestAdditions.Text = "Latest additions";
            // 
            // lblTotalByReleaseYear
            // 
            lblTotalByReleaseYear.AutoSize = true;
            lblTotalByReleaseYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalByReleaseYear.Location = new System.Drawing.Point(368, 138);
            lblTotalByReleaseYear.Name = "lblTotalByReleaseYear";
            lblTotalByReleaseYear.Size = new System.Drawing.Size(120, 15);
            lblTotalByReleaseYear.TabIndex = 9;
            lblTotalByReleaseYear.Text = "Total by release year";
            // 
            // lblTotalByGenre
            // 
            lblTotalByGenre.AutoSize = true;
            lblTotalByGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalByGenre.Location = new System.Drawing.Point(159, 138);
            lblTotalByGenre.Name = "lblTotalByGenre";
            lblTotalByGenre.Size = new System.Drawing.Size(86, 15);
            lblTotalByGenre.TabIndex = 8;
            lblTotalByGenre.Text = "Total by genre";
            // 
            // lblTotalByExtension
            // 
            lblTotalByExtension.AutoSize = true;
            lblTotalByExtension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalByExtension.Location = new System.Drawing.Point(28, 138);
            lblTotalByExtension.Name = "lblTotalByExtension";
            lblTotalByExtension.Size = new System.Drawing.Size(92, 15);
            lblTotalByExtension.TabIndex = 7;
            lblTotalByExtension.Text = "Total by format";
            // 
            // lvReleaseYears
            // 
            lvReleaseYears.BackColor = System.Drawing.Color.LightBlue;
            lvReleaseYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvReleaseYears.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3, columnHeader4 });
            lvReleaseYears.FullRowSelect = true;
            lvReleaseYears.Location = new System.Drawing.Point(368, 159);
            lvReleaseYears.MultiSelect = false;
            lvReleaseYears.Name = "lvReleaseYears";
            lvReleaseYears.Size = new System.Drawing.Size(127, 373);
            lvReleaseYears.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvReleaseYears.TabIndex = 6;
            lvReleaseYears.UseCompatibleStateImageBehavior = false;
            lvReleaseYears.View = System.Windows.Forms.View.Details;
            lvReleaseYears.ColumnClick += lvReleaseYears_ColumnClick;
            lvReleaseYears.DoubleClick += lvReleaseYears_DoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Name = "columnHeader3";
            columnHeader3.Text = "Year";
            // 
            // columnHeader4
            // 
            columnHeader4.Name = "columnHeader4";
            columnHeader4.Text = "Tracks";
            // 
            // lvExtensionsTotal
            // 
            lvExtensionsTotal.BackColor = System.Drawing.Color.LightBlue;
            lvExtensionsTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvExtensionsTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
            lvExtensionsTotal.FullRowSelect = true;
            lvExtensionsTotal.Location = new System.Drawing.Point(28, 159);
            lvExtensionsTotal.MultiSelect = false;
            lvExtensionsTotal.Name = "lvExtensionsTotal";
            lvExtensionsTotal.Size = new System.Drawing.Size(126, 373);
            lvExtensionsTotal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvExtensionsTotal.TabIndex = 4;
            lvExtensionsTotal.UseCompatibleStateImageBehavior = false;
            lvExtensionsTotal.View = System.Windows.Forms.View.Details;
            lvExtensionsTotal.ColumnClick += lvExtensionsTotal_ColumnClick;
            lvExtensionsTotal.DoubleClick += lvExtensionsTotal_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Name = "columnHeader1";
            columnHeader1.Text = "Format";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Name = "columnHeader2";
            columnHeader2.Text = "Tracks";
            columnHeader2.Width = 73;
            // 
            // lvGenres
            // 
            lvGenres.BackColor = System.Drawing.Color.LightBlue;
            lvGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvGenres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnExtension, columnExtensionCount });
            lvGenres.FullRowSelect = true;
            lvGenres.Location = new System.Drawing.Point(159, 159);
            lvGenres.MultiSelect = false;
            lvGenres.Name = "lvGenres";
            lvGenres.Size = new System.Drawing.Size(203, 373);
            lvGenres.Sorting = System.Windows.Forms.SortOrder.Ascending;
            lvGenres.TabIndex = 5;
            lvGenres.UseCompatibleStateImageBehavior = false;
            lvGenres.View = System.Windows.Forms.View.Details;
            lvGenres.ColumnClick += lvGenres_ColumnClick;
            lvGenres.DoubleClick += lvGenres_DoubleClick;
            // 
            // columnExtension
            // 
            columnExtension.Name = "columnExtension";
            columnExtension.Text = "Genre";
            columnExtension.Width = 130;
            // 
            // columnExtensionCount
            // 
            columnExtensionCount.Name = "columnExtensionCount";
            columnExtensionCount.Text = "Tracks";
            columnExtensionCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnExtensionCount.Width = 80;
            // 
            // lblTotalTracksValue
            // 
            lblTotalTracksValue.AutoSize = true;
            lblTotalTracksValue.Location = new System.Drawing.Point(103, 110);
            lblTotalTracksValue.Name = "lblTotalTracksValue";
            lblTotalTracksValue.Size = new System.Drawing.Size(13, 15);
            lblTotalTracksValue.TabIndex = 3;
            lblTotalTracksValue.Text = "0";
            // 
            // lblTotalTracks
            // 
            lblTotalTracks.AutoSize = true;
            lblTotalTracks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalTracks.Location = new System.Drawing.Point(28, 110);
            lblTotalTracks.Name = "lblTotalTracks";
            lblTotalTracks.Size = new System.Drawing.Size(74, 15);
            lblTotalTracks.TabIndex = 2;
            lblTotalTracks.Text = "Total tracks:";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDashboard.Location = new System.Drawing.Point(9, 4);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(351, 70);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            // 
            // lvLatestAdditions
            // 
            lvLatestAdditions.BackColor = System.Drawing.Color.LightBlue;
            lvLatestAdditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lvLatestAdditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader6 });
            lvLatestAdditions.FullRowSelect = true;
            lvLatestAdditions.Location = new System.Drawing.Point(500, 159);
            lvLatestAdditions.MultiSelect = false;
            lvLatestAdditions.Name = "lvLatestAdditions";
            lvLatestAdditions.Size = new System.Drawing.Size(381, 373);
            lvLatestAdditions.TabIndex = 10;
            lvLatestAdditions.UseCompatibleStateImageBehavior = false;
            lvLatestAdditions.View = System.Windows.Forms.View.Details;
            lvLatestAdditions.DoubleClick += lvLatestAdditions_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Name = "columnHeader5";
            columnHeader5.Text = "Artist";
            columnHeader5.Width = 190;
            // 
            // columnHeader6
            // 
            columnHeader6.Name = "columnHeader6";
            columnHeader6.Text = "Release";
            columnHeader6.Width = 220;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.Navy;
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new System.Drawing.Point(0, 578);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            statusStrip1.Size = new System.Drawing.Size(1120, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(20, 17);
            toolStripStatusLabel2.Text = "ok";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = System.Drawing.Color.LightBlue;
            pnlSearch.Controls.Add(btnClearSearch);
            pnlSearch.Controls.Add(dgSearchResult);
            pnlSearch.Controls.Add(btnSearchIndex);
            pnlSearch.Controls.Add(txtSearchField);
            pnlSearch.Controls.Add(lblSearchQuery);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new System.Drawing.Point(228, 34);
            pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(892, 544);
            pnlSearch.TabIndex = 6;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearSearch.Location = new System.Drawing.Point(319, 103);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new System.Drawing.Size(75, 23);
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
            dgSearchResult.BackgroundColor = System.Drawing.Color.LightBlue;
            dgSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Artist, Album, Track, Year, TrackNumber, Tags, Path, FileName, Genre });
            dgSearchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            dgSearchResult.Location = new System.Drawing.Point(28, 134);
            dgSearchResult.Name = "dgSearchResult";
            dgSearchResult.ReadOnly = true;
            dgSearchResult.RowHeadersWidth = 51;
            dgSearchResult.RowTemplate.Height = 25;
            dgSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgSearchResult.Size = new System.Drawing.Size(852, 398);
            dgSearchResult.TabIndex = 14;
            dgSearchResult.Visible = false;
            dgSearchResult.CellDoubleClick += dgSearchResult_CellDoubleClick;
            dgSearchResult.RowContextMenuStripNeeded += dgSearchResult_RowContextMenuStripNeeded;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            Year.DefaultCellStyle = dataGridViewCellStyle2;
            Year.FillWeight = 101.5228F;
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.ReadOnly = true;
            Year.Width = 54;
            // 
            // TrackNumber
            // 
            TrackNumber.DataPropertyName = "TrackNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            TrackNumber.DefaultCellStyle = dataGridViewCellStyle3;
            TrackNumber.HeaderText = "Track no";
            TrackNumber.MinimumWidth = 6;
            TrackNumber.Name = "TrackNumber";
            TrackNumber.ReadOnly = true;
            TrackNumber.Width = 50;
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
            // btnSearchIndex
            // 
            btnSearchIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearchIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSearchIndex.Location = new System.Drawing.Point(225, 103);
            btnSearchIndex.Name = "btnSearchIndex";
            btnSearchIndex.Size = new System.Drawing.Size(75, 23);
            btnSearchIndex.TabIndex = 13;
            btnSearchIndex.Text = "Search";
            btnSearchIndex.UseVisualStyleBackColor = true;
            btnSearchIndex.Click += btnSearchIndex_Click;
            // 
            // txtSearchField
            // 
            txtSearchField.Location = new System.Drawing.Point(28, 103);
            txtSearchField.Name = "txtSearchField";
            txtSearchField.Size = new System.Drawing.Size(190, 23);
            txtSearchField.TabIndex = 12;
            txtSearchField.KeyPress += txtSearchField_KeyPress;
            // 
            // lblSearchQuery
            // 
            lblSearchQuery.AutoSize = true;
            lblSearchQuery.Location = new System.Drawing.Point(28, 83);
            lblSearchQuery.Name = "lblSearchQuery";
            lblSearchQuery.Size = new System.Drawing.Size(124, 15);
            lblSearchQuery.TabIndex = 11;
            lblSearchQuery.Text = "Enter search keywords";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(9, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(232, 70);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // ctxFileOptions
            // 
            ctxFileOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            ctxFileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripShowFileInfo, toolStripShowMoreFromArtist, toolStripSeparator5, toolStripEditMetaTags, toolStripConvertSelectedFiles, toolStripSeparator3, toolStripOpenFileLocation, toolStripPlayFile, toolStripSeparator1, toolStripSearchRuTracker, toolStripSearchAllMusic, toolStripSeparator2, toolStripAddToList, toolStripSeparator4, toolStripRemoveFromIndex });
            ctxFileOptions.Name = "ctxFileOptions";
            ctxFileOptions.ShowImageMargin = false;
            ctxFileOptions.Size = new System.Drawing.Size(170, 254);
            ctxFileOptions.ItemClicked += ctxFileOptions_ItemClicked;
            // 
            // toolStripShowFileInfo
            // 
            toolStripShowFileInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            toolStripShowFileInfo.Name = "toolStripShowFileInfo";
            toolStripShowFileInfo.Size = new System.Drawing.Size(169, 22);
            toolStripShowFileInfo.Text = "Show file info";
            // 
            // toolStripShowMoreFromArtist
            // 
            toolStripShowMoreFromArtist.Name = "toolStripShowMoreFromArtist";
            toolStripShowMoreFromArtist.Size = new System.Drawing.Size(169, 22);
            toolStripShowMoreFromArtist.Text = "All from this artist";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripEditMetaTags
            // 
            toolStripEditMetaTags.Name = "toolStripEditMetaTags";
            toolStripEditMetaTags.Size = new System.Drawing.Size(169, 22);
            toolStripEditMetaTags.Text = "Edit meta tags";
            // 
            // toolStripConvertSelectedFiles
            // 
            toolStripConvertSelectedFiles.Name = "toolStripConvertSelectedFiles";
            toolStripConvertSelectedFiles.Size = new System.Drawing.Size(169, 22);
            toolStripConvertSelectedFiles.Text = "Convert selected file(s)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripOpenFileLocation
            // 
            toolStripOpenFileLocation.Name = "toolStripOpenFileLocation";
            toolStripOpenFileLocation.Size = new System.Drawing.Size(169, 22);
            toolStripOpenFileLocation.Text = "Open file location";
            // 
            // toolStripPlayFile
            // 
            toolStripPlayFile.Name = "toolStripPlayFile";
            toolStripPlayFile.Size = new System.Drawing.Size(169, 22);
            toolStripPlayFile.Text = "Play file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripSearchRuTracker
            // 
            toolStripSearchRuTracker.Name = "toolStripSearchRuTracker";
            toolStripSearchRuTracker.Size = new System.Drawing.Size(169, 22);
            toolStripSearchRuTracker.Text = "Search ruTracker";
            // 
            // toolStripSearchAllMusic
            // 
            toolStripSearchAllMusic.Name = "toolStripSearchAllMusic";
            toolStripSearchAllMusic.Size = new System.Drawing.Size(169, 22);
            toolStripSearchAllMusic.Text = "Search AllMusic";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripAddToList
            // 
            toolStripAddToList.Name = "toolStripAddToList";
            toolStripAddToList.Size = new System.Drawing.Size(169, 22);
            toolStripAddToList.Text = "Add to list";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripRemoveFromIndex
            // 
            toolStripRemoveFromIndex.Name = "toolStripRemoveFromIndex";
            toolStripRemoveFromIndex.Size = new System.Drawing.Size(169, 22);
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
            pnlLists.BackColor = System.Drawing.Color.LightBlue;
            pnlLists.Controls.Add(gbLists);
            pnlLists.Controls.Add(dgvList);
            pnlLists.Controls.Add(lblLists);
            pnlLists.Location = new System.Drawing.Point(228, 34);
            pnlLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlLists.Name = "pnlLists";
            pnlLists.Size = new System.Drawing.Size(892, 548);
            pnlLists.TabIndex = 20;
            // 
            // gbLists
            // 
            gbLists.Controls.Add(btnSaveList);
            gbLists.Controls.Add(lblListName);
            gbLists.Controls.Add(lblSelectList);
            gbLists.Controls.Add(btnNewList);
            gbLists.Controls.Add(txtListName);
            gbLists.Controls.Add(cmbLists);
            gbLists.Location = new System.Drawing.Point(276, 26);
            gbLists.Margin = new System.Windows.Forms.Padding(2);
            gbLists.Name = "gbLists";
            gbLists.Padding = new System.Windows.Forms.Padding(2);
            gbLists.Size = new System.Drawing.Size(605, 73);
            gbLists.TabIndex = 20;
            gbLists.TabStop = false;
            gbLists.Text = "Actions";
            // 
            // btnSaveList
            // 
            btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveList.Location = new System.Drawing.Point(513, 40);
            btnSaveList.Margin = new System.Windows.Forms.Padding(2);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new System.Drawing.Size(79, 26);
            btnSaveList.TabIndex = 24;
            btnSaveList.Text = "Save";
            btnSaveList.UseVisualStyleBackColor = true;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new System.Drawing.Point(209, 25);
            lblListName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblListName.Name = "lblListName";
            lblListName.Size = new System.Drawing.Size(58, 15);
            lblListName.TabIndex = 21;
            lblListName.Text = "List name";
            // 
            // lblSelectList
            // 
            lblSelectList.AutoSize = true;
            lblSelectList.Location = new System.Drawing.Point(4, 25);
            lblSelectList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSelectList.Name = "lblSelectList";
            lblSelectList.Size = new System.Drawing.Size(56, 15);
            lblSelectList.TabIndex = 23;
            lblSelectList.Text = "Select list";
            // 
            // btnNewList
            // 
            btnNewList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewList.Location = new System.Drawing.Point(422, 40);
            btnNewList.Margin = new System.Windows.Forms.Padding(2);
            btnNewList.Name = "btnNewList";
            btnNewList.Size = new System.Drawing.Size(79, 26);
            btnNewList.TabIndex = 22;
            btnNewList.Text = "New";
            btnNewList.UseVisualStyleBackColor = true;
            btnNewList.Click += btnNewList_Click;
            // 
            // txtListName
            // 
            txtListName.Location = new System.Drawing.Point(209, 43);
            txtListName.Margin = new System.Windows.Forms.Padding(2);
            txtListName.Name = "txtListName";
            txtListName.Size = new System.Drawing.Size(175, 23);
            txtListName.TabIndex = 21;
            txtListName.KeyPress += txtListName_Enter;
            // 
            // cmbLists
            // 
            cmbLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbLists.FormattingEnabled = true;
            cmbLists.Location = new System.Drawing.Point(4, 41);
            cmbLists.Margin = new System.Windows.Forms.Padding(2);
            cmbLists.Name = "cmbLists";
            cmbLists.Size = new System.Drawing.Size(189, 23);
            cmbLists.TabIndex = 18;
            // 
            // dgvList
            // 
            dgvList.AllowUserToOrderColumns = true;
            dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colPath });
            dgvList.Location = new System.Drawing.Point(9, 110);
            dgvList.Margin = new System.Windows.Forms.Padding(2);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersWidth = 62;
            dgvList.RowTemplate.Height = 33;
            dgvList.Size = new System.Drawing.Size(872, 431);
            dgvList.TabIndex = 19;
            // 
            // colPath
            // 
            colPath.HeaderText = "Path";
            colPath.MinimumWidth = 8;
            colPath.Name = "colPath";
            colPath.ReadOnly = true;
            colPath.Width = 150;
            // 
            // lblLists
            // 
            lblLists.AutoSize = true;
            lblLists.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLists.Location = new System.Drawing.Point(23, 13);
            lblLists.Name = "lblLists";
            lblLists.Size = new System.Drawing.Size(140, 70);
            lblLists.TabIndex = 17;
            lblLists.Text = "Lists";
            // 
            // ctxLists
            // 
            ctxLists.ImageScalingSize = new System.Drawing.Size(20, 20);
            ctxLists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTbNewList, toolStripCbLists });
            ctxLists.Name = "ctxFileOptions";
            ctxLists.ShowImageMargin = false;
            ctxLists.Size = new System.Drawing.Size(157, 56);
            // 
            // toolStripTbNewList
            // 
            toolStripTbNewList.BackColor = System.Drawing.SystemColors.HighlightText;
            toolStripTbNewList.Name = "toolStripTbNewList";
            toolStripTbNewList.Size = new System.Drawing.Size(100, 23);
            toolStripTbNewList.ToolTipText = "New list name";
            toolStripTbNewList.KeyPress += toolStripTbNewList_KeyPress;
            // 
            // toolStripCbLists
            // 
            toolStripCbLists.Name = "toolStripCbLists";
            toolStripCbLists.Size = new System.Drawing.Size(121, 23);
            toolStripCbLists.SelectedIndexChanged += toolStripCbLists_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1120, 600);
            Controls.Add(pnlLists);
            Controls.Add(pnlIndex);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlSearch);
            Controls.Add(pnlTop);
            Controls.Add(statusStrip1);
            Controls.Add(pnlLeft);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            gbLists.ResumeLayout(false);
            gbLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ctxLists.ResumeLayout(false);
            ctxLists.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
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
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.Label lblListName;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowMoreFromArtist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddToList;
        private System.Windows.Forms.ContextMenuStrip ctxLists;
        private System.Windows.Forms.ToolStripTextBox toolStripTbNewList;
        private System.Windows.Forms.ToolStripComboBox toolStripCbLists;
    }
}