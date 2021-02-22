using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory.Hyundai
{
    public class HyundaiFactory : CarFactory
    {
        public ISedan createSedan()
        {
            return new HyundaiSedan();
        }

        public ISportsCar createSportsCar()
        {
            return new HyundaiSportsCar();
        }
    }
}
