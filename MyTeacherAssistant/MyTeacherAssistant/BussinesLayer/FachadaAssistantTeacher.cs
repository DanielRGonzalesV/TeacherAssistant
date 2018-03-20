using MyTeacherAssistant.DataLayer.DAOLayer;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.BussinesLayer
{
    class FachadaAssistantTeacher
    {
        private AlumnoDA alumnoDa = new AlumnoDA();
        private Alumno alumno = new Alumno();

        public void insertarAlumno(string nombre, string apellido, string ci)
        {
            alumno = new Alumno(nombre, apellido, ci);
            
            int id_result = alumnoDa.insertar(alumno);

            if (id_result > 0)
            {
                alumno.Id = id_result;
                System.Windows.MessageBox.Show("Alumno: " + nombre + " ingresado satisfactoriamente");
            }
            else
            {
                System.Windows.MessageBox.Show("Datos incorrectos, vuelva a intertarlo");
            }
        }

        public List<Alumno> getAlumnos()
        {
           return alumnoDa.listar();
        }



        public void modificarAlumno(int idPersona, string nombre, string apellido, DateTime fechaNacimiento)
        {
            throw new NotImplementedException();
        }
        public void eliminarAlumno(int idPersona)
        {
            throw new NotImplementedException();
        }
    }
}
