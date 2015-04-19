using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Shop_system.Data
{
    public static class EmployeeAuthentification
    {
        public static string CheckLoginData(string employeeIdNumber, string employeePassword)
        {
            return EmplData.Login(employeeIdNumber, employeePassword);
        }
    }
}
