namespace TPWinForm_equipo_6A
{
    partial class ListaMarcas
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblListaMarcas = new System.Windows.Forms.Label();
            this.dgvListaMarca = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrar.Location = new System.Drawing.Point(188, 301);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblListaMarcas
            // 
            this.lblListaMarcas.AutoSize = true;
            this.lblListaMarcas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMarcas.Location = new System.Drawing.Point(35, 29);
            this.lblListaMarcas.Name = "lblListaMarcas";
            this.lblListaMarcas.Size = new System.Drawing.Size(127, 21);
            this.lblListaMarcas.TabIndex = 1;
            this.lblListaMarcas.Text = "Lista de marcas";
            // 
            // dgvListaMarca
            // 
            this.dgvListaMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaMarca.Location = new System.Drawing.Point(39, 64);
            this.dgvListaMarca.Name = "dgvListaMarca";
            this.dgvListaMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarca.Size = new System.Drawing.Size(224, 203);
            this.dgvListaMarca.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(56, 301);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ListaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 356);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvListaMarca);
            this.Controls.Add(this.lblListaMarcas);
            this.Controls.Add(this.btnCerrar);
            this.MaximumSize = new System.Drawing.Size(338, 600);
            this.MinimumSize = new System.Drawing.Size(338, 395);
            this.Name = "ListaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaMarcas";
            this.Load += new System.EventHandler(this.ListaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblListaMarcas;
        private System.Windows.Forms.DataGridView dgvListaMarca;
        private System.Windows.Forms.Button btnModificar;
    }
}