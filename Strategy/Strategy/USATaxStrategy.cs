using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy
{
    public class USATaxStrategy : ITaxStrategy
    {
        public string CurrencySymbol => "usd";

        public decimal ToCalculateCIT(decimal amount)
        {
            return amount * 0.1m;
        }

        public decimal ToCalculatePIT(decimal amount)
        {
            return amount * 0.2m;
        }

        public decimal ToCalculateVat(decimal amount)
        {
            return amount * 0.19m;
        }
    }
}
