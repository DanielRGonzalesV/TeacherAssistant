using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.EntityLayer
{
    public class Tareas

    {
        private int id;
        private string nombre;
        private string descripcion;
        private string fechainicio;
        private string fechafin;

        public Tareas(int id, string nombre, string descripcion, string fechainicio, string fechafin)
        {
            this.id = Id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Fechainicio = fechainicio;
            this.Fechafin = fechafin;
        }

        public Tareas()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Fechainicio
        {
            get { return fechainicio; }
            set { fechainicio = value; }
        }
        public string Fechafin
        {
            get { return fechafin; }
            set { fechafin = value; }
        }

    }
}
