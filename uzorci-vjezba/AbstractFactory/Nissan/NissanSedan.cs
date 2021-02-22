using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory.Nissan
{
    public class NissanSedan : ISedan
    {
        public string doSomething()
        {
            return "A Nissan Sedan, Go!";
        }
    }
}
