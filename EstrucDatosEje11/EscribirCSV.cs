using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EstrucDatosEje11
{
    class EscribirCSV
    {
        public static void AgregarAlumno(string nombre, string parcial1, string parcial2, string parcial3)
        {
            String ruta = "C:\\Users\\edgar\\OneDrive\\Escritorio\\pruebagit\\EstrucDatosEje11\\Alumnos.csv";//RUTA DEL ARCHIVO
            String separador = ";";//CREAMOS UN SEPARADOR
            StringBuilder salida = new StringBuilder();//CRAMOS UNA INSTANCIA STRINGBUILDER (QUE LEE EL ARRAY COMPLETO)

            String cadena = nombre + "," + parcial1 + "," + parcial2 + "," + parcial3;//HACEMOS UN PROTOTIPO DE REGISTRO
            List<String> List = new List<String>();//CREAMOS UN LISTA DE STRING
            List.Add(cadena);//ASIGNAMOS EL FORMATO CADENA A LA LISTA

            for (int i = 0; i < List.Count; i++)// Count es el número de elementos que están realmente en List<tipo de dato>.
            {
                salida.AppendLine(String.Join(separador, List[i]));// El método AppendLine agrega el terminador de línea predeterminado al final del objeto StringBuilder actual.

                File.AppendAllText(ruta, salida.ToString());//AGREGA LA CADENA AL ARCHIVO.
            }
        }
    }
}
