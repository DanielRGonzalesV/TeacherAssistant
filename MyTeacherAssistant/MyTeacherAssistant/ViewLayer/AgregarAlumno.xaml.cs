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
    /// Interaction logic for AgregarAlumno.xaml
    /// </summary>
    public partial class AgregarAlumno : Window
    {
        FachadaAssistantTeacher fachada = new FachadaAssistantTeacher();
        public List<Alumno> alumnos = new List<Alumno>();

        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, RoutedEventArgs e)
        {
            string nombre = NombreTbx.Text;
            string apellido = ApellidoTbx.Text;
            string ci = CiTbx.Text;
            fachada.insertarAlumno(nombre, apellido, ci);
            this.Close();
            actualizarListView();
        }

        private void CancelarBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void actualizarListView()
        {
            alumnos = fachada.getAlumnos();
            PagePrincipalAlumno page = new PagePrincipalAlumno();
            page.listaGeneral.ItemsSource = alumnos;
            page.listaGeneral.Items.Refresh();
        }
    }
}
