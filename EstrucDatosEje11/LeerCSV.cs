using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace EstrucDatosEje11
{
    class LeerCSV
    {
        List<string> listA;
        List<string> listB;

        public void Guardar()

        {
            var reader = new StreamReader(File.OpenRead("C:\\Users\\edgar\\OneDrive\\Escritorio\\pruebagit\\EstrucDatosEje11\\Alumnos.csv"));
            listA = new List<string>();
            listB = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                listA.Add(values[0]);
                listB.Add(values[1]);

            }

        }
        public void LeerLista(string listaA, string listaB)
        {

            foreach (int i in listaA)
            {
                Console.WriteLine(listaA[i]);
                Console.WriteLine(listaB[i]);

            }


        }
    }
}
