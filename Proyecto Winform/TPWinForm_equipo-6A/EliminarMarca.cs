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
    public partial class frmEliminarMarca : Form
    {
        public frmEliminarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarElimMar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            dgvMarcas.DataSource = marca.Listar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca eliminado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro que queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    eliminado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.EliminarMarca(eliminado.Id);
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
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarcas.DataSource = negocio.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
