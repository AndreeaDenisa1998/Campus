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
	internal abstract class TypesUsersMapping
	{
		internal static void Map(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TypesUsers>(entity =>
			{
				entity.Property(s => s.Id)
					.HasColumnName("Id")
					.IsRequired()
					.ValueGeneratedNever();
			});
		}
	}
}

