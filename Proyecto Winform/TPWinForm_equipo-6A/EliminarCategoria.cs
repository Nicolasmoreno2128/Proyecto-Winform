using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_6A
{
    public partial class frmEliminarCategoria : Form
    {
        public frmEliminarCategoria()
        {
            InitializeComponent();
        }

        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategorias.DataSource = categoria.Listar();
        }

        private void btnCancelarElimCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria eliminado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro que queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    eliminado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminarRegistro(eliminado.Id);
                    cargar();
                    MessageBox.Show("Eliminado correctamente");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }


        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                dgvCategorias.DataSource = negocio.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
