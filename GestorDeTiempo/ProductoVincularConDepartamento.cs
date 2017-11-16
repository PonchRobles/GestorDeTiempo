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
    public partial class ProductoVincularConDepartamento : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public ProductoVincularConDepartamento()
        {
            InitializeComponent();
        }

        private void ProductoVincularConDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tablaProductoParaVincularConDepartamento.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.tablaProductoParaVincularConDepartamento.Producto);
            // TODO: This line of code loads data into the 'tablaDepartamentoParaVincularConProducto.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.tablaDepartamentoParaVincularConProducto.Departamento);

        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            try
            {


                if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
                {
                    cmd = new SqlCommand(@"insert into ProductoPorDepartamento(IdDepartamento,IdProducto)
                                                values(@IdDepartamento,@IdProducto)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@IdDepartamento", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@IdProducto", comboBox2.SelectedValue);
                    // cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();
            ME.ShowDialog();
            this.Close();
        }
    }
}
