using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.Models
{
    public class CustomerProcessViewModel
    {
        public int CustomerProcessID { get; set; }
        public String Name { get; set; }
        public int Amount { get; set; }
        public String EmployeeName { get; set; }
        public String Description { get; set; }
    }
}
