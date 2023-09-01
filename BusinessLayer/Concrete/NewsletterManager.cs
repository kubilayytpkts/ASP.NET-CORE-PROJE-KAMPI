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
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal newsletterDal;
        public NewsletterManager(INewsletterDal _newsletterDal)
        {
            newsletterDal = _newsletterDal;
        }

        public void add(NewsLetter newsLetter)
        {
            newsletterDal.Insert(newsLetter);
        }
    }
}
