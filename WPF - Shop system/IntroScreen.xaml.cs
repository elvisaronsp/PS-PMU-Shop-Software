using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF___Shop_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class IntroScreen : Window
    {
        public IntroScreen()
        {
            LanguageSupport();
            InitializeComponent();
        }

        private void LanguageSupport()
        {
            ILanguage language = new BulgarianLanguage();
            Resources.Add("IntroScreenEmployeeID", language.IntroScreenEmployeeID);
        }
    }
}
