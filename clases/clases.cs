using System;

namespace clases
{
    class clases
    {
        interface ICuenta
        {    
         public int operacion(int valor1, int valor2);
                    
        }

        class Suma : ICuenta 
        { 

            protected int valor1 { get; set; }

            protected int valor2 { get; set; }

            protected int resultado { get; set; }

            public int operacion(int valor1, int valor2) 
            {

                this.valor1 = valor1;
                this.valor2 = valor2;

                int resultado = valor1 + valor2;

                return default;
            
            }
        }

        class Resta : ICuenta 
        {

            protected int valor1 { get; set; }

            protected int valor2 { get; set; }

            protected int resultado { get; set; }

            public int operacion(int valor1, int valor2)
            {
                this.valor1 = valor1;
                this.valor2 = valor2;

                int resultado = valor1 - valor2;

                return resultado;

            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
