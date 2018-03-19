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
    public class AsignacionDA
    {
        private string nombre;
        private string apellido;
        private string grupo;
        private string tarea;
        private string descripcion;
        private string fechainicio;
        private string fechafin;
        public AsignacionDA()
        {
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
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Fechainicio
        {
            get { return fechainicio; }
            set { fechainicio = value; }
        }
        public string Fechafin
        {
            get { return fechafin; }
            set { fechafin = value; }
        }

        public int insertar(Tareas tarea, Grupo grupo, int[] idAlumnos)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tarea(nombre_tarea, descripcion_tarea, fechainicio_tarea, fechafin_tarea, estado_tarea) VALUES ('{0}','{1}','{2}','{3}')", tarea.Nombre, tarea.Descripcion, tarea.Fechainicio, tarea.Fechafin, "ACTIVO"), Conexion.ObtenerConexion());
            MySqlCommand com = new MySqlCommand(string.Format("SELECT MAX(id_tarea) AS id_tarea FROM tarea"), Conexion.ObtenerConexion());
            if (comando.ExecuteNonQuery() > 0)
                if (insertarGrupo(grupo, (Int32)com.ExecuteScalar(), idAlumnos) > 0)
                    return 1;
                else
                    return 0;
            else
                return 0;
        }

        public int insertarGrupo(Grupo grupo, int idTarea, int[] idAlumnos)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO grupo(nombre_grupo, tarea_id_tarea, estado_grup) VALUES ('{0}','{1}','{2}')", grupo.Nombre, idTarea, "ACTIVO"), Conexion.ObtenerConexion());
            MySqlCommand com = new MySqlCommand(string.Format("SELECT MAX(id_grupo) AS id_grupo FROM grupo"), Conexion.ObtenerConexion());
            if (comando.ExecuteNonQuery() > 0)
                return ((Int32)com.ExecuteScalar());//devuelve el id insertado
            else
                return 0;
        }

        public void insertarAsignacion(int idGrupo, int[] idAlumnos)
        {
            for (int i = 0; i < idAlumnos.Length; i++)
            {
                MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO asignaciongrupo(alumnos_id_alumno, grupo_id_grupo, estado_asig) VALUES ('{0}','{1}','{2}')", idGrupo, idAlumnos[i], "ACTIVO"), Conexion.ObtenerConexion());
                comando.ExecuteNonQuery();
            }
        }

        public List<AsignacionDA> listarPorAlumno(int idAlumno)
        {
            List<AsignacionDA> lista = new List<AsignacionDA>();

            MySqlCommand _comando = new MySqlCommand(String.Format
                 ("SELECT nombre_alumno, apellido_alumno, nombre_grupo, nombre_tarea, descripcion_tarea, fechainicio_tarea, fechafin_tarea FROM alumnos, grupo, tarea, asignaciongrupo WHERE id_alumno ='" + idAlumno + "' AND alumnos_id_alumno=id_grupo"), Conexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                AsignacionDA asig = new AsignacionDA();
                asig.Nombre = _reader.GetString(0);
                asig.Apellido = _reader.GetString(1);
                asig.Grupo = _reader.GetString(2);
                asig.Tarea = _reader.GetString(3);
                asig.Descripcion = _reader.GetString(4);
                asig.Fechainicio = _reader.GetString(5);
                asig.Fechafin = _reader.GetString(6);
                lista.Add(asig);
            }
            return lista;
        }

        //public static Docente Login(string nombre, string contraseña)
        //{
        //    Docente docente = new Docente();
        //    MySqlConnection conexion = BdComun.ObtenerConexcion();
        //    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM docente WHERE noombre = {0}", nombre), conexion);
        //    MySqlDataReader _reader = _comando.ExecuteReader();
        //    while (_reader.Read())
        //    {
        //        //pCliente.id = _reader.GetInt32(0);
        //        pCliente.Nombre = _reader.GetString(0);
        //        pCliente.Apellidos = _reader.GetString(1);
        //        pCliente.Nit = _reader.GetString(2);
        //        pCliente.Ci = _reader.GetString(3);
        //        pCliente.Telefono = _reader.GetString(4);
        //        pCliente.Direccion = _reader.GetString(5);
        //        pCliente.Correo = _reader.GetString(6);
        //        pCliente.Pass = _reader.GetString(7);
        //    }
        //    conexion.Close();
        //    return pCliente;
        //}
    }
}
