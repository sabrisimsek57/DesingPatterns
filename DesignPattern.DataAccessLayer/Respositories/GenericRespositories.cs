using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.Respositories
{
    public class GenericRespositories<T> : IGenericDal<T> where T : class
    {
        private readonly Context context;

        public GenericRespositories(Context context)
        {
            this.context = context;
        }

        public void Delete(T t)
        {
            context.Remove(t);
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            context.UpdateRange(t);
        }

        public void Update(T t)
        {
            context.Update(t);
        }
    }
}
