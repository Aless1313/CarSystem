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
            //LocalHost
            //cn = new MySqlConnection("Server = localhost; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
            //Red
            cn = new MySqlConnection("Server = prueba; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
            cn.Open();
            return cn;
        }
        
    }
}
