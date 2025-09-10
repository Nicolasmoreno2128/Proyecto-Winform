namespace TPWinForm_equipo_6A
{
    partial class ListaArticulos
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
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.lblListaArticulos = new System.Windows.Forms.Label();
            this.btbAgregarArticulo = new System.Windows.Forms.Button();
            this.btbModificararticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Location = new System.Drawing.Point(57, 60);
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.Size = new System.Drawing.Size(691, 190);
            this.dgvListaArticulos.TabIndex = 1;
            this.dgvListaArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaArticulos_CellContentClick);
            // 
            // lblListaArticulos
            // 
            this.lblListaArticulos.AutoSize = true;
            this.lblListaArticulos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaArticulos.Location = new System.Drawing.Point(53, 26);
            this.lblListaArticulos.Name = "lblListaArticulos";
            this.lblListaArticulos.Size = new System.Drawing.Size(139, 21);
            this.lblListaArticulos.TabIndex = 2;
            this.lblListaArticulos.Text = "Lista de Artículos";
            // 
            // btbAgregarArticulo
            // 
            this.btbAgregarArticulo.Location = new System.Drawing.Point(57, 340);
            this.btbAgregarArticulo.Name = "btbAgregarArticulo";
            this.btbAgregarArticulo.Size = new System.Drawing.Size(80, 37);
            this.btbAgregarArticulo.TabIndex = 3;
            this.btbAgregarArticulo.Text = "Agregar Artículos";
            this.btbAgregarArticulo.UseVisualStyleBackColor = true;
            this.btbAgregarArticulo.Click += new System.EventHandler(this.btbAgregarArticulo_Click);
            // 
            // btbModificararticulo
            // 
            this.btbModificararticulo.Location = new System.Drawing.Point(181, 340);
            this.btbModificararticulo.Name = "btbModificararticulo";
            this.btbModificararticulo.Size = new System.Drawing.Size(73, 37);
            this.btbModificararticulo.TabIndex = 4;
            this.btbModificararticulo.Text = "Modificar Artículos";
            this.btbModificararticulo.UseVisualStyleBackColor = true;
            this.btbModificararticulo.Click += new System.EventHandler(this.btbModificararticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(299, 340);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(74, 37);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar Articulos";
            this.btnEliminarArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btbModificararticulo);
            this.Controls.Add(this.btbAgregarArticulo);
            this.Controls.Add(this.lblListaArticulos);
            this.Controls.Add(this.dgvListaArticulos);
            this.Name = "ListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaArticulos";
            this.Load += new System.EventHandler(this.ListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.Label lblListaArticulos;
        private System.Windows.Forms.Button btbAgregarArticulo;
        private System.Windows.Forms.Button btbModificararticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
    }
}