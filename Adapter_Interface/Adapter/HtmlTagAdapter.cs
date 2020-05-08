using Adapter_Interface.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Interface.Adapter
{
    // 1. adapter musi dziedziczyć po intefejsie który jest przyjmowany w Writerze
    public class HtmlTagAdapter : IText
    {
        // 2. implementujemy logikę adaptera 

        public HtmlTagAdapter(HtmlTag tagHtml, ConsoleColor color)
        {
            Color = color;
            Content = tagHtml.ToHtml();
        }

        // 3. Te property muszą zostać uzupełnione z konstruktora
        public ConsoleColor Color { get; set; }
        public string Content { get; set; }
    }
}
