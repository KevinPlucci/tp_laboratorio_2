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

    public partial class FormTelevisor : Form
    {
        string xml_Televisores = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableTelevisores.xml";
        string xml_Televisores_Schema = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\DataTableTelevisoresSchema.xml";
        protected SqlDataAdapter da;

        protected DataTable dt;

        SqlConnection cn;

        public bool confirma;
        public FormTelevisor(bool Confirma)
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
                this.da.InsertCommand = new SqlCommand("INSERT INTO Televisores (id, marca, calidad, pulgadas) VALUES (@id, @marca, @calidad, @pulgadas)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE Televisores SET marca=@marca, calidad=@calidad, pulgadas=@pulgadas WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM Televisores WHERE id=@id", cn);

                this.da.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 100, "id");
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

        private void crearT_Click(object sender, EventArgs e)
        {
            DataRow fila = this.dt.NewRow();

            fila[1] = this.marcaT.Text;
            fila[2] = this.calidadT.Text;
            fila[3] = this.pulgadasT.Text;

            this.dt.Rows.Add(fila);

            da.Update(dt);
        }

        /// <summary>
        /// Guardaremos la serializacion.
        /// </summary>
        /// <param name="sender">Remitente</param>
        /// <param name="e">Clase base</param>
        private void guardar_Click(object sender, EventArgs e)
        {
        List<Television> auxTelevisor = new List<Television>();
            
            
            try
            {
                string consultaP = "SELECT * FROM Televisores WHERE id = @id";

                


                SqlCommand comandP = new SqlCommand(consultaP, cn);


                GuardarDataTable();

                //comandP.Parameters.AddWithValue("@id", CrearM.Text);
                comandP.ExecuteNonQuery();
                SqlDataReader infoP = comandP.ExecuteReader();


                while (infoP.Read())
                {


                    ECalidad Calidad = (ECalidad)Enum.Parse(typeof(ECalidad), infoP["calidad"].ToString());
                    EMarcaTel marcaTelev = (EMarcaTel)Enum.Parse(typeof(EMarcaTel), infoP["marca"].ToString());
                    int id = Convert.ToInt32(infoP["id"].ToString());
                    int pulgadas = Convert.ToInt32(infoP["pulgadas"].ToString());

                    Television televisores = new Television(id, pulgadas, Calidad, marcaTelev);


                }
            }

            catch (Exception ex)
            {

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
                this.dt.WriteXmlSchema(xml_Televisores_Schema);

                this.dt.WriteXml(xml_Televisores);

                System.Threading.Thread.Sleep(2000);
                MessageBox.Show("Se han guardado el esquema y los datos del DataTable!!!");

            }
            catch
            {
                MessageBox.Show("Error al guardar el DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void volverT_Click(object sender, EventArgs e)
        {
            //FormInicio frmInicio = new FormInicio();

            //this.Hide();

            //frmInicio.Show();
            
            this.Close();

        }


    }

}
