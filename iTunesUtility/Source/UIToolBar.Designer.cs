namespace iTunesUtility.Source {
	partial class UIToolBar {
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIToolBar));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu1_takeMusicLibrary = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuItem_RegisteriTunesLibrary = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.menu1_readMusicLibraryFromFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menu1_writeMusicLibraryToFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menu1_importPlayList = new System.Windows.Forms.ToolStripMenuItem();
			this.menu1_exportPlayList = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menu1_musicLibraryMarge = new System.Windows.Forms.ToolStripMenuItem();
			this.フィルターToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2_ShowAll = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2_DeadLink = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2_NotArkwork = new System.Windows.Forms.ToolStripMenuItem();
			this.menu2_FixAlbumRating = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowLog = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.操作ToolStripMenuItem,
            this.フィルターToolStripMenuItem,
            this.menuShowLog});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(518, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem1.Image")));
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
			this.ToolStripMenuItem1.Text = "iTunesに接続";
			// 
			// 操作ToolStripMenuItem
			// 
			this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1_takeMusicLibrary,
            this.MainMenuItem_RegisteriTunesLibrary,
            this.toolStripSeparator3,
            this.menu1_readMusicLibraryFromFile,
            this.menu1_writeMusicLibraryToFile,
            this.toolStripSeparator1,
            this.menu1_importPlayList,
            this.menu1_exportPlayList,
            this.toolStripSeparator2,
            this.menu1_musicLibraryMarge});
			this.操作ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("操作ToolStripMenuItem.Image")));
			this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
			this.操作ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.操作ToolStripMenuItem.Text = "操作";
			// 
			// menu1_takeMusicLibrary
			// 
			this.menu1_takeMusicLibrary.Name = "menu1_takeMusicLibrary";
			this.menu1_takeMusicLibrary.Size = new System.Drawing.Size(202, 22);
			this.menu1_takeMusicLibrary.Text = "iTunesからインポート";
			// 
			// MainMenuItem_RegisteriTunesLibrary
			// 
			this.MainMenuItem_RegisteriTunesLibrary.Enabled = false;
			this.MainMenuItem_RegisteriTunesLibrary.Name = "MainMenuItem_RegisteriTunesLibrary";
			this.MainMenuItem_RegisteriTunesLibrary.Size = new System.Drawing.Size(202, 22);
			this.MainMenuItem_RegisteriTunesLibrary.Text = "iTunesに登録する";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
			// 
			// menu1_readMusicLibraryFromFile
			// 
			this.menu1_readMusicLibraryFromFile.Enabled = false;
			this.menu1_readMusicLibraryFromFile.Name = "menu1_readMusicLibraryFromFile";
			this.menu1_readMusicLibraryFromFile.Size = new System.Drawing.Size(202, 22);
			this.menu1_readMusicLibraryFromFile.Text = "ファイルからインポート";
			// 
			// menu1_writeMusicLibraryToFile
			// 
			this.menu1_writeMusicLibraryToFile.Enabled = false;
			this.menu1_writeMusicLibraryToFile.Name = "menu1_writeMusicLibraryToFile";
			this.menu1_writeMusicLibraryToFile.Size = new System.Drawing.Size(202, 22);
			this.menu1_writeMusicLibraryToFile.Text = "ファイルにエクスポート";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
			// 
			// menu1_importPlayList
			// 
			this.menu1_importPlayList.Enabled = false;
			this.menu1_importPlayList.Name = "menu1_importPlayList";
			this.menu1_importPlayList.Size = new System.Drawing.Size(202, 22);
			this.menu1_importPlayList.Text = "プレイリストをインポート";
			// 
			// menu1_exportPlayList
			// 
			this.menu1_exportPlayList.Name = "menu1_exportPlayList";
			this.menu1_exportPlayList.Size = new System.Drawing.Size(202, 22);
			this.menu1_exportPlayList.Text = "プレイリストをエクスポート";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
			// 
			// menu1_musicLibraryMarge
			// 
			this.menu1_musicLibraryMarge.Enabled = false;
			this.menu1_musicLibraryMarge.Name = "menu1_musicLibraryMarge";
			this.menu1_musicLibraryMarge.Size = new System.Drawing.Size(202, 22);
			this.menu1_musicLibraryMarge.Text = "ミュージックライブラリをマージ";
			// 
			// フィルターToolStripMenuItem
			// 
			this.フィルターToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu2_ShowAll,
            this.menu2_DeadLink,
            this.menu2_NotArkwork,
            this.menu2_FixAlbumRating});
			this.フィルターToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("フィルターToolStripMenuItem.Image")));
			this.フィルターToolStripMenuItem.Name = "フィルターToolStripMenuItem";
			this.フィルターToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.フィルターToolStripMenuItem.Text = "フィルター";
			// 
			// menu2_ShowAll
			// 
			this.menu2_ShowAll.Name = "menu2_ShowAll";
			this.menu2_ShowAll.Size = new System.Drawing.Size(249, 22);
			this.menu2_ShowAll.Text = "全て表示する";
			// 
			// menu2_DeadLink
			// 
			this.menu2_DeadLink.Name = "menu2_DeadLink";
			this.menu2_DeadLink.Size = new System.Drawing.Size(249, 22);
			this.menu2_DeadLink.Text = "デッドリンクを検出する";
			// 
			// menu2_NotArkwork
			// 
			this.menu2_NotArkwork.Name = "menu2_NotArkwork";
			this.menu2_NotArkwork.Size = new System.Drawing.Size(249, 22);
			this.menu2_NotArkwork.Text = "未設定のアートワークを検出する";
			// 
			// menu2_FixAlbumRating
			// 
			this.menu2_FixAlbumRating.Name = "menu2_FixAlbumRating";
			this.menu2_FixAlbumRating.Size = new System.Drawing.Size(249, 22);
			this.menu2_FixAlbumRating.Text = "不要なアルバムレーティングを検出する";
			// 
			// menuShowLog
			// 
			this.menuShowLog.Image = ((System.Drawing.Image)(resources.GetObject("menuShowLog.Image")));
			this.menuShowLog.Name = "menuShowLog";
			this.menuShowLog.Size = new System.Drawing.Size(53, 20);
			this.menuShowLog.Text = "ログ";
			// 
			// UIToolBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.menuStrip1);
			this.Name = "UIToolBar";
			this.Size = new System.Drawing.Size(518, 26);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuItem_RegisteriTunesLibrary;
		private System.Windows.Forms.ToolStripMenuItem menu1_takeMusicLibrary;
		private System.Windows.Forms.ToolStripMenuItem フィルターToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuShowLog;
		private System.Windows.Forms.ToolStripMenuItem menu2_ShowAll;
		private System.Windows.Forms.ToolStripMenuItem menu2_DeadLink;
		private System.Windows.Forms.ToolStripMenuItem menu2_NotArkwork;
		private System.Windows.Forms.ToolStripMenuItem menu2_FixAlbumRating;
		private System.Windows.Forms.ToolStripMenuItem menu1_readMusicLibraryFromFile;
		private System.Windows.Forms.ToolStripMenuItem menu1_writeMusicLibraryToFile;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menu1_exportPlayList;
		private System.Windows.Forms.ToolStripMenuItem menu1_importPlayList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menu1_musicLibraryMarge;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}
