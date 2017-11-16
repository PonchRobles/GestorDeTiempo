using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTiempo
{
      
    public partial class Reporte : Form
    {
        public List<DatosParaReporteDeVistaGralDeEncargado> Datos = new List<DatosParaReporteDeVistaGralDeEncargado>();

        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("VistaGeneralDeEncargadoGeneral2", Datos));
            this.reportViewer1.RefreshReport();
        }
    }
}
