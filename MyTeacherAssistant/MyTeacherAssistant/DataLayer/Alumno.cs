using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer
{
    class Alumno
    {
        public string Name { get; set; }
        public string Apellido { get; set; }

        public Alumno(string name, string apellido)
        {
            this.Name = name;
            this.Apellido = apellido;
        }
    }
}
