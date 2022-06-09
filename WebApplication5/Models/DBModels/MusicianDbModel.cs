namespace WebApplication5.Models.DBModels
{
    public class MusicianDbModel
    {
        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Nickname { get; set; }

        //

        public virtual ICollection<MusicianTrackDbModel> MusicianTracks { get; set; }
    }
}
