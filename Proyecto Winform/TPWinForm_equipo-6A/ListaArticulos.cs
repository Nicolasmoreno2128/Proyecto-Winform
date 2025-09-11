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
    public partial class ListaArticulos : Form
    {
        public ListaArticulos()
        {
            InitializeComponent();
        }

        public void ListaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            dgvListaArticulos.DataSource = articulo.listar();
            cbxCampo.Items.Add("Id");
            cbxCampo.Items.Add("Precio");
            cbxCriterio.Items.Add("Mayor a");
            cbxCriterio.Items.Add("Menor a");
            cbxCriterio.Items.Add("Igual a");
        }               

        private void btbAgregarArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarArticulo))
                    return;
            }
            AgregarArticulo alta = new AgregarArticulo();
            alta.ShowDialog();
        }

        private void btbModificararticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado=(Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

            ModificarArticulo modificar = new ModificarArticulo(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            frmEliminarArticulo eliminar = new frmEliminarArticulo();
            eliminar.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                int filtro = (int)numFiltro.Value;
                dgvListaArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
