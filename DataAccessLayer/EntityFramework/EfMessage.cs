using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Entity;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetListByMessage(int id)
        {
            using (var value = new Context())
            {
                return value.Messagess.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }
        public List<Message> GetWriterByID(int id)
        {
            using(var value=new Context())
            {
                return value.Messagess.Include(x => x.SenderUser).Where(x => x.MessageID == id).ToList();
            }
        }
    }
}
