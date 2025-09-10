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
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuevoCodigoArticulo
            // 
            this.lblNuevoCodigoArticulo.AutoSize = true;
            this.lblNuevoCodigoArticulo.Location = new System.Drawing.Point(55, 58);
            this.lblNuevoCodigoArticulo.Name = "lblNuevoCodigoArticulo";
            this.lblNuevoCodigoArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblNuevoCodigoArticulo.TabIndex = 1;
            this.lblNuevoCodigoArticulo.Text = "Código";
            // 
            // lblNuevoNombreArticulo
            // 
            this.lblNuevoNombreArticulo.AutoSize = true;
            this.lblNuevoNombreArticulo.Location = new System.Drawing.Point(55, 97);
            this.lblNuevoNombreArticulo.Name = "lblNuevoNombreArticulo";
            this.lblNuevoNombreArticulo.Size = new System.Drawing.Size(44, 13);
            this.lblNuevoNombreArticulo.TabIndex = 2;
            this.lblNuevoNombreArticulo.Text = "Nombre";
            // 
            // lblNuevaDescripcionArticulo
            // 
            this.lblNuevaDescripcionArticulo.AutoSize = true;
            this.lblNuevaDescripcionArticulo.Location = new System.Drawing.Point(55, 140);
            this.lblNuevaDescripcionArticulo.Name = "lblNuevaDescripcionArticulo";
            this.lblNuevaDescripcionArticulo.Size = new System.Drawing.Size(63, 13);
            this.lblNuevaDescripcionArticulo.TabIndex = 3;
            this.lblNuevaDescripcionArticulo.Text = "Descripción";
            // 
            // lblNuevoPrecioArticulo
            // 
            this.lblNuevoPrecioArticulo.AutoSize = true;
            this.lblNuevoPrecioArticulo.Location = new System.Drawing.Point(55, 181);
            this.lblNuevoPrecioArticulo.Name = "lblNuevoPrecioArticulo";
            this.lblNuevoPrecioArticulo.Size = new System.Drawing.Size(37, 13);
            this.lblNuevoPrecioArticulo.TabIndex = 4;
            this.lblNuevoPrecioArticulo.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(58, 157);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(58, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lvlNuevoArticulo
            // 
            this.lvlNuevoArticulo.AutoSize = true;
            this.lvlNuevoArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNuevoArticulo.Location = new System.Drawing.Point(54, 18);
            this.lvlNuevoArticulo.Name = "lvlNuevoArticulo";
            this.lvlNuevoArticulo.Size = new System.Drawing.Size(135, 21);
            this.lvlNuevoArticulo.TabIndex = 10;
            this.lvlNuevoArticulo.Text = "Agregar Artículo";
            // 
            // btnCrearNuevoArticulo
            // 
            this.btnCrearNuevoArticulo.Location = new System.Drawing.Point(39, 315);
            this.btnCrearNuevoArticulo.Name = "btnCrearNuevoArticulo";
            this.btnCrearNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCrearNuevoArticulo.TabIndex = 11;
            this.btnCrearNuevoArticulo.Text = "Crear";
            this.btnCrearNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnCrearNuevoArticulo.Click += new System.EventHandler(this.btnCrearNuevoArticulo_Click);
            // 
            // btnCancelarNuevoArticulo
            // 
            this.btnCancelarNuevoArticulo.Location = new System.Drawing.Point(132, 315);
            this.btnCancelarNuevoArticulo.Name = "btnCancelarNuevoArticulo";
            this.btnCancelarNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevoArticulo.TabIndex = 12;
            this.btnCancelarNuevoArticulo.Text = "Cancelar";
            this.btnCancelarNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoArticulo.Click += new System.EventHandler(this.btnCancelarNuevoArticulo_Click);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(58, 237);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbbCategoria.TabIndex = 13;
            // 
            // cbbMarca
            // 
            this.cbbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(58, 277);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbbMarca.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(57, 221);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(57, 261);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 365);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbbMarca);
            this.Controls.Add(this.cbbCategoria);
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
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
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
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
    }
}