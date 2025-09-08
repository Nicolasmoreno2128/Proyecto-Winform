namespace TPWinForm_equipo_6A
{
    partial class AgregarArticulo
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
            this.lblNuevoCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNuevoNombreArticulo = new System.Windows.Forms.Label();
            this.lblNuevaDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblNuevoPrecioArticulo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lvlNuevoArticulo = new System.Windows.Forms.Label();
            this.btnCrearNuevoArticulo = new System.Windows.Forms.Button();
            this.btnCancelarNuevoArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoCodigoArticulo
            // 
            this.lblNuevoCodigoArticulo.AutoSize = true;
            this.lblNuevoCodigoArticulo.Location = new System.Drawing.Point(55, 70);
            this.lblNuevoCodigoArticulo.Name = "lblNuevoCodigoArticulo";
            this.lblNuevoCodigoArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblNuevoCodigoArticulo.TabIndex = 1;
            this.lblNuevoCodigoArticulo.Text = "Código";
            // 
            // lblNuevoNombreArticulo
            // 
            this.lblNuevoNombreArticulo.AutoSize = true;
            this.lblNuevoNombreArticulo.Location = new System.Drawing.Point(55, 109);
            this.lblNuevoNombreArticulo.Name = "lblNuevoNombreArticulo";
            this.lblNuevoNombreArticulo.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoNombreArticulo.TabIndex = 2;
            this.lblNuevoNombreArticulo.Text = "Nombre";
            // 
            // lblNuevaDescripcionArticulo
            // 
            this.lblNuevaDescripcionArticulo.AutoSize = true;
            this.lblNuevaDescripcionArticulo.Location = new System.Drawing.Point(55, 152);
            this.lblNuevaDescripcionArticulo.Name = "lblNuevaDescripcionArticulo";
            this.lblNuevaDescripcionArticulo.Size = new System.Drawing.Size(63, 13);
            this.lblNuevaDescripcionArticulo.TabIndex = 3;
            this.lblNuevaDescripcionArticulo.Text = "Descripción";
            // 
            // lblNuevoPrecioArticulo
            // 
            this.lblNuevoPrecioArticulo.AutoSize = true;
            this.lblNuevoPrecioArticulo.Location = new System.Drawing.Point(55, 193);
            this.lblNuevoPrecioArticulo.Name = "lblNuevoPrecioArticulo";
            this.lblNuevoPrecioArticulo.Size = new System.Drawing.Size(37, 13);
            this.lblNuevoPrecioArticulo.TabIndex = 4;
            this.lblNuevoPrecioArticulo.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 86);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(58, 169);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(58, 210);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lvlNuevoArticulo
            // 
            this.lvlNuevoArticulo.AutoSize = true;
            this.lvlNuevoArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNuevoArticulo.Location = new System.Drawing.Point(54, 28);
            this.lvlNuevoArticulo.Name = "lvlNuevoArticulo";
            this.lvlNuevoArticulo.Size = new System.Drawing.Size(135, 21);
            this.lvlNuevoArticulo.TabIndex = 10;
            this.lvlNuevoArticulo.Text = "Agregar Artículo";
            // 
            // btnCrearNuevoArticulo
            // 
            this.btnCrearNuevoArticulo.Location = new System.Drawing.Point(31, 253);
            this.btnCrearNuevoArticulo.Name = "btnCrearNuevoArticulo";
            this.btnCrearNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearNuevoArticulo.TabIndex = 11;
            this.btnCrearNuevoArticulo.Text = "Crear";
            this.btnCrearNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnCrearNuevoArticulo.Click += new System.EventHandler(this.btnCrearNuevoArticulo_Click);
            // 
            // btnCancelarNuevoArticulo
            // 
            this.btnCancelarNuevoArticulo.Location = new System.Drawing.Point(124, 253);
            this.btnCancelarNuevoArticulo.Name = "btnCancelarNuevoArticulo";
            this.btnCancelarNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevoArticulo.TabIndex = 12;
            this.btnCancelarNuevoArticulo.Text = "Cancelar";
            this.btnCancelarNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoArticulo.Click += new System.EventHandler(this.btnCancelarNuevoArticulo_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 365);
            this.Controls.Add(this.btnCancelarNuevoArticulo);
            this.Controls.Add(this.btnCrearNuevoArticulo);
            this.Controls.Add(this.lvlNuevoArticulo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNuevoPrecioArticulo);
            this.Controls.Add(this.lblNuevaDescripcionArticulo);
            this.Controls.Add(this.lblNuevoNombreArticulo);
            this.Controls.Add(this.lblNuevoCodigoArticulo);
            this.MaximumSize = new System.Drawing.Size(262, 404);
            this.MinimumSize = new System.Drawing.Size(262, 404);
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNuevoCodigoArticulo;
        private System.Windows.Forms.Label lblNuevoNombreArticulo;
        private System.Windows.Forms.Label lblNuevaDescripcionArticulo;
        private System.Windows.Forms.Label lblNuevoPrecioArticulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lvlNuevoArticulo;
        private System.Windows.Forms.Button btnCrearNuevoArticulo;
        private System.Windows.Forms.Button btnCancelarNuevoArticulo;
    }
}