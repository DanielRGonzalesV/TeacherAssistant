using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer
{
    class Persona
    {
        private string nombre;
        private string apellido;
         Persona(){
         
         }
        public abstract string guardar();
        public abstract string mostrar();
        public abstract string modificar();

    }
}
