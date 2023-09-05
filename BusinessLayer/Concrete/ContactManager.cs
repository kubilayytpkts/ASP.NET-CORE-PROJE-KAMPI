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
	public class ContactManager : IContactService
	{
		IContactDal ıContactDal;
        public ContactManager(IContactDal _ıContactdal)
        {
			ıContactDal = _ıContactdal;
        }
        public void ContactAdd(Contact contact)
		{
			ıContactDal.Insert(contact);
		}
	}
}
