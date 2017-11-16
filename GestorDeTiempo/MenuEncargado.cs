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
            //RTU.Tag = this;
            //RTU.Show(this);
            //Hide();
            RTU.ShowDialog();
            this.Close();
        }

        private void btnProducirUnProducto_Click(object sender, EventArgs e)
        {
            SeleccionarProducto SP = new SeleccionarProducto();
            SP.ShowDialog();
            this.Close();

        }

        private void btnCrearPath_Click(object sender, EventArgs e)
        {
            AgregarLaCreacionDeUnProducto ACP = new AgregarLaCreacionDeUnProducto();
            ACP.ShowDialog();
            this.Close();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            VistaGeneralEncargado VGE = new VistaGeneralEncargado();
            VGE.ShowDialog();
            this.Close();
        }

        private void btnRegistrarDep_Click(object sender, EventArgs e)
        {
            DepartamentoCRUD DEPCRUD = new DepartamentoCRUD();
            DEPCRUD.ShowDialog();
            this.Close();

        }

        private void btnRegistrarProceso_Click(object sender, EventArgs e)
        {
            RegistroDeProceso RP = new RegistroDeProceso();
            RP.ShowDialog();
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            RegistrarWorkStation RWS = new RegistrarWorkStation();
            RWS.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkStationVincularConDepartamento WSVD = new WorkStationVincularConDepartamento();
            WSVD.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoVincularConDepartamento PVD = new ProductoVincularConDepartamento();
            PVD.ShowDialog();
            this.Close();
        }
    }
}
