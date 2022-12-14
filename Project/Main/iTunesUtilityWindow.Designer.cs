namespace iTunesUtility
{
  partial class iTunesUtilityWindow
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iTunesUtilityWindow));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.m_listView1 = new System.Windows.Forms.ListView();
			this.columnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnAlbumRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDurarion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnArtwork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.曲の情報をiTunesから読み込むToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iTunesからこの曲を削除するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.アルバムレーティングを1に設定するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ファイルを選択してアルバムアートを設定するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Context_RegisterLibrary = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_LibraryImport = new System.Windows.Forms.ToolStripMenuItem();
			this.ファイルからライブラリを読み込むToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuItem_RegisteriTunesLibrary = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuItem_ExportPlaylistToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuItem_ImportPlaylistToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.iTunesUtilsのToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全て表示するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.デッドリンクを検出するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.未設定のアートワークを検出するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.不要なアルバムレーティングを検出するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ログToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ファイルにライブラリを書き出すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.m_listView1);
			this.splitContainer1.Size = new System.Drawing.Size(780, 393);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
			// 
			// m_listView1
			// 
			this.m_listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndex,
            this.columnAlbum,
            this.columnAlbumRating,
            this.columnDurarion,
            this.columnHeader7,
            this.columnArtist,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader4,
            this.columnComment,
            this.columnGenre,
            this.columnRating,
            this.columnHeader10,
            this.columnHeader11,
            this.columnArtwork,
            this.columnLocation});
			this.m_listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.m_listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_listView1.FullRowSelect = true;
			this.m_listView1.GridLines = true;
			this.m_listView1.Location = new System.Drawing.Point(0, 0);
			this.m_listView1.Name = "m_listView1";
			this.m_listView1.Size = new System.Drawing.Size(751, 393);
			this.m_listView1.TabIndex = 0;
			this.m_listView1.UseCompatibleStateImageBehavior = false;
			this.m_listView1.View = System.Windows.Forms.View.Details;
			this.m_listView1.VirtualMode = true;
			this.m_listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.m_listView1_ColumnClick);
			this.m_listView1.DoubleClick += new System.EventHandler(this.m_listView1_DoubleClick);
			// 
			// columnIndex
			// 
			this.columnIndex.Text = "ColumnIndex";
			this.columnIndex.Width = 0;
			// 
			// columnAlbum
			// 
			this.columnAlbum.Text = "アルバム";
			// 
			// columnAlbumRating
			// 
			this.columnAlbumRating.Text = "アルバムレーティング";
			// 
			// columnDurarion
			// 
			this.columnDurarion.Text = "時間";
			this.columnDurarion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "年";
			// 
			// columnArtist
			// 
			this.columnArtist.Text = "アーティスト";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "名前";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "ディスク番号";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "トラック番号";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "追加日";
			// 
			// columnComment
			// 
			this.columnComment.Text = "コメント";
			// 
			// columnGenre
			// 
			this.columnGenre.Text = "ジャンル";
			// 
			// columnRating
			// 
			this.columnRating.Text = "評価";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "再生回数";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "グループ";
			// 
			// columnArtwork
			// 
			this.columnArtwork.Text = "アートワーク";
			// 
			// columnLocation
			// 
			this.columnLocation.Text = "場所";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.曲の情報をiTunesから読み込むToolStripMenuItem,
            this.iTunesからこの曲を削除するToolStripMenuItem,
            this.アルバムレーティングを1に設定するToolStripMenuItem,
            this.ファイルを選択してアルバムアートを設定するToolStripMenuItem,
            this.Context_RegisterLibrary});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(274, 114);
			// 
			// 曲の情報をiTunesから読み込むToolStripMenuItem
			// 
			this.曲の情報をiTunesから読み込むToolStripMenuItem.Name = "曲の情報をiTunesから読み込むToolStripMenuItem";
			this.曲の情報をiTunesから読み込むToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
			this.曲の情報をiTunesから読み込むToolStripMenuItem.Text = "曲の情報をiTunesから読み込む";
			this.曲の情報をiTunesから読み込むToolStripMenuItem.Click += new System.EventHandler(this.曲の情報をiTunesから読み込むToolStripMenuItem_Click);
			// 
			// iTunesからこの曲を削除するToolStripMenuItem
			// 
			this.iTunesからこの曲を削除するToolStripMenuItem.Name = "iTunesからこの曲を削除するToolStripMenuItem";
			this.iTunesからこの曲を削除するToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
			this.iTunesからこの曲を削除するToolStripMenuItem.Text = "iTunesからこの曲を削除する";
			this.iTunesからこの曲を削除するToolStripMenuItem.Click += new System.EventHandler(this.iTunesからこの曲を削除する);
			// 
			// アルバムレーティングを1に設定するToolStripMenuItem
			// 
			this.アルバムレーティングを1に設定するToolStripMenuItem.Name = "アルバムレーティングを1に設定するToolStripMenuItem";
			this.アルバムレーティングを1に設定するToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
			this.アルバムレーティングを1に設定するToolStripMenuItem.Text = "アルバムレーティングを1に設定する";
			this.アルバムレーティングを1に設定するToolStripMenuItem.Click += new System.EventHandler(this.アルバムレーティングを1に設定するToolStripMenuItem_Click);
			// 
			// ファイルを選択してアルバムアートを設定するToolStripMenuItem
			// 
			this.ファイルを選択してアルバムアートを設定するToolStripMenuItem.Name = "ファイルを選択してアルバムアートを設定するToolStripMenuItem";
			this.ファイルを選択してアルバムアートを設定するToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
			this.ファイルを選択してアルバムアートを設定するToolStripMenuItem.Text = "ファイルを選択してアルバムアートを設定する";
			this.ファイルを選択してアルバムアートを設定するToolStripMenuItem.Click += new System.EventHandler(this.ファイルを選択してアートワークを設定するToolStripMenuItem_Click);
			// 
			// Context_RegisterLibrary
			// 
			this.Context_RegisterLibrary.Name = "Context_RegisterLibrary";
			this.Context_RegisterLibrary.Size = new System.Drawing.Size(273, 22);
			this.Context_RegisterLibrary.Text = "この曲をiTunesUtilsの内容で登録する";
			this.Context_RegisterLibrary.Click += new System.EventHandler(this.この曲をiTunesUtilsの内容で登録し直すToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 417);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(780, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
			this.toolStripStatusLabel1.Text = "インポート中";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.MenuItem_Tools,
            this.ツールToolStripMenuItem,
            this.ログToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(780, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem1.Image")));
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
			this.ToolStripMenuItem1.Text = "iTunesに接続";
			this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
			// 
			// MenuItem_Tools
			// 
			this.MenuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_LibraryImport,
            this.ファイルからライブラリを読み込むToolStripMenuItem,
            this.ファイルにライブラリを書き出すToolStripMenuItem,
            this.MainMenuItem_RegisteriTunesLibrary,
            this.toolStripSeparator1,
            this.MainMenuItem_ExportPlaylistToolStrip,
            this.MainMenuItem_ImportPlaylistToolStrip,
            this.toolStripSeparator2,
            this.iTunesUtilsのToolStripMenuItem});
			this.MenuItem_Tools.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_Tools.Image")));
			this.MenuItem_Tools.Name = "MenuItem_Tools";
			this.MenuItem_Tools.Size = new System.Drawing.Size(59, 20);
			this.MenuItem_Tools.Text = "操作";
			// 
			// MenuItem_LibraryImport
			// 
			this.MenuItem_LibraryImport.Name = "MenuItem_LibraryImport";
			this.MenuItem_LibraryImport.Size = new System.Drawing.Size(282, 22);
			this.MenuItem_LibraryImport.Text = "iTunesからライブラリを取り込む";
			this.MenuItem_LibraryImport.Click += new System.EventHandler(this.MainMenu_ImportLibrary);
			// 
			// ファイルからライブラリを読み込むToolStripMenuItem
			// 
			this.ファイルからライブラリを読み込むToolStripMenuItem.Name = "ファイルからライブラリを読み込むToolStripMenuItem";
			this.ファイルからライブラリを読み込むToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.ファイルからライブラリを読み込むToolStripMenuItem.Text = "ファイルからライブラリを読み込む";
			this.ファイルからライブラリを読み込むToolStripMenuItem.Click += new System.EventHandler(this.MainMenu_ImportLibraryFromFile);
			// 
			// MainMenuItem_RegisteriTunesLibrary
			// 
			this.MainMenuItem_RegisteriTunesLibrary.Name = "MainMenuItem_RegisteriTunesLibrary";
			this.MainMenuItem_RegisteriTunesLibrary.Size = new System.Drawing.Size(282, 22);
			this.MainMenuItem_RegisteriTunesLibrary.Text = "iTunesUtilsの内容をiTunesに登録する";
			this.MainMenuItem_RegisteriTunesLibrary.Click += new System.EventHandler(this.MainMenu_RegisteriTunesLibrary);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
			// 
			// MainMenuItem_ExportPlaylistToolStrip
			// 
			this.MainMenuItem_ExportPlaylistToolStrip.Name = "MainMenuItem_ExportPlaylistToolStrip";
			this.MainMenuItem_ExportPlaylistToolStrip.Size = new System.Drawing.Size(282, 22);
			this.MainMenuItem_ExportPlaylistToolStrip.Text = "iTunesからプレイリストを書き出す";
			this.MainMenuItem_ExportPlaylistToolStrip.Click += new System.EventHandler(this.MainMenu_ExportPlaylist);
			// 
			// MainMenuItem_ImportPlaylistToolStrip
			// 
			this.MainMenuItem_ImportPlaylistToolStrip.Name = "MainMenuItem_ImportPlaylistToolStrip";
			this.MainMenuItem_ImportPlaylistToolStrip.Size = new System.Drawing.Size(282, 22);
			this.MainMenuItem_ImportPlaylistToolStrip.Text = "iTunesにプレイリストを登録する";
			this.MainMenuItem_ImportPlaylistToolStrip.Click += new System.EventHandler(this.MainMenu_ImportPlaylist);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
			// 
			// iTunesUtilsのToolStripMenuItem
			// 
			this.iTunesUtilsのToolStripMenuItem.Name = "iTunesUtilsのToolStripMenuItem";
			this.iTunesUtilsのToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.iTunesUtilsのToolStripMenuItem.Text = "iTunesUtilsの内容に別ライブラリをマージする";
			this.iTunesUtilsのToolStripMenuItem.Click += new System.EventHandler(this.iTunesUtilsのToolStripMenuItem_Click);
			// 
			// ツールToolStripMenuItem
			// 
			this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全て表示するToolStripMenuItem,
            this.デッドリンクを検出するToolStripMenuItem,
            this.未設定のアートワークを検出するToolStripMenuItem,
            this.不要なアルバムレーティングを検出するToolStripMenuItem});
			this.ツールToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ツールToolStripMenuItem.Image")));
			this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
			this.ツールToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.ツールToolStripMenuItem.Text = "フィルター";
			// 
			// 全て表示するToolStripMenuItem
			// 
			this.全て表示するToolStripMenuItem.Checked = true;
			this.全て表示するToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.全て表示するToolStripMenuItem.Name = "全て表示するToolStripMenuItem";
			this.全て表示するToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.全て表示するToolStripMenuItem.Text = "全て表示する";
			this.全て表示するToolStripMenuItem.Click += new System.EventHandler(this.全て表示する);
			// 
			// デッドリンクを検出するToolStripMenuItem
			// 
			this.デッドリンクを検出するToolStripMenuItem.Name = "デッドリンクを検出するToolStripMenuItem";
			this.デッドリンクを検出するToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.デッドリンクを検出するToolStripMenuItem.Text = "デッドリンクを検出する";
			this.デッドリンクを検出するToolStripMenuItem.Click += new System.EventHandler(this.デッドリンクを検出する);
			// 
			// 未設定のアートワークを検出するToolStripMenuItem
			// 
			this.未設定のアートワークを検出するToolStripMenuItem.Name = "未設定のアートワークを検出するToolStripMenuItem";
			this.未設定のアートワークを検出するToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.未設定のアートワークを検出するToolStripMenuItem.Text = "未設定のアートワークを検出する";
			this.未設定のアートワークを検出するToolStripMenuItem.Click += new System.EventHandler(this.未設定のアートワークを検出する);
			// 
			// 不要なアルバムレーティングを検出するToolStripMenuItem
			// 
			this.不要なアルバムレーティングを検出するToolStripMenuItem.Name = "不要なアルバムレーティングを検出するToolStripMenuItem";
			this.不要なアルバムレーティングを検出するToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
			this.不要なアルバムレーティングを検出するToolStripMenuItem.Text = "不要なアルバムレーティングを検出する";
			this.不要なアルバムレーティングを検出するToolStripMenuItem.Click += new System.EventHandler(this.不要なアルバムレーティングを検出する);
			// 
			// ログToolStripMenuItem
			// 
			this.ログToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ログToolStripMenuItem.Image")));
			this.ログToolStripMenuItem.Name = "ログToolStripMenuItem";
			this.ログToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ログToolStripMenuItem.Text = "ログ";
			this.ログToolStripMenuItem.Click += new System.EventHandler(this.ログToolStripMenuItem_Click);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(21, 17);
			this.toolStripStatusLabel2.Text = "[0]";
			this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ファイルにライブラリを書き出すToolStripMenuItem
			// 
			this.ファイルにライブラリを書き出すToolStripMenuItem.Name = "ファイルにライブラリを書き出すToolStripMenuItem";
			this.ファイルにライブラリを書き出すToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
			this.ファイルにライブラリを書き出すToolStripMenuItem.Text = "ファイルにライブラリを書き出す";
			this.ファイルにライブラリを書き出すToolStripMenuItem.Click += new System.EventHandler(this.ファイルにライブラリを書き出すToolStripMenuItem_Click);
			// 
			// iTunesUtilityWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 439);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "iTunesUtilityWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "iTunesUtils";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView m_listView1;
		private System.Windows.Forms.ColumnHeader columnArtist;
		private System.Windows.Forms.ColumnHeader columnAlbum;
		private System.Windows.Forms.ColumnHeader columnDurarion;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnComment;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnRating;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 曲の情報をiTunesから読み込むToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		private System.Windows.Forms.ColumnHeader columnArtwork;
		private System.Windows.Forms.ColumnHeader columnLocation;
		private System.Windows.Forms.ColumnHeader columnIndex;
		private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem デッドリンクを検出するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 未設定のアートワークを検出するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 不要なアルバムレーティングを検出するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全て表示するToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnAlbumRating;
		private System.Windows.Forms.ColumnHeader columnGenre;
		private System.Windows.Forms.ToolStripMenuItem アルバムレーティングを1に設定するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iTunesからこの曲を削除するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ログToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ファイルを選択してアルバムアートを設定するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Tools;
		private System.Windows.Forms.ToolStripMenuItem MainMenuItem_RegisteriTunesLibrary;
		//private System.Windows.Forms.ToolStripMenuItem 曲を追加するToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuItem_ExportPlaylistToolStrip;
		private System.Windows.Forms.ToolStripMenuItem MainMenuItem_ImportPlaylistToolStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_LibraryImport;
		private System.Windows.Forms.ToolStripMenuItem Context_RegisterLibrary;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem iTunesUtilsのToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ファイルからライブラリを読み込むToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripMenuItem ファイルにライブラリを書き出すToolStripMenuItem;
	}
}

