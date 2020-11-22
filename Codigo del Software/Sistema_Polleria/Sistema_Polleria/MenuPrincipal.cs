using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Polleria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trabajadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {        
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void trabajadoresRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajadores p = new Trabajadores();
            p.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajadores t = new Trabajadores();
            t.Show();
        }

        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void trabajadoresRegistradosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListadoTrabajador lt = new ListadoTrabajador();
            lt.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba p = new Prueba();
            p.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Usuario ru = new Registro_Usuario();
            ru.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbUsu.Visible = true;
            if (lbUsu.Visible == true)
            {
                if (lbUsu.SelectedIndex == 0)
                {
                    Form1 f1 = new Form1();
                    this.Close();
                    f1.Show();
                }
            }
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prueba p = new Prueba();
            p.Show();
        }

        private void representantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Representantes r = new Representantes();
            r.Show();
        }

        private void lblUsu_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbUsu.Visible = true;
        }

        private void lbUsu_MouseHover(object sender, EventArgs e)
        {
            lbUsu.Visible = true;
        }

        private void lbUsu_MouseLeave(object sender, EventArgs e)
        {
            lbUsu.Visible = false;
        }

        private void realizarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }

        private void asignaciónDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Precios_Productos pp = new Precios_Productos();
            pp.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Producto rp = new Registro_Producto();
            rp.Show();
        }

        private void listarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado_Proveedores lp = new Listado_Proveedores();
            lp.Show();
        }

        private void productosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insumos_Registrados ir = new Insumos_Registrados();
            ir.Show();
        }

        private void pagarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos();
            p.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Ventas rv = new Reporte_Ventas();
            rv.Show();
        }
    }
}
