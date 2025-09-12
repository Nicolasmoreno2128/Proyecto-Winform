using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_6A
{
    public partial class ListaCategorias : Form
    {
        public ListaCategorias()
        {
            InitializeComponent();
        }

        public void ListaCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvListaCategoria.DataSource = categoria.Listar();
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvListaCategoria.CurrentRow.DataBoundItem;

            ModificarCategoria modificar = new ModificarCategoria(seleccionado);
            modificar.ShowDialog();
        }
    }
}
