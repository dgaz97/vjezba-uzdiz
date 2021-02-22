using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory.Nissan
{
    public class NissanSportsCar : ISportsCar
    {
        public string doSomethingElse()
        {
            return "A Nissan Sports car, Go fast!";
        }
    }
}
