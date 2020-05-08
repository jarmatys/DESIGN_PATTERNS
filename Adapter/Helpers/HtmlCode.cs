using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Class.Helpers
{
    public class HtmlCode
    {
        public string Html { get; set; }
        public HtmlCode(string html)
        {
            Html = html;
        }
    }
}
