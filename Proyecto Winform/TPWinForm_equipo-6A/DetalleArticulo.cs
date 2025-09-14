using dominio;
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
    public partial class frmDetalleArticulo : Form
    {
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("C");
            lblMarca.Text = articulo.Marca.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
        }

        private void btnCancelarDetalleArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
