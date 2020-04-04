using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Car_System
{
    class Tipo_de_conexion
    {
        public static int ti_con = 0;
        public static string usu = "";
        public static int rango = 0;
    }

    class Conexion
    {
        public static MySqlConnection Obtener_Conexion()
        {
            
            MySqlConnection cn;
            
            if (Tipo_de_conexion.ti_con == 1)
            {
                cn = new MySqlConnection("Server = localhost; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");
                cn.Open();
            }
            else
            {
                cn = new MySqlConnection("Server = fdchvtfbjcuhubv.ddns.net; Database = Automotriz_Castillo ; uid =Castillo ; Pwd =rbyn2FSt5FCLw5jr");

                

                cn.Open();
            }
            

            return cn;

        }
    }


}
