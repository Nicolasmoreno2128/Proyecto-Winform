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
    public partial class AgregarImagen : Form
    {
        public AgregarImagen()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen();
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                imagen.IdArticulo = int.Parse(txtIdArticulo.Text);
                imagen.ImagenUrl = txtUrlImagen.Text;

                negocio.agregar(imagen);
                MessageBox.Show("Se agregó correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
