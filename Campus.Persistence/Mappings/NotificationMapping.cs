using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;
using Campus.Entities.Activities;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence.Mappings
{
    class NotificationMapping
    {
        internal abstract class NotificationMappings
        {
            internal static void Map(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Notification>(entity =>
                {
                    entity.Property(c => c.Id)
                        .HasColumnName("IdNotification")
                        .IsRequired();

                    entity.Property(c => c.Content)
                        .HasColumnName("Content")
                        .IsRequired();
                });
            }
        }
    }
}
