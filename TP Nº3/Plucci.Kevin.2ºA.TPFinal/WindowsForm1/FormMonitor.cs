using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForm1
{
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();
        }

        private void VolverM_Click(object sender, EventArgs e)
        {
            FormInicio frmInicio = new FormInicio();

            this.Hide();

            frmInicio.Show();
        }

        private void CrearM_Click(object sender, EventArgs e)
        {
            dgwM.Rows.Add(marcaM.Text, calidadM.Text, pulgadasM.Text);
        }
        /// <summary>
        /// Guardaremos la serializacion.
        /// </summary>
        /// <param name="sender">Remitente</param>
        /// <param name="e">Clase base</param>
        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos.ShowDialog() == DialogResult.OK)
                {
                    List<string> filas = new List<string>();

                    List<string> cabeceras = new List<string>();

                    foreach (DataGridViewColumn col in dgwM.Columns)
                    {
                        cabeceras.Add(col.HeaderText);
                    }

                    string separador = "|";
                    filas.Add(string.Join(separador, cabeceras));

                    foreach (DataGridViewRow fila in dgwM.Rows)
                    {
                        try
                        {
                            string strLinea = "";

                            foreach (DataGridViewCell cel in fila.Cells)
                            {
                                if (cel.Value == null)
                                {
                                    strLinea += "";
                                }
                                else
                                {
                                    strLinea += cel.Value.ToString();
                                    strLinea += "|";
                                }
                            }

                            filas.Add(string.Join(separador, strLinea));
                        }
                        catch (Exception ex) { }
                    }

                    File.WriteAllLines(guardarDatos.FileName, filas);

                    MessageBox.Show("Guardado con exito");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }
        }
    }
}
