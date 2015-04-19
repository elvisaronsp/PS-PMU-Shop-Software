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
using WPF___Shop_system.Data;
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
            Resources.Add("IntroScreenEmployeePassword", language.IntroScreenEmployeePassword);
        }

        private void btnQuit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(EmployeeAuthentification.CheckLoginData(this.txtBoxEmployeeIDNumber.Text, this.txtBoxEmployeePassword.Password),"Result");
        }
    }
}
