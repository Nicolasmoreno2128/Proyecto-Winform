namespace Proyecto_Winform
{
    partial class Frm1
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
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Location = new System.Drawing.Point(199, 158);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(207, 66);
            this.BtnArticulos.TabIndex = 0;
            this.BtnArticulos.Text = "Articulos";
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 407);
            this.Controls.Add(this.BtnArticulos);
            this.Name = "Frm1";
            this.Text = "Primer ventana del Proyecto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnArticulos;
    }
}

