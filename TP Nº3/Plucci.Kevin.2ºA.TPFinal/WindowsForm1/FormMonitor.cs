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

    public partial class FormMonitor : Form
    {
        protected SqlDataAdapter da;
        protected DataTable dt;

        public bool confirma;
        public FormMonitor(bool Confirma)
        {
            {
                InitializeComponent();

                if (!this.ConfigurarDataAdapter())
                {
                    MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                    this.Close();
                }

                this.ConfigurarDataTable();

                try
                {
                    this.da.Fill(this.dt);

                    this.ConfigurarGrilla();

                    this.dataGridView1.DataSource = this.dt;

                    txtVisorTickets.ScrollBars = ScrollBars.Vertical;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                
            }
        }

        #region DataTable
        /// <summary>
        /// Configuracion de Data Table
        /// </summary>
        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Fabrica");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("calidad", typeof(string));
            this.dt.Columns.Add("pulgadas", typeof(int));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;
        }
        #endregion

        private void VolverM_Click(object sender, EventArgs e)
        {
            //FormInicio frmInicio = new FormInicio();

            //this.Hide();

            //frmInicio.Show();

            this.Close();
        }

        private void CrearM_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(marcaM.Text, calidadM.Text, pulgadasM.Text);
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

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        cabeceras.Add(col.HeaderText);
                    }

                    string separador = "|";
                    filas.Add(string.Join(separador, cabeceras));

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
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

        private void pulgadasM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cerrarForm(object sender, FormClosingEventArgs e)
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

                this.da.SelectCommand = new SqlCommand("SELECT id, marca, calidad, pulgadas FROM Monitor", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO Monitor (marca, calidad, pulgadas) VALUES (@marca, @calidad, @pulgadas)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE Monitor SET marca=@marca, calidad=@calidad, pulgadas=@pulgadas WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM Monitor WHERE id=@id", cn);

                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@calidad", SqlDbType.VarChar, 50, "calidad");
                this.da.InsertCommand.Parameters.Add("@pulgadas", SqlDbType.Int, 100, "pulgadas");

                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@calidad", SqlDbType.VarChar, 50, "calidad");
                this.da.UpdateCommand.Parameters.Add("@pulgadas", SqlDbType.Int, 100, "pulgadas");
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

        }


    }

}
