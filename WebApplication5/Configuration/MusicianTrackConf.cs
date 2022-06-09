using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Configuration
{
    public class MusicianTrackConf : IEntityTypeConfiguration<MusicianTrackDbModel>
    {
        public void Configure(EntityTypeBuilder<MusicianTrackDbModel> builder)
        {
            builder
                .HasKey(mt => new { mt.IdTrack, mt.IdMusician });
            
            //

            builder
                .HasOne(mt => mt.TheMusician)
                .WithMany(m => m.MusicianTracks);

            builder
                .HasOne(mt => mt.TheTrack)
                .WithMany(t => t.MusicianTracks);
        }
    }
}
