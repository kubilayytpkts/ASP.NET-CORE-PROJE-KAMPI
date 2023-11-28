using DataAccessLayer.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjeKampı.Controllers
{
    public class WriterLogınController : Controller
    {

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();
            var userData = context.Writers.FirstOrDefault(x => x.WriterPassword == writer.WriterPassword && x.WriterMail == writer.WriterMail);
            if (userData != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, writer.WriterMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            else
                return View();
        }
        public int GetByUserID()
        {
            var context = new Context();
            var userMail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == userMail).
                                       Select(y => y.WriterID).FirstOrDefault();
            return writerID;
        }
    }
}
