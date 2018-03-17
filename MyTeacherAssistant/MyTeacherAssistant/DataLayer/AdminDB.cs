using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyTeacherAssistant.DataLayer
{
    class AdminDB
    {
        static MySqlConnection Conex = new MySqlConnection();
             static string serv = "Server=localhost;";
             static string db = "Database=prueba;";
             static string usuario = "UID=root;";
             static string pwd = "Password = masterkey;";
             string CadenaDeConexion = serv + db + usuario + pwd;
             static MySqlCommand Comando = new MySqlCommand();
             static MySqlDataAdapter Adaptador = new MySqlDataAdapter();

             public void Conectar()
             {
             try
             {
             Conex.ConnectionString = CadenaDeConexion;
             Conex.Open();
             MessageBox.Show("La BD esta ahora conectada");
             }
             catch (Exception)
             {
             MessageBox.Show("Ocurrio un error al conectar a la BD");
             throw;
             }
             }
             public static void Desconectar()
             {
             Conex.Close();
             }

             static void Main(string[] args)
             {
                 // Display the number of command line arguments:
                 AdminDB prueba = new AdminDB;
                 prueba.Conectar();
                 //System.Console.WriteLine(args.Length);
             }
    }
}
