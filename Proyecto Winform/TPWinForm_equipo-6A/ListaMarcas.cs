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
    public partial class ListaMarcas : Form
    {
        public ListaMarcas()
        {
            InitializeComponent();
        }
        public void ListaMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            dgvListaMarca.DataSource = marca.Listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
