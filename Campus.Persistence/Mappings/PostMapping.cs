﻿using Campus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities.Activities;

namespace Campus.Persistence.Mappings
{
    internal abstract class PostMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasMany(u => u.Comments)
                    .WithOne(a => a.Posts)
                    .HasForeignKey(u => u.IdPosts);
                entity.HasMany(u => u.Reviews)
                    .WithOne(r => r.Posts)
                    .HasForeignKey(u => u.IdPosts);
                entity.HasOne(u => u.Notification)
                    .WithOne(n => n.Posts)
                    .HasForeignKey<Notification>(d => d.IdPosts);

            });
        }
    }
}