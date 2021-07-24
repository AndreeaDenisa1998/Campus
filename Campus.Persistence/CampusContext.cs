using System;
using Campus.Entities;
//using Campus.Entities.Activities;
using Microsoft.EntityFrameworkCore;
namespace Campus.Persistence
{
    public sealed class CampusContext : DbContext
    {
        public CampusContext(DbContextOptions<CampusContext> options) : base(options)
        {
            //Database.Migrate();
            //nu gasesc pachetul
        }

        public CampusContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasMany<TypesUsers>(user => user.TypesUsers)
                .WithOne()
                .IsRequired();

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Students> Students { get; set; }

        public DbSet<TypesUsers> TypesUsers { get; set; }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Posts { get; set; }

       // public DbSet<Notification> Notification { get; set; }
        public DbSet<Review> Review { get; set; }

        public DbSet<CafeteriaPost> CafeteriaPost { get; set; }

    }
}
