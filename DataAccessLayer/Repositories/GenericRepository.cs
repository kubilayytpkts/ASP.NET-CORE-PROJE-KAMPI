using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using Context context = new();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using Context context = new();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using Context context = new();
           return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using Context context = new();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using Context context = new();
            context.Update(context);
            context.SaveChanges();
        }
    }
}
