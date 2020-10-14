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
        public void exportarData(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Reporte_Trabajadores";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Se guardó correctamente el reporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            exportarData(gvTrabajadores);
            
        }
    }
}
