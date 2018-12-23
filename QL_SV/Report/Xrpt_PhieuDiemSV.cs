using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_PhieuDiemSV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_PhieuDiemSV(String masv)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_GetMaxValueDiem_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_GetMaxValueDiem_ReportTableAdapter.Fill(ds1.sp_GetMaxValueDiem_Report, masv);
        }

    }
}
