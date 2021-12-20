using DecoratorPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Pizza : IPizza
    {
        public string doPizza()
        {
            return "Pizza";
        }
    }
}
