using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities.Authentication;

namespace Campus.Entities
{
	public sealed class TypesUsers:Entity
	{
		
		public TypesUsers(Guid idUser,string type) : base()
		{
			IdUsers = idUser;
			Type = type;
			//0-super admin, 1-admin owner, 2-user
			
		}
		



	[Required]
	public string Type { get; private set; }

	public Guid IdUsers { get; private set; }
	public Users Users { get; set; }
		


	}

}
