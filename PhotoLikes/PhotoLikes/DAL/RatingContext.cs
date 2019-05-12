using PhotoLikes.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PhotoLikes.DAL
{
    public class RatingContext : DbContext
    {

        public RatingContext() : base("RatingContext")
        {
        }

        public DbSet<PhotoRating> PhotoRatings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}