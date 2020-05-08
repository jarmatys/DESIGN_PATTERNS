using Adapter_Class.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Adapter_Class
{
    public class HtmlChecker
    {
        public string GetTagName(HtmlCode htmlCode)
        {
            var regex = new Regex(@"^<([a-z-]){1,}>");
            var match = regex.Match(htmlCode.Html);
            return match.Value.Trim('<', '>');
        }
    }
}
