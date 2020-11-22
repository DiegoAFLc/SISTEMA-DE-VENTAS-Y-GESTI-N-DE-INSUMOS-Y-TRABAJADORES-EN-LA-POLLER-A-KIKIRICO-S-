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
    public partial class Reporte_Ventas : Form
    {
        public Reporte_Ventas()
        {
            InitializeComponent();
            gvVentas.AutoGenerateColumns = false;         
            if (dtInicio.Checked)
            {
                dtInicio.Visible = true;
                dtFinal.Visible = false;                
            }
        }

        private void rbUnica_Click(object sender, EventArgs e)
        {
            dtInicio.Visible = true;
            dtFinal.Visible = false;            
        }

        private void rbIntervalo_Click(object sender, EventArgs e)
        {
            dtInicio.Visible = true;
            dtFinal.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbUnica.Checked)
            {
                gvVentas.DataSource=new ne_ventas().vent_sel_unica(dtInicio.Value);
            }
            if (rbIntervalo.Checked)
            {
                gvVentas.DataSource=new ne_ventas().vent_sel_intervalo(dtInicio.Value, dtFinal.Value);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            ColeccionClases obCol;
            id = Convert.ToString(gvVentas.SelectedCells[0].Value);
            obCol = new ne_ventas().sel_by_idventa(id);
            Info_Venta iv = new Info_Venta();
            iv.Show();
            foreach (Venta v in obCol)
            {
                iv.txtCliente.Text = v.Cliente;
                iv.txtID.Text = v.Id_venta;
                iv.lblEstado.Text = v.Estado;
                iv.dtFecha.Value = v.Fecha_emision;
                iv.cmbPago.Text = v.Met_pago;
                iv.txtVale.Text = v.Vale;
                iv.txtVendedor.Text = v.Vendedor;
                return;
            }
        }
    }
}
