
namespace MiForm
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCelular = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCelular
            // 
            this.btnCelular.Location = new System.Drawing.Point(23, 24);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(156, 81);
            this.btnCelular.TabIndex = 0;
            this.btnCelular.Text = "Celular";
            this.btnCelular.UseVisualStyleBackColor = true;
            this.btnCelular.Click += new System.EventHandler(this.btnCelular_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.Location = new System.Drawing.Point(211, 24);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(156, 81);
            this.btnTablet.TabIndex = 1;
            this.btnTablet.Text = "Tablet";
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(120, 124);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(156, 81);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 216);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnTablet);
            this.Controls.Add(this.btnCelular);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCelular;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnMostrar;
    }
}

