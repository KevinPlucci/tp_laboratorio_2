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
using System.Data.SqlClient;

namespace WindowsForm1
{
    
    public partial class FormTelevisor : Form
    {
        protected SqlDataAdapter da;
        protected DataTable dt;

        public bool confirma;
        public FormTelevisor(bool Confirma)
        {
            InitializeComponent();
            this.dt = new DataTable("Televisores");
            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;
            
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; // lo agregue yo, no esta en la cascara.


            this.StartPosition = FormStartPosition.CenterScreen;

            this.confirma = Confirma;

        }

        /// <summary>
        /// Boton volver.Click (Vuelve al inicio)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volverT_Click(object sender, EventArgs e)
        {
            //FormInicio frmInicio = new FormInicio();

            //this.Hide();

            //rmInicio.Show();

            this.Close();


        }

        /// <summary>
        /// Boton crear o agregar Televisor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crearT_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(marcaT.Text, calidadT.Text, pulgadasT.Text);
        }

        /// <summary>
        /// Boton guardar(Guarda datos en la tabla y los guarda en archivos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if(guardarDatos.ShowDialog() == DialogResult.OK)
                {
                        List<string> filas = new List<string>();

                        List<string> cabeceras = new List<string>();

                        foreach(DataGridViewColumn col in dataGridView1.Columns)
                        {
                            cabeceras.Add(col.HeaderText);
                        }

                        string separador = "|";
                        filas.Add(string.Join(separador, cabeceras));

                        foreach(DataGridViewRow fila in dataGridView1.Rows)
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

        private void FormTelevisor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormTelevisor_Load(object sender, EventArgs e)
        {

        }

        private void btnVerLog_Click(object sender, EventArgs e)
        {
            DialogResult rta = openFileDialog1.ShowDialog();//Reemplazar por la llamada al método correspondiente del OpenFileDialog

            if (rta == DialogResult.OK)
            {
                //leer el archivo seleccionado por el cliente y mostrarlo en txtVisorTickets

                string path = openFileDialog1.FileName;
                string texto;
                StreamReader f = new StreamReader(path);

                texto = f.ReadToEnd();

                this.txtVisorTickets.Text = texto;
            }
        }

        private void txtVisorTickets_TextChanged(object sender, EventArgs e)
        {

        }

        #region DataAdapter
        /// <summary>
        /// Configuracion del Data Adapter
        /// </summary>
        /// <returns></returns>
        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                SqlConnection cn; cn = new SqlConnection(Properties.Settings.Default.Conexion);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT id, marca, calidad, pulgadas FROM Televisores", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO Televisores (marca, calidad, pulgadas) VALUES (@marca, @calidad, @pulgadas)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE Televisores SET marca=@marca, calidad=@calidad, pulgadas=@pulgadas WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM Televisores WHERE id=@id", cn);

                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@calidad", SqlDbType.VarChar, 50, "calidad");
                this.da.InsertCommand.Parameters.Add("@pulgadas", SqlDbType.Int, 100, "pulgadas");

                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@calidad", SqlDbType.VarChar, 50, "calidad");
                this.da.UpdateCommand.Parameters.Add("@calidad", SqlDbType.Int, 100, "pulgadas");
                //this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }

        #endregion

        #region DataGridView

        /// <summary>
        /// Configuracion de la Grilla
        /// </summary>
        private void ConfigurarGrilla()
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Wheat;

            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood;

            this.dataGridView1.BackgroundColor = Color.Beige;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.GridColor = Color.HotPink;

            this.dataGridView1.ReadOnly = false;

            this.dataGridView1.MultiSelect = false;

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            this.dataGridView1.RowHeadersVisible = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion



    }
}
