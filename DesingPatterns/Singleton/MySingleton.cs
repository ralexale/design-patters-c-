using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class MySingleton
    {
        private static MySingleton _instance;

        // añadir un Guid para identificar la instancia
        public Guid Id { get; private set; }

        /* es importante que el contructor sea privado
         * esto nos permite controlar la creacion de instancias, 
         * para que no se sobreescriba la instancia ya creada
         */

        private MySingleton()
        {
            Id = Guid.NewGuid();
        }


        /*
         * Metodo que nos permite obtener la instancia de la clase
         */
        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }

        /*
         * Resumen, creamos una clase con un constructor privado y un método
         * que nos permite obtener la instancia de la clase, si la instancia
         * ya esta creada la retorna, si no la crea y la retorna.
         */
    }
}
