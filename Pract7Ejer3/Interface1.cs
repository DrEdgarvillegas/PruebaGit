using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7Ejer3
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IProject
    {
        string GetProjectDetails(int employeeId);
    }
}
