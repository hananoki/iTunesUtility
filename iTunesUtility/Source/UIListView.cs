using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HananokiLib;

namespace iTunesUtility.Source {

	//////////////////////////////////////////////////////////////////////////////////
	public partial class UIListView : UserControl {

		ListView.ListViewItemCollection listViewItemCollection;
		ListView.SelectedIndexCollection listViewItemSelection;
		ListViewItem[] _item;

		/////////////////////////////////////////
		public UIListView( iTunesUtilityWindow window ) {
			InitializeComponent();
			Dock = DockStyle.Fill;

			m_listView1.VirtualMode = true;
			m_listView1.SetDoubleBuffered( true );
			listViewItemCollection = new ListView.ListViewItemCollection( m_listView1 );
			listViewItemSelection = new ListView.SelectedIndexCollection( m_listView1 );
			m_listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler( ( s, e ) => {
				if( _item == null ) return;
				e.Item = _item[ e.ItemIndex ];
			} );

			window.applyTrackInfoToListView += OnApplyTrackInfoToListView;
			window.applyFilter += OnApplyFilter;

			m_listView1.ColumnClick += ( object sender, ColumnClickEventArgs e ) => {
				int clm = (int) e.Column;

				Array.Sort( _item, ( x, y ) => {
					if( 13 == clm ) {
						if( x.SubItems[ clm ].Text.ToInt32() == y.SubItems[ clm ].Text.ToInt32() ) return 0;
						if( x.SubItems[ clm ].Text.ToInt32() < y.SubItems[ clm ].Text.ToInt32() ) return 1;
						return -1;
					}
					return string.Compare( x.SubItems[ clm ].Text, y.SubItems[ clm ].Text );
				} );
				m_listView1.Refresh();
			};

			m_listView1.DoubleClick += ( object sender, EventArgs e ) => {
				iTunesHelper.Attach();
				var idxs = MakeSelectIndexArray();
				if( idxs.Length == 0 ) return;
				//var t = iTunesHelper.Track( _item[ selectIndex ].ID() );
				//var tracks = iTunesHelper.mainLibrary.Tracks;
				var t = iTunesHelper.tracks[ idxs[ 0 ] + 1 ];
				t.Play();
				Marshal.ReleaseComObject( t );
				t = null;
				//Marshal.ReleaseComObject( tracks );
				//tracks = null;
			};
		}


		/////////////////////////////////////////
		void OnApplyFilter( EFilterType n ) {
			switch( n ) {
				// 全て表示する
				case EFilterType.All:
					_item = AppWork.m_TrackInfo.Select( x => new ListViewItem( x.GetItemString() ) ).ToArray();
					if( 0 < _item.Length ) {
						ArrayUtility.RemoveAt( ref _item, 0 );
					}
					m_listView1.VirtualListSize = _item.Length;
					break;

				// デッドリンクを検出する
				case EFilterType.DeadLink:
					ListViewItem[] _item2 = AppWork.m_TrackInfo
						.Where( x => !File.Exists( x.Location ) )
						.Select( x => new ListViewItem( x.GetItemString() ) )
						.ToArray();

					if( _item2.Length == 0 ) {
						Log.Info( "デッドリンクはありません" );
					}
					_item = _item2;
					//ArrayUtility.RemoveAt( ref _item, 0 );
					m_listView1.VirtualListSize = _item.Length;
					Log.Info( $"デッドリンク {_item.Length} 検出しました" );
					break;

				// 未設定のアートワークを検出する
				case EFilterType.NotArtwork:
					_item = AppWork.m_TrackInfo
						.Where( x => x.ArtworkCount == 0 )
						.Select( x => new ListViewItem( x.GetItemString() ) )
						.ToArray();
					//ArrayUtility.RemoveAt( ref _item, 0 );
					m_listView1.VirtualListSize = _item.Length;
					break;

				// 不要なアルバムレーティングを検出する
				case EFilterType.FixAlbumRating:
					_item = AppWork.m_TrackInfo
						.Where( x => 5 < x.AlbumRating || x.AlbumRating == 0 )
						.Select( x => new ListViewItem( x.GetItemString() ) )
						.ToArray();
					//ArrayUtility.RemoveAt( ref _item, 0 );
					m_listView1.VirtualListSize = _item.Length;
					break;
			}
		}


		/// <summary>
		/// m_TrackInfo配列をリストビューに反映させる
		/// </summary>
		void OnApplyTrackInfoToListView( TrackInfo[] m_TrackInfo, EFilterType m_filterMode ) {
			Invoke( new Action( () => {
				Log.Info( $"トラック数: {m_TrackInfo.Length}" );

				OnApplyFilter( m_filterMode );

				// ModifyFlagが設定された要素のみのインデックス配列を作成
				var idd = m_TrackInfo.Select( ( x, i ) => {
					if( x.ModifyFlag == 0 ) return -1;
					return i;
				} ).ToList();
				idd.RemoveAll( x => x == -1 );

				// ModifyFlagなトラックの背景色を変更
				foreach( var i in idd ) {
					_item[ i ].BackColor = Color.LightPink; ;
				}

				// 各列の幅を広げる
				//for( int i = 1; i < m_listView1.Columns.Count; i++ ) {
				//	var c = m_listView1.Columns[ i ];
				//	( (ColumnHeader) c ).Width = -1;
				//}
			} ) );
		}



		/// <summary>
		/// 現在選択されている項目をm_TrackInfoでのインデックス番号として取得する
		/// </summary>
		/// <returns></returns>
		int[] MakeSelectIndexArray() {
			var lst = new List<int>();
			Invoke( new Action( () => {
				if( listViewItemSelection.Count > 0 ) {
					foreach( int index in listViewItemSelection ) {
						lst.Add( _item[ index ].SubItems[ 0 ].Text.ToInt32() );
					}
				}
			} ) );
			return lst.ToArray();
		}

	}
}
