using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTunesLib;
using HananokiLib;

namespace iTunesUtility {
	public struct CsvValue {
		string[] ss;

		public CsvValue( string[] input ) {
			ss = input;
		}
		public string GetString( ESerializeNo e ) {
			return ss[ (int) e ];
		}
		public int GetInt( ESerializeNo e ) {
			return ss[ (int) e ].ToInt32(); ;
		}
		public bool GetBool( ESerializeNo e ) {
			return bool.Parse( ss[ (int) e ] );
		}
	}

	public struct TrackInfo {
		[Flags]
		public enum Modify {
			AlbumRating = 0x01,
		}
		public int Index;

		public int trackID;
		public int TrackDatabaseID;

		public string Artist;
		public string Album;
		public string AlbumArtist;
		public string Name;
		public string Comment;

		public int Duration;
		public int PlayedCount;

		public int TrackCount;
		public int TrackNumber;
		public int DiscCount;
		public int DiscNumber;

		public int Year;

		public DateTime DateAdded;
		public DateTime ModificationDate;
		public DateTime PlayedDate;

		public int Rating;
		public int AlbumRating;
		public int AlbumRatingKind;
		public int ratingKind;

		public int SampleRate;
		public int Size;

		//public string Time;

		public string Grouping;
		public int VolumeAdjustment;
		public string KindAsString;

		// 音楽ファイルの場所
		public string Location;

		// アートワークの数
		public int ArtworkCount;

		// ジャンル
		public string Genre;

		public Modify ModifyFlag;

		public bool Compilation;
		public bool Enabled;


		string DiscString {
			get {
				if( DiscCount == 0 && DiscNumber == 0 ) {
					return "";
				}
				return $"{DiscNumber}/{DiscCount}";
			}
		}
		string TrackString {
			get {
				if( TrackCount == 0 && TrackNumber == 0 ) {
					return "";
				}
				return $"{TrackNumber}/{TrackCount}";
			}
		}

		string ArtworkString {
			get {
				if( ArtworkCount == 0 ) return "×";
				if( ArtworkCount == 1 ) return "〇";
				return $"〇{ArtworkCount}";
			}
		}

		string RatingString {
			get {
				if( Rating == 0 ) return "0";
				if( Rating == 1 ) return "1";
				return $"☆{Rating / 20}";
			}
		}

		string AlbumRatingString {
			get {
				if( AlbumRating == 0 ) return "0";
				if( AlbumRating == 1 ) return "";
				return $"☆{AlbumRating / 20}";
			}
		}

		public string[] GetItemString() {
			return new string[] {
				Index.ToString(),
				trackID.ToString(),
				TrackDatabaseID.ToString(),
				Name,
				Album,
				Artist,
				AlbumArtist,
				AlbumRatingString,
				//Time,
				Year.ToString(),
				DiscString,
				TrackString,
				DateAdded.ToString() ,
				Comment,
				Genre,
				RatingString,
				PlayedCount.ToString(),
				/*AlbumRatingKind.ToString(),*/Grouping,
				Compilation.ToString(),
				ArtworkString,
				Location,
				};
		}


		/////////////////////////////////////////
		public TrackInfo( int index, IITTrack track2 ) {
			IITFileOrCDTrack track = (IITFileOrCDTrack) track2;
			this.ModifyFlag = 0;
			this.Index = index;
			this.trackID = track.trackID;
			this.TrackDatabaseID = track.TrackDatabaseID;

			this.Name = track.Name ?? "";
			this.Artist = track.Artist ?? "";
			this.Album = track.Album ?? "";
			this.AlbumArtist = track.AlbumArtist ?? "";
			this.Compilation = track.Compilation;

			
			this.Comment = track.Comment ?? "";

			this.Duration = track.Duration;
			this.PlayedCount = track.PlayedCount;
			this.DateAdded = track.DateAdded;
			this.DiscCount = track.DiscCount;
			this.DiscNumber = track.DiscNumber;

			this.ModificationDate = track.ModificationDate;
			this.PlayedDate = track.PlayedDate;

			this.Rating = track.Rating;
			this.AlbumRating = track.AlbumRating;
			this.AlbumRatingKind = (int) track.AlbumRatingKind;
			this.ratingKind = (int) track.ratingKind;

			this.SampleRate = track.SampleRate;
			this.Size = track.Size;

			//this.Time = track.Time ?? "";
			this.TrackCount = track.TrackCount;
			this.TrackNumber = track.TrackNumber;
			this.Year = track.Year;
			this.Grouping = track.Grouping ?? "";
			this.VolumeAdjustment = track.VolumeAdjustment;
			this.KindAsString = track.KindAsString;
			this.Location = track.Location;

			this.Genre = track.Genre;

			this.ArtworkCount = track.Artwork.Count;

			
			this.Enabled = track.Enabled;
		}
	}
}
