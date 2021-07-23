using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;
using Campus.Entities.Authentication;
using Microsoft.EntityFrameworkCore;


namespace Campus.Persistence.Mappings
{
	internal abstract class StudentMapping
	{
		internal static void Map(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Users>(entity =>
			{
				entity.Property(s => s.Id)
					.HasColumnName("Id")
					.IsRequired()
					.ValueGeneratedNever();
				entity.Property(s=>s.UserName)
					.HasColumnName("UserName")
					.HasMaxLength(200)
					.IsRequired()
					.ValueGeneratedNever();
				entity.Property(s => s.Email)
					.HasColumnName("Email")
					.HasMaxLength(200)
					.IsRequired()
					.ValueGeneratedNever();
				entity.Property(s => s.PasswordHash)
					.HasColumnName("Password")
					.HasMaxLength(25)
					.IsRequired()
					.ValueGeneratedNever();
				entity.HasOne(u => u.TypesUsers)
					.WithOne(d => d.Users)
					.HasForeignKey<TypesUsers>(d => d.IdUsers);
				entity.HasMany(s => s.Posts)
					.WithOne(p => p.Users)
					.HasForeignKey(s => s.IdUsers);
				entity.HasMany(s => s.Comments)
					.WithOne(c => c.Users)
					.HasForeignKey(s => s.IdUsers);
				//entity.HasMany(s => s.Notifications)
				//	.WithOne(c => c.Users)
				//	.HasForeignKey(s => s.IdUsers);
				entity.HasMany(s => s.Reviews)
					.WithOne(c => c.Users)
					.HasForeignKey(s => s.IdUsers);
			});
		}
	}
}
