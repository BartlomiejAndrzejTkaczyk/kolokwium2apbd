using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Configuration
{
    public class MusicLabelConf : IEntityTypeConfiguration<MusicLabelDbModel>
    {
        public void Configure(EntityTypeBuilder<MusicLabelDbModel> builder)
        {
            builder
                .HasKey(ml => ml.IdMusicLabel);

            builder
                .Property(ml => ml.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
