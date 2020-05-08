using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy
{
    public class PolandTaxStrategy : ITaxStrategy
    {
        public string CurrencySymbol => "pln";

        public decimal ToCalculateCIT(decimal amount)
        {
            return amount * 0.12m;
        }

        public decimal ToCalculatePIT(decimal amount)
        {
            return amount * 0.18m;
        }

        public decimal ToCalculateVat(decimal amount)
        {
            return amount * 0.23m;
        }
    }
}
