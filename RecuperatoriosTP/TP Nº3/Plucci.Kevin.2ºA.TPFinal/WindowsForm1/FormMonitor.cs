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
using Entidades;

namespace WindowsForm1
{

    public partial class FormMonitor : Form
    {
        string xml_Monitores = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableMonitoresDatos.xml";
        string xml_Monitores_Schema = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableMonitoresSchema.xml";
        public int contador = 0;

        protected SqlDataAdapter da;

        protected DataTable dt;

        SqlConnection cn;

        public bool confirma;
        public FormMonitor(bool Confirma)
        {
            {
                InitializeComponent();
                calidadM.DataSource = Enum.GetValues(typeof(ECalidad));
                marcaM.DataSource = Enum.GetValues(typeof(EMarcaMoni));


                if (!this.ConfigurarDataAdapter())
                {
                    System.Threading.Thread.Sleep(2000);
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
                this.cn = new SqlConnection(Properties.Settings.Default.Conexion);

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
        private void VolverM_Click(object sender, EventArgs e)
        {
            //FormInicio frmInicio = new FormInicio();

            //this.Hide();

            //frmInicio.Show();

            this.Close();
        }

        private void CrearM_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                DataRow fila = this.dt.NewRow();
                
                
                Monitor monitor = new Monitor(contador, int.Parse(pulgadasM.Text), (ECalidad)Enum.Parse(typeof(ECalidad),calidadM.Text), (EMarcaMoni)Enum.Parse(typeof(EMarcaMoni), marcaM.Text));
                

                
                fila["marca"] = monitor.MarcaMoni;
                
                fila["calidad"] = monitor.Calidad;
                fila["pulgadas"] = monitor.Pulgadas;
                
                this.dt.Rows.Add(fila);
                
                da.Update(dt);
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString()+"Campos vacios.");
            }



        }


        private void guardar_Click(object sender, EventArgs e)
        {
            List<Monitor> auxMonitor = new List<Monitor>();

            try
            {
                string consultaP = "SELECT * FROM Monitor WHERE id = @id";

                cn.Open();


                SqlCommand comandP = new SqlCommand(consultaP, cn);
                

                GuardarDataTable();

                //comandP.Parameters.AddWithValue("@id", CrearM.Text);
                comandP.ExecuteNonQuery();
                SqlDataReader infoP = comandP.ExecuteReader();
                

                while (infoP.Read())
                {


                    ECalidad Calidad = (ECalidad)Enum.Parse(typeof(ECalidad), infoP["calidad"].ToString());
                    EMarcaMoni MarcaMoni = (EMarcaMoni)Enum.Parse(typeof(EMarcaMoni), infoP["marca"].ToString());
                    int id = Convert.ToInt32(infoP["id"].ToString());
                    int pulgadas = Convert.ToInt32(infoP["pulgadas"].ToString());

                    Monitor monitores = new Monitor(id, pulgadas, Calidad, MarcaMoni);


                }
            }

            catch(Exception ex) 
            {
               
            }


            finally
            {
                cn.Close();
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

                System.Threading.Thread.Sleep(2000);
                string path = openFileDialog1.FileName;
                string texto;
                StreamReader f = new StreamReader(path);

                texto = f.ReadToEnd();

                this.txtVisorTickets.Text = texto;
            }
        }



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

        private void GuardarDataTable()
        {
            try
            {
                this.dt.WriteXmlSchema(xml_Monitores_Schema);

                this.dt.WriteXml(xml_Monitores);

                System.Threading.Thread.Sleep(2000);
                MessageBox.Show("Se han guardado el esquema y los datos del DataTable!!!");

            }
            catch
            {
                MessageBox.Show("Error al guardar el DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void marcaM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
