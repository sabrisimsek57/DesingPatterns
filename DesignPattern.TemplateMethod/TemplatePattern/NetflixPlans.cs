using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.TemplatePattern
{
    public abstract  class NetflixPlans
    {
        public void CreatePlan()
        {
            Plantype(string.Empty);
            CountPerson(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }

        public abstract string Plantype (string plantype );
        public abstract int CountPerson (  int countPerson );
        public abstract double Price ( double price );
        public abstract string Resolution(string Resolution);
        public abstract string Content (string content);
    }
}
