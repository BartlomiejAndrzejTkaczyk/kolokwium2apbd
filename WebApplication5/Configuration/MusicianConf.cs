using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Configuration
{
    public class MusicianConf : IEntityTypeConfiguration<MusicianDbModel>
    {
        public void Configure(EntityTypeBuilder<MusicianDbModel> builder)
        {
            builder
                .HasKey(m => m.IdMusician);

            builder
                .Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Nickname)
                .HasMaxLength(20);
        }
    }
}
