using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTiempo
{
    public partial class DepartamentoCRUD : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public DepartamentoCRUD()
        {
            InitializeComponent();
        }

        private void btnCrearDep_Click(object sender, EventArgs e)
        {

            try
            {


                if (txtNombreDepartamento.Text != "")
                {
                    cmd = new SqlCommand(@"insert into Departamento (NombreDepartamento,IdUsuario) 
                                                                values(@NombreDepartamento,@IdUsuario)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@NombreDepartamento", txtNombreDepartamento.Text);
                    cmd.Parameters.AddWithValue("@IdUsuario",listBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");

                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartamentoCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaUsuariosParaCrearDepartamento.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.tablaUsuariosParaCrearDepartamento.Usuarios);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();

            ME.ShowDialog();
            this.Close();
        }
    }
}
