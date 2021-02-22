using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Command
{
    public interface ICommand
    {
        void execute();
        void undo();
    }
}
