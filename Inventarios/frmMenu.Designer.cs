namespace Inventarios
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingregarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUusuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.gestionUusuariosToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCompraToolStripMenuItem,
            this.ingresarProductosToolStripMenuItem,
            this.ingregarProveedorToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ingresarCompraToolStripMenuItem
            // 
            this.ingresarCompraToolStripMenuItem.Name = "ingresarCompraToolStripMenuItem";
            this.ingresarCompraToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.ingresarCompraToolStripMenuItem.Text = "Ingresar Compra";
            // 
            // ingresarProductosToolStripMenuItem
            // 
            this.ingresarProductosToolStripMenuItem.Name = "ingresarProductosToolStripMenuItem";
            this.ingresarProductosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.ingresarProductosToolStripMenuItem.Text = "Ingresar Productos";
            // 
            // ingregarProveedorToolStripMenuItem
            // 
            this.ingregarProveedorToolStripMenuItem.Name = "ingregarProveedorToolStripMenuItem";
            this.ingregarProveedorToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.ingregarProveedorToolStripMenuItem.Text = "Ingregar Proveedor";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarVentaToolStripMenuItem,
            this.ingresarClienteToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ingresarVentaToolStripMenuItem
            // 
            this.ingresarVentaToolStripMenuItem.Name = "ingresarVentaToolStripMenuItem";
            this.ingresarVentaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.ingresarVentaToolStripMenuItem.Text = "Ingresar Venta";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar Cliente";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gestionUusuariosToolStripMenuItem
            // 
            this.gestionUusuariosToolStripMenuItem.Name = "gestionUusuariosToolStripMenuItem";
            this.gestionUusuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.gestionUusuariosToolStripMenuItem.Text = "Gestion Uusuarios";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 719);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingregarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUusuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}