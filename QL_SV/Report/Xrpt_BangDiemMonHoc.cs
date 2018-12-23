using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_BangDiemMonHoc : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMonHoc(String malop , String mamonhoc, int lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_GetValueDiem_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_GetValueDiem_ReportTableAdapter.Fill(ds1.sp_GetValueDiem_Report,malop,mamonhoc,lan);
        }

    }
}
