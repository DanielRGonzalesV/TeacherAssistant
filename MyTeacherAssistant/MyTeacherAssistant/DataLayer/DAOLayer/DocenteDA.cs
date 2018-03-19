using MySql.Data.MySqlClient;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTeacherAssistant.DataLayer.ConnectionLayer;

namespace MyTeacherAssistant.DataLayer.DAOLayer
{
    public class DocenteDA : Persona
    {
        public DocenteDA() { }

        public override int guardar(Docente docente)
        {

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO docente(nombre_docente, apellido_docente, password_docente, estado_docente) VALUES ('{0}','{1}','{2}','{3}')", docente.Nombre, docente.Apellido, docente.Password, "ACTIVO; SELECT LAST_INSERT_ID()"), Conexion.ObtenerConexion());
            MySqlCommand com = new MySqlCommand(string.Format("SELECT MAX(id_docente) AS id_docente FROM docente"), Conexion.ObtenerConexion());
            if (comando.ExecuteNonQuery() > 0)
                return ((Int32)com.ExecuteScalar());//devuelve el id insertado
            else
                return 0;
        }

        public override string modificar()
        {
            throw new NotImplementedException();
        }

        public override string mostrar()
        {
            throw new NotImplementedException();
        }

        public bool login(string nombre, string pass)
        {
            MySqlConnection conexion = Conexion.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM docente WHERE nombre_docente='" + nombre + "'AND password_docente='" + pass + "' ", conexion);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                return true;

            }
            else
                return false;

        }
    }
}
