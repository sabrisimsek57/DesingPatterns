using RepositoryDesignPattern.DataAcsessLayer.Abstract;
using RepositoryDesignPattern.DataAcsessLayer.Concrete;
using RepositoryDesignPattern.DataAcsessLayer.Repository;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAcsessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {

        }
    }
}
