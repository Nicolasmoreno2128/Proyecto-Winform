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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnListaArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListaArticulos))
                    return;
            }
            ListaArticulos ventana3 = new ListaArticulos();
            ventana3.ShowDialog();
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

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            frmEliminarArticulo eliminar = new frmEliminarArticulo();
            eliminar.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnListarArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListaArticulos))
                    return;
            }
            ListaArticulos ventana3 = new ListaArticulos();
            ventana3.ShowDialog();
        }

        private void btbModificararticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            frmEliminarCategoria eliminarCategoria = new frmEliminarCategoria();
            eliminarCategoria.ShowDialog();
        }

        private void btnListaCategorias_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListaCategorias))
                    return;
            }
            ListaCategorias ventana = new ListaCategorias();
            ventana.ShowDialog();
        }

        private void btnListaMarcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListaMarcas))
                    return;
            }
            ListaMarcas ventana = new ListaMarcas();
            ventana.ShowDialog();
        }

        private void btbAgregarCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarCategoria))
                    return;
            }
            AgregarCategoria alta = new AgregarCategoria();
            alta.ShowDialog();
        }

        private void btbAgregarMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarMarcas))
                    return;
            }
            AgregarMarcas alta = new AgregarMarcas();
            alta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
