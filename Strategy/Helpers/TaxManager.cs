using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Helpers
{
    public class TaxManager : ITaxManager
    {
        public ITaxStrategy TaxStrategy { get; set; }

        public TaxManager(ITaxStrategy taxStrategy)
        {
            TaxStrategy = taxStrategy;
        }

        public string Income(decimal netto)
        {
            netto = decimal.Round(netto, 2);
            decimal pit = TaxStrategy.ToCalculatePIT(netto);
            return $"{netto - pit} {TaxStrategy.CurrencySymbol}";
        }

        public string Brutto(decimal netto)
        {
            netto = decimal.Round(netto, 2);
            decimal vat = TaxStrategy.ToCalculateVat(netto);
            return $"{netto - vat} {TaxStrategy.CurrencySymbol}";

        }
    }
}
