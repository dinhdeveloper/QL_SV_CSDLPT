namespace QL_SV.Report
{
    partial class Xrpt_BangDiemTongKet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sp_BangDiemTongKet_ReportTableAdapter = new QL_SV.DSTableAdapters.sp_BangDiemTongKet_ReportTableAdapter();
            this.ds1 = new QL_SV.DS();
            this.fieldHOTEN1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldTENMH1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDIEM1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.field2 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.field1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.field = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.dIEMTableAdapter = new QL_SV.DSTableAdapters.DIEMTableAdapter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblLOP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Detail.BorderWidth = 12F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrPivotGrid1});
            this.Detail.HeightF = 121.4583F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1467F, 11.54165F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.DataAdapter = this.sp_BangDiemTongKet_ReportTableAdapter;
            this.xrPivotGrid1.DataMember = "sp_BangDiemTongKet_Report";
            this.xrPivotGrid1.DataSource = this.ds1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldHOTEN1,
            this.fieldTENMH1,
            this.fieldDIEM1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 25.08332F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = false;
            this.xrPivotGrid1.OptionsView.ShowColumnHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowDataHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowRowGrandTotals = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(356.6667F, 57.29166F);
            // 
            // sp_BangDiemTongKet_ReportTableAdapter
            // 
            this.sp_BangDiemTongKet_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldHOTEN1
            // 
            this.fieldHOTEN1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldHOTEN1.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldHOTEN1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHOTEN1.AreaIndex = 0;
            this.fieldHOTEN1.Caption = "Mã sinh viên - Họ tên";
            this.fieldHOTEN1.FieldName = "HOTEN";
            this.fieldHOTEN1.Name = "fieldHOTEN1";
            this.fieldHOTEN1.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.fieldHOTEN1.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.False;
            this.fieldHOTEN1.Options.ShowInFilter = true;
            this.fieldHOTEN1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.fieldHOTEN1.Width = 200;
            // 
            // fieldTENMH1
            // 
            this.fieldTENMH1.Appearance.CustomTotalCell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldTENMH1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldTENMH1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTENMH1.AreaIndex = 0;
            this.fieldTENMH1.Caption = "Tên môn học";
            this.fieldTENMH1.FieldName = "TENMH";
            this.fieldTENMH1.Name = "fieldTENMH1";
            this.fieldTENMH1.Options.ShowInFilter = true;
            this.fieldTENMH1.Width = 200;
            // 
            // fieldDIEM1
            // 
            this.fieldDIEM1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldDIEM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDIEM1.AreaIndex = 0;
            this.fieldDIEM1.Caption = "Điểm ";
            this.fieldDIEM1.FieldName = "DIEM";
            this.fieldDIEM1.Name = "fieldDIEM1";
            this.fieldDIEM1.Options.ShowInFilter = true;
            // 
            // field2
            // 
            this.field2.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.field2.Appearance.FieldHeader.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.field2.AreaIndex = 2;
            this.field2.Name = "field2";
            this.field2.Options.ShowInFilter = true;
            // 
            // field1
            // 
            this.field1.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.field1.AreaIndex = 1;
            this.field1.Name = "field1";
            this.field1.Options.ShowInFilter = true;
            // 
            // field
            // 
            this.field.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.field.AreaIndex = 0;
            this.field.Name = "field";
            this.field.Options.ShowInFilter = true;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 55F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(481.25F, 10.00001F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(121.875F, 23F);
            this.xrPageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(170.8333F, 23F);
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Red;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(178.125F, 10F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(236.4583F, 33.00001F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BẢNG ĐIỂM TỔNG KẾT ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.lblLOP,
            this.xrLabel2});
            this.ReportHeader.HeightF = 91.66666F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblLOP
            // 
            this.lblLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOP.ForeColor = System.Drawing.Color.Blue;
            this.lblLOP.LocationFloat = new DevExpress.Utils.PointFloat(134.375F, 55.16666F);
            this.lblLOP.Multiline = true;
            this.lblLOP.Name = "lblLOP";
            this.lblLOP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLOP.SizeF = new System.Drawing.SizeF(444.7917F, 23F);
            this.lblLOP.StylePriority.UseFont = false;
            this.lblLOP.StylePriority.UseForeColor = false;
            this.lblLOP.Text = "lblLOP";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Red;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(73.95834F, 55.16666F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(47.91666F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "Lớp : ";
            // 
            // xrPivotGridField1
            // 
            this.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.xrPivotGridField1.AreaIndex = 0;
            this.xrPivotGridField1.Name = "xrPivotGridField1";
            this.xrPivotGridField1.Options.ShowInFilter = true;
            // 
            // Xrpt_BangDiemTongKet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ds1});
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 55, 100);
            this.PageHeight = 1600;
            this.PageWidth = 1667;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DSTableAdapters.sp_BangDiemTongKet_ReportTableAdapter sp_BangDiemTongKet_ReportTableAdapter;
        private DS ds1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField field2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField field1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField field;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel lblLOP;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHOTEN1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldTENMH1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDIEM1;
        public DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        public DevExpress.XtraReports.UI.XRLine xrLine1;
    }
}
