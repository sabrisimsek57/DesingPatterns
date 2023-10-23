using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAcsessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal ;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            categoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
           categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
           categoryDal.Update(t);
        }
    }
}
