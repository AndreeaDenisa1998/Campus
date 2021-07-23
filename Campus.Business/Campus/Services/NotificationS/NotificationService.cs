using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Campus.Business.Campus.Models.Notifications;
using Campus.Business.Campus.Models.Reviews;
using Campus.Entities;
using Campus.Entities.Activities;
using Campus.Persistence;

namespace Campus.Business.Campus.Services.NotificationS
{
    public class NotificationService
    {
        private readonly INotificationRepository notificationRepository;
        private readonly IMapper mapper;
        public NotificationService(INotificationRepository notificationRepository, IMapper mapper)
        {
            this.notificationRepository = notificationRepository;
            this.mapper = mapper;
        }
        public async Task<NotificationModel> GetById(Guid id)
        {
            var notification = await notificationRepository.GetNotificationById(id);
            return mapper.Map<NotificationModel>(notification);
        }
        public async Task<NotificationModel> Create(CreateNotificationModel model)
        {
            var notification = this.mapper.Map<Notification>(model);

            await this.notificationRepository.Create(notification);

            await this.notificationRepository.SaveChanges();

            return mapper.Map<NotificationModel>(notification);
        }
        public async Task Delete(Guid reviewId)
        {
            var notification = await notificationRepository.GetNotificationById(reviewId);

            notificationRepository.Delete(notification);

            await notificationRepository.SaveChanges();
        }
        public async Task Update(Guid reviewId, CreateNotificationModel model)
        {
            var notification = await notificationRepository.GetNotificationById(reviewId);

            mapper.Map(model, notification);

            notificationRepository.Update(notification);

            await notificationRepository.SaveChanges();
        }


    }
}

