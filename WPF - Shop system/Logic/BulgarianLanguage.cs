using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Shop_system
{
    public class BulgarianLanguage : ILanguage
    {
        public string IntroScreenEmployeeID
        {
            get { return "Потp. номер:"; }
        }


        public string IntroScreenEmployeePassword
        {
            get { return "Парола:"; }
        }
    }
}
