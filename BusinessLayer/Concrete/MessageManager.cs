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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal MessageDal)
        {
            _messageDal=MessageDal; 
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {

            return _messageDal.GetById(id);
        }

        public List<Message> ListAll()
        {
           return _messageDal.GetListAll();
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListByMessage(int id)
        {
            return _messageDal.GetListByMessage(id);
        }

        List<Message> IGenericService<Message>.ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetWriterByID(int id)
        {
            return _messageDal.GetWriterByID(id);
        }
    }
}
