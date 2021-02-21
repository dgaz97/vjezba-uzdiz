using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.FactoryMethod.Abstractions;
using uzorci_vjezba.FactoryMethod.Products;

namespace uzorci_vjezba.FactoryMethod.Creators
{
    public class TenSpammerCreator : AbstractCreator
    {
        public override ISpammer CreateSpammer()
        {
            return new TenSpammer();
        }
    }
}
