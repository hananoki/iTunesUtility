namespace iTunesUtility.Source {
	partial class UIListView {
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
			this.m_listView1 = new System.Windows.Forms.ListView();
			this.columnIndex = new System.Windows.Forms.ColumnHeader();
			this.columntrackID = new System.Windows.Forms.ColumnHeader();
			this.columnTrackDatabaseID = new System.Windows.Forms.ColumnHeader();
			this.columnName = new System.Windows.Forms.ColumnHeader();
			this.columnAlbum = new System.Windows.Forms.ColumnHeader();
			this.columnArtist = new System.Windows.Forms.ColumnHeader();
			this.columnAlbumArtist = new System.Windows.Forms.ColumnHeader();
			this.columnAlbumRating = new System.Windows.Forms.ColumnHeader();
			this.columnYear = new System.Windows.Forms.ColumnHeader();
			this.columnDiscNo = new System.Windows.Forms.ColumnHeader();
			this.columnTrackNo = new System.Windows.Forms.ColumnHeader();
			this.columnAddedDate = new System.Windows.Forms.ColumnHeader();
			this.columnComment = new System.Windows.Forms.ColumnHeader();
			this.columnGenre = new System.Windows.Forms.ColumnHeader();
			this.columnRating = new System.Windows.Forms.ColumnHeader();
			this.columnPlayCount = new System.Windows.Forms.ColumnHeader();
			this.columnGroup = new System.Windows.Forms.ColumnHeader();
			this.columnComp = new System.Windows.Forms.ColumnHeader();
			this.columnArtwork = new System.Windows.Forms.ColumnHeader();
			this.columnLocation = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// m_listView1
			// 
			this.m_listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndex,
            this.columntrackID,
            this.columnTrackDatabaseID,
            this.columnName,
            this.columnAlbum,
            this.columnArtist,
            this.columnAlbumArtist,
            this.columnAlbumRating,
            this.columnYear,
            this.columnDiscNo,
            this.columnTrackNo,
            this.columnAddedDate,
            this.columnComment,
            this.columnGenre,
            this.columnRating,
            this.columnPlayCount,
            this.columnGroup,
            this.columnComp,
            this.columnArtwork,
            this.columnLocation});
			this.m_listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_listView1.FullRowSelect = true;
			this.m_listView1.GridLines = true;
			this.m_listView1.Location = new System.Drawing.Point(0, 0);
			this.m_listView1.Name = "m_listView1";
			this.m_listView1.Size = new System.Drawing.Size(512, 313);
			this.m_listView1.TabIndex = 2;
			this.m_listView1.UseCompatibleStateImageBehavior = false;
			this.m_listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnIndex
			// 
			this.columnIndex.Width = 0;
			// 
			// columntrackID
			// 
			this.columntrackID.Text = "trackID";
			// 
			// columnTrackDatabaseID
			// 
			this.columnTrackDatabaseID.Text = "TrackDatabaseID";
			// 
			// columnName
			// 
			this.columnName.Text = "名前";
			// 
			// columnAlbum
			// 
			this.columnAlbum.Text = "アルバム";
			// 
			// columnArtist
			// 
			this.columnArtist.Text = "アーティスト";
			// 
			// columnAlbumArtist
			// 
			this.columnAlbumArtist.Text = "アルバムアーティスト";
			// 
			// columnAlbumRating
			// 
			this.columnAlbumRating.Text = "アルバムレーティング";
			// 
			// columnYear
			// 
			this.columnYear.Text = "年";
			// 
			// columnDiscNo
			// 
			this.columnDiscNo.Text = "ディスク番号";
			this.columnDiscNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnTrackNo
			// 
			this.columnTrackNo.Text = "トラック番号";
			this.columnTrackNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnAddedDate
			// 
			this.columnAddedDate.Text = "追加日";
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
			// columnPlayCount
			// 
			this.columnPlayCount.Text = "再生回数";
			this.columnPlayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnGroup
			// 
			this.columnGroup.Text = "グループ";
			// 
			// columnComp
			// 
			this.columnComp.Text = "コンピレーション";
			// 
			// columnArtwork
			// 
			this.columnArtwork.Text = "アートワーク";
			// 
			// columnLocation
			// 
			this.columnLocation.Text = "場所";
			// 
			// UIListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_listView1);
			this.Name = "UIListView";
			this.Size = new System.Drawing.Size(512, 313);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView m_listView1;
		private System.Windows.Forms.ColumnHeader columnIndex;
		private System.Windows.Forms.ColumnHeader columnAlbum;
		private System.Windows.Forms.ColumnHeader columnAlbumRating;
		private System.Windows.Forms.ColumnHeader columnYear;
		private System.Windows.Forms.ColumnHeader columnArtist;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnDiscNo;
		private System.Windows.Forms.ColumnHeader columnTrackNo;
		private System.Windows.Forms.ColumnHeader columnAddedDate;
		private System.Windows.Forms.ColumnHeader columnComment;
		private System.Windows.Forms.ColumnHeader columnGenre;
		private System.Windows.Forms.ColumnHeader columnRating;
		private System.Windows.Forms.ColumnHeader columnPlayCount;
		private System.Windows.Forms.ColumnHeader columnGroup;
		private System.Windows.Forms.ColumnHeader columnArtwork;
		private System.Windows.Forms.ColumnHeader columnLocation;
		private System.Windows.Forms.ColumnHeader columntrackID;
		private System.Windows.Forms.ColumnHeader columnTrackDatabaseID;
		private System.Windows.Forms.ColumnHeader columnAlbumArtist;
		private System.Windows.Forms.ColumnHeader columnComp;
	}
}
