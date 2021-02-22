using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Command
{
    public class IncrementCommand : ICommand
    {
        private Receiver _receiver;
        public IncrementCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void execute()
        {
            _receiver.increment();
        }
        public void undo()
        {
            _receiver.decrement();
        }
    }
}
