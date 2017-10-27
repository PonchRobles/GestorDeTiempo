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
    public partial class Registro : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Registro()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (txtNombreDeUsuario.Text != "" && txtPassword.Text != "")
            {
                cmd = new SqlCommand("insert into Usuarios(NombreDeUsuario,IdTipoDeUsuario,Password) values(@name,@tipodeusuarioid,@password)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txtNombreDeUsuario.Text);
                cmd.Parameters.AddWithValue("@tipodeusuarioid",Convert.ToInt32(lboxTipoDeUsuario.SelectedValue));
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
               
                DisplayData();
                ClearData();
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
        private void DisplayData()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Usuarios", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }
        //Clear Data  
        private void ClearData()
        {
            try
            {
                txtNombreDeUsuario.Text = "";
                txtPassword.Text = "";
                ID = 0;
               // lboxTipoDeUsuario.Items.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNombreDeUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lboxTipoDeUsuario.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtPassword.Text != "")
            {
                cmd = new SqlCommand("update Usuarios set (@name,@tipodeusuarioid,@password where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtNombreDeUsuario.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@tipodeusuarioid", lboxTipoDeUsuario.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Usuarios where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestorTiempoDataSet.TipoDeUsuario' table. You can move, or remove it, as needed.
            this.tipoDeUsuarioTableAdapter.Fill(this.gestorTiempoDataSet.TipoDeUsuario);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();
            ME.ShowDialog();
            this.Close();
        }
    }
}
