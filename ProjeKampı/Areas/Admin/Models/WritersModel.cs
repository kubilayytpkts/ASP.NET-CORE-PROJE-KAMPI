using Microsoft.AspNetCore.Http;

namespace ProjeKampı.Areas.Admin.Models
{
    public class WritersModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    public class WriterModelForImage 
    {
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
