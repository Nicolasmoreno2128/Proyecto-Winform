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

        private bool ValidarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }

            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar");
                return true;
            }
            return false;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (ValidarFiltro())
                    return;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
                detalle.ShowDialog();
            }
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCampo.SelectedItem.ToString() == "Id")
            {
                numFiltro.Increment = 1;      
                numFiltro.Maximum = 1000000;  
                numFiltro.Minimum = 0;
                numFiltro.Value = 0;
            }
            else if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                numFiltro.Increment = 1000;  
                numFiltro.Maximum = 10000000;  
                numFiltro.Minimum = 0;
                numFiltro.Value = 0;

            }
        }
    }
}
