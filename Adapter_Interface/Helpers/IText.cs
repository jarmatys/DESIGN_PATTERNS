using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Interface.Helpers
{
    public interface IText
    {
        ConsoleColor Color { get; set; }
        string Content { get; set; }
    }
}
