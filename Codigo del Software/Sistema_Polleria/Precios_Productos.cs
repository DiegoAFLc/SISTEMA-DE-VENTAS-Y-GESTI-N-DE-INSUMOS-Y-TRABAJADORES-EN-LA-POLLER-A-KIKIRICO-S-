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
    public partial class Precios_Productos : Form
    {
        public Precios_Productos()
        {
            InitializeComponent();
            gvProductos.AutoGenerateColumns = false;
            gvProductos.DataSource = new ne_productos().productos_sel();


            cmbProductos.DataSource = new ne_productos().productos_sel();
            cmbProductos.ValueMember = "IdProd";
            cmbProductos.DisplayMember = "Descripcion";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.IdProd = Convert.ToInt32(gvProductos.SelectedCells[0].Value);
            p.Precio = spPrecio.Value;
            p.Descripcion = cmbProductos.Text;
            DialogResult obRes;
            obRes = MessageBox.Show("¿Estas seguro(a) de modificar el producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (obRes == DialogResult.Yes)
            {
                new ne_productos().productos_udp(p);
                //this.Close();
                MessageBox.Show("Modificado con éxito");
            }
            gvProductos.DataSource = new ne_productos().productos_sel();
        }

        private void gvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbProductos.Text = Convert.ToString(gvProductos.SelectedCells[1].Value);
            spPrecio.Value = Convert.ToDecimal(gvProductos.SelectedCells[2].Value);
            
        }
    }
}
