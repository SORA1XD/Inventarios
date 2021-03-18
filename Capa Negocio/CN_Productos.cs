using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable table = new DataTable();
            table = objetoCD.mostrar();
            return table;

        }

        public void InsertarProd(string codigobarra, string codigointerno, string nombre, string descri, string equi, string stockmin, string stockactual, string preciocompra, string precioventa, string ubicacion, string procedencia, string estado)
        {
            objetoCD.Insertar(codigobarra, codigointerno, nombre, descri, equi, Convert.ToInt32(stockmin), Convert.ToInt32(stockactual), Convert.ToInt32(preciocompra), Convert.ToInt32(precioventa), ubicacion, procedencia, estado);
        }

        public void EditarProd(string codigobarra, string codigointerno, string nombre, string descri, string equi, string stockmin, string stockactual, string preciocompra, string precioventa, string ubicacion, string procedencia, string estado)
        {
            objetoCD.Editar(codigobarra, codigointerno, nombre, descri, equi, Convert.ToInt32(stockmin), Convert.ToInt32(stockactual), Convert.ToInt32(preciocompra), Convert.ToInt32(precioventa), ubicacion, procedencia, estado);
        }

        public void EliminarProd(string codigobara)
        {
            objetoCD.Eliminar(codigobara);
        }

        public void BuscarProd(string buscar)
        {
            objetoCD.Buscar(buscar) ;

            //List<Class_productos> lista = new List<Class_productos>();
            //CtrlProductos _ctrlproductos = new CtrlProductos();
            //dataGridView1.DataSource = _ctrlproductos.consulta(dato);
        }
    }
}
