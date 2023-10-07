using DesignPattern.ChainOfResponsibilty.Dal;
using DesignPattern.ChainOfResponsibilty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name.ToString();
                customerProcess.EmployeeName = "Şube Müdür Yardımıcısı - Ayhan Çınar";
                customerProcess.Description = "Para çekme işlemi onaylandı, Müşteriye Talep Ettigi tutar ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();

                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name.ToString();
                customerProcess.EmployeeName = "Şube Müdür Yardımıcısı - Ayhan Çınar";
                customerProcess.Description = "Para çekme tutarı Şube Müdür Yardımıcısının günlük para çekem tutarından fazla olduğu için işlem şube müdürüne yönlendirilmiştir";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
