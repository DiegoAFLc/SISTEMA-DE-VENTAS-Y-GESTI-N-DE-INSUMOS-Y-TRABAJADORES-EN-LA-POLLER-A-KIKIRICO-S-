using Capa_Entidad;
using Capa_Negocio;
using Microsoft.Office.Interop.Excel;
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
        private bool validar_llenado()
        {
            bool resp = false;
            if (txtNombres.Text == string.Empty)
            {
                error1.SetError(txtNombres, "Campo incompleto");
                resp = true;
            }
            if (txtApellidos.Text == string.Empty)
            {
                error1.SetError(txtApellidos, "Campo incompleto");
                resp = true;
            }
            if (txtCorreo.Text == string.Empty)
            {
                error1.SetError(txtCorreo, "Campo incompleto");
                resp = true;
            }
            if (spEdad.Value == 0)
            {
                error1.SetError(spEdad, "Campo incompleto");
                resp = true;
            }
            if (txtNident.Text==string.Empty)
            {
                error1.SetError(txtNident, "Campo incompleto");
                resp = true;
            }
            if (cmbModalidad.Text == string.Empty)
            {
                error1.SetError(cmbModalidad, "Campo incompleto");
                resp = true;
            }
            if (cmbPuesto.Text == string.Empty)
            {
                error1.SetError(cmbPuesto, "Campo incompleto");
                resp = true;
            }
            if (cmbTipoDoc.Text == string.Empty)
            {
                error1.SetError(cmbTipoDoc, "Campo incompleto");
                resp = true;
            }
            return resp;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar_llenado() != true)
            {
                Trabajador t = new Trabajador();
                t.Nombres = txtNombres.Text;
                t.Apellidos = txtApellidos.Text;
                t.Correo = txtCorreo.Text;
                t.Edad = Convert.ToInt32(spEdad.Value);
                if (txtNident.Text == string.Empty)
                {
                    error1.SetError(txtNident, "Campo sin datos");
                }
                else
                {
                    t.Nidentidad = Convert.ToInt32(txtNident.Text);
                }
                
                t.Modalidad = cmbModalidad.Text;
                t.Puesto = cmbPuesto.Text;
                t.Tipodoc = cmbTipoDoc.Text;
                t.Rutaimage = txtImage.Text;
                if (new ne_trabajador().trabajador_ins(t))
                {
                    MessageBox.Show("Cargado Correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se Registro correctamente");
                }
            }
            else
            {
                MessageBox.Show("Existen campos no llenados");
            }          
        }

        private void label9_Click(object sender, EventArgs e)
        {
            uf1.ShowDialog();
            txtImage.Text=uf1.FileName;
        }
    }
}
