using MyTeacherAssistant.DataLayer.DAOLayer;
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
            //  BussinesLayer.Validaciones valida = new BussinesLayer.Validaciones();

            string nombre = UsernameTbx.Text;
            string password = PasswordBox.Password.ToString();
            DocenteDA docente = new DocenteDA();

            if (docente.login(nombre, password))
            {
                PagePrincipalAlumno page = new PagePrincipalAlumno();
                this.NavigationService.Navigate(page);
                MessageBox.Show("Bienvenido " + nombre);
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrecto");
            }
             //    //// Force WPF to download this page again
            //    //this.NavigationService.Refresh();
        }

        private void cerrarBtn_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            App.Current.Shutdown();
        }
    }
}
