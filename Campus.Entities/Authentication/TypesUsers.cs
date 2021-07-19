using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Entities
{
	public sealed class TypesUsers:Entity
	{
		public TypesUsers(string type) : base()
		{

			Type = type;
			//0-super admin, 1-admin owner, 2-user
		}
		
	[Required]
	public string Type { get; private set; }

	public Collection<Users> Users { get; private set; }


	}

}
