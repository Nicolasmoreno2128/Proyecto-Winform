namespace TPWinForm_equipo_6A
{
    partial class Principal
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
            this.grbListas = new System.Windows.Forms.GroupBox();
            this.lblListas = new System.Windows.Forms.Label();
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnListaCategorias = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.grbListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListas
            // 
            this.grbListas.Controls.Add(this.btnMarcas);
            this.grbListas.Controls.Add(this.btnListaCategorias);
            this.grbListas.Controls.Add(this.btnListaArticulos);
            this.grbListas.Location = new System.Drawing.Point(17, 49);
            this.grbListas.Name = "grbListas";
            this.grbListas.Size = new System.Drawing.Size(252, 60);
            this.grbListas.TabIndex = 0;
            this.grbListas.TabStop = false;
            // 
            // lblListas
            // 
            this.lblListas.AutoSize = true;
            this.lblListas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListas.Location = new System.Drawing.Point(12, 9);
            this.lblListas.Name = "lblListas";
            this.lblListas.Size = new System.Drawing.Size(63, 25);
            this.lblListas.TabIndex = 1;
            this.lblListas.Text = "Listas";
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Location = new System.Drawing.Point(6, 19);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnListaArticulos.TabIndex = 0;
            this.btnListaArticulos.Text = "Artículos";
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.btnListaArticulos_Click);
            // 
            // btnListaCategorias
            // 
            this.btnListaCategorias.Location = new System.Drawing.Point(87, 19);
            this.btnListaCategorias.Name = "btnListaCategorias";
            this.btnListaCategorias.Size = new System.Drawing.Size(75, 23);
            this.btnListaCategorias.TabIndex = 1;
            this.btnListaCategorias.Text = "Categorias";
            this.btnListaCategorias.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(168, 19);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListas);
            this.Controls.Add(this.grbListas);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.grbListas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListas;
        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Label lblListas;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnListaCategorias;
    }
}