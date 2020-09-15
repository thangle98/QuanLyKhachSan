using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QuanLyPhongKhamNhi
{
    public partial class FormQLNV : DevExpress.XtraEditors.XtraForm
    {
        public static int kt = 0;// biến kiểm tra thêm, sửa, xóa
        public FormQLNV()
        {
            InitializeComponent();
            dataNV.ReadOnly = true;
            textTenPB.ReadOnly = true;
            getData();
        }
        public void loadMaPB()
        {
            textMaPB.Items.Clear();
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadData("DanhSachPB");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textMaPB.Items.Add(dt.Rows[i][0]);
            }

        }
        public void getData()
        {
            loadMaPB();
            KetNoi kn = new KetNoi();
            dataNV.DataSource = kn.LoadData("DanhSachNV");
            kn.OpenConnection();
            DataTable dt = kn.LoadData("HienThiNV");
            dt.Columns["MaNV"].ColumnName = "Mã nhân viên";
            dt.Columns["hoTenNV"].ColumnName = "Họ tên";
            dt.Columns["ngaySinh"].ColumnName = "Ngày sinh";
            dt.Columns["gioiTinh"].ColumnName = "Giới tính";
            dt.Columns["namLamViec"].ColumnName = "Năm làm việc";
            dt.Columns["luong"].ColumnName = "Lương";
            dt.Columns["tenPB"].ColumnName = "Tên phòng ban";
            dt.Columns["maPB"].ColumnName = "Mã phòng ban";
            searchLookUpEdit1.Properties.DataSource = dt;
        }
        public bool kiemtra()
        {
            if (textMaNV.Text == "" || textHoTen.Text == "" || textNS.Text == "" || textGT.Text == ""|| textLuong.Text == "" || textTenPB.Text == "")
                return false;
            return true;
        }
        public void clear()
        {
            textMaNV.Text = "";
            textHoTen.Text = "";
            textNS.Text = "";
            textGT.Text = "";
            textLuong.Text = "";
            textTenPB.Text = "";
            textMaPB.Text = "";
            textNamLV.Text = "";
        }

        private void butThemPk_Click(object sender, EventArgs e)
        {
            kt = 1;
            layoutNhanVien.Enabled = true;
            butLuu.Enabled = true;
            textMaNV.Enabled = true;
            clear();
            butThem.ForeColor = Color.White;
            butSua.ForeColor = Color.Black;
            butXoa.ForeColor = Color.Black;
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            layoutNhanVien.Enabled = true;
            butLuu.Enabled = true;
            textMaNV.Enabled = false;
            butThem.ForeColor = Color.Black;
            butSua.ForeColor = Color.White;
            butXoa.ForeColor = Color.Black;

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            kt = 3;
            layoutNhanVien.Enabled = false;
            butLuu.Enabled = true;
            butThem.ForeColor = Color.Black;
            butSua.ForeColor = Color.Black;
            butXoa.ForeColor = Color.White;
        }

        private void butLuu_Click(object sender, EventArgs e)
        {

            if (kiemtra() == false)
            {
                XtraMessageBox.Show("Bạn điền thông tin chưa đầy đủ");
                return;
            }
            KetNoi kn = new KetNoi();
            if (kt == 1)
            {
                if (kn.LoadDataDK("NhanVienDK", "@MaNV", textMaNV.Text).Rows.Count == 1)
                    XtraMessageBox.Show("Nhân viên này đã có trong danh sách");
                else
                {
                    kn.OpenConnection();
                    kn.NhanVien("ThemNV", textMaNV.Text, textHoTen.Text, textNS.Text, textNamLV.Text, textGT.Text, textLuong.Text, textTenPB.Text);
                }
            }
            else if (kt == 2)
            {
                if (kn.LoadDataDK("NhanVienDK", "@MaNV", textMaNV.Text).Rows.Count == 0)
                    XtraMessageBox.Show("Không tìm thấy nhân viên để sửa ");
                else
                {
                    kn.OpenConnection();
                    kn.NhanVien("SuaNV", textMaNV.Text, textHoTen.Text, textNS.Text, textNamLV.Text, textGT.Text, textLuong.Text, textMaPB.Text);
                }
            }
            else if (kt == 3)
            {
                try
                {
                    if (kn.LoadDataDK("NhanVienDK", "@MaNV", textMaNV.Text).Rows.Count == 0)
                        XtraMessageBox.Show("Không tìm thấy nhân viên để xóa ");
                    else
                    {
                        kn.OpenConnection();
                        kn.Xoa("XoaNV", "@MaNV", textMaNV.Text);
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    kn.connection.Close();
                    XtraMessageBox.Show(ex.Message);
                }

            }
            getData();
            kt = 0;
            butThem.ForeColor = Color.Black;
            butSua.ForeColor = Color.Black;
            butXoa.ForeColor = Color.Black;

        }

        private void dataPhieuKham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataNV.Rows[e.RowIndex];
                textMaNV.Text = row.Cells[0].Value.ToString();
                textHoTen.Text = row.Cells[1].Value.ToString();
                textNS.Text = row.Cells[2].Value.ToString().Substring(0, 10);;
                textGT.Text = row.Cells[4].Value.ToString();
                textNamLV.Text = row.Cells[3].Value.ToString();
                textLuong.Text = row.Cells[5].Value.ToString();
                textMaPB.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit1.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã nhân viên";
            string fieldName2 = "Họ tên";
            string fieldName3 = "Ngày sinh";
            string fieldName4 = "Giới tính";
            string fieldName5 = "Năm làm việc";
            string fieldName6 = "Lương";
            string fieldName7 = "Mã phòng ban";
            string fieldName8 = "Tên phòng ban";
            
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            object value5 = view.GetRowCellValue(rowHandle, fieldName5);
            object value6 = view.GetRowCellValue(rowHandle, fieldName6);
            object value7 = view.GetRowCellValue(rowHandle, fieldName7);
            object value8 = view.GetRowCellValue(rowHandle, fieldName8);
            textMaNV.Text = value1.ToString();
            textHoTen.Text =value2.ToString();
            textNS.Text = value3.ToString().Substring(0, 10);
            textGT.Text = value4.ToString();
            textNamLV.Text = value5.ToString();
            textLuong.Text = value6.ToString();
            textTenPB.Text = value7.ToString();
            textMaPB.Text = value8.ToString();
        }

        private void textTenPB_SelectedValueChanged(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadDataDK("PBDK", "@maPB", textMaPB.Text);
            if (textMaPB.SelectedItem != null)
            {
                textTenPB.Text = dt.Rows[0][0].ToString(); // tên tương ứng
            }
        }

        private void butSapXep_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            dataNV.DataSource = kn.LoadData("SapXepLuong");
        }

        private void butNhapLai_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}