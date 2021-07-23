using System;
using Campus.Entities;
using Campus.Entities.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;
namespace Campus.Persistence
{
	public sealed class CampusContext : DbContext
	{

		public CampusContext(DbContextOptions<CampusContext> options) : base(options)
        {
            Database.Migrate();
        }

		public CampusContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasOne<TypesUsers>(user => user.TypesUsers)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<TypesUsers>()
	            .Property(s=>s.IdUsers)
	            .IsRequired()
	            .ValueGeneratedNever();

            /*modelBuilder.Entity<Posts>()
	            .HasOne<TypesPosts>(user => user.TypesPosts)
	            .WithOne()
	            .OnDelete(DeleteBehavior.Cascade);
            
            
            modelBuilder.Entity<TypesPosts>()
	            .Property(s => s.IdPosts)
	            .IsRequired()
	            .ValueGeneratedNever();
            */

            modelBuilder.Entity<Posts>()
	            .HasMany<Comments>(user => user.Comments)
	            .WithOne()
	            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comments>()
	            .Property(s => s.Id)
	            .IsRequired()
	            .ValueGeneratedNever();


            modelBuilder.Entity<Posts>()
	            .HasMany<Review>(user => user.Reviews)
	            .WithOne()
	            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Review>()
	            .Property(s => s.Id)
	            .IsRequired()
	            .ValueGeneratedNever();




			/*modelBuilder.Entity<Notifications>()
	            .HasOne<Posts>(user => user.Posts)
	            .WithOne()
	            .OnDelete(DeleteBehavior.Cascade);
			
            */
			modelBuilder.Entity<Posts>()
				.Property(s => s.Id)
				.IsRequired()
				.ValueGeneratedNever();
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<TypesUsers> TypesUsers { get; set; }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

        public DbSet<Review> Review { get; set; }

       // public DbSet<Notifications> Notifications { get; set; }

    }
}
