using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public class UltraPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string Plantype(string plantype)
        {
            return plantype;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string Resolution)
        {
            return Resolution;
        }
    }
}
