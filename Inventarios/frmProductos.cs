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
using Inventarios.Ventanas_Secundarias;

namespace Inventarios
{

    public partial class frmProductos : Form
    {
        CN_Productos objetoCN = new CN_Productos();


        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void MostrarTabla()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarProd(txt_codigodebarras.Text, txt_codigointerno.Text, txt_nombre.Text, txt_descripcion.Text, txt_equivalente.Text, txt_stockmin.Text, txt_stockactual.Text, txt_preciocompra.Text, txt_precioventa.Text, txt_ubicacion.Text, cmb_procedencia.Text, cmb_estado.Text);
                MessageBox.Show("Se Registro correctamente el producto");
                MostrarTabla();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema:  " + ex);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductos_mod myform = new frmProductos_mod();
            myform.txt_codigodebarras.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myform.txt_codigointerno.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myform.txt_nombre.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myform.txt_descripcion.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myform.txt_equivalente.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myform.txt_stockmin.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myform.txt_stockactual.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            myform.txt_preciocompra.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            myform.txt_precioventa.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            myform.txt_ubicacion.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            myform.cmb_procedencia.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            myform.cmb_estado.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            myform.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = objetoCN.BuscarProd(txt_buscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema:  " + ex);
            }
        }
    }
}
