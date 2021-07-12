namespace WindowsForm1
{
    partial class FormTelevisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.marcaT = new System.Windows.Forms.ComboBox();
            this.calidadT = new System.Windows.Forms.ComboBox();
            this.pulgadasT = new System.Windows.Forms.ComboBox();
            this.tbF = new System.Windows.Forms.TextBox();
            this.volverT = new System.Windows.Forms.Button();
            this.crearT = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.guardarDatos = new System.Windows.Forms.SaveFileDialog();
            this.btnVerLog = new System.Windows.Forms.Button();
            this.txtVisorTickets = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaT
            // 
            this.marcaT.FormattingEnabled = true;
            this.marcaT.Items.AddRange(new object[] {
            " LG",
            "Sony",
            "Philips"});
            this.marcaT.Location = new System.Drawing.Point(28, 38);
            this.marcaT.Name = "marcaT";
            this.marcaT.Size = new System.Drawing.Size(121, 21);
            this.marcaT.TabIndex = 0;
            this.marcaT.Text = "Elija marca";
            // 
            // calidadT
            // 
            this.calidadT.FormattingEnabled = true;
            this.calidadT.Items.AddRange(new object[] {
            "FullHD",
            "_4K",
            "_8K"});
            this.calidadT.Location = new System.Drawing.Point(28, 100);
            this.calidadT.Name = "calidadT";
            this.calidadT.Size = new System.Drawing.Size(121, 21);
            this.calidadT.TabIndex = 2;
            this.calidadT.Text = "Calidad";
            // 
            // pulgadasT
            // 
            this.pulgadasT.FormattingEnabled = true;
            this.pulgadasT.Items.AddRange(new object[] {
            "22",
            "24",
            "28",
            "32",
            "40",
            "42",
            "43",
            "48",
            "49",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "77",
            "85"});
            this.pulgadasT.Location = new System.Drawing.Point(28, 161);
            this.pulgadasT.Name = "pulgadasT";
            this.pulgadasT.Size = new System.Drawing.Size(121, 21);
            this.pulgadasT.TabIndex = 3;
            this.pulgadasT.Text = "Pulgadas";
            // 
            // tbF
            // 
            this.tbF.BackColor = System.Drawing.Color.DarkOrange;
            this.tbF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbF.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbF.Location = new System.Drawing.Point(223, 38);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(192, 19);
            this.tbF.TabIndex = 6;
            this.tbF.Text = "Fabricando...";
            // 
            // volverT
            // 
            this.volverT.BackColor = System.Drawing.Color.LemonChiffon;
            this.volverT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volverT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.volverT.Location = new System.Drawing.Point(433, 310);
            this.volverT.Name = "volverT";
            this.volverT.Size = new System.Drawing.Size(147, 23);
            this.volverT.TabIndex = 9;
            this.volverT.Text = "Volver al inicio";
            this.volverT.UseVisualStyleBackColor = false;
            this.volverT.Click += new System.EventHandler(this.volverT_Click);
            // 
            // crearT
            // 
            this.crearT.BackColor = System.Drawing.Color.LemonChiffon;
            this.crearT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crearT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.crearT.Location = new System.Drawing.Point(28, 227);
            this.crearT.Name = "crearT";
            this.crearT.Size = new System.Drawing.Size(121, 55);
            this.crearT.TabIndex = 10;
            this.crearT.Text = "Crear Televisor";
            this.crearT.UseVisualStyleBackColor = false;
            this.crearT.Click += new System.EventHandler(this.crearT_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.guardar.Location = new System.Drawing.Point(245, 310);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(147, 23);
            this.guardar.TabIndex = 11;
            this.guardar.Text = "Guardar datos";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // btnVerLog
            // 
            this.btnVerLog.Location = new System.Drawing.Point(642, 310);
            this.btnVerLog.Name = "btnVerLog";
            this.btnVerLog.Size = new System.Drawing.Size(205, 23);
            this.btnVerLog.TabIndex = 28;
            this.btnVerLog.Text = "Abrir archivo";
            this.btnVerLog.UseVisualStyleBackColor = true;
            this.btnVerLog.Click += new System.EventHandler(this.btnVerLog_Click);
            // 
            // txtVisorTickets
            // 
            this.txtVisorTickets.Location = new System.Drawing.Point(642, 100);
            this.txtVisorTickets.Multiline = true;
            this.txtVisorTickets.Name = "txtVisorTickets";
            this.txtVisorTickets.Size = new System.Drawing.Size(205, 179);
            this.txtVisorTickets.TabIndex = 29;
            this.txtVisorTickets.TextChanged += new System.EventHandler(this.txtVisorTickets_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(642, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 19);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Ya Fabricado";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 190);
            this.dataGridView1.TabIndex = 31;
            // 
            // FormTelevisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(916, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtVisorTickets);
            this.Controls.Add(this.btnVerLog);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.crearT);
            this.Controls.Add(this.volverT);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.pulgadasT);
            this.Controls.Add(this.calidadT);
            this.Controls.Add(this.marcaT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTelevisor";
            this.Text = "FormTelevisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTelevisor_FormClosing);
            this.Load += new System.EventHandler(this.FormTelevisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox marcaT;
        private System.Windows.Forms.ComboBox calidadT;
        private System.Windows.Forms.ComboBox pulgadasT;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Button volverT;
        private System.Windows.Forms.Button crearT;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.SaveFileDialog guardarDatos;
        private System.Windows.Forms.Button btnVerLog;
        private System.Windows.Forms.TextBox txtVisorTickets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}