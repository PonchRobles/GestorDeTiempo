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
    public partial class RegistrarWorkStation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public RegistrarWorkStation()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();
            ME.ShowDialog();
            this.Close();
        }

        private void btnRegistrarWorkStation_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtWorkStationNombre.Text != string.Empty)
                {
                    cmd = new SqlCommand("insert into WorkStation (NombreWorkStation) values(@name)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txtWorkStationNombre.Text);
                   
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
