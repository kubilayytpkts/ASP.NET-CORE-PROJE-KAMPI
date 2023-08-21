using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository:GenericRepository<Writer>,IWriterDal
    {
    }
}
