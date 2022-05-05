using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            double salario, meses, salarioTotal;

            Console.WriteLine("Ingrese el nombre del trabajador ");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del obrero");

             salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de meses trabajados");

             meses = Int32.Parse(Console.ReadLine());

             salarioTotal = (Math.Truncate(meses/6) * (salario * 0.25))+salario;

            Console.WriteLine("El salario total del" + nombre + " es: " + salarioTotal);

            Console.ReadKey();



        }
    }
}
