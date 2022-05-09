using System;

namespace pract6ejer1
{
    class Program : rectangulo
    {
        static void Main(string[] args)
        {
            rectangulo super = new rectangulo();

            rectangulo peri = new rectangulo();

            Console.WriteLine(super.Superficie(2, 5));

            Console.WriteLine(peri.Perimetro(3, 4));
        }
    }
}
