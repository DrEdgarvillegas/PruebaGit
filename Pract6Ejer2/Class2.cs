using System;
using System.Collections.Generic;
using System.Text;

namespace Pract6Ejer2
{
    partial class vehiculo
    {
        public bool Arrancar(bool estadoMotor) 
        {
            this.estadoMotor = estadoMotor;
            if (estadoMotor == false)
            {
                Console.WriteLine("Encendiendo");
                return true;
            }
            else
                 Console.WriteLine("El motor está en marcha");
            return false;
        }

        public bool Frenar( bool velocidad) 
        {
            this.velocidad = velocidad;

            if ( velocidad == true) 
            {
                Console.WriteLine("Frenando");
                return true;
            }
            else
                return false;
        }

        public bool Acelerar(bool velocidad) 
        {
            this.velocidad = velocidad;

            if (velocidad == true)
            {
                return false;

            }else

                Console.WriteLine("Acelerando");
            return true;

              
        }

        public bool Apagar() 
        {
            
            Console.WriteLine("Apagando");
            return estadoMotor = false;
        }
    }
}
