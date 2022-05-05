using System;
using System.Collections;

namespace pila2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int opcion = 0;
            int numero = 0;
            bool encontrado = false;
            Stack miPila = new Stack();
            do
            {
                Console.WriteLine("1-INSERTAR.");
                Console.WriteLine("2-ELIMINAR.");
                Console.WriteLine("3-BORRAR LA PILA.");
                Console.WriteLine("4-BUSCAR.");
                Console.WriteLine("5-SALIR.");
                Console.WriteLine();
                Console.WriteLine("DAME TU OPCION:");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Dame el valor a introducir:");
                    numero = int.Parse(Console.ReadLine());
                    miPila.Push(numero);
                }
                if (opcion == 2)
                {
                    numero = (int)miPila.Pop();
                    Console.WriteLine("el valor obtenido es:" + numero);
                }
                if (opcion == 3)
                {
                    miPila.Clear();
                }
                if (opcion == 4)
                {
                    Console.WriteLine("dame el valor a contar:");
                    numero = int.Parse(Console.ReadLine());
                    encontrado = miPila.Contains(numero);
                    Console.WriteLine("encontrado {0}", encontrado);
                }
                Console.WriteLine("lA PILA  TIENE {0} elementos", miPila.Count);
                foreach (int n in miPila)
                    Console.Write(" {0},", n);
                Console.WriteLine("");
                Console.WriteLine("_______");
            } while (opcion != 5);
        }
    }
}
