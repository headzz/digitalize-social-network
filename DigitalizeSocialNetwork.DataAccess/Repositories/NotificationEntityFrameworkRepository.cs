using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DataAccess.Contexts;
using DigitalizeSocialNetwork.DomainModel.Entities;
using DigitalizeSocialNetwork.DomainModel.Interfaces.Repositories;

namespace DigitalizeSocialNetwork.DataAccess.Repositories
{
    public class NotificationEntityFrameworkRepository : INotificationRepository
    {
        public void Create(Notification notification)
        {
            var notificationContext = new SocialNetworkContext();
            notificationContext.Notifications.Add(notification);
            notificationContext.SaveChanges();
        }

        public IEnumerable<Notification> ReadAll(Profile recipient)
        {
            var notificationContext = new SocialNetworkContext();
            return notificationContext.Notifications;
        }
    }
}
