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
    public partial class ModificarCategoria : Form
    {

        private Categoria categoria = null;
        public ModificarCategoria()
        {
            InitializeComponent();
        }
        public ModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null)
                    categoria = new Categoria();  
                
                categoria.Descripcion = txtDescripcion.Text;               

                negocio.Modificar(categoria);

                MessageBox.Show("Se Modifico correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
