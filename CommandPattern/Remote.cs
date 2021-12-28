using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Remote
    {
        private readonly ICommand _turnOnCommand;
        private readonly ICommand _turnOffCommand;

        public Remote(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            _turnOnCommand = turnOnCommand;
            _turnOffCommand = turnOffCommand;
        }

        public void TurnOnButtonClick()
        {
            _turnOnCommand.Excute();
        }

        public void TurnOffButtonClick()
        {
            _turnOffCommand.Excute();
        }
    }
}
