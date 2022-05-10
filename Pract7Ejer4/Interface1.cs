using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7Ejer4
{
    public interface IEmployeeDatabase
    {
        bool AddEmployeeDetails();
        bool ShowEmployeeDetails(int employeeId);
    }

    //-------------------------------------------------------------------------------

    public interface IAddOperation
    {
        bool AddEmployeeDetails();
    }
    public interface IGetOperation
    {
        bool ShowEmployeeDetails(int employeeId);
    }
}
