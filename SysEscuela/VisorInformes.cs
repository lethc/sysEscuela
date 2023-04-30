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
using Microsoft.Reporting.WinForms;


namespace SysEscuela
{
    public partial class VisorInformes : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-N10B9GL;Initial Catalog=EscuelaDB;Integrated Security=True");

        public VisorInformes()
        {
            InitializeComponent();
        }

        private void VisorInformes_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            SqlCommand comm = new SqlCommand("Select * from Alumno", connection);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "ReporteAlumnos.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        //public void vistaPreliminar(DataSet pds, string pReportDataSourceNombre, string pReportEmbeddedResourceNombre)
        //{
        //    foreach (DataTable dt in pds.Tables)
        //    {
        //        ReportDataSource ReportDataSource1 = new ReportDataSource();
        //        ReportDataSource1.Value = dt;
        //        ReportDataSource1.Name = dt.TableName;
        //        this.reportViewer1.LocalReport.DataSources.Add(ReportDataSource1);
        //    }
        //    this.reportViewer1.ProcessingMode = ProcessingMode.Local;
        //    this.reportViewer1.LocalReport.ReportEmbeddedResource = pReportEmbeddedResourceNombre;
        //    this.reportViewer1.Location = new System.Drawing.Point(1, 2);
        //    this.reportViewer1.Name = "VisorInformes";
        //    this.reportViewer1.TabIndex = 0;
        //    this.reportViewer1.LocalReport.Refresh();
        //    this.reportViewer1.RefreshReport();
        //}
    }
}
