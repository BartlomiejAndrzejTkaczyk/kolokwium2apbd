using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Configuration
{
    public class AlbumConf : IEntityTypeConfiguration<AlbumDbModel>
    {
        public void Configure(EntityTypeBuilder<AlbumDbModel> builder)
        {
            builder
                .HasKey(a => a.IdAlbum);

            builder
                .Property(a => a.AlbumName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(a => a.PublishDate);

            //

            builder
                .HasOne(a => a.TheMusicLabel)
                .WithMany(ml => ml.Albums);
            
        }
    }
}
