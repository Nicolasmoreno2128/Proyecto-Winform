namespace TPWinForm_equipo_6A
{
    partial class frmDetalleArticulo
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblDetalleImagen = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.btnCancelarDetalleArticulo = new System.Windows.Forms.Button();
            this.lvlDetalleArticulo = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(130, 309);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(59, 13);
            this.lblMarca.TabIndex = 70;
            this.lblMarca.Text = "labelMarca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(129, 269);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 13);
            this.lblCategoria.TabIndex = 69;
            this.lblCategoria.Text = "labelCategoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(130, 229);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 13);
            this.lblPrecio.TabIndex = 68;
            this.lblPrecio.Text = "labelPrecio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(130, 188);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 13);
            this.lblDescripcion.TabIndex = 67;
            this.lblDescripcion.Text = "labelDescripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(133, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 13);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "labelNombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(130, 106);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 13);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "labelCodigo";
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(290, 122);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(218, 200);
            this.pcbImagen.TabIndex = 64;
            this.pcbImagen.TabStop = false;
            // 
            // lblDetalleImagen
            // 
            this.lblDetalleImagen.AutoSize = true;
            this.lblDetalleImagen.Location = new System.Drawing.Point(287, 106);
            this.lblDetalleImagen.Name = "lblDetalleImagen";
            this.lblDetalleImagen.Size = new System.Drawing.Size(45, 13);
            this.lblDetalleImagen.TabIndex = 63;
            this.lblDetalleImagen.Text = "Imagen:";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Location = new System.Drawing.Point(36, 309);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(40, 13);
            this.lblDetalleMarca.TabIndex = 62;
            this.lblDetalleMarca.Text = "Marca:";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(36, 269);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblDetalleCategoria.TabIndex = 61;
            this.lblDetalleCategoria.Text = "Categoria:";
            // 
            // btnCancelarDetalleArticulo
            // 
            this.btnCancelarDetalleArticulo.Location = new System.Drawing.Point(17, 365);
            this.btnCancelarDetalleArticulo.Name = "btnCancelarDetalleArticulo";
            this.btnCancelarDetalleArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDetalleArticulo.TabIndex = 60;
            this.btnCancelarDetalleArticulo.Text = "Cancelar";
            this.btnCancelarDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarDetalleArticulo.Click += new System.EventHandler(this.btnCancelarDetalleArticulo_Click);
            // 
            // lvlDetalleArticulo
            // 
            this.lvlDetalleArticulo.AutoSize = true;
            this.lvlDetalleArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDetalleArticulo.Location = new System.Drawing.Point(165, 44);
            this.lvlDetalleArticulo.Name = "lvlDetalleArticulo";
            this.lvlDetalleArticulo.Size = new System.Drawing.Size(207, 28);
            this.lvlDetalleArticulo.TabIndex = 59;
            this.lvlDetalleArticulo.Text = "Detalle del Articulo";
            this.lvlDetalleArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(34, 229);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(40, 13);
            this.lblDetallePrecio.TabIndex = 58;
            this.lblDetallePrecio.Text = "Precio:";
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(34, 188);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDetalleDescripcion.TabIndex = 57;
            this.lblDetalleDescripcion.Text = "Descripción:";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(34, 145);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(47, 13);
            this.lblDetalleNombre.TabIndex = 56;
            this.lblDetalleNombre.Text = "Nombre:";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(34, 106);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblDetalleCodigo.TabIndex = 55;
            this.lblDetalleCodigo.Text = "Código:";
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lblDetalleImagen);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.lblDetalleCategoria);
            this.Controls.Add(this.btnCancelarDetalleArticulo);
            this.Controls.Add(this.lvlDetalleArticulo);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Name = "frmDetalleArticulo";
            this.Text = "Detalle de Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblDetalleImagen;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.Button btnCancelarDetalleArticulo;
        private System.Windows.Forms.Label lvlDetalleArticulo;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label lblDetalleCodigo;
    }
}