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
    public partial class AgregarLaCreacionDeUnProducto : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public AgregarLaCreacionDeUnProducto()
        {
            InitializeComponent();
        }

        private void AgregarLaCreacionDeUnProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestorTiempoDataSet3.Proceso' table. You can move, or remove it, as needed.
            this.procesoTableAdapter.Fill(this.gestorTiempoDataSet3.Proceso);
            // TODO: This line of code loads data into the 'selectedDepartamento.Departamento' table. You can move, or remove it, as needed.
            this.departamentoTableAdapter.Fill(this.selectedDepartamento.Departamento);
            // TODO: This line of code loads data into the 'gestorTiempoDataSet1.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.gestorTiempoDataSet1.Producto);

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into ProductoDepartamentoProceso (IdProducto,IdDepartamento,IdProceso,StartTime,IdEstado) values(@IdProducto,@IdDepartamento,@IdProceso,@StartTime,@IdEstado)", con);
                con.Open();
                cmd.Parameters.AddWithValue("IdProducto", this.comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("IdDepartamento", this.comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("IdProceso", this.comboBox3.SelectedValue);
                cmd.Parameters.AddWithValue("StartTime", this.dateTimePicker1.Value.ToLongDateString().ToString());
                cmd.Parameters.AddWithValue("IdEstado", 1);
                //cmd.Parameters.AddWithValue("@IdProductoDepartamentoProceso", dataGridView1.Rows.Count);
                //cmd.Parameters.AddWithValue("@idestado", listBox1.SelectedValue);
                //cmd.Parameters.AddWithValue("@state", txt_State.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
