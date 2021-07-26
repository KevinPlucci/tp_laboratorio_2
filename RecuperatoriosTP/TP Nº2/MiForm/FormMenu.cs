using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MiForm
{
    public partial class FormMenu : Form
    {
        Deposito deposito = 200;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            FormCelular formCelular = new FormCelular();
            formCelular.ShowDialog();
            if (formCelular.DialogResult==DialogResult.OK)
            {
                Celular celular = new Celular(formCelular.modelo, new Fabricante(formCelular.marca, formCelular.pais), formCelular.gama);
                deposito += celular;
            }
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {
            FormTablet formTablet = new FormTablet();
            formTablet.ShowDialog();
            if (formTablet.DialogResult == DialogResult.OK)
            {
                Tablet tablet = new Tablet(formTablet.modelo, formTablet.marca, formTablet.pais, formTablet.tipo);
                deposito += tablet;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Deposito.Mostrar(this.deposito)}");
        }
    }
}
