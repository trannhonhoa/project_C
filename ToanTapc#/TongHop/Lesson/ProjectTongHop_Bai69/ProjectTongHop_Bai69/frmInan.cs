using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace ProjectTongHop_Bai69
{
    public partial class frmInan : Form
    {
        public frmInan()
        {
            InitializeComponent();
        }

        private void frmInan_Load(object sender, EventArgs e)
        {
            SqlConnection conc = new SqlConnection("Server=DESKTOP-P9L00KA; Database=CSDL_QLKH; User Id=sa; pwd=trannhonhoa");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from KhachHang", conc);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectTongHop_Bai69.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
