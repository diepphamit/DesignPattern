using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Base
{
    internal abstract class PizzaDecorator : IPizza
    {
        protected IPizza mPizza { get; set; }
        public PizzaDecorator(IPizza pizza)
        {
            mPizza = pizza;
        }

        public virtual string doPizza()
        {
            return mPizza.doPizza();
        }
    }
}
