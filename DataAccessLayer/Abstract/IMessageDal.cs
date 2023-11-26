using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessageDal:IGenericDal<Message>
    {
        List<Message> GetListByMessage(int id);
        List<Message> GetWriterByID(int id);

    }
}
