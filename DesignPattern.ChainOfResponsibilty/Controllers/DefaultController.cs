using DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty;
using DesignPattern.ChainOfResponsibilty.Dal;
using DesignPattern.ChainOfResponsibilty.datareit;
using DesignPattern.ChainOfResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.Controllers
{

    public class DefaultController : Controller
    {
       
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)  
        {
            Employee Treasurer = new Treasurer();
            Employee Manager = new Manager();
            Employee ManagerAssistant = new ManagerAssistant();
            Employee AreaDirector = new AreaDirector();

            Treasurer.SetNextApprover(ManagerAssistant);
            ManagerAssistant.SetNextApprover(Manager);
            Manager.SetNextApprover(AreaDirector);

            Treasurer.ProcessRequest(model);
            return View();
        }
        [HttpGet]



        public IActionResult List()
        {
            DataRetriever dataRetriever = new DataRetriever();
            var customerProcesses = dataRetriever.GetCustomerProcessesFromDatabase();
            return View(customerProcesses);

        }
    }
}
