using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.Dal
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public String Name { get; set; }
        public String Amount { get; set; }
        public String EmployeeName { get; set; }
        public String Description { get; set; }
    }
}
