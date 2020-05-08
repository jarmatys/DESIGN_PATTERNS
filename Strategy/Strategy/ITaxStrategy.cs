using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategy
{
    public interface ITaxStrategy
    {
        string CurrencySymbol { get; }
        decimal ToCalculateVat(decimal amount);
        decimal ToCalculatePIT(decimal amount);
        decimal ToCalculateCIT(decimal amount);
    }
}
