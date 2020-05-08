using Adapter_Class;
using Adapter_Class.Adapter;
using Adapter_Class.Helpers;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. nasza klasa, której chcemy użyć
            var html = new HtmlChecker();

            // 2. klasa do adaptacji
            var htmlTag = new HtmlTag("div", "content");

            // 3. adapter, który przyjmuje HtmlTag i oddaje HtmlCode który jest juz przyjmowany przez HtmlCheckera
            var htmlAdapter = new HtmlAdapter(htmlTag);

            // 4. tak zaadaptowaną klasę możemy umieścić w checkerze
            var result = html.GetTagName(htmlAdapter);

            Console.WriteLine(result);
        }
    }
}
