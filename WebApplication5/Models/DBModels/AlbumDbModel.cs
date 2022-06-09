using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models.DBModels
{
    public class AlbumDbModel
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }

        // 

        public int IdMusicLabel { get; set; }

        [ForeignKey("IdMusicLabel")]
        public virtual MusicLabelDbModel TheMusicLabel { get; set; }
        public virtual ICollection<TrackDbModel> Tracks { get; set; }

    }
}
