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

namespace WindowsForm1
{
    public partial class FormInicio : Form
    {
        public bool confirma=false;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Monitor_Click(object sender, EventArgs e)
        {

            FormMonitor frmMonitor = new FormMonitor(confirma);
            
            if (frmMonitor.Visible==true)              
            {
                confirma = false;
                this.Hide();
            }

            frmMonitor.Show();

            
        }

        private void Televisor_Click(object sender, EventArgs e)
        {
            FormTelevisor frmTelevisor = new FormTelevisor(confirma);

           if(frmTelevisor.Visible==true)
            {
                confirma = false;
                this.Hide();
            } 
            
            frmTelevisor.Show();
        }
        
    }
}
