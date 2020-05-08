using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Helpers
{
    public class Product : IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // 1. ustawiamy seter na danej propercie tak aby najpierw przy przypisywaniu następowało sprawdzanie czy dany kolor jest już na liście
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!_sharedColor.Contains(value))
                {
                    _sharedColor.Add(value);
                }
                // ustawiamy wartość z naszej listy, aby nie tworzyć nowego miejsca w pamięci na nowy kolor
                _color = _sharedColor.Find(c => c.Equals(value));
            }
        }

        // 2. Tworzymy listę gdzie będą znajdować się wspólne obiekty
        public static List<string> _sharedColor { get; set; } = new List<string>();
        private string _color;

        public Product(int id, string name, string color)
        {
            ID = id;
            Name = name;
            Color = color;
        }

        // 3. Tworzymy statyczną metodę która tworzy instancje klasy
        public static IProduct CreateInstance(int id, string name, string color)
        {
            return new Product(id, name, color);
        }
    }
}
