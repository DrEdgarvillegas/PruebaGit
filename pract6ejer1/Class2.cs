using System;
using System.Collections.Generic;
using System.Text;

namespace pract6ejer1
{
    partial class rectangulo
    {
        public double Superficie(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;

            return lado1 * lado2;
        }

        public double Perimetro(double lado1, double lado2) 
        {
            this.lado1 = lado1;
            this.lado2 = lado2;

            return 2 * (lado1 + lado2);
        }

    }
}
