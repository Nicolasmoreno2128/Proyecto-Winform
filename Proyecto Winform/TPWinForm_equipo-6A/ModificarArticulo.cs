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
    public partial class ModificarArticulo : Form
    {

        private Articulo articulo = null;
        public ModificarArticulo()
        {
            InitializeComponent();
        }
        public ModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cbbCategoria.DataSource = categoriaNegocio.Listar();
                cbbCategoria.ValueMember = "Id";
                cbbCategoria.DisplayMember = "Descripcion";
                cbbMarca.DataSource = marcaNegocio.Listar();
                cbbMarca.ValueMember = "Id";    
                cbbMarca.DisplayMember = "Descripcion"; 


                //Prueba de carga de datos en los campos

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbbMarca.SelectedValue = articulo.Marca.Id;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }

        private void btnModArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                if (articulo == null)
                    articulo = new Articulo();
               
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbbMarca.SelectedItem;

                negocio.Modificar(articulo);

                MessageBox.Show("Se Modifico correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarModArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
