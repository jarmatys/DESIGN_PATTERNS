using Adapter_Class.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Class.Adapter
{
    // Adapter musi dziedziczyć po klasie którą będzie adaptował
    public class HtmlAdapter : HtmlCode
    {
        // konstruktor przyjmuje obiekt do adaptacji (HtmlTag) i przekazuje go do klasy po której dziedziczy (HtmlCode)
        public HtmlAdapter(HtmlTag htmlTag) : base(htmlTag.ToHtml()) { }
    }
}
