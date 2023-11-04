using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;
        public WriterManager(IWriterDal _writerDal)
        {
            writerDal = _writerDal;
        }

        public void Add(Writer writer)
        {
            writerDal.Insert(writer);
        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return writerDal.GetListAll(x => x.WriterID == id);
        }

        public List<Writer> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}
