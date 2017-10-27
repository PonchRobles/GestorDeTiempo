using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTiempo
{
    public partial class MenuEncargado : Form
    {
        public MenuEncargado()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Registro R = new Registro();
            R.ShowDialog();
            this.Close();
        }

        private void btnRegistroTipoDeUsuario_Click(object sender, EventArgs e)
        {
            RegistroDeTipoDeUsuario RTU = new RegistroDeTipoDeUsuario();
            RTU.ShowDialog();
            this.Close();
        }

        private void btnProducirUnProducto_Click(object sender, EventArgs e)
        {
            SeleccionarProducto SP = new SeleccionarProducto();
            SP.ShowDialog();
            this.Close();

        }
    }
}
