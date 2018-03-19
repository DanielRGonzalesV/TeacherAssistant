using MySql.Data.MySqlClient;
using MyTeacherAssistant.DataLayer.ConnectionLayer;
using MyTeacherAssistant.DataLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeacherAssistant.DataLayer.DAOLayer
{
    public class AlumnoDA : Persona
    {
        public int insertar(Alumno alumno)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO alumnos(nombre_alumno, apellido_alumno, ci_alumno, estado_alumno) VALUES ('{0}','{1}','{2}','{3}')", alumno.Nombre, alumno.Apellido, alumno.Ci, "ACTIVO"), Conexion.ObtenerConexion());
            MySqlCommand com = new MySqlCommand(string.Format("SELECT MAX(id_alumno) AS id_alumno FROM alumnos"), Conexion.ObtenerConexion());
            if (comando.ExecuteNonQuery() > 0)
                return ((Int32)com.ExecuteScalar());//devuelve el id insertado
            else
                return 0;
        }
        public override int guardar(Docente d)
        {
            throw new NotImplementedException();
        }

        public override string modificar()
        {
            throw new NotImplementedException();
        }
        public override string mostrar()
        {
            throw new NotImplementedException();
        }
        public List<Alumno> listar()
        {
            List<Alumno> _lista = new List<Alumno>();

            MySqlCommand _comando = new MySqlCommand(String.Format
                 ("SELECT nombre_alumno, apellido_alumno, ci_alumno FROM alumnos WHERE estado_alumno = 'ACTIVO'"), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Alumno alumno = new Alumno();
                alumno.Id = _reader.GetInt32(0);
                alumno.Nombre = _reader.GetString(1);
                alumno.Apellido = _reader.GetString(2);
                alumno.Ci = _reader.GetString(3);
                _lista.Add(alumno);
            }
            return _lista;
        }

    }
}
