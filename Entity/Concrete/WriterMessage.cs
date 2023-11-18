using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int MessageID { get; set; }
        public string Sender { get; set; }
        public string Receiver  { get; set; }
        public string Subject { get; set; }
        public string MessageDetails{ get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }


    }
}
