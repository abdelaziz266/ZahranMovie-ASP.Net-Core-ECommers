using Microsoft.EntityFrameworkCore;
using ZahranMovie.Models;

namespace ZahranMovie.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.MovieId,
                am.ActoreId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(am => am.Actor_Movie).HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(am => am.Actor_Movie).HasForeignKey(am => am.ActoreId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
