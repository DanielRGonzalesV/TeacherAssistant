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

namespace MyTeacherAssistant.ViewLayer
{
    /// <summary>
    /// Interaction logic for PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            BussinesLayer.Validaciones valida = new BussinesLayer.Validaciones();
            if (valida.validarLogin(UsernameTbx, PasswordBox))
            {

                // Instantiate the page to navigate to
                PagePrincipalAlumno page = new PagePrincipalAlumno();

                // Navigate to the page, using the NavigationService
                this.NavigationService.Navigate(page);

                //// Force WPF to download this page again
                //this.NavigationService.Refresh();

            }
            else {
                mensaje
            }


        }

        private void cerrarBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
