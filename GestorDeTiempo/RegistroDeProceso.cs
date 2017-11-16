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
    public partial class RegistroDeProceso : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        DataSet ds;
        public RegistroDeProceso()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select IdProceso,NombreProceso,EstadoProceso,IdDepartamento,TiempoRecomendado,TiempoNoRecomendado from Proceso", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();
            ME.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProceso.Text != "")
                {
                    string TiempoR = txtTiempoR.Text;
                    string TiempoNoR = txtTiempoNoR.Text;
                    cmd = new SqlCommand(@"insert into Proceso (NombreProceso,EstadoProceso,IdDepartamento,TiempoRecomendado,TiempoNoRecomendado)
                        values(@NombreProceso,@EstadoProceso,@IdDepartamento,@TiempoRecomendado,@TiempoNoRecomendado)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@NombreProceso", txtNombreProceso.Text);
                    cmd.Parameters.AddWithValue("@EstadoProceso",1);
                    cmd.Parameters.AddWithValue("@IdDepartamento", lboxTipoDeUsuario.SelectedValue);
                    cmd.Parameters.AddWithValue("@TiempoRecomendado", SqlDbType.Time).Value = TimeSpan.Parse(TiempoR);
                    cmd.Parameters.AddWithValue("@TiempoNoRecomendado", SqlDbType.Time).Value = TimeSpan.Parse(TiempoNoR);
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

        private void RegistroDeProceso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaDepartamentoParaProcesos.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.tablaDepartamentoParaProcesos.Departamento);

        }
    }
}
