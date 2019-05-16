using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalP
{
    public class Nombre

    {
        public string nombre;
        string apellido;
        char[] arr;

        public void preguntarNombre()
        {
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            arr = nombre.ToCharArray();
            int arrlenght;

            arrlenght = arr.Length;
                
            if ( arrlenght <= 2)
            {
                throw new FormatException();
                
            }
            else
            {
               
                    
            }
         }
            
            


        
    }
}
