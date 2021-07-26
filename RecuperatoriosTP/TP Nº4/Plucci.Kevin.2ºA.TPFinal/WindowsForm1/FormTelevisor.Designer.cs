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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaT
            // 
            this.marcaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaT.FormattingEnabled = true;
            this.marcaT.Items.AddRange(new object[] {
            " LG",
            "Sony",
            "Philips"});
            this.marcaT.Location = new System.Drawing.Point(28, 38);
            this.marcaT.Name = "marcaT";
            this.marcaT.Size = new System.Drawing.Size(121, 21);
            this.marcaT.TabIndex = 0;
            // 
            // calidadT
            // 
            this.calidadT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calidadT.FormattingEnabled = true;
            this.calidadT.Items.AddRange(new object[] {
            "FullHD",
            "_4K",
            "_8K"});
            this.calidadT.Location = new System.Drawing.Point(28, 100);
            this.calidadT.Name = "calidadT";
            this.calidadT.Size = new System.Drawing.Size(121, 21);
            this.calidadT.TabIndex = 2;
            // 
            // pulgadasT
            // 
            this.pulgadasT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.txtVisorTickets.ReadOnly = true;
            this.txtVisorTickets.Size = new System.Drawing.Size(205, 179);
            this.txtVisorTickets.TabIndex = 29;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(28, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 19);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "Marca";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(28, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 19);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "Calidad";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(28, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 19);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "Pulgadas";
            // 
            // FormTelevisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(916, 354);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}