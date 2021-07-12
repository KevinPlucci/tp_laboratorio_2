namespace WindowsForm1
{
    partial class FormInicio
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
            this.Monitor = new System.Windows.Forms.Button();
            this.Televisor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.Color.Tan;
            this.Monitor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Monitor.Location = new System.Drawing.Point(62, 122);
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(110, 48);
            this.Monitor.TabIndex = 0;
            this.Monitor.Text = "Fabricar Monitor";
            this.Monitor.UseVisualStyleBackColor = false;
            this.Monitor.Click += new System.EventHandler(this.Monitor_Click);
            // 
            // Televisor
            // 
            this.Televisor.BackColor = System.Drawing.Color.Tan;
            this.Televisor.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Televisor.Location = new System.Drawing.Point(234, 122);
            this.Televisor.Name = "Televisor";
            this.Televisor.Size = new System.Drawing.Size(110, 48);
            this.Televisor.TabIndex = 1;
            this.Televisor.Text = "Fabricar Televisor";
            this.Televisor.UseVisualStyleBackColor = false;
            this.Televisor.Click += new System.EventHandler(this.Televisor_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Miriam Mono CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(62, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "¿Qué desea fabricar?";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Orange;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(21, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Fabrica de monitores y televisores";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(415, 207);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Televisor);
            this.Controls.Add(this.Monitor);
            this.Name = "FormInicio";
            this.Text = "Plucci Kevin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Monitor;
        private System.Windows.Forms.Button Televisor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

