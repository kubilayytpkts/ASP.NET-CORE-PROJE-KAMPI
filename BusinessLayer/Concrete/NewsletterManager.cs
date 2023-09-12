using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Migrations;
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

        public void Add(NewsLetter newsLetter)
        {
            newsletterDal.Insert(newsLetter);
        }

        public void Delete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
