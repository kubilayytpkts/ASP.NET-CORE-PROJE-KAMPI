using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal notificationDal;

        public NotificationManager(INotificationDal _notificationDal)
        {
            notificationDal = _notificationDal;
        }

        public void Add(Notification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> ListAll()
        {
           return notificationDal.GetListAll();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
