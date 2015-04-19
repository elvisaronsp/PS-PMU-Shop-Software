using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Shop_system.Data
{
    public class EmplData
    {
        public static bool IsFullAdmin(string emplIDNumber)
        {
            EmployeeClassesDataContext theObject = new EmployeeClassesDataContext();

            var query = theObject.GetTable<Employee>().Where(emp => emp.EmpID == emplIDNumber).First();

            if (query.Rank == 5) return true;
            return false;
        }

        public static string Login(string emplIDNumber, string emplPassword)
        {
            EmployeeClassesDataContext theObject = new EmployeeClassesDataContext();
            var query = theObject.GetTable<Employee>().Where(emp => emp.EmpID == emplIDNumber && emp.EmpPass == emplPassword).FirstOrDefault();
            if (query != null)
            {
                return "Successfully!";
            }
            else
            {
                return "Incorrect information!";
            }
        }
    }
}
