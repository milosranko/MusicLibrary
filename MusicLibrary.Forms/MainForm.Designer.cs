﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.gbIndexScanner = new System.Windows.Forms.GroupBox();
            this.btnIndexNewFiles = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblIndexFolder = new System.Windows.Forms.Label();
            this.btnIndexFolder = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.gbIndexMaintenance = new System.Windows.Forms.GroupBox();
            this.btnStopOptimize = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.btnClearIndex = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnMainMenuDashboard = new System.Windows.Forms.Button();
            this.btnMainMenuSearch = new System.Windows.Forms.Button();
            this.btnMainMenuIndex = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblLatestAdditions = new System.Windows.Forms.Label();
            this.lvLatestAdditions = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblTotalByReleaseYear = new System.Windows.Forms.Label();
            this.lblTotalByGenre = new System.Windows.Forms.Label();
            this.lblTotalByExtension = new System.Windows.Forms.Label();
            this.lvReleaseYears = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lvExtensionsTotal = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvGenres = new System.Windows.Forms.ListView();
            this.columnExtension = new System.Windows.Forms.ColumnHeader();
            this.columnExtensionCount = new System.Windows.Forms.ColumnHeader();
            this.lblTotalTracksValue = new System.Windows.Forms.Label();
            this.lblTotalTracks = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.dgSearchResult = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchIndex = new System.Windows.Forms.Button();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.lblSearchQuery = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolTipBtnClose = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnMinimize = new System.Windows.Forms.ToolTip(this.components);
            this.ctxFileOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditMetaTags = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConvertSelectedFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPlayFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSearchRuTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRemoveFromIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripShowFileInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlIndex.SuspendLayout();
            this.gbIndexScanner.SuspendLayout();
            this.gbIndexMaintenance.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResult)).BeginInit();
            this.ctxFileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Navy;
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.lblFormTitle);
            this.pnlTop.Controls.Add(this.btnCloseForm);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 45);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 3);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(46, 41);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1192, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "─";
            this.toolTipBtnMinimize.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFormTitle.Location = new System.Drawing.Point(49, 5);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(177, 32);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "MusicLibrary";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseForm.Location = new System.Drawing.Point(1235, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(37, 36);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "X";
            this.toolTipBtnClose.SetToolTip(this.btnCloseForm, "Close");
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pnlIndex
            // 
            this.pnlIndex.BackColor = System.Drawing.Color.LightBlue;
            this.pnlIndex.Controls.Add(this.lblIndex);
            this.pnlIndex.Controls.Add(this.gbIndexScanner);
            this.pnlIndex.Controls.Add(this.gbIndexMaintenance);
            this.pnlIndex.Location = new System.Drawing.Point(261, 45);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(1019, 725);
            this.pnlIndex.TabIndex = 4;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIndex.Location = new System.Drawing.Point(10, 17);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(244, 89);
            this.lblIndex.TabIndex = 16;
            this.lblIndex.Text = "Index";
            // 
            // gbIndexScanner
            // 
            this.gbIndexScanner.BackColor = System.Drawing.Color.LightBlue;
            this.gbIndexScanner.Controls.Add(this.btnIndexNewFiles);
            this.gbIndexScanner.Controls.Add(this.btnIndex);
            this.gbIndexScanner.Controls.Add(this.lblIndexFolder);
            this.gbIndexScanner.Controls.Add(this.btnIndexFolder);
            this.gbIndexScanner.Controls.Add(this.btnScan);
            this.gbIndexScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIndexScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIndexScanner.Location = new System.Drawing.Point(25, 153);
            this.gbIndexScanner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIndexScanner.Name = "gbIndexScanner";
            this.gbIndexScanner.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIndexScanner.Size = new System.Drawing.Size(454, 308);
            this.gbIndexScanner.TabIndex = 15;
            this.gbIndexScanner.TabStop = false;
            this.gbIndexScanner.Text = "Index scanner";
            // 
            // btnIndexNewFiles
            // 
            this.btnIndexNewFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndexNewFiles.Enabled = false;
            this.btnIndexNewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIndexNewFiles.Location = new System.Drawing.Point(169, 124);
            this.btnIndexNewFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndexNewFiles.Name = "btnIndexNewFiles";
            this.btnIndexNewFiles.Size = new System.Drawing.Size(104, 105);
            this.btnIndexNewFiles.TabIndex = 14;
            this.btnIndexNewFiles.Text = "Index new files only";
            this.btnIndexNewFiles.UseVisualStyleBackColor = true;
            this.btnIndexNewFiles.Click += new System.EventHandler(this.btnIndexNewFiles_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndex.Enabled = false;
            this.btnIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIndex.Location = new System.Drawing.Point(321, 124);
            this.btnIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(104, 105);
            this.btnIndex.TabIndex = 10;
            this.btnIndex.Text = "Index all files";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click_1);
            // 
            // lblIndexFolder
            // 
            this.lblIndexFolder.AutoSize = true;
            this.lblIndexFolder.BackColor = System.Drawing.Color.LightBlue;
            this.lblIndexFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndexFolder.Location = new System.Drawing.Point(30, 35);
            this.lblIndexFolder.Name = "lblIndexFolder";
            this.lblIndexFolder.Size = new System.Drawing.Size(176, 20);
            this.lblIndexFolder.TabIndex = 13;
            this.lblIndexFolder.Text = "Select root folder to scan";
            // 
            // btnIndexFolder
            // 
            this.btnIndexFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndexFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIndexFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIndexFolder.Location = new System.Drawing.Point(30, 64);
            this.btnIndexFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndexFolder.Name = "btnIndexFolder";
            this.btnIndexFolder.Size = new System.Drawing.Size(101, 31);
            this.btnIndexFolder.TabIndex = 12;
            this.btnIndexFolder.Text = "Select folder";
            this.btnIndexFolder.UseVisualStyleBackColor = true;
            this.btnIndexFolder.Click += new System.EventHandler(this.btnIndexFolder_Click);
            // 
            // btnScan
            // 
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.Enabled = false;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScan.Location = new System.Drawing.Point(30, 124);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(101, 105);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // gbIndexMaintenance
            // 
            this.gbIndexMaintenance.Controls.Add(this.btnStopOptimize);
            this.gbIndexMaintenance.Controls.Add(this.btnOptimize);
            this.gbIndexMaintenance.Controls.Add(this.btnClearIndex);
            this.gbIndexMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbIndexMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbIndexMaintenance.Location = new System.Drawing.Point(571, 153);
            this.gbIndexMaintenance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIndexMaintenance.Name = "gbIndexMaintenance";
            this.gbIndexMaintenance.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIndexMaintenance.Size = new System.Drawing.Size(362, 308);
            this.gbIndexMaintenance.TabIndex = 14;
            this.gbIndexMaintenance.TabStop = false;
            this.gbIndexMaintenance.Text = "Index maintenance";
            // 
            // btnStopOptimize
            // 
            this.btnStopOptimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopOptimize.Location = new System.Drawing.Point(32, 124);
            this.btnStopOptimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopOptimize.Name = "btnStopOptimize";
            this.btnStopOptimize.Size = new System.Drawing.Size(101, 105);
            this.btnStopOptimize.TabIndex = 16;
            this.btnStopOptimize.Text = "Stop";
            this.btnStopOptimize.UseVisualStyleBackColor = true;
            this.btnStopOptimize.Visible = false;
            this.btnStopOptimize.Click += new System.EventHandler(this.btnStopOptimize_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimize.Location = new System.Drawing.Point(32, 124);
            this.btnOptimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(101, 105);
            this.btnOptimize.TabIndex = 14;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // btnClearIndex
            // 
            this.btnClearIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearIndex.Location = new System.Drawing.Point(226, 124);
            this.btnClearIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearIndex.Name = "btnClearIndex";
            this.btnClearIndex.Size = new System.Drawing.Size(101, 105);
            this.btnClearIndex.TabIndex = 15;
            this.btnClearIndex.Text = "Clear index";
            this.btnClearIndex.UseVisualStyleBackColor = true;
            this.btnClearIndex.Click += new System.EventHandler(this.btnClearIndex_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlLeft.Controls.Add(this.btnMainMenuDashboard);
            this.pnlLeft.Controls.Add(this.btnMainMenuSearch);
            this.pnlLeft.Controls.Add(this.btnMainMenuIndex);
            this.pnlLeft.Location = new System.Drawing.Point(0, 45);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(264, 733);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnMainMenuDashboard
            // 
            this.btnMainMenuDashboard.BackColor = System.Drawing.Color.LightGreen;
            this.btnMainMenuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenuDashboard.Location = new System.Drawing.Point(22, 120);
            this.btnMainMenuDashboard.Name = "btnMainMenuDashboard";
            this.btnMainMenuDashboard.Size = new System.Drawing.Size(218, 77);
            this.btnMainMenuDashboard.TabIndex = 2;
            this.btnMainMenuDashboard.Text = "Dashboard";
            this.btnMainMenuDashboard.UseVisualStyleBackColor = false;
            this.btnMainMenuDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMainMenuSearch
            // 
            this.btnMainMenuSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnMainMenuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenuSearch.Location = new System.Drawing.Point(22, 332);
            this.btnMainMenuSearch.Name = "btnMainMenuSearch";
            this.btnMainMenuSearch.Size = new System.Drawing.Size(218, 77);
            this.btnMainMenuSearch.TabIndex = 1;
            this.btnMainMenuSearch.Text = "Search";
            this.btnMainMenuSearch.UseVisualStyleBackColor = false;
            this.btnMainMenuSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMainMenuIndex
            // 
            this.btnMainMenuIndex.BackColor = System.Drawing.Color.LightGreen;
            this.btnMainMenuIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenuIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuIndex.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenuIndex.Location = new System.Drawing.Point(22, 227);
            this.btnMainMenuIndex.Name = "btnMainMenuIndex";
            this.btnMainMenuIndex.Size = new System.Drawing.Size(218, 77);
            this.btnMainMenuIndex.TabIndex = 0;
            this.btnMainMenuIndex.Text = "Index";
            this.btnMainMenuIndex.UseVisualStyleBackColor = false;
            this.btnMainMenuIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.LightBlue;
            this.pnlDashboard.Controls.Add(this.lblLatestAdditions);
            this.pnlDashboard.Controls.Add(this.lvLatestAdditions);
            this.pnlDashboard.Controls.Add(this.lblTotalByReleaseYear);
            this.pnlDashboard.Controls.Add(this.lblTotalByGenre);
            this.pnlDashboard.Controls.Add(this.lblTotalByExtension);
            this.pnlDashboard.Controls.Add(this.lvReleaseYears);
            this.pnlDashboard.Controls.Add(this.lvExtensionsTotal);
            this.pnlDashboard.Controls.Add(this.lvGenres);
            this.pnlDashboard.Controls.Add(this.lblTotalTracksValue);
            this.pnlDashboard.Controls.Add(this.lblTotalTracks);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(261, 45);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1019, 725);
            this.pnlDashboard.TabIndex = 3;
            // 
            // lblLatestAdditions
            // 
            this.lblLatestAdditions.AutoSize = true;
            this.lblLatestAdditions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLatestAdditions.Location = new System.Drawing.Point(701, 183);
            this.lblLatestAdditions.Name = "lblLatestAdditions";
            this.lblLatestAdditions.Size = new System.Drawing.Size(121, 20);
            this.lblLatestAdditions.TabIndex = 11;
            this.lblLatestAdditions.Text = "Latest additions";
            // 
            // lvLatestAdditions
            // 
            this.lvLatestAdditions.BackColor = System.Drawing.Color.LightBlue;
            this.lvLatestAdditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLatestAdditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvLatestAdditions.FullRowSelect = true;
            this.lvLatestAdditions.HideSelection = false;
            this.lvLatestAdditions.Location = new System.Drawing.Point(701, 212);
            this.lvLatestAdditions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvLatestAdditions.MultiSelect = false;
            this.lvLatestAdditions.Name = "lvLatestAdditions";
            this.lvLatestAdditions.Size = new System.Drawing.Size(305, 497);
            this.lvLatestAdditions.TabIndex = 10;
            this.lvLatestAdditions.UseCompatibleStateImageBehavior = false;
            this.lvLatestAdditions.View = System.Windows.Forms.View.Details;
            this.lvLatestAdditions.DoubleClick += new System.EventHandler(this.lvLatestAdditions_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Artist";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Release";
            this.columnHeader6.Width = 135;
            // 
            // lblTotalByReleaseYear
            // 
            this.lblTotalByReleaseYear.AutoSize = true;
            this.lblTotalByReleaseYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalByReleaseYear.Location = new System.Drawing.Point(536, 184);
            this.lblTotalByReleaseYear.Name = "lblTotalByReleaseYear";
            this.lblTotalByReleaseYear.Size = new System.Drawing.Size(152, 20);
            this.lblTotalByReleaseYear.TabIndex = 9;
            this.lblTotalByReleaseYear.Text = "Total by release year";
            // 
            // lblTotalByGenre
            // 
            this.lblTotalByGenre.AutoSize = true;
            this.lblTotalByGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalByGenre.Location = new System.Drawing.Point(200, 184);
            this.lblTotalByGenre.Name = "lblTotalByGenre";
            this.lblTotalByGenre.Size = new System.Drawing.Size(109, 20);
            this.lblTotalByGenre.TabIndex = 8;
            this.lblTotalByGenre.Text = "Total by genre";
            // 
            // lblTotalByExtension
            // 
            this.lblTotalByExtension.AutoSize = true;
            this.lblTotalByExtension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalByExtension.Location = new System.Drawing.Point(32, 184);
            this.lblTotalByExtension.Name = "lblTotalByExtension";
            this.lblTotalByExtension.Size = new System.Drawing.Size(137, 20);
            this.lblTotalByExtension.TabIndex = 7;
            this.lblTotalByExtension.Text = "Total by extension";
            // 
            // lvReleaseYears
            // 
            this.lvReleaseYears.BackColor = System.Drawing.Color.LightBlue;
            this.lvReleaseYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReleaseYears.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvReleaseYears.FullRowSelect = true;
            this.lvReleaseYears.HideSelection = false;
            this.lvReleaseYears.Location = new System.Drawing.Point(536, 212);
            this.lvReleaseYears.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvReleaseYears.MultiSelect = false;
            this.lvReleaseYears.Name = "lvReleaseYears";
            this.lvReleaseYears.Size = new System.Drawing.Size(157, 497);
            this.lvReleaseYears.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvReleaseYears.TabIndex = 6;
            this.lvReleaseYears.UseCompatibleStateImageBehavior = false;
            this.lvReleaseYears.View = System.Windows.Forms.View.Details;
            this.lvReleaseYears.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvReleaseYears_ColumnClick);
            this.lvReleaseYears.DoubleClick += new System.EventHandler(this.lvReleaseYears_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Year";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Releases";
            // 
            // lvExtensionsTotal
            // 
            this.lvExtensionsTotal.BackColor = System.Drawing.Color.LightBlue;
            this.lvExtensionsTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvExtensionsTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvExtensionsTotal.FullRowSelect = true;
            this.lvExtensionsTotal.HideSelection = false;
            this.lvExtensionsTotal.Location = new System.Drawing.Point(32, 212);
            this.lvExtensionsTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvExtensionsTotal.MultiSelect = false;
            this.lvExtensionsTotal.Name = "lvExtensionsTotal";
            this.lvExtensionsTotal.Size = new System.Drawing.Size(161, 497);
            this.lvExtensionsTotal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvExtensionsTotal.TabIndex = 4;
            this.lvExtensionsTotal.UseCompatibleStateImageBehavior = false;
            this.lvExtensionsTotal.View = System.Windows.Forms.View.Details;
            this.lvExtensionsTotal.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvExtensionsTotal_ColumnClick);
            this.lvExtensionsTotal.DoubleClick += new System.EventHandler(this.lvExtensionsTotal_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Extension";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Tracks";
            this.columnHeader2.Width = 75;
            // 
            // lvGenres
            // 
            this.lvGenres.BackColor = System.Drawing.Color.LightBlue;
            this.lvGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGenres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnExtension,
            this.columnExtensionCount});
            this.lvGenres.FullRowSelect = true;
            this.lvGenres.HideSelection = false;
            this.lvGenres.Location = new System.Drawing.Point(200, 212);
            this.lvGenres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvGenres.MultiSelect = false;
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(328, 497);
            this.lvGenres.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGenres.TabIndex = 5;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.Details;
            this.lvGenres.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvGenres_ColumnClick);
            this.lvGenres.DoubleClick += new System.EventHandler(this.lvGenres_DoubleClick);
            // 
            // columnExtension
            // 
            this.columnExtension.Name = "columnExtension";
            this.columnExtension.Text = "Genre";
            this.columnExtension.Width = 160;
            // 
            // columnExtensionCount
            // 
            this.columnExtensionCount.Name = "columnExtensionCount";
            this.columnExtensionCount.Text = "Tracks";
            this.columnExtensionCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnExtensionCount.Width = 110;
            // 
            // lblTotalTracksValue
            // 
            this.lblTotalTracksValue.AutoSize = true;
            this.lblTotalTracksValue.Location = new System.Drawing.Point(118, 147);
            this.lblTotalTracksValue.Name = "lblTotalTracksValue";
            this.lblTotalTracksValue.Size = new System.Drawing.Size(17, 20);
            this.lblTotalTracksValue.TabIndex = 3;
            this.lblTotalTracksValue.Text = "0";
            // 
            // lblTotalTracks
            // 
            this.lblTotalTracks.AutoSize = true;
            this.lblTotalTracks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTracks.Location = new System.Drawing.Point(32, 147);
            this.lblTotalTracks.Name = "lblTotalTracks";
            this.lblTotalTracks.Size = new System.Drawing.Size(94, 20);
            this.lblTotalTracks.TabIndex = 2;
            this.lblTotalTracks.Text = "Total tracks:";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(10, 5);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(441, 89);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Navy;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1280, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 20);
            this.toolStripStatusLabel2.Text = "ok";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.LightBlue;
            this.pnlSearch.Controls.Add(this.btnClearSearch);
            this.pnlSearch.Controls.Add(this.dgSearchResult);
            this.pnlSearch.Controls.Add(this.btnSearchIndex);
            this.pnlSearch.Controls.Add(this.txtSearchField);
            this.pnlSearch.Controls.Add(this.lblSearchQuery);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(261, 45);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1019, 725);
            this.pnlSearch.TabIndex = 6;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Location = new System.Drawing.Point(365, 137);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(86, 31);
            this.btnClearSearch.TabIndex = 15;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // dgSearchResult
            // 
            this.dgSearchResult.AllowUserToAddRows = false;
            this.dgSearchResult.AllowUserToDeleteRows = false;
            this.dgSearchResult.AllowUserToResizeColumns = false;
            this.dgSearchResult.AllowUserToResizeRows = false;
            this.dgSearchResult.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Artist,
            this.Album,
            this.Track,
            this.Year,
            this.TrackNumber,
            this.Tags,
            this.Path,
            this.FileName,
            this.Genre});
            this.dgSearchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgSearchResult.Location = new System.Drawing.Point(32, 179);
            this.dgSearchResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSearchResult.Name = "dgSearchResult";
            this.dgSearchResult.ReadOnly = true;
            this.dgSearchResult.RowHeadersWidth = 51;
            this.dgSearchResult.RowTemplate.Height = 25;
            this.dgSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSearchResult.Size = new System.Drawing.Size(974, 531);
            this.dgSearchResult.TabIndex = 14;
            this.dgSearchResult.Visible = false;
            this.dgSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearchResult_CellDoubleClick);
            this.dgSearchResult.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgSearchResult_RowContextMenuStripNeeded);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.FillWeight = 99.49239F;
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Width = 200;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.FillWeight = 99.49239F;
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Width = 220;
            // 
            // Track
            // 
            this.Track.DataPropertyName = "TrackName";
            this.Track.FillWeight = 99.49239F;
            this.Track.HeaderText = "Track";
            this.Track.MinimumWidth = 6;
            this.Track.Name = "Track";
            this.Track.ReadOnly = true;
            this.Track.Width = 270;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Year.DefaultCellStyle = dataGridViewCellStyle2;
            this.Year.FillWeight = 101.5228F;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 54;
            // 
            // TrackNumber
            // 
            this.TrackNumber.DataPropertyName = "TrackNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TrackNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrackNumber.HeaderText = "Track no";
            this.TrackNumber.MinimumWidth = 6;
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.ReadOnly = true;
            this.TrackNumber.Width = 50;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.HeaderText = "Tags";
            this.Tags.MinimumWidth = 6;
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.Visible = false;
            this.Tags.Width = 125;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.MinimumWidth = 6;
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            this.Path.Width = 125;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Visible = false;
            this.FileName.Width = 125;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            this.Genre.Width = 125;
            // 
            // btnSearchIndex
            // 
            this.btnSearchIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchIndex.Location = new System.Drawing.Point(257, 137);
            this.btnSearchIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchIndex.Name = "btnSearchIndex";
            this.btnSearchIndex.Size = new System.Drawing.Size(86, 31);
            this.btnSearchIndex.TabIndex = 13;
            this.btnSearchIndex.Text = "Search";
            this.btnSearchIndex.UseVisualStyleBackColor = true;
            this.btnSearchIndex.Click += new System.EventHandler(this.btnSearchIndex_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(32, 137);
            this.txtSearchField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(217, 27);
            this.txtSearchField.TabIndex = 12;
            this.txtSearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchField_KeyPress);
            // 
            // lblSearchQuery
            // 
            this.lblSearchQuery.AutoSize = true;
            this.lblSearchQuery.Location = new System.Drawing.Point(32, 111);
            this.lblSearchQuery.Name = "lblSearchQuery";
            this.lblSearchQuery.Size = new System.Drawing.Size(155, 20);
            this.lblSearchQuery.TabIndex = 11;
            this.lblSearchQuery.Text = "Enter search keywords";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(10, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(292, 89);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // ctxFileOptions
            // 
            this.ctxFileOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxFileOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShowFileInfo,
            this.toolStripEditMetaTags,
            this.toolStripConvertSelectedFiles,
            this.toolStripSeparator3,
            this.toolStripOpenFileLocation,
            this.toolStripPlayFile,
            this.toolStripSeparator1,
            this.toolStripSearchRuTracker,
            this.toolStripSeparator2,
            this.toolStripRemoveFromIndex});
            this.ctxFileOptions.Name = "ctxFileOptions";
            this.ctxFileOptions.ShowImageMargin = false;
            this.ctxFileOptions.Size = new System.Drawing.Size(205, 190);
            this.ctxFileOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxFileOptions_ItemClicked);
            // 
            // toolStripEditMetaTags
            // 
            this.toolStripEditMetaTags.Name = "toolStripEditMetaTags";
            this.toolStripEditMetaTags.Size = new System.Drawing.Size(204, 24);
            this.toolStripEditMetaTags.Text = "Edit meta tags";
            // 
            // toolStripConvertSelectedFiles
            // 
            this.toolStripConvertSelectedFiles.Name = "toolStripConvertSelectedFiles";
            this.toolStripConvertSelectedFiles.Size = new System.Drawing.Size(204, 24);
            this.toolStripConvertSelectedFiles.Text = "Convert selected file(s)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // toolStripOpenFileLocation
            // 
            this.toolStripOpenFileLocation.Name = "toolStripOpenFileLocation";
            this.toolStripOpenFileLocation.Size = new System.Drawing.Size(204, 24);
            this.toolStripOpenFileLocation.Text = "Open file location";
            // 
            // toolStripPlayFile
            // 
            this.toolStripPlayFile.Name = "toolStripPlayFile";
            this.toolStripPlayFile.Size = new System.Drawing.Size(204, 24);
            this.toolStripPlayFile.Text = "Play file";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // toolStripSearchRuTracker
            // 
            this.toolStripSearchRuTracker.Name = "toolStripSearchRuTracker";
            this.toolStripSearchRuTracker.Size = new System.Drawing.Size(204, 24);
            this.toolStripSearchRuTracker.Text = "Search ruTracker";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // toolStripRemoveFromIndex
            // 
            this.toolStripRemoveFromIndex.Name = "toolStripRemoveFromIndex";
            this.toolStripRemoveFromIndex.Size = new System.Drawing.Size(204, 24);
            this.toolStripRemoveFromIndex.Text = "Remove from index";
            // 
            // toolStripShowFileInfo
            // 
            this.toolStripShowFileInfo.Name = "toolStripShowFileInfo";
            this.toolStripShowFileInfo.Size = new System.Drawing.Size(204, 24);
            this.toolStripShowFileInfo.Text = "Show file info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlIndex);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicLibrary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlIndex.ResumeLayout(false);
            this.pnlIndex.PerformLayout();
            this.gbIndexScanner.ResumeLayout(false);
            this.gbIndexScanner.PerformLayout();
            this.gbIndexMaintenance.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchResult)).EndInit();
            this.ctxFileOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
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
    }
}