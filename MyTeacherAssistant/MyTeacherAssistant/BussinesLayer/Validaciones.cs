using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyTeacherAssistant.BussinesLayer
{
    class Validaciones
    {
        internal bool validarLogin(TextBox usernameTbx, PasswordBox passwordBox)
        {
            DataLayer.EntidadDocente docente = new DataLayer.EntidadDocente();
            return docente.getLogin(usernameTbx, passwordBox);
            throw new NotImplementedException();

        }
    }
}
