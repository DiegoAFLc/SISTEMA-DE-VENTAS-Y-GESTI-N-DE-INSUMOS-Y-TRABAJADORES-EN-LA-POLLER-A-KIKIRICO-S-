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
    public partial class Listado_Proveedores : Form
    {
        public Listado_Proveedores()
        {
            InitializeComponent();
            gvProveedores.DataSource = new ne_proveedor().proveedor_sel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gvProveedores.DataSource = new ne_proveedor().proveedor_sel_especial(txtNombre.Text);
        }
    }
}
