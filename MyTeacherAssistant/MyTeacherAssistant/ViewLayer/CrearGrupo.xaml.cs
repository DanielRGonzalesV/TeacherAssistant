﻿using MyTeacherAssistant.BussinesLayer;
using MyTeacherAssistant.DataLayer.EntityLayer;
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

        FachadaAssistantTeacher fachada = new FachadaAssistantTeacher();
        public List<Alumno> alumnos = new List<Alumno>();

        public CrearGrupo()
        {
            InitializeComponent();
            actualizarListView();
        }


        private void GuardarBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void actualizarListView()
        {
            alumnos = fachada.getAlumnos();
            listaSeleccion.ItemsSource = alumnos;
            listaSeleccion.Items.Refresh();
        }
    }
}
