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
    public partial class Registro_Usuario : Form
    {
        public Registro_Usuario()
        {
            InitializeComponent();
            cmbTrabajadores.DataSource = new ne_trabajador().trabajador_Get();
            cmbTrabajadores.DisplayMember = "Nombres";         
            cmbTrabajadores.ValueMember = "Nidentidad";

            cmbTipo.DataSource = new ne_tipo_trabajador().tipo_usuario();
            //cmbTipo.DisplayMember = "Descripcion";
            //cmbTipo.ValueMember = "IdTipo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario obUs = new Usuario();
            obUs.Nidenti = Convert.ToString(cmbTrabajadores.SelectedValue);
            obUs.IdTipo = Convert.ToInt32(cmbTipo.SelectedValue);
            obUs.Usuarios = txtUsuario.Text;
            obUs.Contraseña = txtContraseña.Text;
            
            if(new ne_usuario().usuario_ins(obUs))
            {
                MessageBox.Show("Se registró correctamente el usuario");
            }
            else
            {
                MessageBox.Show("Upss, no se registró el usuario");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basedDataSet.usario_sel' Puede moverla o quitarla según sea necesario.
            this.usario_selTableAdapter.Fill(this.basedDataSet.usario_sel);

        }
    }
}
