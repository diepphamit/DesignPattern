using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class TurnOnCommand : ICommand
    {
        private readonly Fan _fan;
        public TurnOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Excute()
        {
            _fan.TurnOn();  
        }

        public void Undo()
        {
            _fan.TurnOff(); 
        }
    }
}
