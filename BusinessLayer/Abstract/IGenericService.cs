using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    { 
        void Add(T t);
        void Delete(T t);
        List<T> ListAll();
        T GetById(int id);
        void Update(T t);
    }
}
