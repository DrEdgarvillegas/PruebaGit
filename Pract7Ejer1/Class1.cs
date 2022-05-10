using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7Ejer1
{
           
        public class Empleado
        {
            public int Empleado_Id { get; set; }
            public string Empleado_Nombre { get; set; }

            /// <summary>
            /// Meteodo para insertar el empleado a la base
            /// </summary>
            /// <param name="em">Employee object</param>
            /// <returns>Ingresado satisfactoriamente o no</returns>
            public bool InsertarEmpleadoTabla(Empleado em)
            {
                // Introduce el empleado en la tabla.
                return true;
            }
            /// <summary>
            /// Metodo para generar reporte
            /// </summary>
            /// <param name="em"></param>
            public void GenerarReporte(Empleado em)
            {
                // Generacion de reporte
            }
        }
    

}
