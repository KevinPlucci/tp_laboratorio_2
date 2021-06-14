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
    public partial class FormTelevisor : Form
    {
        public FormTelevisor()
        {
            InitializeComponent();
        }

        private void volverT_Click(object sender, EventArgs e)
        {
            FormInicio frmInicio = new FormInicio();

            this.Hide();

            frmInicio.Show();
        }

        private void crearT_Click(object sender, EventArgs e)
        {
            dgwT.Rows.Add(marcaT.Text, calidadT.Text, pulgadasT.Text);
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if(guardarDatos.ShowDialog() == DialogResult.OK)
                {
                        List<string> filas = new List<string>();

                        List<string> cabeceras = new List<string>();

                        foreach(DataGridViewColumn col in dgwT.Columns)
                        {
                            cabeceras.Add(col.HeaderText);
                        }

                        string separador = "|";
                        filas.Add(string.Join(separador, cabeceras));

                        foreach(DataGridViewRow fila in dgwT.Rows)
                        {
                            try
                            {
                                string strLinea = "";

                                foreach(DataGridViewCell cel in fila.Cells)
                                {
                                    if(cel.Value == null)
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
