using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;
using Campus.Entities.Activities;
using Microsoft.EntityFrameworkCore;

namespace Campus.Persistence
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly CampusContext context;

        public NotificationRepository(CampusContext context)
        {
            this.context = context;
        }
        public async Task<Notification> GetNotificationById(Guid id)
        {
            return await context.Notification
                .FirstAsync(s => s.Id == id);
        }
        public void Delete(Notification notification)
        {
            context.Notification.Remove(notification);
        }
        public async Task Create(Notification notification)
        {
            await this.context.Notification.AddAsync(notification);
        }
        public void Update(Notification notification)
        {
            this.context.Notification.Update(notification);
        }
        public async Task SaveChanges()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
