using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance;
        // usamos el objeto _lock para sincronizar el acceso a la instancia
        private static readonly object _lock = new object();

        private SingletonThreadSafe()
        {
        }

        public static SingletonThreadSafe GetInstace()
        {
            if (_instance == null)
            {
                // con el lock nos aseguramos que solo un hilo pueda acceder a la instancia
                // a la vez
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                    }
                }
            }
            return _instance;
        }
    }
}
