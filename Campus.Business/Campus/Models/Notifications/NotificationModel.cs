using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Business.Campus.Models.Notifications
{
    public class NotificationModel
    {
        public Guid Id { get; set; }
        public string Content { get; private set; }

    }
}
