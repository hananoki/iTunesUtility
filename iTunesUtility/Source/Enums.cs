using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunesUtility {
	public enum EFilterType {
		All,
		DeadLink,
		NotArtwork,
		FixAlbumRating,
	}

	public enum ESerializeNo {
		trackID, TrackDatabaseID,
		Name, Artist, Album, AlbumArtist, Compilation,
		TrackNumber,TrackCount,
		DiscNumber,DiscCount,
		Year, Genre, Rating,
		AlbumRating, AlbumRatingKind, ratingKind,
		Grouping, Comment,
		PlayedCount,
		DateAdded, ModificationDate, PlayedDate,
		ArtworkCount, Location, Enabled,
	}

}
