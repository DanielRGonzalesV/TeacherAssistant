using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.EntityLayer
{
    public class Alumno
    {
        public int id;
        public string nombre;
        public string apellido;
        public string ci;

        public Alumno(int id, string nombre, string apellido, string ci)
        {
            this.id = Id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ci = ci;

        }

        public Alumno()
        {
            Id = 0;
            nombre = "";
            apellido = "";
            ci = " ";
        }

        public Alumno(string p1, string p2, string p3)
        {
            // TODO: Complete member initialization
            this.Nombre = p1;
            this.Apellido = p2;
            this.Ci = p3;
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
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public override string ToString()
        {
            String valor = "Npmbre: " + Nombre;
            return valor;
        }
    }
}
