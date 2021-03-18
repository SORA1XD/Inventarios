using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
    public class CD_Productos
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

        public void Insertar(string codigobarra, string codigointerno, string nombre, string descri, string equi, int stockmin, int stockactual, int preciocompra, int precioventa, string ubicacion, string procedencia, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Productos VALUES ('" + codigobarra + "','" + codigointerno + "','" + nombre + "','" + descri + "','" + equi + "','" + stockmin + "','" + stockactual + "','" + preciocompra + "','" + precioventa + "','" + ubicacion + "','" + procedencia + "','" + estado + "')";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void Editar(string codigobarra, string codigointerno, string nombre, string descri, string equi, int stockmin, int stockactual, int preciocompra, int precioventa, string ubicacion, string procedencia, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE Productos SET  prod_cod_interno='" + codigointerno + "', prod_nombre='" + nombre + "', prod_descripcion='" + descri + "', prod_equiva='" + equi + "', prod_stockmin='" + stockmin + "', prod_stockact='" + stockactual + "', prod_preciocompra='" + preciocompra + "', prod_precioventa='" + precioventa + "', prod_ubicacion='" + ubicacion + "', prod_procedencia='" + procedencia + "', prod_estado='" + estado + "' WHERE prod_cod='" + codigobarra + "'";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void Eliminar(string codigobarra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE FROM Productos WHERE prod_cod='" + codigobarra + "'";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void Buscar(string buscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * FROM Productos CONCAT(`prod_cod`, `prod_cod_interno`, `prod_nombre`, `prod_descripcion`, `prod_equiva`, `prod_stockmin`, `prod_stockact`, `prod_preciocompra`, `prod_precioventa`, `prod_ubicacion`, `prod_procedencia`, `prod_estado`) LIKE %'" + buscar + "'%";
            comando.ExecuteNonQuery();
            reader = comando.ExecuteReader();
            table.Load(reader);
        }
    }
}