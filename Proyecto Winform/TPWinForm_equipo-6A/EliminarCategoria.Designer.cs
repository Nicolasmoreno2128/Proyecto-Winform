namespace TPWinForm_equipo_6A
{
    partial class frmEliminarCategoria
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarElimCat = new System.Windows.Forms.Button();
            this.lblEliminarCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AccessibleName = "hola";
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(25, 62);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(250, 184);
            this.dgvCategorias.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(58, 257);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnCancelarElimCat
            // 
            this.btnCancelarElimCat.Location = new System.Drawing.Point(162, 257);
            this.btnCancelarElimCat.Name = "btnCancelarElimCat";
            this.btnCancelarElimCat.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarElimCat.TabIndex = 2;
            this.btnCancelarElimCat.Text = "Cancelar";
            this.btnCancelarElimCat.UseVisualStyleBackColor = true;
            this.btnCancelarElimCat.Click += new System.EventHandler(this.btnCancelarElimCat_Click);
            // 
            // lblEliminarCategoria
            // 
            this.lblEliminarCategoria.AutoSize = true;
            this.lblEliminarCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCategoria.Location = new System.Drawing.Point(22, 23);
            this.lblEliminarCategoria.Name = "lblEliminarCategoria";
            this.lblEliminarCategoria.Size = new System.Drawing.Size(150, 21);
            this.lblEliminarCategoria.TabIndex = 3;
            this.lblEliminarCategoria.Text = "Eliminar Categoria";
            // 
            // frmEliminarCategoria
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.Controls.Add(this.lblEliminarCategoria);
            this.Controls.Add(this.btnCancelarElimCat);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.MaximumSize = new System.Drawing.Size(335, 331);
            this.MinimumSize = new System.Drawing.Size(335, 331);
            this.Name = "frmEliminarCategoria";
            this.Text = "EliminarCategoria";
            this.Load += new System.EventHandler(this.frmEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnCancelarElimCat;
        private System.Windows.Forms.Label lblEliminarCategoria;
    }
}