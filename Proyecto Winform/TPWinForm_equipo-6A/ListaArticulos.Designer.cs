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
            this.btbModificararticulo = new System.Windows.Forms.Button();
            this.numFiltro = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArticulos.Location = new System.Drawing.Point(57, 85);
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(775, 303);
            this.dgvListaArticulos.TabIndex = 1;
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
            // btbModificararticulo
            // 
            this.btbModificararticulo.Location = new System.Drawing.Point(598, 403);
            this.btbModificararticulo.Name = "btbModificararticulo";
            this.btbModificararticulo.Size = new System.Drawing.Size(73, 23);
            this.btbModificararticulo.TabIndex = 4;
            this.btbModificararticulo.Text = "Modificar Artículos";
            this.btbModificararticulo.UseVisualStyleBackColor = true;
            this.btbModificararticulo.Click += new System.EventHandler(this.btbModificararticulo_Click);
            // 
            // numFiltro
            // 
            this.numFiltro.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFiltro.Location = new System.Drawing.Point(463, 56);
            this.numFiltro.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numFiltro.Name = "numFiltro";
            this.numFiltro.Size = new System.Drawing.Size(120, 20);
            this.numFiltro.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(598, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(284, 56);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 18;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(245, 59);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 17;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(54, 60);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 16;
            this.lblCampo.Text = "Campo:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(103, 56);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 15;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(422, 59);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(757, 403);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(677, 403);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(74, 23);
            this.btnDetalle.TabIndex = 22;
            this.btnDetalle.Text = "Detalles";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.numFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btbModificararticulo);
            this.Controls.Add(this.lblListaArticulos);
            this.Controls.Add(this.dgvListaArticulos);
            this.MaximumSize = new System.Drawing.Size(900, 489);
            this.MinimumSize = new System.Drawing.Size(900, 489);
            this.Name = "ListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaArticulos";
            this.Load += new System.EventHandler(this.ListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.Label lblListaArticulos;
        private System.Windows.Forms.Button btbModificararticulo;
        private System.Windows.Forms.NumericUpDown numFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDetalle;
    }
}