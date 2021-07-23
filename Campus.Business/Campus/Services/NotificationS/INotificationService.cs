using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Campus.Models.Notifications;
using Campus.Business.Campus.Models.Reviews;

namespace Campus.Business.Campus.Services.NotificationS
{
    public interface INotificationService
    {
        Task<NotificationModel> GetById(Guid id);
        Task<NotificationModel> Create(CreateNotificationModel model);

        Task Delete(Guid notificationId);

        Task Update(Guid notificationId, CreateNotificationModel model);
    }
}
