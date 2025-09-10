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
            //Prueba de carga de datos en los campos

            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
            }
        }
    }
}
