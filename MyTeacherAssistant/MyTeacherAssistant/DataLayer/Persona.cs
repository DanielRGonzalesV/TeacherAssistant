using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer
{
    class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int ci;
        private int num_celular;

        public Persona(int id, string nombre, string apellido, int ci, int num_celular)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.num_celular = num_celular;
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

        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public int Num_celular
        {
            get { return num_celular; }
            set { num_celular = value; }
        }
    }
}
