using System;
using System.Collections;



namespace Ejercicio_cola
{
    class Program
    {
                     
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 5 números");
            
           
            Stack pila = new Stack();

            //Cargar la pila

            for (int i= 0; i<5; i++)
            {

                int[] linea;
                Console.Write("Ingrese valor de la componente:");
                linea[i] = Int32.Parse(Console.ReadLine());               
                pila.Push(linea[i]);

            }

            //Vaciar la pila

            for (int i = 0; i < 5; i++) {

                pila.Pop(i);
            
            }

            //Ordenar la pila

             Array.Sort(pila);

            //Mostrar la pila ordenada

            foreach (int i in pila) {

                Console.WriteLine(pila);
            }
                      

        }
    }
}
