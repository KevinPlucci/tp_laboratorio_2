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
            this.dgwM = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulgadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardar = new System.Windows.Forms.Button();
            this.guardarDatos = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwM)).BeginInit();
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
            // 
            // CrearM
            // 
            this.CrearM.BackColor = System.Drawing.Color.LemonChiffon;
            this.CrearM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrearM.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.tbF.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbF.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbF.Location = new System.Drawing.Point(223, 38);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(192, 20);
            this.tbF.TabIndex = 6;
            this.tbF.Text = "Fabricando...";
            // 
            // VolverM
            // 
            this.VolverM.BackColor = System.Drawing.Color.LemonChiffon;
            this.VolverM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolverM.Font = new System.Drawing.Font("Miriam Mono CLM", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VolverM.Location = new System.Drawing.Point(433, 308);
            this.VolverM.Name = "VolverM";
            this.VolverM.Size = new System.Drawing.Size(147, 23);
            this.VolverM.TabIndex = 7;
            this.VolverM.Text = "Volver al inicio";
            this.VolverM.UseVisualStyleBackColor = false;
            this.VolverM.Click += new System.EventHandler(this.VolverM_Click);
            // 
            // dgwM
            // 
            this.dgwM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Calidad,
            this.Pulgadas});
            this.dgwM.Location = new System.Drawing.Point(223, 64);
            this.dgwM.Name = "dgwM";
            this.dgwM.Size = new System.Drawing.Size(357, 218);
            this.dgwM.TabIndex = 8;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Calidad
            // 
            this.Calidad.HeaderText = "Calidad";
            this.Calidad.Name = "Calidad";
            this.Calidad.ReadOnly = true;
            // 
            // Pulgadas
            // 
            this.Pulgadas.HeaderText = "Pulgadas";
            this.Pulgadas.Name = "Pulgadas";
            this.Pulgadas.ReadOnly = true;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LemonChiffon;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Font = new System.Drawing.Font("Miriam Mono CLM", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.guardar.Location = new System.Drawing.Point(248, 308);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(147, 23);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar datos";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(604, 349);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.dgwM);
            this.Controls.Add(this.VolverM);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.CrearM);
            this.Controls.Add(this.pulgadasM);
            this.Controls.Add(this.calidadM);
            this.Controls.Add(this.marcaM);
            this.Name = "FormMonitor";
            this.Text = "FormMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgwM)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pulgadas;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.SaveFileDialog guardarDatos;
    }
}