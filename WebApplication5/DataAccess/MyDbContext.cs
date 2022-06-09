using Microsoft.EntityFrameworkCore;
using WebApplication5.Configuration;
using WebApplication5.Models.DBModels;

namespace WebApplication5.DataAccess
{
    public class MyDbContext : DbContext
    {

        public DbSet<MusicianDbModel> Musicians { get; set; }
        public DbSet<MusicianTrackDbModel> MusicianTracks { get; set; }
        public DbSet<TrackDbModel> Tracks { get; set; }
        public DbSet<AlbumDbModel> Albums { get; set; }
        public DbSet<MusicLabelDbModel> MusicLabels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusicianConf).Assembly);
        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }


    }
}
