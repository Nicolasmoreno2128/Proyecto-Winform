namespace TPWinForm_equipo_6A
{
    partial class EliminarImagen
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
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.pboImagenes = new System.Windows.Forms.PictureBox();
            this.lblEliminarImagen = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenes.Location = new System.Drawing.Point(27, 58);
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(328, 306);
            this.dgvImagenes.TabIndex = 0;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // pboImagenes
            // 
            this.pboImagenes.Location = new System.Drawing.Point(398, 58);
            this.pboImagenes.Name = "pboImagenes";
            this.pboImagenes.Size = new System.Drawing.Size(320, 306);
            this.pboImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenes.TabIndex = 1;
            this.pboImagenes.TabStop = false;
            // 
            // lblEliminarImagen
            // 
            this.lblEliminarImagen.AutoSize = true;
            this.lblEliminarImagen.Location = new System.Drawing.Point(44, 27);
            this.lblEliminarImagen.Name = "lblEliminarImagen";
            this.lblEliminarImagen.Size = new System.Drawing.Size(35, 13);
            this.lblEliminarImagen.TabIndex = 2;
            this.lblEliminarImagen.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(562, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(643, 401);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EliminarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 452);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblEliminarImagen);
            this.Controls.Add(this.pboImagenes);
            this.Controls.Add(this.dgvImagenes);
            this.MaximumSize = new System.Drawing.Size(795, 491);
            this.MinimumSize = new System.Drawing.Size(795, 491);
            this.Name = "EliminarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Imagen";
            this.Load += new System.EventHandler(this.EliminarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.PictureBox pboImagenes;
        private System.Windows.Forms.Label lblEliminarImagen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
    }
}