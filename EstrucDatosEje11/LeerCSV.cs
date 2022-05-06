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
        List<string> listC;
        List<string> listD;

        public void Guardar()

        {
            var reader = new StreamReader(File.OpenRead("C:\\Users\\edgar\\OneDrive\\Escritorio\\pruebagit\\EstrucDatosEje11\\Alumnos.csv"));
            listA = new List<string>();
            listB = new List<string>();
            listC = new List<string>();
            listD = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                listA.Add(values[0]);
                listB.Add(values[1]);
                listC.Add(values[2]);
                listD.Add(values[3]);

            }

        }
        public void LeerLista(string listaA, string listaB, string listaC, string listaD)
        {
            
            foreach (int i in listaA)
            {
                Console.WriteLine(listaA[i]);
                Console.WriteLine(listaB[i]);
                Console.WriteLine(listaC[i]);
                Console.WriteLine(listaD[i]);


            }

        }

         

        public void ordenar(List<string> listA, List<string> listB, List<string> listC, List<string> listD)
        {

        }



    }
}
