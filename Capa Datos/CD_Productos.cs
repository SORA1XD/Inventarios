using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
    class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader reader;
        DataTable table = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        
        public DataTable mostrar()
        {
            //transact SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * FROM Productos";
            reader = comando.ExecuteReader();
            table.Load(reader);
            return table;
        } 
    }
}
