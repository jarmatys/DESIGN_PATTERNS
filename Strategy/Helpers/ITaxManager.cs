using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Helpers
{
    public interface ITaxManager
    {
        ITaxStrategy TaxStrategy { get; set; }
        string Income(decimal netto);
        string Brutto(decimal netto);
    }
}
