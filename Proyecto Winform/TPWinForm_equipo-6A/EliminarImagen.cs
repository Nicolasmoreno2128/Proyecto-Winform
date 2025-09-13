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
    public partial class EliminarImagen : Form
    {
        public EliminarImagen()
        {
            InitializeComponent();
        }
        private void EliminarImagen_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagen = new ImagenNegocio();
            dgvImagenes.DataSource = imagen.Listar();
           
        }        
        private void cargarImagen(string imagen)
        {
            try
            {
                pboImagenes.Load(imagen);
            }
            catch (Exception ex)
            {

                pboImagenes.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            cargarImagen(seleccionada.ImagenUrl);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen eliminada;
            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro que queres eliminarla?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    eliminada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    negocio.EliminarImagen(eliminada.Id);
                    cargar();
                    MessageBox.Show("Eliminado correctamente");                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        private void cargar()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            try
            {
                dgvImagenes.DataSource = negocio.Listar();

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
    }
}
