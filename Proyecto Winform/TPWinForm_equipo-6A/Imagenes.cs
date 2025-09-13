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
    public partial class Imagenes : Form
    {
        private List<Imagen> listaImagen;
        public Imagenes()
        {
            InitializeComponent();
        }

        public void ListaImagens_Load(object sender, EventArgs e)
            {
            ImagenNegocio imagen = new ImagenNegocio();
            listaImagen = imagen.Listar();
            dgvImagenes.DataSource = listaImagen;
            cargarImagen(listaImagen[0].ImagenUrl);
            }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            cargarImagen(seleccionada.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pboArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pboArticulo.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Imagen seleccionado;
            seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

            ModificarImagenes modificar = new ModificarImagenes(seleccionado);
            modificar.ShowDialog();
        }
    }    
}
