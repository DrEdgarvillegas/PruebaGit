using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7ejer2
{
    public class Empleado
    {
        public int Empleado_Id { get; set; }
        public string Empleado_Nombre { get; set; }
    }
        public class ReportGeneration
       {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Empleado em)
        {
            if (ReportType == "CSV")
            {
                 // Report generation with employee data in CSV
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
       }
}
