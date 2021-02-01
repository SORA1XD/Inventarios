using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    class CD_Conexion
    {
        private MySqlConnection connection = new MySqlConnection("server=162.241.60.14;user id=casade25_admin;password=Casafrenos2021;persistsecurityinfo=True;database=casade25_POS_CasaFrenos");

        public MySqlConnection AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();

            return connection;
        }

        public MySqlConnection CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();

            return connection;
        }
    }
}
