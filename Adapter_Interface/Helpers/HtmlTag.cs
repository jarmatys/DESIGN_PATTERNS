using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Interface.Helpers
{
    public class HtmlTag
    {
        // klasa którą będziemy adoptować aby mógł ją przyjąć Writer
        public string Name { get; set; }
        public string Content { get; set; }

        public HtmlTag(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public string ToHtml()
        {
            return $"<{Name}>{Content}</{Name}>";
        }
    }
}
