using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Facade
{
    public class ComponentsFacade
    {
        private FirstComponent first = new FirstComponent();
        private SecondComponent second = new SecondComponent();
        private ThirdComponent third = new ThirdComponent();

        public string executeFirstComponent()
        {
            return first.DoCommand();
        }
        public string executeSecondComponent()
        {
            return second.DoCommand();
        }
        public string executeThirdComponent()
        {
            return third.DoCommand();
        }
    }
}
