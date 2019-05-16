using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalP
{
    class Apellido : Nombre
    {
        string apellido;
        char[] arr;
        int arrlenght;

        public void preguntarApellido()
        {

            Console.WriteLine(" ");
            Console.WriteLine("Escribe tu apellido");

            apellido = Console.ReadLine();
            arr = apellido.ToCharArray();
            arrlenght = arr.Length;

            if (arrlenght <= 2)
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine("Gracias" + nombre);
            }
        }





    }
}

