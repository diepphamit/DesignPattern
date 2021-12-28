using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class TurnOffCommand : ICommand
    {
        private readonly Fan _fan;
        public TurnOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Excute()
        {
            _fan.TurnOff();
        }

        public void Undo()
        {
            _fan.TurnOn();
        }
    }
}
