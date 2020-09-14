namespace QuanLyPhongKhamNhi
{
    partial class FormQuanLyDN
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
            this.dataNguoiDung = new System.Windows.Forms.DataGridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboTrangThai = new System.Windows.Forms.ComboBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.comboBoxQuyen = new System.Windows.Forms.ComboBox();
            this.textMK = new System.Windows.Forms.TextBox();
            this.textTenDN = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutThongTinTaiKhoan = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.butThem = new DevExpress.XtraEditors.SimpleButton();
            this.butSua = new DevExpress.XtraEditors.SimpleButton();
            this.butXoa = new DevExpress.XtraEditors.SimpleButton();
            this.butLuu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.butNhapLai = new DevExpress.XtraEditors.SimpleButton();
            this.textMail = new System.Windows.Forms.TextBox();
            this.Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNguoiDung
            // 
            this.dataNguoiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.col4,
            this.Co5,
            this.Column3,
            this.co6});
            this.dataNguoiDung.Location = new System.Drawing.Point(49, 188);
            this.dataNguoiDung.Name = "dataNguoiDung";
            this.dataNguoiDung.RowTemplate.Height = 24;
            this.dataNguoiDung.Size = new System.Drawing.Size(967, 464);
            this.dataNguoiDung.TabIndex = 0;
            this.dataNguoiDung.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataNguoiDung_CellMouseClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textMail);
            this.layoutControl1.Controls.Add(this.comboTrangThai);
            this.layoutControl1.Controls.Add(this.textHoTen);
            this.layoutControl1.Controls.Add(this.comboBoxQuyen);
            this.layoutControl1.Controls.Add(this.textMK);
            this.layoutControl1.Controls.Add(this.textTenDN);
            this.layoutControl1.Location = new System.Drawing.Point(1270, 286);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(407, 260);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboTrangThai
            // 
            this.comboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrangThai.FormattingEnabled = true;
            this.comboTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboTrangThai.Location = new System.Drawing.Point(129, 193);
            this.comboTrangThai.Name = "comboTrangThai";
            this.comboTrangThai.Size = new System.Drawing.Size(254, 24);
            this.comboTrangThai.TabIndex = 8;
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(129, 105);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(254, 25);
            this.textHoTen.TabIndex = 7;
            // 
            // comboBoxQuyen
            // 
            this.comboBoxQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuyen.FormattingEnabled = true;
            this.comboBoxQuyen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxQuyen.Location = new System.Drawing.Point(129, 163);
            this.comboBoxQuyen.Name = "comboBoxQuyen";
            this.comboBoxQuyen.Size = new System.Drawing.Size(254, 24);
            this.comboBoxQuyen.TabIndex = 6;
            // 
            // textMK
            // 
            this.textMK.Location = new System.Drawing.Point(129, 76);
            this.textMK.Name = "textMK";
            this.textMK.Size = new System.Drawing.Size(254, 25);
            this.textMK.TabIndex = 5;
            // 
            // textTenDN
            // 
            this.textTenDN.Location = new System.Drawing.Point(129, 47);
            this.textTenDN.Name = "textTenDN";
            this.textTenDN.Size = new System.Drawing.Size(254, 25);
            this.textTenDN.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutThongTinTaiKhoan});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(407, 260);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 223);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(387, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutThongTinTaiKhoan
            // 
            this.layoutThongTinTaiKhoan.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.Email});
            this.layoutThongTinTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.layoutThongTinTaiKhoan.Name = "layoutThongTinTaiKhoan";
            this.layoutThongTinTaiKhoan.Size = new System.Drawing.Size(387, 223);
            this.layoutThongTinTaiKhoan.Text = "Thông tin tài khoản:";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxQuyen;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(363, 30);
            this.layoutControlItem4.Text = "Quyền truy cập:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(102, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textTenDN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(363, 29);
            this.layoutControlItem1.Text = "Tên đăng nhập:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textMK;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(363, 29);
            this.layoutControlItem2.Text = "Mật khẩu:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(102, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textHoTen;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(363, 29);
            this.layoutControlItem5.Text = "Họ tên:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(102, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.comboTrangThai;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(363, 30);
            this.layoutControlItem6.Text = "Trạng thái:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(102, 17);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(1284, 228);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(101, 29);
            this.butThem.TabIndex = 2;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(1425, 228);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(101, 29);
            this.butSua.TabIndex = 3;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(1559, 228);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(101, 29);
            this.butXoa.TabIndex = 4;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(1425, 549);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(101, 31);
            this.butLuu.TabIndex = 5;
            this.butLuu.Text = "Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl2.Location = new System.Drawing.Point(49, 62);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(974, 120);
            this.layoutControl2.TabIndex = 7;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(86, 47);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(864, 22);
            this.searchLookUpEdit1.StyleController = this.layoutControl2;
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
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(974, 120);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 73);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(954, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(954, 73);
            this.layoutControlGroup3.Text = "Tài khoản";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchLookUpEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(930, 26);
            this.layoutControlItem3.Text = "Tìm kiếm:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 17);
            // 
            // butNhapLai
            // 
            this.butNhapLai.Location = new System.Drawing.Point(1559, 549);
            this.butNhapLai.Name = "butNhapLai";
            this.butNhapLai.Size = new System.Drawing.Size(101, 31);
            this.butNhapLai.TabIndex = 8;
            this.butNhapLai.Text = "Nhập lại";
            this.butNhapLai.Click += new System.EventHandler(this.butNhapLai_Click);
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(129, 134);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(254, 25);
            this.textMail.TabIndex = 9;
            // 
            // Email
            // 
            this.Email.Control = this.textMail;
            this.Email.Location = new System.Drawing.Point(0, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(363, 29);
            this.Email.Text = "Email:";
            this.Email.TextSize = new System.Drawing.Size(102, 16);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenDN";
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "matKhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // col4
            // 
            this.col4.DataPropertyName = "hoTen";
            this.col4.HeaderText = "Họ tên";
            this.col4.Name = "col4";
            this.col4.Width = 180;
            // 
            // Co5
            // 
            this.Co5.DataPropertyName = "email";
            this.Co5.HeaderText = "Email";
            this.Co5.Name = "Co5";
            this.Co5.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "phanQuyen";
            this.Column3.HeaderText = "Quyền truy cập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // co6
            // 
            this.co6.DataPropertyName = "trangThai";
            this.co6.HeaderText = "Trạng thái";
            this.co6.Name = "co6";
            // 
            // FormQuanLyDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 664);
            this.Controls.Add(this.butNhapLai);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyDN";
            this.Text = "FormQuanLyDN";
            this.Load += new System.EventHandler(this.FormQuanLyDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNguoiDung;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.TextBox textMK;
        private System.Windows.Forms.TextBox textTenDN;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton butThem;
        private DevExpress.XtraEditors.SimpleButton butSua;
        private DevExpress.XtraEditors.SimpleButton butXoa;
        private DevExpress.XtraEditors.SimpleButton butLuu;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox comboBoxQuyen;
        private DevExpress.XtraLayout.LayoutControlGroup layoutThongTinTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ComboBox comboTrangThai;
        private System.Windows.Forms.TextBox textHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton butNhapLai;
        private System.Windows.Forms.TextBox textMail;
        private DevExpress.XtraLayout.LayoutControlItem Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn co6;
    }
}