namespace QuanLyPhongKhamNhi
{
    partial class FormQLPB
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
            this.dataPB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dienThoai = new System.Windows.Forms.TextBox();
            this.emailPB = new System.Windows.Forms.TextBox();
            this.tenPB = new System.Windows.Forms.TextBox();
            this.maPB = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutPhongBan = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.butThem = new DevExpress.XtraEditors.SimpleButton();
            this.butSua = new DevExpress.XtraEditors.SimpleButton();
            this.butXoa = new DevExpress.XtraEditors.SimpleButton();
            this.butLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.butSapXep = new DevExpress.XtraEditors.SimpleButton();
            this.butNhapLai = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPB
            // 
            this.dataPB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Email,
            this.Column3});
            this.dataPB.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataPB.Location = new System.Drawing.Point(57, 175);
            this.dataPB.Name = "dataPB";
            this.dataPB.RowTemplate.Height = 24;
            this.dataPB.Size = new System.Drawing.Size(694, 443);
            this.dataPB.TabIndex = 0;
            this.dataPB.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPB_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maPB";
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Mã phòng ban";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenPB";
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Tên phòng ban";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "emailPB";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dienThoai";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Location = new System.Drawing.Point(53, 53);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(707, 91);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(75, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(620, 22);
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
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(707, 91);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.searchLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(687, 26);
            this.layoutControlItem1.Text = "Tìm Kiếm:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(687, 45);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dienThoai);
            this.layoutControl2.Controls.Add(this.emailPB);
            this.layoutControl2.Controls.Add(this.tenPB);
            this.layoutControl2.Controls.Add(this.maPB);
            this.layoutControl2.Location = new System.Drawing.Point(951, 264);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(436, 201);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dienThoai
            // 
            this.dienThoai.Location = new System.Drawing.Point(118, 134);
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.Size = new System.Drawing.Size(294, 25);
            this.dienThoai.TabIndex = 7;
            // 
            // emailPB
            // 
            this.emailPB.Location = new System.Drawing.Point(118, 105);
            this.emailPB.Name = "emailPB";
            this.emailPB.Size = new System.Drawing.Size(294, 25);
            this.emailPB.TabIndex = 6;
            // 
            // tenPB
            // 
            this.tenPB.Location = new System.Drawing.Point(118, 76);
            this.tenPB.Name = "tenPB";
            this.tenPB.Size = new System.Drawing.Size(294, 25);
            this.tenPB.TabIndex = 5;
            // 
            // maPB
            // 
            this.maPB.Location = new System.Drawing.Point(118, 47);
            this.maPB.Name = "maPB";
            this.maPB.Size = new System.Drawing.Size(294, 25);
            this.maPB.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutPhongBan});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(436, 201);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 163);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(416, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutPhongBan
            // 
            this.layoutPhongBan.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutPhongBan.Location = new System.Drawing.Point(0, 0);
            this.layoutPhongBan.Name = "layoutPhongBan";
            this.layoutPhongBan.Size = new System.Drawing.Size(416, 163);
            this.layoutPhongBan.Text = "Thông tin phòng ban:";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.maPB;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(392, 29);
            this.layoutControlItem2.Text = "Mã phòng ban:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tenPB;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(392, 29);
            this.layoutControlItem3.Text = "Tên phòng ban:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.emailPB;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(392, 29);
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dienThoai;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(392, 29);
            this.layoutControlItem5.Text = "Số điện thoại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 17);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(961, 204);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(94, 29);
            this.butThem.TabIndex = 3;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(1121, 203);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(94, 29);
            this.butSua.TabIndex = 4;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSuaPB_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(1266, 204);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(94, 29);
            this.butXoa.TabIndex = 5;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoaPB_Click);
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(1121, 471);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(94, 29);
            this.butLuu.TabIndex = 6;
            this.butLuu.Text = "Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 150);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Danh sách phòng ban:";
            // 
            // butSapXep
            // 
            this.butSapXep.Location = new System.Drawing.Point(654, 136);
            this.butSapXep.Name = "butSapXep";
            this.butSapXep.Size = new System.Drawing.Size(94, 29);
            this.butSapXep.TabIndex = 9;
            this.butSapXep.Text = "Sắp xếp";
            this.butSapXep.Click += new System.EventHandler(this.butSapXep_Click);
            // 
            // butNhapLai
            // 
            this.butNhapLai.Location = new System.Drawing.Point(1266, 471);
            this.butNhapLai.Name = "butNhapLai";
            this.butNhapLai.Size = new System.Drawing.Size(94, 29);
            this.butNhapLai.TabIndex = 10;
            this.butNhapLai.Text = "Nhập lại";
            this.butNhapLai.Click += new System.EventHandler(this.butNhapLai_Click);
            // 
            // FormQLPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 714);
            this.Controls.Add(this.butNhapLai);
            this.Controls.Add(this.butSapXep);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLPB";
            this.Text = "FormQLPB";
            ((System.ComponentModel.ISupportInitialize)(this.dataPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.TextBox dienThoai;
        private System.Windows.Forms.TextBox emailPB;
        private System.Windows.Forms.TextBox tenPB;
        private System.Windows.Forms.TextBox maPB;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutPhongBan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton butThem;
        private DevExpress.XtraEditors.SimpleButton butSua;
        private DevExpress.XtraEditors.SimpleButton butXoa;
        private DevExpress.XtraEditors.SimpleButton butLuu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton butSapXep;
        private DevExpress.XtraEditors.SimpleButton butNhapLai;
    }
}