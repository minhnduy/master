﻿namespace QLBH.VIEW
{
    partial class DSPhieuBan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_PBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_MUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_ST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_CTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONG_TIEN_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN_VND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1029, 374);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(12, 12);
            this.gc.MainView = this.gvPhieuBan;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(1005, 350);
            this.gc.TabIndex = 4;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuBan});
            // 
            // gvPhieuBan
            // 
            this.gvPhieuBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_PBH,
            this.NGAY_MUA,
            this.MA_ST,
            this.TEN_CTY,
            this.TONG_TIEN_HANG,
            this.SO_TIEN_VND});
            this.gvPhieuBan.GridControl = this.gc;
            this.gvPhieuBan.Name = "gvPhieuBan";
            this.gvPhieuBan.OptionsBehavior.ReadOnly = true;
            this.gvPhieuBan.OptionsFind.AlwaysVisible = true;
            this.gvPhieuBan.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gvPhieuBan.OptionsView.ShowGroupPanel = false;
            // 
            // ID_PBH
            // 
            this.ID_PBH.Caption = "Số hóa đơn";
            this.ID_PBH.FieldName = "ID_PBH";
            this.ID_PBH.Name = "ID_PBH";
            this.ID_PBH.Visible = true;
            this.ID_PBH.VisibleIndex = 0;
            // 
            // NGAY_MUA
            // 
            this.NGAY_MUA.Caption = "Ngày bán hàng";
            this.NGAY_MUA.FieldName = "NGAY_BAN";
            this.NGAY_MUA.Name = "NGAY_MUA";
            this.NGAY_MUA.Visible = true;
            this.NGAY_MUA.VisibleIndex = 2;
            // 
            // MA_ST
            // 
            this.MA_ST.Caption = "Mã số thuế";
            this.MA_ST.FieldName = "MA_ST";
            this.MA_ST.Name = "MA_ST";
            this.MA_ST.Visible = true;
            this.MA_ST.VisibleIndex = 1;
            // 
            // TEN_CTY
            // 
            this.TEN_CTY.Caption = "Tên công ty";
            this.TEN_CTY.FieldName = "TEN_CTY";
            this.TEN_CTY.Name = "TEN_CTY";
            this.TEN_CTY.Visible = true;
            this.TEN_CTY.VisibleIndex = 3;
            // 
            // TONG_TIEN_HANG
            // 
            this.TONG_TIEN_HANG.Caption = "Tổng tiền hàng";
            this.TONG_TIEN_HANG.FieldName = "TONG_TIEN_HANG";
            this.TONG_TIEN_HANG.Name = "TONG_TIEN_HANG";
            this.TONG_TIEN_HANG.Visible = true;
            this.TONG_TIEN_HANG.VisibleIndex = 4;
            // 
            // SO_TIEN_VND
            // 
            this.SO_TIEN_VND.Caption = "Số tiền bằng chữ";
            this.SO_TIEN_VND.FieldName = "SO_TIEN_VND";
            this.SO_TIEN_VND.Name = "SO_TIEN_VND";
            this.SO_TIEN_VND.Visible = true;
            this.SO_TIEN_VND.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1029, 374);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1009, 354);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DSPhieuBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 374);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DSPhieuBan";
            this.Text = "Danh sách phiếu bán hàng";
            this.Load += new System.EventHandler(this.DSPhieuBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuBan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_PBH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_MUA;
        private DevExpress.XtraGrid.Columns.GridColumn MA_ST;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_CTY;
        private DevExpress.XtraGrid.Columns.GridColumn TONG_TIEN_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN_VND;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
    }
}