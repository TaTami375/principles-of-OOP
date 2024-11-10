using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_SOLID
{
    internal class OpenClosedPrinciple
    {
        public abstract class Discount
        {
            public abstract decimal Calculate(decimal totalAmount);
        }

        public class PercentageDiscount : Discount
        {
            private readonly decimal _percentage;

            public PercentageDiscount(decimal percentage)
            {
                _percentage = percentage;
            }

            public override decimal Calculate(decimal totalAmount)
            {
                return totalAmount - (totalAmount * _percentage / 100);
            }
        }

        public class FixedAmountDiscount : Discount
        {
            private readonly decimal _amount;

            public FixedAmountDiscount(decimal amount)
            {
                _amount = amount;
            }

            public override decimal Calculate(decimal totalAmount)
            {
                return totalAmount - _amount;
            }
        }
    }
}
