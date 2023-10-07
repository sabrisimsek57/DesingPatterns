using DesignPattern.ChainOfResponsibilty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
