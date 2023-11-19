using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjeKampı.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllNotification()
        {
           var  notificationList = notificationManager.ListAll();
            foreach (var item in notificationList)
            {
                if(item.NotificationDate != null)
                {
                   var gecenSure=System.DateTime.Now - item.NotificationDate;
                   double gecenGun =(int)gecenSure.TotalDays;
                    if(gecenGun==0)
                    {
                        var gecenSaat = (int)gecenSure.TotalHours;
                        item.GecenSure = gecenSaat;
                        item.DaysOrHours = "Hour";
                    }
                    else
                    {
                        item.GecenSure = (int)gecenGun;
                        item.DaysOrHours = "Day";
                    }

                }
            }
            return View(notificationList);
        }

    }
}
