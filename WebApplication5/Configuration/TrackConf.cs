using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Configuration
{
    public class TrackConf : IEntityTypeConfiguration<TrackDbModel>
    {
        public void Configure(EntityTypeBuilder<TrackDbModel> builder)
        {
            builder
                .HasKey(t => t.IdTrack);

            builder
                .Property(t => t.TrackName)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(t => t.Duration)
                .IsRequired();
        }
    }
}
