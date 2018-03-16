using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer
{
    class Docente : Persona
    {
        public Docente(int id, string nombre, string apellido, int ci, int num_celular) : base(id, nombre, apellido, ci, num_celular)
        {
        }

    }
}
