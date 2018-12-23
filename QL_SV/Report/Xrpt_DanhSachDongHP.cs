using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_DanhSachDongHP : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachDongHP(String malop, String nienkhoa,int hocky )
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
           this.sp_DsDongHocPhi_ReportTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sp_DsDongHocPhi_ReportTableAdapter1.Fill(ds1.sp_DsDongHocPhi_Report, malop, nienkhoa, hocky);
        }

    }
}
