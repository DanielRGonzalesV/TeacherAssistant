using MyTeacherAssistant.BussinesLayer;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace MyTeacherAssistant.ViewLayer
{
    /// <summary>
    /// Interaction logic for CrearGrupo.xaml
    /// </summary>
    public partial class CrearGrupo : Window
    {

        FachadaAssistantTeacher fachada = new FachadaAssistantTeacher();
        public List<Alumno> alumnos = new List<Alumno>();
        

        public CrearGrupo()
        {
            InitializeComponent();
            actualizarListViewSelection();
        }


        private void GuardarBtn_Click(object sender, RoutedEventArgs e)
        {
            List<int> listId = new List<int>();
            string nombreTarea = NombreTareaTbx.Text;
            string descripcionTarea = DescripciontareaTbx.Text;
            string nombregrupo = NombreGrupoTbx.Text;

            for (int i = 0; i < listaSeleccion.SelectedItems.Count; i++)
            {  
                Alumno alumno = (Alumno)listaSeleccion.SelectedItems[i];
                int id = alumno.Id;
                listId.Add(id);
            }
            int[] idArray = listId.ToArray();
            fachada.crearAsignacion(nombreTarea, descripcionTarea, nombregrupo, idArray);
            this.Close();
            actualizarListViewGeneral();
        }

        private void CancelarBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void actualizarListViewSelection()
        {
            alumnos = fachada.getAlumnos();
            listaSeleccion.ItemsSource = alumnos;
            listaSeleccion.Items.Refresh();
        }

        private void actualizarListViewGeneral()
        {
            alumnos = fachada.getAlumnos();
            PagePrincipalAlumno page = new PagePrincipalAlumno();
            page.listaGeneral.ItemsSource = alumnos;
            page.listaGeneral.Items.Refresh();
        }

        private void listaSeleccion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }


    }
    }

