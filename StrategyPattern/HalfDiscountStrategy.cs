using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class HalfDiscountStrategy : IPromotedStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.5;
        }
    }
}
