using Capa_Datos;
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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            gvPedidos.AutoGenerateColumns = false;
            gvPedidos.DataSource = new ne_ventas().ventas_sel();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new ne_ventas().pagar_pedido(Convert.ToString(gvPedidos.SelectedCells[0].Value)))
            {
                MessageBox.Show("Se pagó correctamente la Venta");
            }
        }

        private void gvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            ColeccionClases obCol;
            id = Convert.ToString(gvPedidos.SelectedCells[0].Value);
            obCol = new ne_ventas().sel_by_idventa(id);
            foreach(Venta v in obCol)
            {
                lblCli.Text = v.Cliente;
                lblFecha.Text = Convert.ToString(v.Fecha_emision);
                lblID.Text = v.Id_venta;
                lblMeto.Text = v.Met_pago;
                lblTot.Text =Convert.ToString(v.Total);

            }
        }
    }
}
