using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjeKampı.Controllers
{
    public class UserIdentity : Controller
    {
        public int UserID()
        {
            var context = new Context();
            var userMail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == userMail).
                                       Select(y => y.WriterID).FirstOrDefault();
            return writerID;
        }
    }
}
