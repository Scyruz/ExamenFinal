using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalP
{
    class Program
    {
        static void Main(string[] args)
        {
            Nombre nombre = new Nombre();
            try
            {
                nombre.preguntarNombre();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Nombre no válido", e);
            
            }

            Apellido apellido = new Apellido();

            try
            {
                apellido.preguntarApellido();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Apellido no válido", e);
            }

        }
    }
}
