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
        private AsignacionDA asignacion = new AsignacionDA();

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

        public List<AsignacionDA> getAsignaciones()
        {
            List<Alumno> alumnos = alumnoDa.listar();
            List<AsignacionDA> listaAsignaciones = new List<AsignacionDA>();
            IEnumerable<AsignacionDA> listaAsigna2 = new List<AsignacionDA>();

            foreach (Alumno alumno in alumnos)
            {
                List<AsignacionDA> test = asignacion.listarPorAlumno(alumno.Id);
                //listaAsignaciones = (List<AsignacionDA>)listaAsignaciones.Union(asignacion.listarPorAlumno(alumno.Id));
                listaAsigna2 = listaAsigna2.Union(asignacion.listarPorAlumno(alumno.Id));
            }

     
                return listaAsignaciones;



            //private string nombre;
            //private string apellido;
            //private string grupo;
            //private string tarea;
            //private string descripcion;
            //private string fechainicio;
            //private string fechafin;
        }

        public void modificarAlumno(int idPersona, string nombre, string apellido, DateTime fechaNacimiento)
        {
            throw new NotImplementedException();
        }

        public void eliminarAlumno(int idPersona)
        {
            throw new NotImplementedException();
        }

        public void crearAsignacion(String nombreTarea, String descripcionTarea, String nombreGrupo, int[] idAlumnos)
        {
            Tareas tarea = new Tareas(nombreTarea, descripcionTarea, "2018-03-18", "2018-03-20");
            Grupo grupo = new Grupo(nombreGrupo);
            int id_result = asignacion.insertar(tarea, grupo, idAlumnos);

            if (id_result > 0)
            {
                alumno.Id = id_result;
                System.Windows.MessageBox.Show("Asignacion Correcta");
            }
            else
            {
                System.Windows.MessageBox.Show("Datos incorrectos, vuelva a intertarlo");
            }
        }
    }
}
