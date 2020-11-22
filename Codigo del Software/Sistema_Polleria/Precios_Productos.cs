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
    public partial class Precios_Productos : Form
    {
        public Precios_Productos()
        {
            InitializeComponent();
            cmbProductos.DataSource = new ne_productos().productos_sel();
            cmbProductos.ValueMember = "IdProd";
            cmbProductos.DisplayMember = "Descripcion";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
