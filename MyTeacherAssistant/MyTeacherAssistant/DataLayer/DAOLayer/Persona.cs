using MySql.Data.MySqlClient;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.DAOLayer
{
    public abstract class Persona
    {
        public string nombres;
        public string apellidos;

        public abstract int guardar(Docente d);
        public abstract string mostrar();
        public abstract string modificar();

    }
}
