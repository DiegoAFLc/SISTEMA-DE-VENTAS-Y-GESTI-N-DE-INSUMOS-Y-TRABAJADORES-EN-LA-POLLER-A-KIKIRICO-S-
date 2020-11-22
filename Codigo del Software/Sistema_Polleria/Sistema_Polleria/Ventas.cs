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
    
    public partial class Ventas : Form
    {
        double tot = 0;
        public Ventas()
        {
            InitializeComponent();
            cmbVendedor.DataSource = new ne_trabajador().trabajador_Get();
            cmbVendedor.ValueMember = "Nidentidad";
            cmbVendedor.DisplayMember = "Nombres";
            cmbVendedor.SelectedIndex = -1;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double cant, precio;
            double tot=0;
            spPollopa.Visible = true;                   
        }
        public void total()
        {
            //gvProd.Rows.Remove(gvProd.Rows[gvProd.Rows.Count - 1]);

            foreach (DataGridViewRow row in gvProd.Rows)
            {
                tot =tot+ Convert.ToDouble(row.Cells["Column3"].Value);
            }
            lblTotal.Text ="S./"+Convert.ToString(tot);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double cant, precio;
            spPollosol.Visible = true;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spPapas.Visible = true;
            //int n = gvProd.Rows.Add();
            //gvProd.Rows[n].Cells[0].Value = 1;
            //gvProd.Rows[n].Cells[1].Value = "Porción de Papas";
            //gvProd.Rows[n].Cells[2].Value = 8;
            //cant = Convert.ToDouble(gvProd.Rows[n].Cells[0].Value);
            //precio = Convert.ToDouble(gvProd.Rows[n].Cells[2].Value);
            //gvProd.Rows[n].Cells[3].Value = cant * precio;
            //total();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void spPollopa_ValueChanged(object sender, EventArgs e)
        {

            double cant, precio;
            int n = gvProd.Rows.Add();
            gvProd.Rows[n].Cells[0].Value = spPollopa.Value;
            gvProd.Rows[n].Cells[1].Value = "Pollo a la brasa con papas";
            gvProd.Rows[n].Cells[2].Value = 35;
            cant = Convert.ToDouble(gvProd.Rows[n].Cells[0].Value);
            precio = Convert.ToDouble(gvProd.Rows[n].Cells[2].Value);
            gvProd.Rows[n].Cells[3].Value = cant * precio;
            total();
        }

        private void spPollopa_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void spPollopa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                spPollopa.Visible = false;
            }          
        }

        private void spPollosol_ValueChanged(object sender, EventArgs e)
        {
            double cant, precio;
            int n = gvProd.Rows.Add();
            gvProd.Rows[n].Cells[0].Value = spPollosol.Value;
            gvProd.Rows[n].Cells[1].Value = "Pollo a la brasa solo";
            gvProd.Rows[n].Cells[2].Value = 25;
            cant = Convert.ToDouble(gvProd.Rows[n].Cells[0].Value);
            precio = Convert.ToDouble(gvProd.Rows[n].Cells[2].Value);
            gvProd.Rows[n].Cells[3].Value = cant * precio;
            total();
        }

       

        private void spPollosol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                spPollosol.Visible = false;
            }
        }

        private void spPapas_ValueChanged(object sender, EventArgs e)
        {
            double cant, precio;
            int n = gvProd.Rows.Add();
            gvProd.Rows[n].Cells[0].Value = spPapas.Value;
            gvProd.Rows[n].Cells[1].Value = "Porción de Papas";
            gvProd.Rows[n].Cells[2].Value = 8;
            cant = Convert.ToDouble(gvProd.Rows[n].Cells[0].Value);
            precio = Convert.ToDouble(gvProd.Rows[n].Cells[2].Value);
            gvProd.Rows[n].Cells[3].Value = cant * precio;
            total();
        }

        private void spPapas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                spPapas.Visible = false;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string total;
            Venta v = new Venta();
            v.Cliente = txtCliente.Text;
            v.Id_vend = Convert.ToInt32(cmbVendedor.SelectedValue);
            v.Met_pago = cmbPago.Text;
            v.Vale = txtDscto.Text;
            total = lblTotal.Text;
            v.Total = Decimal.Parse(total.Substring(3));

            if (validar() == true)
            {
                if (new ne_ventas().ventas_ins(v))
                {
                    MessageBox.Show("Se realizó la venta correctamente");
                }
            }
            else
            {
                MessageBox.Show("Exiten campos obligatorios sin datos");
                validar();
            }
            
            
        }
        private bool validar()
        {
            int cont;
            bool resp=true;
            if (txtCliente.Text == string.Empty)
            {
                eP1.SetError(txtCliente, "Campo sin datos");
                resp = false;
            }
            if (cmbVendedor.Text == String.Empty)
            {
                eP1.SetError(cmbVendedor,"Campo sin datos");
                resp = false;
            }
            if (cmbPago.Text == string.Empty)
            {
                eP1.SetError(cmbPago, "Campo sin datos");
                resp = false;
            }
            return resp;
        }

        private void cmbPago_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gvProd_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            
        }
    }
}
