using DesignPattern.ChainOfResponsibilty.Dal;
using DesignPattern.ChainOfResponsibilty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name.ToString();
                customerProcess.EmployeeName = "Bölge Müdürü - Esma Yıldız";
                customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye Talep Ettigi tutar ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name.ToString();
                customerProcess.EmployeeName = "Bölge Müdürü - Esma Yıldız";
                customerProcess.Description = "Para çekme tutarı Şube Müdürünün günlük para çekem tutarından fazla olduğu için işlem gerçekleştirilemedi, Müşterinin Günlük İşlem Limiti 400000 TL olup daha fazlası için birden fazla gün para çekme işlemi yapması gerekmektedir.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
