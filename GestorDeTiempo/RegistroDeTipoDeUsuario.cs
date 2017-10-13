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
    public partial class RegistroDeTipoDeUsuario : Form
    {
            
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public RegistroDeTipoDeUsuario()
        {
            InitializeComponent();
        }

        private void btnResitrarTipo_Click(object sender, EventArgs e)
        {

            try
            {


                if (txtNombreDeTipo.Text != "")
                {
                    cmd = new SqlCommand("insert into TipoDeUsuario(NombreTipoDeUsuario) values(@NombreTipoDeUsuario)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@NombreTipoDeUsuario", txtNombreDeTipo.Text);
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
    }
}
