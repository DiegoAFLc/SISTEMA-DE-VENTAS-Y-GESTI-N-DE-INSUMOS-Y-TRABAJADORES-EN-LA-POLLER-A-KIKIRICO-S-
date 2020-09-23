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
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            spEdad.Controls[0].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Trabajador t = new Trabajador();
            t.Nombres = txtNombres.Text;
            t.Apellidos = txtApellidos.Text;
            t.Correo = txtCorreo.Text;
            t.Edad = Convert.ToInt32(spEdad.Value);
            t.Nidentidad = Convert.ToInt32(txtNident.Text);
            t.Modalidad = cmbModalidad.Text;
            t.Puesto = cmbPuesto.Text;
            t.Tipodoc = cmbTipoDoc.Text;
            t.Rutaimage = txtImage.Text;
            if(new ne_trabajador().trabajador_ins(t))
            {
                MessageBox.Show("Cargado Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se Registro correctamente");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            uf1.ShowDialog();
            txtImage.Text=uf1.FileName;
        }
    }
}
