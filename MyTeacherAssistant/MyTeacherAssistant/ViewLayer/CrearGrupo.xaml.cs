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
using System.Windows.Shapes;

namespace MyTeacherAssistant.ViewLayer
{
    /// <summary>
    /// Interaction logic for CrearGrupo.xaml
    /// </summary>
    public partial class CrearGrupo : Window
    {
        public CrearGrupo()
        {
            InitializeComponent();
        }

        private void AlumnosGrid_Loaded(object sender, RoutedEventArgs e)
        {

            //// ... Create a List of objects.
            //var items = new List<DataLayer.Alumno>();
            //items.Add(new DataLayer.Alumno("Daniel", "Gonzales"));
            //items.Add(new DataLayer.Alumno("Alvaro", "Montecinos"));
            //items.Add(new DataLayer.Alumno("Marcelo", "Ucatec"));

            //// ... Assign ItemsSource of DataGrid.
            //var grid = sender as DataGrid;
            //grid.ItemsSource = items;
        }

        private void GuardarBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
