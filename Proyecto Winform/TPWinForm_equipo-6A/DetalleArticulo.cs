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
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        private List<Imagen> imagenes;
        private int indiceActual = 0;
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            imagenes = negocio.Listar().FindAll(x => x.IdArticulo == articulo.Id);

            if (imagenes.Count > 0)
                {
                    indiceActual = 0;
                    mostrarImagen(imagenes[indiceActual].ImagenUrl);
                }
                else
                {
                    mostrarImagen(""); // muestra la imagen de "no disponible"
                }
        }
        private void mostrarImagen(string url)
        {
            try
            {
                pcbImagen.Load(url);
            }
            catch
            {
                pcbImagen.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0) return;

            indiceActual++;
            if (indiceActual >= imagenes.Count)
                indiceActual = 0; // vuelve al principio

            mostrarImagen(imagenes[indiceActual].ImagenUrl);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0) return;

            indiceActual--;
            if (indiceActual < 0)
                indiceActual = imagenes.Count - 1; // va al final

            mostrarImagen(imagenes[indiceActual].ImagenUrl);
        }
    }
}
