using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.EntityLayer
{
    public class Grupo
    {
        public int id;
        public string nombre;

        public Grupo(int id, string nombre)
        {
            this.id = Id;
            this.Nombre = nombre;
        }

        public Grupo()
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
    }
}
