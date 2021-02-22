using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory.Nissan
{
    public class NissanFactory : CarFactory
    {
        public ISedan createSedan()
        {
            return new NissanSedan();
        }

        public ISportsCar createSportsCar()
        {
            return new NissanSportsCar();
        }
    }
}
