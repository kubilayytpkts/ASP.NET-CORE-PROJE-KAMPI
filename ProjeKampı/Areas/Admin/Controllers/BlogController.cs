using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeKampı.Areas.Admin.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjeKampı.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.ID;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "blog1.xlsx");
                }
            };
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> blogModelList = new List<BlogModel>();
            using (Context context = new Context())
            {
               blogModelList=(context.Blogs.Select(x => new BlogModel
                {
                    ID=x.BlogID,
                    BlogName=x.BlogTitle
                }).ToList());
            }
            return blogModelList;
        }
    }
}
