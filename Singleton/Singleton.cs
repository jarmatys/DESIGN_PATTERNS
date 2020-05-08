using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        //1. Prywatna statyczna properta na trzymanie obiektu
        private static Singleton _singleton;

        //2. Obiekt do blokowanie wątków
        private static readonly object _lock = new object();

        //3. Prywatny konstuktor aby móc wywołać go tylko za pomocą dedykowanej metody wewnątrz klasy
        private Singleton() { }

        //4. Metoda do tworzenia instancji klasy
        public static Singleton Instance()
        {
            lock (_lock)
            {
                if(_singleton == null)
                {
                    _singleton = new Singleton();
                }
                return _singleton;
            }
        }

        //5. Obsługa dostępności przez wiele wątków do inkrementacji zmiennej number
        private volatile int _number = 0;

        private static readonly object _lockIncrement = new object();
        public int GetNextNumber()
        {
            lock (_lockIncrement)
            {
                return _number++;
            }
        }
    }
}
