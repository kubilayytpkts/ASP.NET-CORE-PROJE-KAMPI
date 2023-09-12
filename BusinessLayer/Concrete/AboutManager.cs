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
    public class AboutManager : IAboutService
    {
        IAboutDal ıAboutDal;
        public AboutManager(IAboutDal _ıAbaoutDal)
        {
            ıAboutDal = _ıAbaoutDal;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> ListAll()
        {
            return ıAboutDal.GetListAll();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
