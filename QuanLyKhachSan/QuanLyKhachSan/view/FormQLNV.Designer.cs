namespace QuanLyPhongKhamNhi
{
    partial class FormQLNV
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
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.MaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.textMaPB = new System.Windows.Forms.ComboBox();
            this.textTenPB = new System.Windows.Forms.TextBox();
            this.textLuong = new System.Windows.Forms.TextBox();
            this.textNamLV = new System.Windows.Forms.TextBox();
            this.textGT = new System.Windows.Forms.ComboBox();
            this.textNS = new DevExpress.XtraEditors.DateEdit();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textMaNV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutNhanVien = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.butThem = new DevExpress.XtraEditors.SimpleButton();
            this.butSua = new DevExpress.XtraEditors.SimpleButton();
            this.butXoa = new DevExpress.XtraEditors.SimpleButton();
            this.butLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.butSapXep = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNV
            // 
            this.dataNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPK,
            this.MaBN,
            this.TenBN,
            this.TenBS,
            this.MaBS,
            this.TrieuChung,
            this.NgayKham});
            this.dataNV.Location = new System.Drawing.Point(21, 152);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowTemplate.Height = 24;
            this.dataNV.Size = new System.Drawing.Size(993, 552);
            this.dataNV.TabIndex = 0;
            this.dataNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPhieuKham_CellMouseClick);
            // 
            // MaPK
            // 
            this.MaPK.DataPropertyName = "maNV";
            this.MaPK.HeaderText = "Mã nhân viên";
            this.MaPK.Name = "MaPK";
            this.MaPK.Width = 140;
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "hoTenNV";
            this.MaBN.HeaderText = "Họ tên";
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 200;
            // 
            // TenBN
            // 
            this.TenBN.DataPropertyName = "ngaySinh";
            this.TenBN.HeaderText = "Ngày sinh";
            this.TenBN.Name = "TenBN";
            this.TenBN.Width = 140;
            // 
            // TenBS
            // 
            this.TenBS.DataPropertyName = "gioiTinh";
            this.TenBS.HeaderText = "Giới tính";
            this.TenBS.Name = "TenBS";
            // 
            // MaBS
            // 
            this.MaBS.DataPropertyName = "namLamViec";
            this.MaBS.HeaderText = "Năm làm việc";
            this.MaBS.Name = "MaBS";
            this.MaBS.Width = 120;
            // 
            // TrieuChung
            // 
            this.TrieuChung.DataPropertyName = "luong";
            this.TrieuChung.HeaderText = "Lương";
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.Width = 120;
            // 
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "maPB";
            this.NgayKham.HeaderText = "Phòng ban";
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Width = 120;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Location = new System.Drawing.Point(31, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(994, 69);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(74, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(908, 22);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 4;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(994, 69);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(974, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.searchLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(974, 26);
            this.layoutControlItem1.Text = "Tìm kiếm:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 17);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.textMaPB);
            this.layoutControl2.Controls.Add(this.textTenPB);
            this.layoutControl2.Controls.Add(this.textLuong);
            this.layoutControl2.Controls.Add(this.textNamLV);
            this.layoutControl2.Controls.Add(this.textGT);
            this.layoutControl2.Controls.Add(this.textNS);
            this.layoutControl2.Controls.Add(this.textHoTen);
            this.layoutControl2.Controls.Add(this.textMaNV);
            this.layoutControl2.Location = new System.Drawing.Point(1131, 187);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(687, 205);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // textMaPB
            // 
            this.textMaPB.FormattingEnabled = true;
            this.textMaPB.Location = new System.Drawing.Point(118, 131);
            this.textMaPB.Name = "textMaPB";
            this.textMaPB.Size = new System.Drawing.Size(223, 24);
            this.textMaPB.TabIndex = 19;
            this.textMaPB.SelectedValueChanged += new System.EventHandler(this.textTenPB_SelectedValueChanged);
            // 
            // textTenPB
            // 
            this.textTenPB.Location = new System.Drawing.Point(439, 135);
            this.textTenPB.Name = "textTenPB";
            this.textTenPB.Size = new System.Drawing.Size(224, 25);
            this.textTenPB.TabIndex = 18;
            // 
            // textLuong
            // 
            this.textLuong.Location = new System.Drawing.Point(439, 106);
            this.textLuong.Name = "textLuong";
            this.textLuong.Size = new System.Drawing.Size(224, 25);
            this.textLuong.TabIndex = 16;
            // 
            // textNamLV
            // 
            this.textNamLV.Location = new System.Drawing.Point(118, 102);
            this.textNamLV.Name = "textNamLV";
            this.textNamLV.Size = new System.Drawing.Size(223, 25);
            this.textNamLV.TabIndex = 15;
            // 
            // textGT
            // 
            this.textGT.FormattingEnabled = true;
            this.textGT.Location = new System.Drawing.Point(439, 76);
            this.textGT.Name = "textGT";
            this.textGT.Size = new System.Drawing.Size(224, 24);
            this.textGT.TabIndex = 14;
            // 
            // textNS
            // 
            this.textNS.EditValue = null;
            this.textNS.Location = new System.Drawing.Point(118, 76);
            this.textNS.Name = "textNS";
            this.textNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNS.Size = new System.Drawing.Size(223, 22);
            this.textNS.StyleController = this.layoutControl2;
            this.textNS.TabIndex = 13;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(439, 47);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(224, 25);
            this.textHoTen.TabIndex = 12;
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(118, 47);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(223, 22);
            this.textMaNV.StyleController = this.layoutControl2;
            this.textMaNV.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutNhanVien});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(687, 205);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 164);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(667, 21);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutNhanVien
            // 
            this.layoutNhanVien.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem8});
            this.layoutNhanVien.Location = new System.Drawing.Point(0, 0);
            this.layoutNhanVien.Name = "layoutNhanVien";
            this.layoutNhanVien.Size = new System.Drawing.Size(667, 164);
            this.layoutNhanVien.Text = "Thông tin nhân viên:";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textMaNV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 29);
            this.layoutControlItem2.Text = "Mã nhân viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textHoTen;
            this.layoutControlItem7.Location = new System.Drawing.Point(321, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(322, 29);
            this.layoutControlItem7.Text = "Họ Tên:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textNS;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(321, 26);
            this.layoutControlItem3.Text = "Ngày sinh:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textGT;
            this.layoutControlItem4.Location = new System.Drawing.Point(321, 29);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(322, 30);
            this.layoutControlItem4.Text = "Giới tính:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textNamLV;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(321, 29);
            this.layoutControlItem5.Text = "Năm làm việc:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textLuong;
            this.layoutControlItem6.Location = new System.Drawing.Point(321, 59);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(322, 29);
            this.layoutControlItem6.Text = "Lương:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textTenPB;
            this.layoutControlItem9.Location = new System.Drawing.Point(321, 88);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(322, 29);
            this.layoutControlItem9.Text = "Tên phòng ban:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textMaPB;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(321, 33);
            this.layoutControlItem8.Text = "Mã phòng ban:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(91, 16);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(1145, 152);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(196, 29);
            this.butThem.TabIndex = 3;
            this.butThem.Text = "Thêm ";
            this.butThem.Click += new System.EventHandler(this.butThemPk_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(1381, 152);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(196, 29);
            this.butSua.TabIndex = 4;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(1598, 152);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(196, 29);
            this.butXoa.TabIndex = 5;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(1381, 384);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(196, 29);
            this.butLuu.TabIndex = 6;
            this.butLuu.Text = "Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Danh sách thông tin nhân viên:";
            // 
            // butSapXep
            // 
            this.butSapXep.Location = new System.Drawing.Point(911, 115);
            this.butSapXep.Name = "butSapXep";
            this.butSapXep.Size = new System.Drawing.Size(94, 29);
            this.butSapXep.TabIndex = 8;
            this.butSapXep.Text = "Sắp xếp";
            this.butSapXep.Click += new System.EventHandler(this.butSapXep_Click);
            // 
            // FormQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 1102);
            this.Controls.Add(this.butSapXep);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLNV";
            this.Text = "FormPhieuKham";
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNV;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit textMaNV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutNhanVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton butThem;
        private DevExpress.XtraEditors.SimpleButton butSua;
        private DevExpress.XtraEditors.SimpleButton butXoa;
        private DevExpress.XtraEditors.SimpleButton butLuu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox textMaPB;
        private System.Windows.Forms.TextBox textTenPB;
        private System.Windows.Forms.TextBox textLuong;
        private System.Windows.Forms.TextBox textNamLV;
        private System.Windows.Forms.ComboBox textGT;
        private DevExpress.XtraEditors.DateEdit textNS;
        private System.Windows.Forms.TextBox textHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private DevExpress.XtraEditors.SimpleButton butSapXep;
    }
}