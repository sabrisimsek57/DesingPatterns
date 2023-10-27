using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAcsessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
