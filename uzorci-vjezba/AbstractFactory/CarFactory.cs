using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.AbstractFactory.ICars;

namespace uzorci_vjezba.AbstractFactory
{
    public interface CarFactory
    {
        ISedan createSedan();
        ISportsCar createSportsCar();
    }
}
