using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;

namespace ProjeKampı.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());
        List<Notification> enableNotification = new List<Notification>();
        public IViewComponentResult Invoke()
        {
            
            var value = notificationManager.ListAll();
            foreach (var item in value)
            {
                if(item.NotificationStatus==true)
                {
                    enableNotification.Add(item);
                }
            }
            return View(value);
        }
    }
}
