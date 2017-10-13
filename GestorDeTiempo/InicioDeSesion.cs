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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();

        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True";
                con.Open();
                string userid = txtNombreDeUsuario.Text;
                string password = txtPassword.Text;
                SqlCommand cmd = new SqlCommand("select NombreDeUsuario,password,IdTipoDeUsuario from Usuarios where NombreDeUsuario='" + txtNombreDeUsuario.Text + "'and password='" + txtPassword.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();

                    string tipodeUsuario = dt.Rows[0]["IdTIpoDeUsuario"].ToString();
                    switch (tipodeUsuario)
                    {
                        case "1":
                            MenuEncargado ME = new MenuEncargado();
                            ME.ShowDialog();
                            this.Close();
                            break;
                    }

                    //  MessageBox.Show("Login sucess Welcome");

                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

   

    }
