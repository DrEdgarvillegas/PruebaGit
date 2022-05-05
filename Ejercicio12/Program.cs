using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Desea consultar? s/n");

            string decision= Console.ReadLine();

            if (decision == "s")
            {

                Console.WriteLine("Introduzca el código del producto");

                string codigo = Console.ReadLine();

                if (codigo.Length == 7)
                {

                    

                }
                else Console.WriteLine("El código debe tener 7 dígitos");

            }
            else Console.WriteLine("Gracias nos vemos luego"); 
            
            



           

           


        }
    }
}
