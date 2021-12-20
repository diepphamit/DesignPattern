using DecoratorPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    internal class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string doPizza()
        {
            return mPizza.doPizza() + " + Pepper";
        }
    }
}
