using Campus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Persistence.Mappings
{
    internal abstract class UserMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasMany(u => u.Comments)
                    .WithOne(a => a.Users)
                    .HasForeignKey(u => u.IdUsers);
                entity.HasMany(u => u.Reviews)
                    .WithOne(r => r.Users)
                    .HasForeignKey(u => u.IdUsers);
            });
        }
    }
}