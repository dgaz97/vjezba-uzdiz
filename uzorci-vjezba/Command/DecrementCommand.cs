using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Command
{
    public class DecrementCommand : ICommand
    {
        private Receiver _receiver;
        public DecrementCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void execute()
        {
            _receiver.decrement();
        }
        public void undo()
        {
            _receiver.increment();
        }
    }
}
