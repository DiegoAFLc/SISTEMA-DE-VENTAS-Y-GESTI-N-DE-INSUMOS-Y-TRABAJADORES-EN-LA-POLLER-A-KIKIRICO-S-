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
    public partial class Registro_Producto : Form
    {
        public Registro_Producto()
        {
            InitializeComponent();
            cmbProveedor.ValueMember = "Idempresa";
            cmbProveedor.DisplayMember = "Empresa";
            cmbProveedor.DataSource = new ne_proveedor().proveedor_sel();
            cmbProveedor.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insumos obIns = new Insumos();
            if (rbUnidad.Checked)
            {
                obIns.Tipo_cant = "Unidades";
            }
            else if (rbKilo.Checked)
            {
                obIns.Tipo_cant = "Kilos";
            }
            else
            {
                obIns.Tipo_cant = "Litros";
            }
           
            obIns.CodInsumo = "001INS";
            obIns.Fecha_reg = dtIngreso.Value;
            obIns.Insumo = cmbInsumo.Text;
            obIns.Cantidad = Convert.ToInt32(spCantidad.Value);
            obIns.Descripcion = txtDescrip.Text;
            obIns.Idempresa = Convert.ToInt32(cmbProveedor.SelectedValue);

            new ne_insumos().insumos_ins(obIns);
            MessageBox.Show("Registrado con éxito");
        }

        

       
    }
}
