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
    public partial class SeleccionarProducto : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        DataSet ds;
        public SeleccionarProducto()
        {
            InitializeComponent();
            DisplayData();
        }

        private void SeleccionarProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestorTiempoDataSet5.ProductoDepartamentoProceso' table. You can move, or remove it, as needed.
            this.productoDepartamentoProcesoTableAdapter.Fill(this.gestorTiempoDataSet5.ProductoDepartamentoProceso);
            // TODO: This line of code loads data into the 'gestorTiempoDataSet4.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter1.Fill(this.gestorTiempoDataSet4.Producto);
            // TODO: This line of code loads data into the 'gestorTiempoDataSet2.EstadoDeProceso' table. You can move, or remove it, as needed.
            this.estadoDeProcesoTableAdapter.Fill(this.gestorTiempoDataSet2.EstadoDeProceso);
            // TODO: This line of code loads data into the 'gestorTiempoDataSet1.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.gestorTiempoDataSet1.Producto);

        }

       
        private void DisplayData()
        {
            try
            {

                con.Open();
                DataTable dt = new DataTable();
                //adapt = new SqlDataAdapter("select PDP.IdProductoDepartamentoProceso,PRS.NombreProceso, D.NombreDepartamento,P.NombreProducto,EP.NombreEstadoProceso,PDP.StartTime from ProductoDepartamentoProceso PDP inner join ProductoPorDepartamento PD on PD.IdDepartamento = PDP.IdDepartamento and pd.IdProducto = PDP.IdProducto inner join Proceso PRS on PRS.IdDepartamento = PDP.IdDepartamento inner join EstadoDeProceso EP on EP.IdEstadoDeProceso = PDP.IdEstado inner join Departamento D on D.IdDepartamento = PDP.IdDepartamento inner join Producto P on P.IdProducto = PDP.IdProducto", con);
                adapt = new SqlDataAdapter(@"SELECT IdProducto,IdDepartamento,IdProceso,IdProductoDepartamentoProceso,StartTime,EndTime,IdEstado,CantidadDeProductos
                                                    from ProductoDepartamentoProceso", con);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Product_Details");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            listBox1.DisplayMember = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // //txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            // btnFinalizar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // btnComenzarProduccion.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEncargado ME = new MenuEncargado();
            ME.ShowDialog();
            this.Close();
        }

        private void btnComenzarProduccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
                {
                    cmd = new SqlCommand("UPDATE ProductoDepartamentoProceso SET IdEstado =@idestado  WHERE '" + txtIdProductoDepartamento.Text + "'= IdProductoDepartamentoProceso", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("idestado", Convert.ToInt32(listBox1.SelectedValue));
                  


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
                {
                    cmd = new SqlCommand("UPDATE ProductoDepartamentoProceso SET IdEstado =@idestado,EndTime=@EndTime  WHERE '" + txtIdProductoDepartamento.Text + "'= IdProductoDepartamentoProceso", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("idestado", Convert.ToInt32(listBox1.SelectedValue));
                    cmd.Parameters.AddWithValue("EndTime",DateTime.Now);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    txtIdProducto.Text = row.Cells["IdProducto"].Value.ToString();
                    txtIdDepartamento.Text = row.Cells["IdDepartamento"].Value.ToString();
                    txtIdProceso.Text = row.Cells["IdProceso"].Value.ToString();
                    txtIdProductoDepartamento.Text = row.Cells["IdProductoDepartamentoProceso"].Value.ToString();

                    txtStartTime.Text = row.Cells["StartTime"].Value.ToString();
                    txtEnTime.Text = row.Cells["EndTime"].Value.ToString();
                    txtIdEstado.Text = row.Cells["IdEstado"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }
    }
}
