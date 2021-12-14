using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class Ticket
	{
		public IPromotedStrategy promotedStrategy { get; set; }
		public string name { get; set; }
		public double price { get; set; }

        public Ticket()
		{

		}

		public Ticket(IPromotedStrategy promotedStrategy)
		{
			this.promotedStrategy = promotedStrategy;
		}

		public double GetPromotedPrice()
		{
			return this.promotedStrategy.DoDiscount(this.price);
		}
	}
}
