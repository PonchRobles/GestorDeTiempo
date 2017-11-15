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
    public partial class VistaGeneralEncargado : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CID5MAP;Initial Catalog=GestorTiempo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        DataSet ds;

        public VistaGeneralEncargado()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            try
            {

                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(@"select DISTINCT PDP.IdProductoDepartamentoProceso as 'ID',
                        PRS.NombreProceso as 'NombrePro',
                         D.NombreDepartamento as 'NombreDep',
                         P.NombreProducto as 'NombreProd',
                         EP.NombreEstadoProceso as 'Estado',
                         PDP.StartTime,
                         PDP.EndTime,
                         U.NombreDeUsuario
                            from ProductoDepartamentoProceso PDP
                inner join ProductoPorDepartamento PD on PD.IdDepartamento = PDP.IdDepartamento and pd.IdProducto = PDP.IdProducto
                inner join Proceso PRS on PRS.IdDepartamento = PDP.IdDepartamento
                inner join EstadoDeProceso EP on EP.IdEstadoDeProceso = PDP.IdEstado
                inner join Departamento D on D.IdDepartamento = PDP.IdDepartamento
                inner join Producto P on P.IdProducto = PDP.IdProducto
				inner join Usuarios U on U.IdUsuario = D.IdUsuario
				where PDP.IdEstado = 3", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void VistaGeneralEncargado_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtNombrePro.Text = row.Cells["NombrePro"].Value.ToString();
                txtNombreDep.Text = row.Cells["NombreDep"].Value.ToString();
                txtNombreProd.Text = row.Cells["NombreProd"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
                txtStartTime.Text = row.Cells["StartTime"].Value.ToString();
                txtEndTime.Text = row.Cells["EndTime"].Value.ToString();
                txtUser.Text = row.Cells["NombreDeUsuario"].Value.ToString();

            }
        }

        public void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DatosParaReporteDeVistaGralDeEncargado datos = new DatosParaReporteDeVistaGralDeEncargado();
                Reporte R = new Reporte();
                datos.ID = Convert.ToInt32(txtID.Text);
                datos.NombrePro = txtNombrePro.Text;
                datos.NombreDep = txtNombreDep.Text;
                datos.NombreProd = txtNombreProd.Text;
                datos.Estado = txtEstado.Text;
                datos.StartTime = Convert.ToDateTime(txtStartTime.Text);
                datos.EndTime = Convert.ToDateTime(txtEndTime.Text);
                datos.NombreDeUsuario = txtUser.Text;
                R.Datos.Add(datos);
                R.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
