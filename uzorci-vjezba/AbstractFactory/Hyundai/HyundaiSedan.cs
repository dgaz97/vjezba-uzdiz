using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory.Hyundai
{
    public class HyundaiSedan : ISedan
    {
        public string doSomething()
        {
            return "A Hyundai Sedan, Go!";
        }
    }
}
