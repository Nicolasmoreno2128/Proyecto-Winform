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
    public partial class frmEliminarArticulo : Form
    {
        private List<ListaArticulos> listaArticulos;
        public frmEliminarArticulo()
        {
            InitializeComponent();
        }

        private void frmEliminarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            dgvEliminar.DataSource = articulo.listar();
    }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo eliminado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro que queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                eliminado = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
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
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvEliminar.DataSource = negocio.listar();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
