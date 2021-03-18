using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;


namespace Inventarios.Ventanas_Secundarias
{
    public partial class frmProductos_mod : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        public frmProductos_mod()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.EditarProd(txt_codigodebarras.Text, txt_codigointerno.Text, txt_nombre.Text, txt_descripcion.Text, txt_equivalente.Text, txt_stockmin.Text, txt_stockactual.Text, txt_preciocompra.Text, txt_precioventa.Text, txt_ubicacion.Text, cmb_procedencia.Text, cmb_estado.Text);
                MessageBox.Show("Se ha modificado correctamente los datos del Producto");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al modificar" + ex);
                this.Close();
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar Los Datos?", "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    objetoCN.EliminarProd(txt_codigodebarras.Text);
                    MessageBox.Show("Se ha Eliminado Correctamente el Producto");
                    this.Close();
                }
                catch(Exception ex)
                {

                }
            }
            else
            {

            }
                
        }
    }
}
