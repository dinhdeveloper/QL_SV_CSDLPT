using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemTongKet(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_BangDiemTongKet_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_BangDiemTongKet_ReportTableAdapter.Fill(ds1.sp_BangDiemTongKet_Report,malop);
        }

    }
}
