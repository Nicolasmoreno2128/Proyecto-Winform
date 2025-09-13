namespace TPWinForm_equipo_6A
{
    partial class frmEliminarMarca
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
            this.btnCancelarElimMar = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarElimMar
            // 
            this.btnCancelarElimMar.Location = new System.Drawing.Point(156, 232);
            this.btnCancelarElimMar.Name = "btnCancelarElimMar";
            this.btnCancelarElimMar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarElimMar.TabIndex = 5;
            this.btnCancelarElimMar.Text = "Cancelar";
            this.btnCancelarElimMar.UseVisualStyleBackColor = true;
            this.btnCancelarElimMar.Click += new System.EventHandler(this.btnCancelarElimMar_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(65, 232);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 4;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AccessibleName = "hola";
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(26, 33);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(258, 184);
            this.dgvMarcas.TabIndex = 3;
            // 
            // frmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 292);
            this.Controls.Add(this.btnCancelarElimMar);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.MaximumSize = new System.Drawing.Size(335, 331);
            this.MinimumSize = new System.Drawing.Size(335, 331);
            this.Name = "frmEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Marca";
            this.Load += new System.EventHandler(this.EliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarElimMar;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}