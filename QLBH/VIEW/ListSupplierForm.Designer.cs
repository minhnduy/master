namespace QLBH.VIEW
{
    partial class ListSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSupplierForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gvDoiTac = new DevExpress.XtraGrid.GridControl();
            this.gvListDT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA_ST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGUOI_LH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWECHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAI_KHOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHI_CHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDetail);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnExit);
            this.layoutControl1.Controls.Add(this.gvDoiTac);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(944, 452);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDetail
            // 
            this.btnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.Image")));
            this.btnDetail.Location = new System.Drawing.Point(172, 418);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(84, 22);
            this.btnDetail.StyleController = this.layoutControl1;
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "Chi tiết";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(92, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(12, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(864, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvDoiTac
            // 
            this.gvDoiTac.DataSource = typeof(QLBH.MODEL.DOI_TAC);
            this.gvDoiTac.Location = new System.Drawing.Point(12, 28);
            this.gvDoiTac.MainView = this.gvListDT;
            this.gvDoiTac.Name = "gvDoiTac";
            this.gvDoiTac.Size = new System.Drawing.Size(920, 386);
            this.gvDoiTac.TabIndex = 4;
            this.gvDoiTac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListDT});
            // 
            // gvListDT
            // 
            this.gvListDT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA_ST,
            this.colTEN_DT,
            this.colDIA_CHI,
            this.colNGUOI_LH,
            this.colSDT,
            this.colEMAIL,
            this.colWECHAT,
            this.colTAI_KHOAN,
            this.colGHI_CHU,
            this.colSTATUS});
            this.gvListDT.GridControl = this.gvDoiTac;
            this.gvListDT.Name = "gvListDT";
            this.gvListDT.OptionsBehavior.Editable = false;
            this.gvListDT.OptionsBehavior.ReadOnly = true;
            this.gvListDT.OptionsView.ShowGroupPanel = false;
            // 
            // colMA_ST
            // 
            this.colMA_ST.Caption = "Mã số thuế";
            this.colMA_ST.FieldName = "MA_ST";
            this.colMA_ST.Name = "colMA_ST";
            this.colMA_ST.Visible = true;
            this.colMA_ST.VisibleIndex = 0;
            // 
            // colTEN_DT
            // 
            this.colTEN_DT.Caption = "Tên đối tác";
            this.colTEN_DT.FieldName = "TEN_DT";
            this.colTEN_DT.Name = "colTEN_DT";
            this.colTEN_DT.Visible = true;
            this.colTEN_DT.VisibleIndex = 1;
            // 
            // colDIA_CHI
            // 
            this.colDIA_CHI.Caption = "Địa chỉ";
            this.colDIA_CHI.FieldName = "DIA_CHI";
            this.colDIA_CHI.Name = "colDIA_CHI";
            this.colDIA_CHI.Visible = true;
            this.colDIA_CHI.VisibleIndex = 2;
            // 
            // colNGUOI_LH
            // 
            this.colNGUOI_LH.Caption = "Người đại diện";
            this.colNGUOI_LH.FieldName = "NGUOI_LH";
            this.colNGUOI_LH.Name = "colNGUOI_LH";
            this.colNGUOI_LH.Visible = true;
            this.colNGUOI_LH.VisibleIndex = 3;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "Email";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            // 
            // colWECHAT
            // 
            this.colWECHAT.Caption = "Website";
            this.colWECHAT.FieldName = "WECHAT";
            this.colWECHAT.Name = "colWECHAT";
            this.colWECHAT.Visible = true;
            this.colWECHAT.VisibleIndex = 6;
            // 
            // colTAI_KHOAN
            // 
            this.colTAI_KHOAN.Caption = "Thông tin ngân hàng";
            this.colTAI_KHOAN.FieldName = "TAI_KHOAN";
            this.colTAI_KHOAN.Name = "colTAI_KHOAN";
            this.colTAI_KHOAN.Visible = true;
            this.colTAI_KHOAN.VisibleIndex = 7;
            // 
            // colGHI_CHU
            // 
            this.colGHI_CHU.Caption = "Ghi chú";
            this.colGHI_CHU.FieldName = "GHI_CHU";
            this.colGHI_CHU.Name = "colGHI_CHU";
            this.colGHI_CHU.Visible = true;
            this.colGHI_CHU.VisibleIndex = 8;
            // 
            // colSTATUS
            // 
            this.colSTATUS.Caption = "Trạng thái";
            this.colSTATUS.FieldName = "STATUS";
            this.colSTATUS.Name = "colSTATUS";
            this.colSTATUS.Visible = true;
            this.colSTATUS.VisibleIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(944, 452);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gvDoiTac;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(924, 406);
            this.layoutControlItem1.Text = "Danh sách đối tác";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(248, 406);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(604, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExit;
            this.layoutControlItem2.Location = new System.Drawing.Point(852, 406);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(72, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAdd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 406);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(80, 406);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDetail;
            this.layoutControlItem5.Location = new System.Drawing.Point(160, 406);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(88, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ListSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 452);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ListSupplierForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Danh sách đối tác";
            this.Activated += new System.EventHandler(this.ListSupplierForm_Activated);
            this.Load += new System.EventHandler(this.ListSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gvDoiTac;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListDT;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnDetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_ST;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGUOI_LH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colWECHAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTAI_KHOAN;
        private DevExpress.XtraGrid.Columns.GridColumn colGHI_CHU;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUS;
    }
}