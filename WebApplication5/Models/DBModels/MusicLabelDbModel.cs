namespace WebApplication5.Models.DBModels
{
    public class MusicLabelDbModel
    {
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }

        //

        public virtual ICollection<AlbumDbModel> Albums{ get; set; }
    }
}
