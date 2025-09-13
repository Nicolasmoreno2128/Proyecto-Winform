namespace TPWinForm_equipo_6A
{
    partial class AgregarImagen
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
            this.lblAgegarImagen = new System.Windows.Forms.Label();
            this.lblIdArticulo = new System.Windows.Forms.Label();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.lblDireccionUrl = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgegarImagen
            // 
            this.lblAgegarImagen.AutoSize = true;
            this.lblAgegarImagen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgegarImagen.Location = new System.Drawing.Point(51, 33);
            this.lblAgegarImagen.Name = "lblAgegarImagen";
            this.lblAgegarImagen.Size = new System.Drawing.Size(134, 21);
            this.lblAgegarImagen.TabIndex = 0;
            this.lblAgegarImagen.Text = "Agregar Imagen";
            // 
            // lblIdArticulo
            // 
            this.lblIdArticulo.AutoSize = true;
            this.lblIdArticulo.Location = new System.Drawing.Point(51, 69);
            this.lblIdArticulo.Name = "lblIdArticulo";
            this.lblIdArticulo.Size = new System.Drawing.Size(74, 13);
            this.lblIdArticulo.TabIndex = 1;
            this.lblIdArticulo.Text = "ID del artículo";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdArticulo.Location = new System.Drawing.Point(54, 97);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(182, 20);
            this.txtIdArticulo.TabIndex = 2;
            // 
            // lblDireccionUrl
            // 
            this.lblDireccionUrl.AutoSize = true;
            this.lblDireccionUrl.Location = new System.Drawing.Point(51, 142);
            this.lblDireccionUrl.Name = "lblDireccionUrl";
            this.lblDireccionUrl.Size = new System.Drawing.Size(92, 13);
            this.lblDireccionUrl.TabIndex = 3;
            this.lblDireccionUrl.Text = "URL de la imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlImagen.Location = new System.Drawing.Point(54, 167);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(182, 20);
            this.txtUrlImagen.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(54, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(161, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblDireccionUrl);
            this.Controls.Add(this.txtIdArticulo);
            this.Controls.Add(this.lblIdArticulo);
            this.Controls.Add(this.lblAgegarImagen);
            this.MaximumSize = new System.Drawing.Size(600, 308);
            this.MinimumSize = new System.Drawing.Size(308, 308);
            this.Name = "AgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgegarImagen;
        private System.Windows.Forms.Label lblIdArticulo;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label lblDireccionUrl;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}