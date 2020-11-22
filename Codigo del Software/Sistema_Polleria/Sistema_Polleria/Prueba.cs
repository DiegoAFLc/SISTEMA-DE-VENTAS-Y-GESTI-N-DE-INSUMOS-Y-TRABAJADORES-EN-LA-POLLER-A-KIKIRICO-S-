using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Polleria
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {              
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Proveedor obPro = new Proveedor();
            obPro.Empresa = txtEmpresa.Text;
            obPro.Tipreg = cmbRegimen.Text;
            obPro.Nreg = Convert.ToInt32(numericUpDown1.Value);
            obPro.Correo = txtCorreo.Text;
            obPro.Direccion = txtDirec.Text;
            obPro.Tipoprod = cmbProd.Text;
            if(new ne_proveedor().proveedor_ins(obPro))
            {
                MessageBox.Show("Se registró correctamente el Proveedor");
            }
            else
            {
                MessageBox.Show("No se registró correctamente el Proveedor");
            }
        }
    }
}
