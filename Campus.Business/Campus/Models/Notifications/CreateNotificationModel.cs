using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models.Notifications
{
    public class CreateNotificationModel
    {
        public string Context { get; set; }

        public Guid IdUser { get; set; }
    }
}
