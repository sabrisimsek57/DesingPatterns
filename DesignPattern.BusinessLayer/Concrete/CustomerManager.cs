using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal customerDal;
        private readonly IUowDal uowDal ;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            this.customerDal = customerDal;
            this.uowDal = uowDal;
        }

        public void TDelete(Customer t)
        {
            customerDal.Delete(t);
            uowDal.Save();
        }

        public Customer TGetByID(int id)
        {
            return customerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return customerDal.GetList();   
        }

        public void TInsert(Customer t)
        {
           customerDal.Insert(t);
            uowDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
           customerDal.MultiUpdate(t);  
            uowDal.Save();
        }

        public void TUpdate(Customer t)
        {
           customerDal.Update(t);   
            uowDal.Save();
        }
    }
}
