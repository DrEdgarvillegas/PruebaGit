using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Coche : IVehiculo
    {
        public void Conducir()
        {
            if (gas > 0)
            {

                Console.WriteLine("En marcha");

            }
            else {
                Console.WriteLine("Carga combustible");
            
            }



        }


        public bool CargarNafta(int entradagas) 
        {
            if (gas < 0)
               return false;
            else
            {
                this.gas += entradagas;
                return true;                
            }               

        }
        public int gas { get; set; }

        public Coche(int gas)
        {

            this.gas = gas;

        }

        public Coche() 
        {
            this.gas = 0;
        }
    }
}
