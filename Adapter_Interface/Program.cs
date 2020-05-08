using Adapter_Interface.Adapter;
using Adapter_Interface.Helpers;
using System;

namespace Adapter_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Obiekt do którego będziemy chcieli umieścić HtmlTag w kolorze
            var w = new Writer();

            // 2. Tworzymy html tag
            var htmlTag = new HtmlTag("div", "content");

            // 3. Adaptujemy go pod Writera
            var adapter = new HtmlTagAdapter(htmlTag, ConsoleColor.Red);

            // 4. Przekazujemy do writera
            w.Write(adapter);
        }
    }
}
