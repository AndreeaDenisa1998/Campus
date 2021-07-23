using Campus.Entities.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Persistence
{
    public interface INotificationRepository
    {
        Task<Notification> GetNotificationById(Guid id);
        Task Create(Notification notification);
        Task SaveChanges();
        void Delete(Notification notification);
        void Update(Notification notification);
    }
}
