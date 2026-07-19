using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ServiciosMedicos.DataConexion
{
    internal class Conexion
    {
        private readonly string cadena;

        public Conexion()
        {
            cadena = "Server=127.0.0.1; Database=serviciosmedicos; Uid=root; Pwd=; Port=3306";

        }


        public MySqlConnection obtenerconexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar la base de datos " + ex.ToString());
                return null;
            }
        }
    }
}
