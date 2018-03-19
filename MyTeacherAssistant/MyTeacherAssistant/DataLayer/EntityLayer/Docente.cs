using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.EntityLayer
{
    public class Docente
    {
        public int id;
        public string nombre;
        public string apellido;
        public string password;

        public Docente(int dId, string dNombre, string dApellido, string dPass)
        {
            this.id = dId;
            this.Nombre = dNombre;
            this.Apellido = dApellido;
            this.Password = dPass;

        }

        public Docente()
        {

        }

        public Docente(string p1, string p2, string p3)
        {
            this.Nombre = p1;
            this.Apellido = p2;
            this.Password = p3;
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
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
