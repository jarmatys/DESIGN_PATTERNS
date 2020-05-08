using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Interface.Helpers
{
    public class Writer
    {
        public Writer Write(IText text)
        {
            Console.ForegroundColor = text.Color;
            Console.WriteLine(text.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
            return this;
        }
    }
}
