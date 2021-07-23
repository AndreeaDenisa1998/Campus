using Campus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Persistence.Mappings
{
    internal abstract class CommentMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(c => c.Id)
                    .HasColumnName("IdPosts")
                    .IsRequired();

                entity.Property(c => c.Date)
                    .HasColumnName("DateAndTime")
                    .IsRequired();
                entity.Property(c => c.NumberOfLikes)
                    .HasColumnName("NumberOfLikes")
                    .IsRequired();
                entity.Property(c => c.Content)
                    .HasColumnName("Content")
                    .IsRequired();
            });
        }
    }
}