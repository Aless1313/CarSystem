using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Car_System
{
    class Conexion
    {
        public static MySqlConnection Obtener_Conexion()
        {
            MySqlConnection cn;
<<<<<<< HEAD
            //LocalHost
            //cn = new MySqlConnection("Server = localhost; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
            //Red
            cn = new MySqlConnection("Server = prueba; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
=======
            cn = new MySqlConnection("Server = localhost; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
>>>>>>> 69bccf3e4ed14980ee0b773849b6ce1ca08e6480
            cn.Open();
            return cn;
        }
        
    }
}
