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
    public partial class ModificarMarca : Form
    {

        private Marca marca = null;    

        public ModificarMarca()
        {
            InitializeComponent();
        }

        public ModificarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
           MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtDescripcion.Text;

                negocio.Modificar(marca);

                MessageBox.Show("Se Modifico correctamente");
                Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {

            try
            {

                if (marca  != null)
                {

                    txtDescripcion.Text = marca.Descripcion;

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
