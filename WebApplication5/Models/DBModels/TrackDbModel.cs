using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models.DBModels
{
    public class TrackDbModel
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; }

        //

        public virtual int? IdMusicAlbum { get; set; }

        [ForeignKey("IdMusicAlbum")]
        public virtual AlbumDbModel TheAlbum { get; set; }
        public virtual ICollection<MusicianTrackDbModel> MusicianTracks { get; set; }
    }
}
