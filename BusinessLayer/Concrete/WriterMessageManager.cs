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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;
        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal=writerMessageDal; 
        }

        public void Add(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void Delete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> ListAll()
        {
           return _writerMessageDal.GetListAll();
        }

        public void Update(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> WriterMessageByWriter(string value)
        {
           return _writerMessageDal.GetListAll(x => x.Receiver == value);
        }
    }
}
