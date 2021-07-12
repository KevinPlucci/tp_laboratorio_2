namespace WindowsForm1
{
    partial class FormMonitor
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
            this.marcaM = new System.Windows.Forms.ComboBox();
            this.calidadM = new System.Windows.Forms.ComboBox();
            this.pulgadasM = new System.Windows.Forms.ComboBox();
            this.CrearM = new System.Windows.Forms.Button();
            this.tbF = new System.Windows.Forms.TextBox();
            this.VolverM = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.guardarDatos = new System.Windows.Forms.SaveFileDialog();
            this.btnVerLog = new System.Windows.Forms.Button();
            this.txtVisorTickets = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaM
            // 
            this.marcaM.FormattingEnabled = true;
            this.marcaM.Items.AddRange(new object[] {
            "Zowie",
            "Viewsonic",
            "Samsung"});
            this.marcaM.Location = new System.Drawing.Point(28, 38);
            this.marcaM.Name = "marcaM";
            this.marcaM.Size = new System.Drawing.Size(121, 21);
            this.marcaM.TabIndex = 0;
            this.marcaM.Text = "Elija marca";
            // 
            // calidadM
            // 
            this.calidadM.FormattingEnabled = true;
            this.calidadM.Items.AddRange(new object[] {
            "FullHD",
            "_4K",
            "_8K"});
            this.calidadM.Location = new System.Drawing.Point(28, 100);
            this.calidadM.Name = "calidadM";
            this.calidadM.Size = new System.Drawing.Size(121, 21);
            this.calidadM.TabIndex = 2;
            this.calidadM.Text = "Calidad";
            // 
            // pulgadasM
            // 
            this.pulgadasM.FormattingEnabled = true;
            this.pulgadasM.Items.AddRange(new object[] {
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
            this.pulgadasM.Location = new System.Drawing.Point(28, 161);
            this.pulgadasM.Name = "pulgadasM";
            this.pulgadasM.Size = new System.Drawing.Size(121, 21);
            this.pulgadasM.TabIndex = 3;
            this.pulgadasM.Text = "Pulgadas";
            this.pulgadasM.SelectedIndexChanged += new System.EventHandler(this.pulgadasM_SelectedIndexChanged);
            // 
            // CrearM
            // 
            this.CrearM.BackColor = System.Drawing.Color.LemonChiffon;
            this.CrearM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrearM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CrearM.Location = new System.Drawing.Point(28, 227);
            this.CrearM.Name = "CrearM";
            this.CrearM.Size = new System.Drawing.Size(121, 55);
            this.CrearM.TabIndex = 4;
            this.CrearM.Text = "Crear Monitor";
            this.CrearM.UseVisualStyleBackColor = false;
            this.CrearM.Click += new System.EventHandler(this.CrearM_Click);
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
            // VolverM
            // 
            this.VolverM.BackColor = System.Drawing.Color.LemonChiffon;
            this.VolverM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolverM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VolverM.Location = new System.Drawing.Point(433, 308);
            this.VolverM.Name = "VolverM";
            this.VolverM.Size = new System.Drawing.Size(147, 23);
            this.VolverM.TabIndex = 7;
            this.VolverM.Text = "Volver al inicio";
            this.VolverM.UseVisualStyleBackColor = false;
            this.VolverM.Click += new System.EventHandler(this.VolverM_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.guardar.Location = new System.Drawing.Point(248, 308);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(147, 23);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar datos";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // btnVerLog
            // 
            this.btnVerLog.Location = new System.Drawing.Point(612, 309);
            this.btnVerLog.Name = "btnVerLog";
            this.btnVerLog.Size = new System.Drawing.Size(205, 23);
            this.btnVerLog.TabIndex = 28;
            this.btnVerLog.Text = "Abrir archivo";
            this.btnVerLog.UseVisualStyleBackColor = true;
            this.btnVerLog.Click += new System.EventHandler(this.btnVerLog_Click);
            // 
            // txtVisorTickets
            // 
            this.txtVisorTickets.Location = new System.Drawing.Point(612, 100);
            this.txtVisorTickets.Multiline = true;
            this.txtVisorTickets.Name = "txtVisorTickets";
            this.txtVisorTickets.Size = new System.Drawing.Size(205, 179);
            this.txtVisorTickets.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(612, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 19);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Ya Fabricado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 188);
            this.dataGridView1.TabIndex = 31;
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(927, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtVisorTickets);
            this.Controls.Add(this.btnVerLog);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.VolverM);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.CrearM);
            this.Controls.Add(this.pulgadasM);
            this.Controls.Add(this.calidadM);
            this.Controls.Add(this.marcaM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox marcaM;
        private System.Windows.Forms.ComboBox calidadM;
        private System.Windows.Forms.ComboBox pulgadasM;
        private System.Windows.Forms.Button CrearM;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Button VolverM;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.SaveFileDialog guardarDatos;
        private System.Windows.Forms.Button btnVerLog;
        private System.Windows.Forms.TextBox txtVisorTickets;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}