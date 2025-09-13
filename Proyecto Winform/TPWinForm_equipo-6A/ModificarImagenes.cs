using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_6A
{
    public partial class ModificarImagenes : Form
    {
        private Imagen imagen = null;
        public ModificarImagenes()
        {
            InitializeComponent();
        }
        public ModificarImagenes(Imagen imagen)
        {
            InitializeComponent();
            this.imagen = imagen;

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            try
            {
                if (imagen == null)
                    imagen = new Imagen();

                imagen.IdArticulo = int.Parse(txtIdArticulo.Text);
                imagen.ImagenUrl = txtUrlImagen.Text;

                negocio.ModificarImagen(imagen);

                MessageBox.Show("Se Modifico correctamente");
                Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void ModificarImagenes_Load(object sender, EventArgs e)
        {
            try
            {

                if (imagen != null)
                {

                    txtIdArticulo.Text = imagen.IdArticulo.ToString();
                    txtUrlImagen.Text = imagen.ImagenUrl;

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
