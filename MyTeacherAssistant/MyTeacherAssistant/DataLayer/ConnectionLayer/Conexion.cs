using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyTeacherAssistant.DataLayer.ConnectionLayer
{
    public class Conexion
    {
        private static string servidor;
        private static string basededatos;
        private static string usuario;
        private static string password;
        public Conexion()
        {
            Servidor = "localhos";
            Basededatos = "teacherassistant";
            Usuario = "root";
            Password = "";
        }
        #region propiedades

        public static string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        public static string Basededatos
        {
            get { return basededatos; }
            set { basededatos = value; }
        }

        public static string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion propiedades

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=teacherassistant; Uid=root; pwd=;");
            //MySqlConnection conectar = new MySqlConnection("server="+Servidor+"; database="+Basededatos+"; Uid="+Usuario+"; pwd="+Password+";");
            conectar.Open();
            return conectar;
        }
    }
}
