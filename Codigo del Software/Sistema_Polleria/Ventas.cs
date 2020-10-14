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
        public Ventas()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double cant, precio;
            double tot=0;
            spPollopa.Visible = true;                   
        }
        public void total()
        {
            double tot = 0;
            foreach (DataGridViewRow row in gvProd.Rows)
            {
                tot += Convert.ToDouble(row.Cells["Column3"].Value);
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
    }
}
