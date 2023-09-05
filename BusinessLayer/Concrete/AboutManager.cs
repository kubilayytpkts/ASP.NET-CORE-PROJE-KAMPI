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
        public List<About> ListAboutAll()
        {
           return ıAboutDal.GetListAll();
        }
    }
}
