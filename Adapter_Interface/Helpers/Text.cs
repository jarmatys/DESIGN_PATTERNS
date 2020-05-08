using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Interface.Helpers
{
    public class Text : IText
    {
        public Text(ConsoleColor color, string content)
        {
            Color = color;
            Content = content;
        }

        public ConsoleColor Color { get; set; }
        public string Content { get; set; }
    }
}
