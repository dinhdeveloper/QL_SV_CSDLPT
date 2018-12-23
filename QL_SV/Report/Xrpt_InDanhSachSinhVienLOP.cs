using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_InDanhSachSinhVienLOP : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_InDanhSachSinhVienLOP(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_GetInfoSV_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_GetInfoSV_ReportTableAdapter.Fill(ds1.sp_GetInfoSV_Report,malop);
        }   

    }
}
