using HananokiLib;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunesUtility.Source {

	//////////////////////////////////////////////////////////////////////////////////
	public partial class UIToolBar : UserControl {

		iTunesUtilityWindow mainWindow;

		Color m_CtrlColor;

		/////////////////////////////////////////
		public UIToolBar( iTunesUtilityWindow window ) {
			InitializeComponent();
			Dock = DockStyle.Top;

			mainWindow = window;
			m_CtrlColor = ToolStripMenuItem1.BackColor;

			Win32.SHSTOCKICONINFO sii = new Win32.SHSTOCKICONINFO();
			sii.cbSize = Marshal.SizeOf( sii );

			Win32.SHGetStockIconInfo( Win32.SIID_SHIELD, Win32.SHGSI_ICON | Win32.SHGSI_SMALLICON, ref sii );
			if( sii.hIcon != IntPtr.Zero ) {
				Icon shieldIcon = Icon.FromHandle( sii.hIcon );
				MainMenuItem_RegisteriTunesLibrary.Image = shieldIcon.ToBitmap();
				//Context_RegisterLibrary.Image = shieldIcon.ToBitmap();
			}


			ToolStripMenuItem1.Click += ( object o, EventArgs e ) => {
				if( iTunesHelper.IsAlive() ) {
					iTunesHelper.Dettach();
				}
				else {
					iTunesHelper.Attach();
				}
			};
			menuShowLog.Click += ( object o, EventArgs e ) => {
				LogWindow.Visible = true;
			};

			// iTunesからライブラリを取り込む
			menu1_takeMusicLibrary.Click += async ( object obj, EventArgs e ) => {
				await Task.Run( () => AppWork.ImportMusicLibrary() );
			};

			#region ファイルからライブラリを読み込む

			menu1_readMusicLibraryFromFile.Click += ( object obj, EventArgs e ) => {
				var ofd = new OpenFileDialog();
				ofd.InitialDirectory = AppWork.config.playlistFolderPath;
				ofd.FilterIndex = 1;
				ofd.Title = "ライブラリファイルを選択してください";
				ofd.Filter = "CSV Files (*.csv)|*.csv";
				ofd.RestoreDirectory = false;
				ofd.CheckFileExists = true;
				ofd.CheckPathExists = true;
				if( ofd.ShowDialog() == DialogResult.Cancel ) return;

				AppWork.ReadLibrary( ofd.FileName );

				iTunesUtilityWindow.ApplyTrackInfoToListView();
			};

			#endregion


			#region ファイルにライブラリを書き出す

			menu1_writeMusicLibraryToFile.Click += ( object obj, EventArgs e ) => {
				var dlg = new SaveFileDialog();
				dlg.FileName = "iTunes Library " + DateTime.Now.ToString( "yyyyMMddHHmmss" ) + ".csv";
				dlg.InitialDirectory = AppWork.config.playlistFolderPath;
				dlg.FilterIndex = 1;
				dlg.Title = "保存先のファイルを選択してください";
				dlg.Filter = "CSV Files (*.csv)|*.csv";
				dlg.RestoreDirectory = false;
				dlg.CheckFileExists = false;
				dlg.CheckPathExists = false;
				if( dlg.ShowDialog() == DialogResult.Cancel ) return;

				AppWork.WriteMusicLibraryJson( dlg.FileName );
			};

			#endregion

			// プレイリストをエクスポート
			menu1_exportPlayList.Click += ( object obj, EventArgs e ) => {
				Task.Run( () => AppWork.ExportPlaylist() );
			};

			// プレイリストをインポート
			menu1_importPlayList.Click += async ( object obj, EventArgs e ) => {
				var fbd = new FolderBrowserDialog();
				fbd.SelectedPath = AppWork.config.playlistFolderPath;
				fbd.ShowNewFolderButton = false;

				if( fbd.ShowDialog() == DialogResult.OK ) {
					AppWork.config.playlistFolderPath = fbd.SelectedPath;
					await Task.Run( () => AppWork.ImportPlaylist() );
				}
			};

			// ミュージックライブラリをマージ
			menu1_musicLibraryMarge.Click += ( object obj, EventArgs e ) => {
				AppWork.MargeMusicLibrary();
			};

			#region フィルターメニュー
			menu2_ShowAll.Tag = EFilterType.All;
			menu2_DeadLink.Tag = EFilterType.DeadLink;
			menu2_NotArkwork.Tag = EFilterType.NotArtwork;
			menu2_FixAlbumRating.Tag = EFilterType.FixAlbumRating;
			menu2_ShowAll.Click += OnClickFilter;
			menu2_DeadLink.Click += OnClickFilter;
			menu2_NotArkwork.Click += OnClickFilter;
			menu2_FixAlbumRating.Click += OnClickFilter;
			#endregion

			mainWindow.applyFilter += OnApplyFilter;

			iTunesHelper.ActiveEvent += () => {
				SetConnectStatus( iTunesHelper.IsAlive() );
			};
		}



		/////////////////////////////////////////
		void OnClickFilter( object obj, EventArgs e ) {
			var item = obj as ToolStripMenuItem;
			mainWindow.SetCheckedFillter( (EFilterType) item.Tag );
		}


		/////////////////////////////////////////
		void OnApplyFilter( EFilterType n ) {
			ToolStripMenuItem[] tbl = {
				menu2_ShowAll,
				menu2_DeadLink,
				menu2_NotArkwork,
				menu2_FixAlbumRating
			};
			for( int i = 0; i < tbl.Length; i++ ) {
				var t = tbl[ i ];
				if( i == (int) n ) {
					t.Checked = true;
				}
				else {
					t.Checked = false;
				}
			}
		}


		/////////////////////////////////////////
		public void SetConnectStatus( bool status ) {
			Invoke( new Action( () => {
				if( status ) {
					ToolStripMenuItem1.Text = "iTunes 接続中";
					//MenuItem_Tools.Enabled = true;
					ToolStripMenuItem1.BackColor = Color.LightGreen;
				}
				else {
					ToolStripMenuItem1.Text = "iTunes 接続する";
					//MenuItem_Tools.Enabled = false;
					ToolStripMenuItem1.BackColor = m_CtrlColor;
				}
			} ) );
		}
	}
}
