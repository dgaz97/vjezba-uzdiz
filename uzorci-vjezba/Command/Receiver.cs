using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Command
{
    public class Receiver
    {
        private int value;
        public Receiver()
        {
            value = 0;
        }
        public void increment() {
            value++;
        }
        public void decrement()
        {
            value--;
        }

        public int getValue()
        {
            return value;
        }
    }
}
