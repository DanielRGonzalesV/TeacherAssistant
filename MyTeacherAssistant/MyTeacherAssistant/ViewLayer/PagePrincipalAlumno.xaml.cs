using MyTeacherAssistant.BussinesLayer;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    
    public partial class PagePrincipalAlumno : Page
    {

        public List<Alumno> alumnos = new List<Alumno>();
        FachadaAssistantTeacher fachada = new FachadaAssistantTeacher();

        public PagePrincipalAlumno()
        {
            InitializeComponent();
            actualizarListView();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            App.Current.Shutdown();
        }

        private void AgregarAlumnoBtn_Click(object sender, RoutedEventArgs e)
        {
            AgregarAlumno add_alumno = new AgregarAlumno();
            add_alumno.ShowDialog();
            actualizarListView();
        }

        private void actualizarListView()
        {
            alumnos = fachada.getAlumnos();
            listaGeneral.ItemsSource = alumnos;
            listaGeneral.Items.Refresh();
        }

        private void lista_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void listaGeneral_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void AsignarTareaBtn_Click(object sender, RoutedEventArgs e)
        {
            CrearGrupo crear_grupo = new CrearGrupo();
            crear_grupo.ShowDialog();
        }
    }
}
