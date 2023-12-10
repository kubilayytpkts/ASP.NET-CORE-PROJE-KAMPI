using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public String Name{ get; set; }
        public string UsarName { get; set; }
        public string password { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }

    }
}
