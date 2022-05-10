using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7ejer2
{
    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Empleado em)
        {
            // From base
        }
    }

    /// <summary>
    /// Class to generate CSV report
    /// </summary>
    public class CSVReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Empleado em)
        {
            // Generate CSV report.
        }
    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Empleado em)
        {
            // Generate PDF report.
        }
    }
}
