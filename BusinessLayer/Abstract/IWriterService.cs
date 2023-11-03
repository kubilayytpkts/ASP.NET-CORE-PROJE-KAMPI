using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        public List<Writer> GetWriterById(int id);
    }
}
