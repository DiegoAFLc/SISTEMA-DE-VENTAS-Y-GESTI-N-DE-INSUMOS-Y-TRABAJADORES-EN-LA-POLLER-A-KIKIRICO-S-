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
    public partial class ListTrabajador : Form
    {
        public ListTrabajador()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult obRes;
            obRes = MessageBox.Show("¿Estas seguro de modificar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni;
            dni = int.Parse(txtIdenti.Text);
            DialogResult obRes;
            obRes=MessageBox.Show("¿Estas seguro de eliminar el trabajador?","Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(obRes==DialogResult.Yes){
                new ne_trabajador().trabajador_del(dni);             
                this.Close();
            }
            ListadoTrabajador l = new ListadoTrabajador();
            l.gvTrabajadores.DataSource = new ne_trabajador().trabajador_sel();

        }
    }
}
