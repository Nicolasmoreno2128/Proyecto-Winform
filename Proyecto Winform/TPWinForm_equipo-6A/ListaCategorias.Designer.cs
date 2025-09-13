namespace TPWinForm_equipo_6A
{
    partial class ListaCategorias
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
            this.dgvListaCategoria = new System.Windows.Forms.DataGridView();
            this.lblListaCategorias = new System.Windows.Forms.Label();
            this.btbCerrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCategoria
            // 
            this.dgvListaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaCategoria.Location = new System.Drawing.Point(31, 71);
            this.dgvListaCategoria.Name = "dgvListaCategoria";
            this.dgvListaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCategoria.Size = new System.Drawing.Size(256, 210);
            this.dgvListaCategoria.TabIndex = 0;
            // 
            // lblListaCategorias
            // 
            this.lblListaCategorias.AutoSize = true;
            this.lblListaCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategorias.Location = new System.Drawing.Point(31, 29);
            this.lblListaCategorias.MaximumSize = new System.Drawing.Size(151, 21);
            this.lblListaCategorias.MinimumSize = new System.Drawing.Size(151, 21);
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Size = new System.Drawing.Size(151, 21);
            this.lblListaCategorias.TabIndex = 1;
            this.lblListaCategorias.Text = "Lista de categorias";
            this.lblListaCategorias.UseMnemonic = false;
            // 
            // btbCerrar
            // 
            this.btbCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btbCerrar.Location = new System.Drawing.Point(212, 312);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(75, 23);
            this.btbCerrar.TabIndex = 2;
            this.btbCerrar.Text = "Cerrar";
            this.btbCerrar.UseVisualStyleBackColor = true;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(131, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 356);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btbCerrar);
            this.Controls.Add(this.lblListaCategorias);
            this.Controls.Add(this.dgvListaCategoria);
            this.MaximumSize = new System.Drawing.Size(338, 600);
            this.MinimumSize = new System.Drawing.Size(338, 395);
            this.Name = "ListaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCategorias";
            this.Load += new System.EventHandler(this.ListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCategoria;
        private System.Windows.Forms.Label lblListaCategorias;
        private System.Windows.Forms.Button btbCerrar;
        private System.Windows.Forms.Button btnModificar;
    }
}