using Campus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Persistence.Mappings
{
    internal abstract class ReviewMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(c => c.Id)
                    .HasColumnName("IdPosts")
                    .IsRequired();

                entity.Property(c => c.Content)
                    .HasColumnName("Content")
                    .IsRequired();
                entity.Property(c => c.NumberOfStars)
                    .HasColumnName("NumberOfStars")
                    .IsRequired();
                entity.Property(c => c.NumberOfLikes)
                    .HasColumnName("numberOfLikes")
                    .IsRequired();
                entity.Property(c => c.Date)
                    .HasColumnName("Date")
                    .IsRequired();
            });
        }
    }
}