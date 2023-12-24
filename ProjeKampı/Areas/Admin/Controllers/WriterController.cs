using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office.CustomUI;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjeKampı.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;

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

        [HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(WriterModelForImage writer)
        {
            Writer mainWriter = new Writer();
            if(writer.WriterImage !=null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/web/images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                mainWriter.WriterImage = newImageName;

            }
            mainWriter.WriterName = writer.WriterName;
            mainWriter.WriterAbout = writer.WriterAbout;
            mainWriter.WriterPassword = writer.WriterPassword;
            mainWriter.WriterMail = writer.WriterMail;
            mainWriter.WriterStatus = true;
            writerManager.Add(mainWriter);
            
            return View();
        }
    }
}
