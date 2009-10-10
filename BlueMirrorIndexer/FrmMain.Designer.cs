namespace BlueMirrorIndexer
{
	partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pmTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmTreeItemPropertiesPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteTreeItemPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTree = new System.Windows.Forms.ImageList(this.components);
            this.pmList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmItemPropertiesFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteListItemPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSystem = new System.Windows.Forms.ImageList(this.components);
            this.pmSearchList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmItemPropertiesFromSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFindInDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeWithFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmReadVolume = new System.Windows.Forms.ToolStripMenuItem();
            this.pmVolumes = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pmMainLogicalFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMainNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMainEditFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMainDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPropertiesFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFindInDatabaseFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMainRemoveFromFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmScanNewMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niBackgroundProcess = new System.Windows.Forms.NotifyIcon(this.components);
            this.pmIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmRestoreWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.pmItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmItemPropertiesFromFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFindInDatabaseFromFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRemoveFromFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.ilFolders = new System.Windows.Forms.ImageList(this.components);
            this.pmDrop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDropFolderAsItems = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDropFoldersAsLogicalFolders = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.scDatabase = new System.Windows.Forms.SplitContainer();
            this.tvDatabaseFolderTree = new BlueMirrorIndexer.Components.TreeViewVista();
            this.lvDatabaseItems = new BlueMirrorIndexer.Components.ListViewVista();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.chDiFileVersion = new System.Windows.Forms.ColumnHeader();
            this.chDiVolume = new System.Windows.Forms.ColumnHeader();
            this.chDiPath = new System.Windows.Forms.ColumnHeader();
            this.chDiCrc = new System.Windows.Forms.ColumnHeader();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.searchBottomPanel = new System.Windows.Forms.Panel();
            this.lvSearchResults = new BlueMirrorIndexer.Components.ListViewVista();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.chSrAttributes = new System.Windows.Forms.ColumnHeader();
            this.chSrKeywords = new System.Windows.Forms.ColumnHeader();
            this.chSrFileExtension = new System.Windows.Forms.ColumnHeader();
            this.chSrFileDescription = new System.Windows.Forms.ColumnHeader();
            this.chSrFileVersion = new System.Windows.Forms.ColumnHeader();
            this.chSrVolume = new System.Windows.Forms.ColumnHeader();
            this.chSrPath = new System.Windows.Forms.ColumnHeader();
            this.chSrCrc = new System.Windows.Forms.ColumnHeader();
            this.filesSearchCriteriaPanel = new BlueMirrorIndexer.Components.FilesSearchCriteriaPanel();
            this.tcBottom = new System.Windows.Forms.TabControl();
            this.tpLogicalFolders = new System.Windows.Forms.TabPage();
            this.scFolders = new System.Windows.Forms.SplitContainer();
            this.tvLogicalFolders = new BlueMirrorIndexer.Components.LogicalFoldersTreeView();
            this.lvFolderElements = new BlueMirrorIndexer.Components.ListViewVista();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.pmTree.SuspendLayout();
            this.pmList.SuspendLayout();
            this.pmSearchList.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.pmIcon.SuspendLayout();
            this.pmItems.SuspendLayout();
            this.pmDrop.SuspendLayout();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.scDatabase.Panel1.SuspendLayout();
            this.scDatabase.Panel2.SuspendLayout();
            this.scDatabase.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.searchBottomPanel.SuspendLayout();
            this.tcBottom.SuspendLayout();
            this.tpLogicalFolders.SuspendLayout();
            this.scFolders.Panel1.SuspendLayout();
            this.scFolders.Panel2.SuspendLayout();
            this.scFolders.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pmTree
            // 
            this.pmTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTreeItemPropertiesPopup,
            this.cmDeleteTreeItemPopup});
            this.pmTree.Name = "cmTree";
            resources.ApplyResources(this.pmTree, "pmTree");
            // 
            // cmTreeItemPropertiesPopup
            // 
            this.cmTreeItemPropertiesPopup.Image = global::BlueMirrorIndexer.Properties.Resources.tag_blue_edit;
            resources.ApplyResources(this.cmTreeItemPropertiesPopup, "cmTreeItemPropertiesPopup");
            this.cmTreeItemPropertiesPopup.Name = "cmTreeItemPropertiesPopup";
            this.cmTreeItemPropertiesPopup.Click += new System.EventHandler(this.cmVolumeFolderProperties_Click);
            // 
            // cmDeleteTreeItemPopup
            // 
            this.cmDeleteTreeItemPopup.Image = global::BlueMirrorIndexer.Properties.Resources.delete;
            resources.ApplyResources(this.cmDeleteTreeItemPopup, "cmDeleteTreeItemPopup");
            this.cmDeleteTreeItemPopup.Name = "cmDeleteTreeItemPopup";
            this.cmDeleteTreeItemPopup.Click += new System.EventHandler(this.cmDeleteTreeItemPopup_Click);
            // 
            // ilTree
            // 
            this.ilTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTree.ImageStream")));
            this.ilTree.TransparentColor = System.Drawing.Color.Magenta;
            this.ilTree.Images.SetKeyName(0, "cd.bmp");
            this.ilTree.Images.SetKeyName(1, "OpenFolder.bmp");
            // 
            // pmList
            // 
            this.pmList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmItemPropertiesFromList,
            this.cmDeleteListItemPopup});
            this.pmList.Name = "cmList";
            resources.ApplyResources(this.pmList, "pmList");
            // 
            // cmItemPropertiesFromList
            // 
            resources.ApplyResources(this.cmItemPropertiesFromList, "cmItemPropertiesFromList");
            this.cmItemPropertiesFromList.Image = global::BlueMirrorIndexer.Properties.Resources.tag_blue_edit;
            this.cmItemPropertiesFromList.Name = "cmItemPropertiesFromList";
            this.cmItemPropertiesFromList.Click += new System.EventHandler(this.cmFileProperties_Click);
            // 
            // cmDeleteListItemPopup
            // 
            this.cmDeleteListItemPopup.Image = global::BlueMirrorIndexer.Properties.Resources.delete;
            resources.ApplyResources(this.cmDeleteListItemPopup, "cmDeleteListItemPopup");
            this.cmDeleteListItemPopup.Name = "cmDeleteListItemPopup";
            this.cmDeleteListItemPopup.Click += new System.EventHandler(this.cmDeleteFileInfoPopup_Click);
            // 
            // ilSystem
            // 
            this.ilSystem.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilSystem, "ilSystem");
            this.ilSystem.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pmSearchList
            // 
            this.pmSearchList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmItemPropertiesFromSearch,
            this.cmFindInDatabase});
            this.pmSearchList.Name = "cmsSearchList";
            resources.ApplyResources(this.pmSearchList, "pmSearchList");
            this.pmSearchList.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSearchList_Opening);
            // 
            // cmItemPropertiesFromSearch
            // 
            this.cmItemPropertiesFromSearch.Image = global::BlueMirrorIndexer.Properties.Resources.tag_blue_edit;
            resources.ApplyResources(this.cmItemPropertiesFromSearch, "cmItemPropertiesFromSearch");
            this.cmItemPropertiesFromSearch.Name = "cmItemPropertiesFromSearch";
            this.cmItemPropertiesFromSearch.Click += new System.EventHandler(this.cmItemPropertiesFromSearch_Click);
            // 
            // cmFindInDatabase
            // 
            this.cmFindInDatabase.Image = global::BlueMirrorIndexer.Properties.Resources.folder_find;
            resources.ApplyResources(this.cmFindInDatabase, "cmFindInDatabase");
            this.cmFindInDatabase.Name = "cmFindInDatabase";
            this.cmFindInDatabase.Click += new System.EventHandler(this.cmFindInDatabase_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.pmMainLogicalFolders,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.mergeWithFileToolStripMenuItem,
            this.cmSave,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.page;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.cmNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.folder_page;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.cmOpen_Click);
            // 
            // mergeWithFileToolStripMenuItem
            // 
            this.mergeWithFileToolStripMenuItem.Name = "mergeWithFileToolStripMenuItem";
            resources.ApplyResources(this.mergeWithFileToolStripMenuItem, "mergeWithFileToolStripMenuItem");
            this.mergeWithFileToolStripMenuItem.Click += new System.EventHandler(this.cmMergeFile_Click);
            // 
            // cmSave
            // 
            this.cmSave.Image = global::BlueMirrorIndexer.Properties.Resources.disk;
            this.cmSave.Name = "cmSave";
            resources.ApplyResources(this.cmSave, "cmSave");
            this.cmSave.Click += new System.EventHandler(this.cmSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.cmSaveAs_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.cmDatabaseExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmReadVolume,
            this.pmVolumes});
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            resources.ApplyResources(this.volumeToolStripMenuItem, "volumeToolStripMenuItem");
            // 
            // cmReadVolume
            // 
            this.cmReadVolume.Name = "cmReadVolume";
            resources.ApplyResources(this.cmReadVolume, "cmReadVolume");
            this.cmReadVolume.Click += new System.EventHandler(this.cmReadVolumeFromButtonTag_Click);
            // 
            // pmVolumes
            // 
            this.pmVolumes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.pmVolumes.Name = "pmVolumes";
            resources.ApplyResources(this.pmVolumes, "pmVolumes");
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            resources.ApplyResources(this.aToolStripMenuItem, "aToolStripMenuItem");
            // 
            // pmMainLogicalFolders
            // 
            this.pmMainLogicalFolders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmMainNewFolder,
            this.cmMainEditFolder,
            this.cmMainDeleteFolder});
            this.pmMainLogicalFolders.Name = "pmMainLogicalFolders";
            resources.ApplyResources(this.pmMainLogicalFolders, "pmMainLogicalFolders");
            // 
            // cmMainNewFolder
            // 
            this.cmMainNewFolder.Image = global::BlueMirrorIndexer.Properties.Resources.folder_add;
            this.cmMainNewFolder.Name = "cmMainNewFolder";
            resources.ApplyResources(this.cmMainNewFolder, "cmMainNewFolder");
            // 
            // cmMainEditFolder
            // 
            this.cmMainEditFolder.Image = global::BlueMirrorIndexer.Properties.Resources.folder_edit;
            this.cmMainEditFolder.Name = "cmMainEditFolder";
            resources.ApplyResources(this.cmMainEditFolder, "cmMainEditFolder");
            // 
            // cmMainDeleteFolder
            // 
            this.cmMainDeleteFolder.Image = global::BlueMirrorIndexer.Properties.Resources.folder_delete;
            this.cmMainDeleteFolder.Name = "cmMainDeleteFolder";
            resources.ApplyResources(this.cmMainDeleteFolder, "cmMainDeleteFolder");
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmPropertiesFrm,
            this.cmDeleteFrm,
            this.cmFindInDatabaseFrm,
            this.cmMainRemoveFromFolder});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            resources.ApplyResources(this.itemToolStripMenuItem, "itemToolStripMenuItem");
            // 
            // cmPropertiesFrm
            // 
            this.cmPropertiesFrm.Image = global::BlueMirrorIndexer.Properties.Resources.tag_blue_edit;
            this.cmPropertiesFrm.Name = "cmPropertiesFrm";
            resources.ApplyResources(this.cmPropertiesFrm, "cmPropertiesFrm");
            this.cmPropertiesFrm.Click += new System.EventHandler(this.cmProperties_Click);
            // 
            // cmDeleteFrm
            // 
            this.cmDeleteFrm.Image = global::BlueMirrorIndexer.Properties.Resources.delete;
            this.cmDeleteFrm.Name = "cmDeleteFrm";
            resources.ApplyResources(this.cmDeleteFrm, "cmDeleteFrm");
            this.cmDeleteFrm.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // cmFindInDatabaseFrm
            // 
            this.cmFindInDatabaseFrm.Image = global::BlueMirrorIndexer.Properties.Resources.folder_find;
            this.cmFindInDatabaseFrm.Name = "cmFindInDatabaseFrm";
            resources.ApplyResources(this.cmFindInDatabaseFrm, "cmFindInDatabaseFrm");
            this.cmFindInDatabaseFrm.Click += new System.EventHandler(this.cmFindInDatabaseFrm_Click);
            // 
            // cmMainRemoveFromFolder
            // 
            this.cmMainRemoveFromFolder.Image = global::BlueMirrorIndexer.Properties.Resources.folder_go;
            this.cmMainRemoveFromFolder.Name = "cmMainRemoveFromFolder";
            resources.ApplyResources(this.cmMainRemoveFromFolder, "cmMainRemoveFromFolder");
            this.cmMainRemoveFromFolder.Click += new System.EventHandler(this.cmRemoveFromFolder_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmScanNewMedia});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // cmScanNewMedia
            // 
            this.cmScanNewMedia.Checked = true;
            this.cmScanNewMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmScanNewMedia.Name = "cmScanNewMedia";
            resources.ApplyResources(this.cmScanNewMedia, "cmScanNewMedia");
            this.cmScanNewMedia.Click += new System.EventHandler(this.cmScanNewMedia_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.featureRequestToolStripMenuItem,
            this.whatsNewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.world_go;
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            resources.ApplyResources(this.homePageToolStripMenuItem, "homePageToolStripMenuItem");
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.cmHomePage_Click);
            // 
            // featureRequestToolStripMenuItem
            // 
            this.featureRequestToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.world_go;
            this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
            resources.ApplyResources(this.featureRequestToolStripMenuItem, "featureRequestToolStripMenuItem");
            this.featureRequestToolStripMenuItem.Click += new System.EventHandler(this.cmFeatureRequests_Click);
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.world_go;
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            resources.ApplyResources(this.whatsNewToolStripMenuItem, "whatsNewToolStripMenuItem");
            this.whatsNewToolStripMenuItem.Click += new System.EventHandler(this.cmWhatsNew_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.cmAbout_Click);
            // 
            // niBackgroundProcess
            // 
            this.niBackgroundProcess.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niBackgroundProcess.ContextMenuStrip = this.pmIcon;
            resources.ApplyResources(this.niBackgroundProcess, "niBackgroundProcess");
            this.niBackgroundProcess.DoubleClick += new System.EventHandler(this.niBackgroundProcess_DoubleClick);
            // 
            // pmIcon
            // 
            this.pmIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRestoreWindow});
            this.pmIcon.Name = "pmIcon";
            resources.ApplyResources(this.pmIcon, "pmIcon");
            // 
            // cmRestoreWindow
            // 
            this.cmRestoreWindow.Name = "cmRestoreWindow";
            resources.ApplyResources(this.cmRestoreWindow, "cmRestoreWindow");
            this.cmRestoreWindow.Click += new System.EventHandler(this.cmRestoreWindow_Click);
            // 
            // pmItems
            // 
            this.pmItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmItemPropertiesFromFolders,
            this.cmFindInDatabaseFromFolders,
            this.cmRemoveFromFolder});
            this.pmItems.Name = "pmItems";
            resources.ApplyResources(this.pmItems, "pmItems");
            // 
            // cmItemPropertiesFromFolders
            // 
            resources.ApplyResources(this.cmItemPropertiesFromFolders, "cmItemPropertiesFromFolders");
            this.cmItemPropertiesFromFolders.Image = global::BlueMirrorIndexer.Properties.Resources.tag_blue_edit;
            this.cmItemPropertiesFromFolders.Name = "cmItemPropertiesFromFolders";
            this.cmItemPropertiesFromFolders.Click += new System.EventHandler(this.cmItemPropertiesFromFolders_Click);
            // 
            // cmFindInDatabaseFromFolders
            // 
            this.cmFindInDatabaseFromFolders.Image = global::BlueMirrorIndexer.Properties.Resources.folder_find;
            resources.ApplyResources(this.cmFindInDatabaseFromFolders, "cmFindInDatabaseFromFolders");
            this.cmFindInDatabaseFromFolders.Name = "cmFindInDatabaseFromFolders";
            this.cmFindInDatabaseFromFolders.Click += new System.EventHandler(this.cmFindInDatabaseFromFolders_Click);
            // 
            // cmRemoveFromFolder
            // 
            this.cmRemoveFromFolder.Image = global::BlueMirrorIndexer.Properties.Resources.folder_go;
            this.cmRemoveFromFolder.Name = "cmRemoveFromFolder";
            resources.ApplyResources(this.cmRemoveFromFolder, "cmRemoveFromFolder");
            this.cmRemoveFromFolder.Click += new System.EventHandler(this.cmRemoveFromFolder_Click);
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // ilFolders
            // 
            this.ilFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFolders.ImageStream")));
            this.ilFolders.TransparentColor = System.Drawing.Color.Magenta;
            this.ilFolders.Images.SetKeyName(0, "VSFolder_open.bmp");
            this.ilFolders.Images.SetKeyName(1, "cab.ico");
            this.ilFolders.Images.SetKeyName(2, "Flag_redHS.png");
            this.ilFolders.Images.SetKeyName(3, "cd.bmp");
            this.ilFolders.Images.SetKeyName(4, "camera.ico");
            this.ilFolders.Images.SetKeyName(5, "user.ico");
            this.ilFolders.Images.SetKeyName(6, "CD_16.bmp");
            // 
            // pmDrop
            // 
            this.pmDrop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDropFolderAsItems,
            this.cmDropFoldersAsLogicalFolders,
            this.toolStripMenuItem1,
            this.cancelToolStripMenuItem});
            this.pmDrop.Name = "cmDrop";
            resources.ApplyResources(this.pmDrop, "pmDrop");
            // 
            // cmDropFolderAsItems
            // 
            this.cmDropFolderAsItems.Name = "cmDropFolderAsItems";
            resources.ApplyResources(this.cmDropFolderAsItems, "cmDropFolderAsItems");
            this.cmDropFolderAsItems.Click += new System.EventHandler(this.cmDropFolderAsItems_Click);
            // 
            // cmDropFoldersAsLogicalFolders
            // 
            this.cmDropFoldersAsLogicalFolders.Name = "cmDropFoldersAsLogicalFolders";
            resources.ApplyResources(this.cmDropFoldersAsLogicalFolders, "cmDropFoldersAsLogicalFolders");
            this.cmDropFoldersAsLogicalFolders.Click += new System.EventHandler(this.cmDropFoldersAsLogicalFolders_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::BlueMirrorIndexer.Properties.Resources.agt_action_fail1;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            resources.ApplyResources(this.cancelToolStripMenuItem, "cancelToolStripMenuItem");
            // 
            // scMain
            // 
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tcMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcBottom);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpDatabase);
            this.tcMain.Controls.Add(this.tpSearch);
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcMain_Selected);
            // 
            // tpDatabase
            // 
            this.tpDatabase.BackColor = System.Drawing.Color.Transparent;
            this.tpDatabase.Controls.Add(this.scDatabase);
            resources.ApplyResources(this.tpDatabase, "tpDatabase");
            this.tpDatabase.Name = "tpDatabase";
            // 
            // scDatabase
            // 
            resources.ApplyResources(this.scDatabase, "scDatabase");
            this.scDatabase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scDatabase.Name = "scDatabase";
            // 
            // scDatabase.Panel1
            // 
            this.scDatabase.Panel1.Controls.Add(this.tvDatabaseFolderTree);
            // 
            // scDatabase.Panel2
            // 
            this.scDatabase.Panel2.Controls.Add(this.lvDatabaseItems);
            // 
            // tvDatabaseFolderTree
            // 
            this.tvDatabaseFolderTree.ContextMenuStrip = this.pmTree;
            resources.ApplyResources(this.tvDatabaseFolderTree, "tvDatabaseFolderTree");
            this.tvDatabaseFolderTree.HideSelection = false;
            this.tvDatabaseFolderTree.ImageList = this.ilTree;
            this.tvDatabaseFolderTree.Name = "tvDatabaseFolderTree";
            this.tvDatabaseFolderTree.ShowLines = false;
            this.tvDatabaseFolderTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvDatabaseFolderTree_MouseUp);
            this.tvDatabaseFolderTree.Enter += new System.EventHandler(this.tvDatabaseFolderTree_Enter);
            this.tvDatabaseFolderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDatabaseFolderTree_AfterSelect);
            this.tvDatabaseFolderTree.Leave += new System.EventHandler(this.tvDatabaseFolderTree_Leave);
            this.tvDatabaseFolderTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tvDatabaseFolderTree_MouseMove);
            this.tvDatabaseFolderTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvDatabaseFolderTree_MouseDown);
            // 
            // lvDatabaseItems
            // 
            this.lvDatabaseItems.AllowColumnReorder = true;
            this.lvDatabaseItems.ColumnOrderArray = ((System.Collections.ArrayList)(resources.GetObject("lvDatabaseItems.ColumnOrderArray")));
            this.lvDatabaseItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12,
            this.columnHeader13,
            this.chDescription,
            this.chDiFileVersion,
            this.chDiVolume,
            this.chDiPath,
            this.chDiCrc});
            this.lvDatabaseItems.ColumnWidthArray = ((System.Collections.ArrayList)(resources.GetObject("lvDatabaseItems.ColumnWidthArray")));
            this.lvDatabaseItems.ContextMenuStrip = this.pmList;
            resources.ApplyResources(this.lvDatabaseItems, "lvDatabaseItems");
            this.lvDatabaseItems.FullRowSelect = true;
            this.lvDatabaseItems.HideSelection = false;
            this.lvDatabaseItems.Name = "lvDatabaseItems";
            this.lvDatabaseItems.SmallImageList = this.ilSystem;
            this.lvDatabaseItems.UseCompatibleStateImageBehavior = false;
            this.lvDatabaseItems.View = System.Windows.Forms.View.Details;
            this.lvDatabaseItems.SelectedIndexChanged += new System.EventHandler(this.lvDatabaseItems_SelectedIndexChanged);
            this.lvDatabaseItems.DoubleClick += new System.EventHandler(this.lvDatabaseItems_DoubleClick);
            this.lvDatabaseItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvDatabaseItems_MouseUp);
            this.lvDatabaseItems.Leave += new System.EventHandler(this.lvDatabaseItems_Leave);
            this.lvDatabaseItems.Enter += new System.EventHandler(this.lvDatabaseItems_Enter);
            this.lvDatabaseItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDatabaseItems_ColumnClick);
            this.lvDatabaseItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvDatabaseItems_MouseMove);
            this.lvDatabaseItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvDatabaseItems_MouseDown);
            this.lvDatabaseItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDatabaseItems_KeyDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // chDescription
            // 
            resources.ApplyResources(this.chDescription, "chDescription");
            // 
            // chDiFileVersion
            // 
            resources.ApplyResources(this.chDiFileVersion, "chDiFileVersion");
            // 
            // chDiVolume
            // 
            resources.ApplyResources(this.chDiVolume, "chDiVolume");
            // 
            // chDiPath
            // 
            resources.ApplyResources(this.chDiPath, "chDiPath");
            // 
            // chDiCrc
            // 
            resources.ApplyResources(this.chDiCrc, "chDiCrc");
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.Controls.Add(this.searchBottomPanel);
            this.tpSearch.Controls.Add(this.filesSearchCriteriaPanel);
            resources.ApplyResources(this.tpSearch, "tpSearch");
            this.tpSearch.Name = "tpSearch";
            // 
            // searchBottomPanel
            // 
            this.searchBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.searchBottomPanel.Controls.Add(this.lvSearchResults);
            resources.ApplyResources(this.searchBottomPanel, "searchBottomPanel");
            this.searchBottomPanel.Name = "searchBottomPanel";
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.AllowColumnReorder = true;
            this.lvSearchResults.BackColor = System.Drawing.SystemColors.Window;
            this.lvSearchResults.ColumnOrderArray = ((System.Collections.ArrayList)(resources.GetObject("lvSearchResults.ColumnOrderArray")));
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.chSrAttributes,
            this.chSrKeywords,
            this.chSrFileExtension,
            this.chSrFileDescription,
            this.chSrFileVersion,
            this.chSrVolume,
            this.chSrPath,
            this.chSrCrc});
            this.lvSearchResults.ColumnWidthArray = ((System.Collections.ArrayList)(resources.GetObject("lvSearchResults.ColumnWidthArray")));
            this.lvSearchResults.ContextMenuStrip = this.pmSearchList;
            resources.ApplyResources(this.lvSearchResults, "lvSearchResults");
            this.lvSearchResults.FullRowSelect = true;
            this.lvSearchResults.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("lvSearchResults.Groups")))});
            this.lvSearchResults.HideSelection = false;
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.SmallImageList = this.ilSystem;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSearchResults.View = System.Windows.Forms.View.Details;
            this.lvSearchResults.VirtualMode = true;
            this.lvSearchResults.SelectedIndexChanged += new System.EventHandler(this.lvSearchResults_SelectedIndexChanged);
            this.lvSearchResults.DoubleClick += new System.EventHandler(this.lvSearchResults_DoubleClick);
            this.lvSearchResults.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvSearchResults_MouseUp);
            this.lvSearchResults.Enter += new System.EventHandler(this.lvSearchResults_Enter);
            this.lvSearchResults.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvSearchResults_ColumnClick);
            this.lvSearchResults.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvSearchResults_MouseMove);
            this.lvSearchResults.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lvSearchResults_RetrieveVirtualItem);
            this.lvSearchResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSearchResults_MouseDown);
            this.lvSearchResults.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.lvSearchResults_CacheVirtualItems);
            this.lvSearchResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSearchResults_KeyDown);
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // chSrAttributes
            // 
            resources.ApplyResources(this.chSrAttributes, "chSrAttributes");
            // 
            // chSrKeywords
            // 
            resources.ApplyResources(this.chSrKeywords, "chSrKeywords");
            // 
            // chSrFileExtension
            // 
            resources.ApplyResources(this.chSrFileExtension, "chSrFileExtension");
            // 
            // chSrFileDescription
            // 
            resources.ApplyResources(this.chSrFileDescription, "chSrFileDescription");
            // 
            // chSrFileVersion
            // 
            resources.ApplyResources(this.chSrFileVersion, "chSrFileVersion");
            // 
            // chSrVolume
            // 
            resources.ApplyResources(this.chSrVolume, "chSrVolume");
            // 
            // chSrPath
            // 
            resources.ApplyResources(this.chSrPath, "chSrPath");
            // 
            // chSrCrc
            // 
            resources.ApplyResources(this.chSrCrc, "chSrCrc");
            // 
            // filesSearchCriteriaPanel
            // 
            resources.ApplyResources(this.filesSearchCriteriaPanel, "filesSearchCriteriaPanel");
            this.filesSearchCriteriaPanel.Name = "filesSearchCriteriaPanel";
            this.filesSearchCriteriaPanel.SearchBtnClicked += new BlueMirrorIndexer.Components.SearchEventHandler(this.filesSearchCriteriaPanel_SearchBtnClicked);
            // 
            // tcBottom
            // 
            this.tcBottom.Controls.Add(this.tpLogicalFolders);
            resources.ApplyResources(this.tcBottom, "tcBottom");
            this.tcBottom.Name = "tcBottom";
            this.tcBottom.SelectedIndex = 0;
            // 
            // tpLogicalFolders
            // 
            this.tpLogicalFolders.Controls.Add(this.scFolders);
            resources.ApplyResources(this.tpLogicalFolders, "tpLogicalFolders");
            this.tpLogicalFolders.Name = "tpLogicalFolders";
            this.tpLogicalFolders.UseVisualStyleBackColor = true;
            // 
            // scFolders
            // 
            this.scFolders.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.scFolders, "scFolders");
            this.scFolders.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scFolders.Name = "scFolders";
            // 
            // scFolders.Panel1
            // 
            this.scFolders.Panel1.Controls.Add(this.tvLogicalFolders);
            // 
            // scFolders.Panel2
            // 
            this.scFolders.Panel2.Controls.Add(this.lvFolderElements);
            // 
            // tvLogicalFolders
            // 
            this.tvLogicalFolders.AllowDrop = true;
            resources.ApplyResources(this.tvLogicalFolders, "tvLogicalFolders");
            this.tvLogicalFolders.HideSelection = false;
            this.tvLogicalFolders.ImageList = this.ilFolders;
            this.tvLogicalFolders.LabelEdit = true;
            this.tvLogicalFolders.Name = "tvLogicalFolders";
            this.tvLogicalFolders.ShowLines = false;
            this.tvLogicalFolders.LogicalFolderDeleted += new System.EventHandler<System.EventArgs>(this.tvLogicalFolders_LogicalFolderDeleted);
            this.tvLogicalFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvLogicalFolders_DragDrop);
            this.tvLogicalFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLogicalFolders_AfterSelect);
            this.tvLogicalFolders.LogicalFolderUpdated += new System.EventHandler<System.EventArgs>(this.tvLogicalFolders_LogicalFolderUpdated);
            this.tvLogicalFolders.NewLogicalFolderAdded += new System.EventHandler<System.EventArgs>(this.tvLogicalFolders_NewLogicalFolderAdded);
            this.tvLogicalFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.tvLogicalFolders_DragOver);
            // 
            // lvFolderElements
            // 
            this.lvFolderElements.AllowColumnReorder = true;
            this.lvFolderElements.AllowDrop = true;
            this.lvFolderElements.ColumnOrderArray = ((System.Collections.ArrayList)(resources.GetObject("lvFolderElements.ColumnOrderArray")));
            this.lvFolderElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28});
            this.lvFolderElements.ColumnWidthArray = ((System.Collections.ArrayList)(resources.GetObject("lvFolderElements.ColumnWidthArray")));
            this.lvFolderElements.ContextMenuStrip = this.pmItems;
            resources.ApplyResources(this.lvFolderElements, "lvFolderElements");
            this.lvFolderElements.FullRowSelect = true;
            this.lvFolderElements.HideSelection = false;
            this.lvFolderElements.Name = "lvFolderElements";
            this.lvFolderElements.SmallImageList = this.ilSystem;
            this.lvFolderElements.UseCompatibleStateImageBehavior = false;
            this.lvFolderElements.View = System.Windows.Forms.View.Details;
            this.lvFolderElements.SelectedIndexChanged += new System.EventHandler(this.lvLogicalFolderItems_SelectedIndexChanged);
            this.lvFolderElements.DoubleClick += new System.EventHandler(this.lvLogicalFolderItems_DoubleClick);
            this.lvFolderElements.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvLogicalFolderItems_MouseUp);
            this.lvFolderElements.Enter += new System.EventHandler(this.lvFolderElements_Enter);
            this.lvFolderElements.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvLogicalFolderItems_DragDrop);
            this.lvFolderElements.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvLogicalFolderItems_MouseMove);
            this.lvFolderElements.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvLogicalFolderItems_MouseDown);
            this.lvFolderElements.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFolderElements_KeyDown);
            this.lvFolderElements.DragOver += new System.Windows.Forms.DragEventHandler(this.lvLogicalFolderItems_DragOver);
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // columnHeader23
            // 
            resources.ApplyResources(this.columnHeader23, "columnHeader23");
            // 
            // columnHeader24
            // 
            resources.ApplyResources(this.columnHeader24, "columnHeader24");
            // 
            // columnHeader25
            // 
            resources.ApplyResources(this.columnHeader25, "columnHeader25");
            // 
            // columnHeader26
            // 
            resources.ApplyResources(this.columnHeader26, "columnHeader26");
            // 
            // columnHeader27
            // 
            resources.ApplyResources(this.columnHeader27, "columnHeader27");
            // 
            // columnHeader28
            // 
            resources.ApplyResources(this.columnHeader28, "columnHeader28");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbFiles,
            this.sbSize});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // sbFiles
            // 
            this.sbFiles.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbFiles.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sbFiles.Name = "sbFiles";
            resources.ApplyResources(this.sbFiles, "sbFiles");
            // 
            // sbSize
            // 
            this.sbSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sbSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sbSize.Name = "sbSize";
            resources.ApplyResources(this.sbSize, "sbSize");
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.pmTree.ResumeLayout(false);
            this.pmList.ResumeLayout(false);
            this.pmSearchList.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pmIcon.ResumeLayout(false);
            this.pmItems.ResumeLayout(false);
            this.pmDrop.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDatabase.ResumeLayout(false);
            this.scDatabase.Panel1.ResumeLayout(false);
            this.scDatabase.Panel2.ResumeLayout(false);
            this.scDatabase.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.searchBottomPanel.ResumeLayout(false);
            this.tcBottom.ResumeLayout(false);
            this.tpLogicalFolders.ResumeLayout(false);
            this.scFolders.Panel1.ResumeLayout(false);
            this.scFolders.Panel2.ResumeLayout(false);
            this.scFolders.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ContextMenuStrip pmTree;
        private System.Windows.Forms.ToolStripMenuItem cmTreeItemPropertiesPopup;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteTreeItemPopup;
        private System.Windows.Forms.ImageList ilTree;
		private System.Windows.Forms.ContextMenuStrip pmList;
        private System.Windows.Forms.ToolStripMenuItem cmItemPropertiesFromList;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteListItemPopup;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDatabase;
        private System.Windows.Forms.SplitContainer scDatabase;
        private BlueMirrorIndexer.Components.TreeViewVista tvDatabaseFolderTree;
        private BlueMirrorIndexer.Components.ListViewVista lvDatabaseItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tpSearch;
        private BlueMirrorIndexer.Components.ListViewVista lvSearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader chSrAttributes;
        private System.Windows.Forms.ColumnHeader chSrVolume;
        private System.Windows.Forms.ColumnHeader chSrPath;
        private BlueMirrorIndexer.Components.FilesSearchCriteriaPanel filesSearchCriteriaPanel;
        private System.Windows.Forms.Panel searchBottomPanel;
        private System.Windows.Forms.ColumnHeader chSrKeywords;
        private System.Windows.Forms.ImageList ilSystem;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ContextMenuStrip pmSearchList;
        private System.Windows.Forms.ToolStripMenuItem cmFindInDatabase;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader chSrFileExtension;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chDiFileVersion;
        private System.Windows.Forms.ColumnHeader chSrCrc;
        private System.Windows.Forms.NotifyIcon niBackgroundProcess;
        private System.Windows.Forms.ToolStripMenuItem cmRestoreWindow;
        private System.Windows.Forms.ContextMenuStrip pmIcon;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scFolders;
        private BlueMirrorIndexer.Components.LogicalFoldersTreeView tvLogicalFolders;
        private BlueMirrorIndexer.Components.ListViewVista lvFolderElements;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ContextMenuStrip pmItems;
        private System.Windows.Forms.ToolStripMenuItem cmRemoveFromFolder;
        private System.Windows.Forms.ToolStripMenuItem cmItemPropertiesFromSearch;
        private System.Windows.Forms.ToolStripMenuItem cmItemPropertiesFromFolders;
        private System.Windows.Forms.TabControl tcBottom;
        private System.Windows.Forms.TabPage tpLogicalFolders;
        private System.Windows.Forms.ImageList ilFolders;
        private System.Windows.Forms.ToolStripMenuItem cmFindInDatabaseFromFolders;
        private System.Windows.Forms.ContextMenuStrip pmDrop;
        private System.Windows.Forms.ToolStripMenuItem cmDropFolderAsItems;
        private System.Windows.Forms.ToolStripMenuItem cmDropFoldersAsLogicalFolders;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chDiVolume;
        private System.Windows.Forms.ColumnHeader chDiPath;
        private System.Windows.Forms.ColumnHeader chDiCrc;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader chSrFileDescription;
        private System.Windows.Forms.ColumnHeader chSrFileVersion;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeWithFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmReadVolume;
        private System.Windows.Forms.ToolStripMenuItem pmVolumes;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmPropertiesFrm;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteFrm;
        private System.Windows.Forms.ToolStripMenuItem cmFindInDatabaseFrm;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmScanNewMedia;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbFiles;
        private System.Windows.Forms.ToolStripStatusLabel sbSize;
        private System.Windows.Forms.ToolStripMenuItem pmMainLogicalFolders;
        private System.Windows.Forms.ToolStripMenuItem cmMainNewFolder;
        private System.Windows.Forms.ToolStripMenuItem cmMainEditFolder;
        private System.Windows.Forms.ToolStripMenuItem cmMainDeleteFolder;
        private System.Windows.Forms.ToolStripMenuItem cmMainRemoveFromFolder;
	}
}
