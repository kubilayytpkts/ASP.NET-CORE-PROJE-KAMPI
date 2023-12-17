using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjeKampı.Areas.Admin.Models;
using System.Collections.Generic;

namespace ProjeKampı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var result = writerManager.ListAll();

            List<WritersModel> writersModels = new List<WritersModel>();
            foreach (var item in result)
            {
                writersModels.Add(new WritersModel
                {
                    ID = item.WriterID,
                    Name = item.WriterName
                });
            }
            


            var jsonResult = JsonConvert.SerializeObject(writersModels);
            return Json(jsonResult);
        }

        public List<WritersModel> writers = new List<WritersModel>()
        {
            new WritersModel()
            {
                ID= 1,
                Name="Şeyma"
            },
            new WritersModel()
            {
                ID=2,
                Name="Kubilay",
            },
            new WritersModel()
            {
                ID=3,
                Name="Esma"
            }
        };
    }
}
