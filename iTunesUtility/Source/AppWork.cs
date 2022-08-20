using HananokiLib;
using iTunesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iTunesUtility {

	//////////////////////////////////////////////////////////////////////////////////
	public static class AppWork {

		public static Config config;

		public static TrackInfo[] m_TrackInfo;

		public static string iTunesLibraryPath
			=> $"{Helper.s_appPath}\\iTunes Library.json";

		public static string iTunesLibraryPath2
			=> $"{Helper.s_appPath}\\iTunes Library.csv";

		/////////////////////////////////////////
		/// <summary>
		/// ライブラリ情報を読み込みます
		/// </summary>
		public static void ReadLibrary( string filepath ) {
			m_TrackInfo = InternalReadLibrary( filepath );
		}





		/// <summary>
		/// iTuneから情報を取得します
		/// </summary>
		public static void ImportMusicLibrary() {
			iTunesHelper.Attach();

			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( true, "ライブラリを取り込み中" );

			TraverseLibrary();

			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( false );

			AppWork.WriteMusicLibraryJson();

			iTunesUtilityWindow.ApplyTrackInfoToListView();
		}



		/// <summary>
		/// ライブラリからトラック情報を取得する
		/// </summary>
		static void TraverseLibrary() {
			var numTracks = iTunesHelper.Tracks.Count;

			m_TrackInfo = new TrackInfo[ numTracks ];

			var sw = new System.Diagnostics.Stopwatch();
			sw.Start();

			iTunesUtilityWindow.uiStatus.progressbar.Begin( numTracks );

			int i = 0;
			var tracks = iTunesHelper.Tracks;
			int trackCount = tracks.Count;
			foreach( IITTrack t in tracks ) {
				m_TrackInfo[ i ] = new TrackInfo( i, t );
				iTunesUtilityWindow.uiStatus.progressbar.Next();
				Marshal.ReleaseComObject( t );

				i++;
				iTunesUtilityWindow.uiStatus.ShowStatusbarControl( true, $"ライブラリを取り込み中 {i}/{trackCount}" );
			}

			sw.Stop();
			TimeSpan ts = sw.Elapsed;
			Debug.Log( ts.ToString() );
		}



		/////////////////////////////////////////
		public static void WriteMusicLibraryJson() {
			WriteMusicLibraryJson( iTunesLibraryPath2 );
		}


		/////////////////////////////////////////
		static TrackInfo[] InternalReadLibrary( string filepath ) {
			if( !File.Exists( filepath ) ) {
				return new TrackInfo[ 0 ]; ;
			}

			var csv = File.ReadAllText( filepath )
				.Split( new string[] { "\r\n" }, StringSplitOptions.None )
				.Where( x => !string.IsNullOrEmpty( x ) )
				.ToList();
			csv.RemoveAt( 0 );

			var tt = new TrackInfo[ csv.Count ];

			for( int i = 0; i < csv.Count; i++ ) {
				var s = csv[ i ];
				var ss = s.Split( '\t' );
				var cv = new CsvValue( ss );
				var t = new TrackInfo();
				t.Index = i;

				t.trackID = cv.GetInt( ESerializeNo.trackID );
				t.TrackDatabaseID = cv.GetInt( ESerializeNo.TrackDatabaseID );

				t.Name = cv.GetString( ESerializeNo.Name );

				t.Artist = cv.GetString( ESerializeNo.Artist );
				t.Album = cv.GetString( ESerializeNo.Album );
				t.AlbumArtist = cv.GetString( ESerializeNo.AlbumArtist );
				t.Compilation = cv.GetBool( ESerializeNo.Compilation );

				t.TrackNumber = cv.GetInt( ESerializeNo.TrackNumber );
				t.TrackCount = cv.GetInt( ESerializeNo.TrackCount );
				t.DiscNumber = cv.GetInt( ESerializeNo.DiscNumber );
				t.DiscCount = cv.GetInt( ESerializeNo.DiscCount );

				t.Year = cv.GetInt( ESerializeNo.Year );
				t.Genre = cv.GetString( ESerializeNo.Genre );
				//t.Time = ss[ 9 ];

				t.Rating = cv.GetInt( ESerializeNo.Rating );

				t.AlbumRating = cv.GetInt( ESerializeNo.AlbumRating );
				t.AlbumRatingKind = cv.GetInt( ESerializeNo.AlbumRatingKind );
				t.ratingKind = cv.GetInt( ESerializeNo.ratingKind );

				t.Grouping = Base64.Decode( ss[ (int) ESerializeNo.Grouping ] );
				t.Comment = Base64.Decode( ss[ (int) ESerializeNo.Comment ] );

				t.PlayedCount = cv.GetInt( ESerializeNo.PlayedCount );

				t.DateAdded = DateTime.Parse( ss[ (int) ESerializeNo.DateAdded ] );
				t.ModificationDate = DateTime.Parse( ss[ (int) ESerializeNo.ModificationDate ] );
				t.PlayedDate = DateTime.Parse( ss[ (int) ESerializeNo.PlayedDate ] );

				t.ArtworkCount = cv.GetInt( ESerializeNo.ArtworkCount );
				t.Location = cv.GetString( ESerializeNo.Location );
				t.Enabled = cv.GetBool( ESerializeNo.Enabled );


				tt[ i ] = t;
			}
			return tt;
		}


		/////////////////////////////////////////
		public static void WriteMusicLibraryJson( string filepath ) {
			//Helper.WriteJson( m_TrackInfo, m_iTunesLibraryPath );
			string[] header = EnumUtils.GetNamesArray<ESerializeNo>();
			//{
			//		"Artist","Album","Name",
			//		"TrackNumber","TrackCount",
			//		"DiscNumber","DiscCount",
			//		"Year","Genre", "Rating",
			//		"AlbumRating","AlbumRatingKind", "ratingKind",
			//		"Grouping", "Comment",
			//		"PlayedCount",
			//		"DateAdded","ModificationDate","PlayedDate",
			//		"ArtworkCount", "Location", "Enabled",
			//		};
			using( var st = new StreamWriter( filepath ) ) {
				st.WriteLine( string.Join( '\t', header ) );
				foreach( var p in m_TrackInfo ) {
					string[] buf = {
						p.trackID.ToString(), p.TrackDatabaseID.ToString(),
						 p.Name, p.Artist, p.Album, p.AlbumArtist,  p.Compilation.ToString(),
						p.TrackNumber.ToString(), p.TrackCount.ToString(),
						p.DiscNumber.ToString(),p.DiscCount.ToString(),
						p.Year.ToString(),p.Genre, p.Rating.ToString(),
						p.AlbumRating.ToString(),p.AlbumRatingKind.ToString(),
						p.ratingKind.ToString(),
						Base64.Encode( p.Grouping ),Base64.Encode( p.Comment ),
						p.PlayedCount.ToString(),
						p.DateAdded.ToString(),p.ModificationDate.ToString(), p.PlayedDate.ToString(),
						p.ArtworkCount.ToString(), p.Location, p.Enabled.ToString(),
						};
					st.WriteLine( string.Join( '\t', buf ) );
				}
			}
		}


		/////////////////////////////////////////
		/// <summary>
		/// iTunesにプレイリストを登録する
		/// </summary>
		public static void ImportPlaylist() {

			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( true, "プレイリストを登録中" );

			Directory.SetCurrentDirectory( config.playlistFolderPath.GetDirectoryName() );

			var files = Directory.EnumerateFiles( config.playlistFolderPath.GetBaseName(), "*", SearchOption.AllDirectories ).ToArray();

			iTunesUtilityWindow.uiStatus.progressbar.Begin( files.Length );

			var dics = new Dictionary<string, IITUserPlaylist>();
			foreach( var f in files ) {
				var ss = f.Split( '\\' ).ToList();
				ss.RemoveAt( 0 );

				string key = "";
				string playlistName = "";
				bool cancel = false;

				// ルート直下の場合
				if( ss.Count == 1 ) {
					(playlistName, cancel) = MakePlaylistName( ss[ 0 ] );

					var playlist = iTunesHelper.GetApp().CreatePlaylist( playlistName ) as IITUserPlaylist;
					if( !cancel ) {
						AddPlaylistToiTunes( f, playlist );
					}
					Marshal.ReleaseComObject( playlist );
				}
				// フォルダに格納されている場合
				else {
					(playlistName, cancel) = MakePlaylistName( ss[ ss.Count - 1 ] );
					// 末尾のファイル名要素を削除、残りをJoinしてKeyとする
					ss.RemoveAt( ss.Count - 1 );
					if( 1 <= ss.Count ) {
						key = string.Join( "_", ss.ToList() );
					}
					if( !dics.ContainsKey( key ) ) {
						var lastName = ss[ ss.Count - 1 ];
						ss.RemoveAt( ss.Count - 1 );
						if( ss.Count == 0 ) {
							dics.Add( key, iTunesHelper.GetApp().CreateFolder( lastName ) as IITUserPlaylist );
						}
						else {
							dics.Add( key, dics[ string.Join( "_", ss.ToList() ) ].CreateFolder( lastName ) as IITUserPlaylist );
						}
					}
					var playlist = dics[ key ].CreatePlaylist( playlistName ) as IITUserPlaylist;
					if( !cancel ) {
						AddPlaylistToiTunes( f, playlist );
					}
					Marshal.ReleaseComObject( playlist );
					iTunesUtilityWindow.uiStatus.progressbar.Next();
				}
			}

			foreach( var p in dics ) {
				Marshal.ReleaseComObject( p.Value );
			}

			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( false );
		}


		/////////////////////////////////////////
		/// <summary>
		/// ファイルパスからプレイリスト用の名前とスマートプレイリストのフラグを返す
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		static (string playlistName, bool smart) MakePlaylistName( string path ) {
			bool cancel = false;
			(var bs, var ext) = ParsePath( path );
			if( string.IsNullOrEmpty( ext ) ) {
				bs = "#" + bs;
				cancel = true;
			}
			return (bs, cancel);
		}


		/////////////////////////////////////////
		/// <summary>
		/// ファイルパスからベース名と拡張子名を返す
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		static (string basename, string ext) ParsePath( string path ) {
			return (path.GetBaseName(), path.GetExtension());
		}


		/////////////////////////////////////////
		/// <summary>
		/// 書き出したプレイリストを読み込んでiTunes側に追加する
		/// </summary>
		/// <param name="playlistFilepath"></param>
		/// <param name="playlist"></param>
		static void AddPlaylistToiTunes( string playlistFilepath, IITUserPlaylist playlist ) {
			var readtext = File.ReadAllText( playlistFilepath ).Split( '\r', '\n' )
				.Where( x => !string.IsNullOrEmpty( x ) )
				.ToList();

			readtext.RemoveAt( 0 );

			if( readtext.Count == 0 ) return;

			playlist.AddFiles( readtext.ToArray() );

			Marshal.ReleaseComObject( playlist );
		}


		/////////////////////////////////////////
		public static void ExportPlaylist() {
			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( true, "プレイリストを書き出し中" );

			var lsp = iTunesHelper.GetApp().LibrarySource.Playlists;
			string outdate = DateTime.Now.ToString( "yyyy_MMdd_HHmmss" );
			string outPath = outdate;
			var dirs = new List<string>();
			Directory.CreateDirectory( outPath );

			iTunesUtilityWindow.uiStatus.progressbar.Begin( lsp.Count );

			foreach( IITPlaylist p in lsp ) {
				try {
					// いらなそうなので排除
					if( p.Kind == ITPlaylistKind.ITPlaylistKindLibrary ) continue;

					IITUserPlaylist p2 = (IITUserPlaylist) p;
					var parent = p2.get_Parent();

					Log.Info( p2.SpecialKind.ToString() );

					try {
						// フォルダの時
						if( p2.SpecialKind == ITUserPlaylistSpecialKind.ITUserPlaylistSpecialKindFolder ) {
							//Debug.Log( "ITUserPlaylistSpecialKindFolder: " );

							if( parent == null ) {
								if( 1 <= dirs.Count ) {
									dirs.RemoveAt( dirs.Count - 1 );
								}
								dirs.Add( p2.Name );
							}
							else {
								if( dirs[ dirs.Count - 1 ] != parent.Name ) {
									dirs.RemoveAt( dirs.Count - 1 );
								}
								dirs.Add( p2.Name );
							}

							outPath = outdate + "/" + string.Join( "/", dirs );
							Directory.CreateDirectory( outPath );
							Log.Info( outPath );
						}
						// 通常のプレイリストと思われる時
						else if( p2.SpecialKind == ITUserPlaylistSpecialKind.ITUserPlaylistSpecialKindNone ) {
							void updatePath( bool force = false ) {
								if( force || dirs[ dirs.Count - 1 ] != parent.Name ) {
									dirs.RemoveAt( dirs.Count - 1 );
									outPath = outdate + "/" + string.Join( "/", dirs );
								}
							}

							if( parent == null ) {
								if( 1 <= dirs.Count ) {
									updatePath( true );
								}
							}
							else {
								updatePath();
							}

							Log.Info( $"Name={p2.Name}: SpecialKind={p2.SpecialKind.ToString()}: Smart={p2.Smart}" );
							var aa = p2.Name.Replace( "/", "／" );
							var path = outPath + "/" + aa;
							if( !p2.Smart ) {
								path = path + ".csv";
							}
							Log.Info( path );

							var tr = p.Tracks;
							WritePlaylistFile( path, tr, p2.Smart );
							Marshal.ReleaseComObject( tr );
						}
					}
					finally {
						if( parent != null ) {
							Marshal.ReleaseComObject( parent );
						}
						Marshal.ReleaseComObject( p2 );
					}
				}
				finally {
					iTunesUtilityWindow.uiStatus.progressbar.Next();
					Marshal.ReleaseComObject( p );
				}
			}
			Marshal.ReleaseComObject( lsp );

			iTunesUtilityWindow.uiStatus.ShowStatusbarControl( false );

			MessageBox.Show( $"{Directory.GetCurrentDirectory()}\\{outdate} に書き出しました。", "プレイリストをエクスポート" );
		}


		/////////////////////////////////////////
		static void WritePlaylistFile( string filepath, IITTrackCollection tracks, bool smartPlaylist ) {
			try {
				using( var st = new StreamWriter( filepath ) ) {
					//if( smartPlaylist ) return;
					st.WriteLine( "trackID\tTrackDatabaseID\tLocation" );

					//var buf = new List<string>();
					foreach( IITFileOrCDTrack p in tracks ) {
						//buf.Add( p.trackID.ToString() );
						//buf.Add( p.Location );
						//st.WriteLine( String.Join( "\t", buf ) );
						string[] buf = {
						p.trackID.ToString(),
						p.TrackDatabaseID.ToString(),
						p.Location,
						};
						st.WriteLine( string.Join( '\t', buf ) );
						Marshal.ReleaseComObject( p );
					}
				}
			}
			catch( Exception e ) {
				Debug.Exception( e );
			}
			finally {
				Marshal.ReleaseComObject( tracks );
			}
		}


		/////////////////////////////////////////
		async public static void MargeMusicLibrary() {
			var ofd = new OpenFileDialog();
			ofd.InitialDirectory = config.playlistFolderPath;
			ofd.FilterIndex = 1;
			ofd.Title = "ライブラリファイルを選択してください";
			ofd.Filter = "CSV Files (*.csv)|*.csv";
			ofd.RestoreDirectory = false;
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;
			if( ofd.ShowDialog() == DialogResult.Cancel ) return;

			await Task.Run( () => {
				iTunesUtilityWindow.uiStatus.ShowStatusbarControl( true, "ライブラリをマージ中" );

				var tt1 = new List<TrackInfo>( m_TrackInfo );
				var tt2 = new List<TrackInfo>( InternalReadLibrary( ofd.FileName ) );
				iTunesUtilityWindow.uiStatus.progressbar.Begin( tt1.Count );

				for( int i = 0; i < tt1.Count; i++ ) {
					iTunesUtilityWindow.uiStatus.progressbar.Next();
					var t1 = tt1[ i ];
					for( int j = 0; j < tt2.Count; j++ ) {
						var t2 = tt2[ j ];
						if( t1.Location == t2.Location ) {
							t1.DateAdded = t2.DateAdded;
							if( string.IsNullOrEmpty( t1.Comment ) && !string.IsNullOrEmpty( t2.Comment ) ) {
								t1.Comment = t2.Comment;
							}
							if( string.IsNullOrEmpty( t1.Grouping ) && !string.IsNullOrEmpty( t2.Grouping ) ) {
								t1.Grouping = t2.Grouping;
							}
							tt1[ i ] = t1;
							tt2.RemoveAt( j );
							j -= 1;
							break;
						}
					}
				}
				tt1.AddRange( tt2 );
				//tt1.Sort( ( a, b ) => a.DateAdded.CompareTo( b.DateAdded ) );
				m_TrackInfo = tt1.OrderBy( x => x.DateAdded )
												 .ThenBy( x => x.Location ).ToArray();
				//m_TrackInfo = tt1.ToArray();

				iTunesUtilityWindow.ApplyTrackInfoToListView();
				iTunesUtilityWindow.uiStatus.ShowStatusbarControl( false );
			} );
		}

	}
}
