using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiForm
{
    public partial class FormTablet : Form
    {
        public string modelo;
        public string marca;
        public Entidades.EPais pais;
        public Entidades.ETipo tipo;
        public FormTablet()
        {
            InitializeComponent();
            this.cmbGama.SelectedIndex = 0;
            this.cmbPais.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.modelo = this.txtModelo.Text;
            this.marca = this.txtMarca.Text;
            Enum.TryParse(this.cmbPais.SelectedItem.ToString(), out pais);
            Enum.TryParse(this.cmbGama.SelectedItem.ToString(), out tipo);
            this.DialogResult = DialogResult.OK;
        }
    }
}
