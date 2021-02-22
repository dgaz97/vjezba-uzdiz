using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzorci_vjezba.Command
{
    public class Invoker
    {
        private Stack<ICommand> commands;
        private ICommand incCommand;
        private ICommand decCommand;

        public Invoker()
        {
            commands = new Stack<ICommand>();
        }
        public void setIncrementCommand(ICommand command)
        {
            incCommand = command;
        }

        public void setDecrementCommand(ICommand command)
        {
            decCommand = command;
        }

        public void undoAll()
        {
            ICommand cmd;
            while (commands.Count != 0)
            {
                cmd = commands.Pop();
                cmd.undo();
            }
        }

        public void addRequest()
        {
            incCommand.execute();
            commands.Push(incCommand);
        }
        public void removeRequest()
        {
            decCommand.execute();
            commands.Push(decCommand);
        }
        public void commit()
        {
            commands = new Stack<ICommand>();
        }
    }
}
