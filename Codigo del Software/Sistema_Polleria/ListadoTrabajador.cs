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
    public partial class ListadoTrabajador : Form
    {
        public ListadoTrabajador()
        {
            InitializeComponent();
            gvTrabajadores.AutoGenerateColumns = false;
            if (txtNombre.Text == string.Empty)
            {
                gvTrabajadores.DataSource = new ne_trabajador().trabajador_sel();                
            }          
            gvTrabajadores.DataSource = new ne_trabajador().trabajador_sel();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gvTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gvTrabajadores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gvTrabajadores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            ColeccionClases obcol;
            id = Convert.ToInt32(gvTrabajadores.SelectedCells[4].Value);
            obcol = new ne_trabajador().trabajador_sel_by_idtra(id);
            ListTrabajador lt = new ListTrabajador();
            lt.Show();
            foreach (Trabajador obTra in obcol)
            {
                lt.txtNombre.Text = obTra.Nombres;
                lt.txtApellido.Text = obTra.Apellidos;
                lt.txtCorreo.Text = obTra.Correo;
                lt.txtIdenti.Text = Convert.ToString(obTra.Nidentidad);
                lt.cmbModalidad.Text= obTra.Modalidad;
                lt.cmbPuesto.Text = obTra.Puesto;
                lt.npEdad.Value = obTra.Edad;
                lt.cmbTipo.Text = obTra.Tipodoc;
                lt.pbUs.ImageLocation = obTra.Rutaimage;
                return;
            }          
            id = 0;         
        }      
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                gvTrabajadores.DataSource = new ne_trabajador().filtrado_trabajador(txtNombre.Text);
            }
            else
            {
                gvTrabajadores.DataSource = new ne_trabajador().trabajador_sel();
                
            }    
             
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
        public void ExportarDatos(DataGridView gvTrA)
        {
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }
    }
}
