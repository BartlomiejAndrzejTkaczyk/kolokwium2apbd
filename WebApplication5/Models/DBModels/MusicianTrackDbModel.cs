namespace WebApplication5.Models.DBModels
{
    public class MusicianTrackDbModel
    {
        public int IdTrack { get; set; }
        public int IdMusician { get; set; }

        //

        public virtual MusicianDbModel TheMusician { get; set; }
        public virtual TrackDbModel TheTrack { get; set; }
    }
}
