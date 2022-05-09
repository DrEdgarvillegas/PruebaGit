using System;

namespace Pract6Ejer2
{
    class Program : vehiculo
    {
        static void Main(string[] args)
        {
            vehiculo estadoMotor = new vehiculo();
            vehiculo velocidad = new vehiculo();

            estadoMotor.Arrancar(true);
            estadoMotor.Frenar(true);

        }
    }
}
