using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConecction
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexcion()
        {
            MySqlConnection conectar = new MySqlConnection("server=192.168.0.16; database=teacherassistant; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
    }
}
