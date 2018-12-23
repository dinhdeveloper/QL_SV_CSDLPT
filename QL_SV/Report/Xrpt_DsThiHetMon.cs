using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QL_SV.Report
{
    public partial class Xrpt_DsThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DsThiHetMon(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_GetInfoSV_Report_DSTHMTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sp_GetInfoSV_Report_DSTHMTableAdapter1.Fill(ds1.sp_GetInfoSV_Report_DSTHM, malop);
        }

    }
}
