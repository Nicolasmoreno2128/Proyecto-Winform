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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevoArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearNuevoArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbbMarca.SelectedItem;

                negocio.agregar(articulo);
                MessageBox.Show("Se agrego correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cbbCategoria.DataSource = categoriaNegocio.Listar();
                cbbMarca.DataSource = marcaNegocio.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
