using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Shop_system.Data
{
    public static class InsertNewEmployee
    {
        public static void AddNewEmployee(Employee newEmployee)
        {
            EmployeeClassesDataContext employeeTableConnection = new EmployeeClassesDataContext();
            employeeTableConnection.AddNewEmployee(
                newEmployee.Name,
                newEmployee.EmpID,
                newEmployee.EmpPass,
                newEmployee.Rank,
                newEmployee.DateHired);
        }
    }
}
