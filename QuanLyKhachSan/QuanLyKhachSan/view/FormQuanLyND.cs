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

namespace QuanLyPhongKhamNhi
{
    public partial class FormQuanLyDN : DevExpress.XtraEditors.XtraForm
    {
        public static int kt = 0; // kiểm tra thêm, sửa, xóa
        public FormQuanLyDN()
        {
            InitializeComponent();
        }
        public void getData()
        {
            KetNoi kn = new KetNoi();
            dataNguoiDung.DataSource = kn.LoadData("DSTenDN");
            kn.OpenConnection();
            DataTable dt = kn.LoadData("DSTenDN");
            dt.Columns[0].ColumnName = "Tên đăng nhập";
            dt.Columns[1].ColumnName = "Mật khẩu";
            dt.Columns[2].ColumnName = "Họ tên";
            dt.Columns[3].ColumnName = "Email";
            dt.Columns[4].ColumnName = "Phân quyền";
            dt.Columns[5].ColumnName = "Trạng thái";
            searchLookUpEdit1.Properties.DataSource = dt;
        }
        public bool kiemtra()
        {
            if (textTenDN.Text == "" || textMK.Text == "" || comboBoxQuyen.Text == "" || textHoTen.Text == "" || comboTrangThai.Text == "")
                return false;
            return true;
        }

        public void clear()
        {
            textTenDN.Text = "";
            textMK.Text = "";
            comboBoxQuyen.Text = "";
            textHoTen.Text = "";
            textMail.Text = "";
            comboTrangThai.Text = "";
        }
        private void FormQuanLyDN_Load(object sender, EventArgs e)
        {
            layoutThongTinTaiKhoan.Enabled = false;
            butLuu.Enabled = false;
            getData();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            layoutThongTinTaiKhoan.Enabled = true;
            butLuu.Enabled = true;
            textTenDN.Enabled = true;
            clear();
            butThem.ForeColor = Color.White;
            butSua.ForeColor = Color.Black;
            butXoa.ForeColor = Color.Black;
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            layoutThongTinTaiKhoan.Enabled = true;
            butLuu.Enabled = true;
            textTenDN.Enabled = false;
            butThem.ForeColor = Color.Black;
            butSua.ForeColor = Color.White;
            butXoa.ForeColor = Color.Black;
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            kt = 3;
            layoutThongTinTaiKhoan.Enabled = false;
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
                if (kn.LoadDataDK("TaiKhoanDK", "@TenTK", textTenDN.Text).Rows.Count == 1)
                    XtraMessageBox.Show("Người dùng đã có trong danh sách");
                else
                {
                    kn.OpenConnection();
                    kn.TaiKhoan("ThemTK", textTenDN.Text, textMK.Text, textHoTen.Text, textMail.Text, comboBoxQuyen.Text, comboTrangThai.Text);
                }
            }
            else if (kt == 2)
            {
                if (kn.LoadDataDK("TaiKhoanDK", "@TenTK", textTenDN.Text).Rows.Count == 0)
                    XtraMessageBox.Show("Không tìm thấy người dùng để sửa ");
                else
                {
                    kn.OpenConnection();
                    kn.TaiKhoan("SuaTK", textTenDN.Text, textMK.Text,textHoTen.Text,textMail.Text, comboBoxQuyen.Text,comboTrangThai.Text);
                }
            }
            else if (kt == 3)
            {
                try
                {
                    if (kn.LoadDataDK("TaiKhoanDK", "@TenTK", textTenDN.Text).Rows.Count == 0)
                        XtraMessageBox.Show("Không tìm thấy người dùng để xóa ");
                    else
                    {
                        kn.OpenConnection();
                        kn.Xoa("XoaTK", "@TenTK", textTenDN.Text);
                        clear();
                    }
                }
                catch(Exception ex)
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

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit1.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Tên đăng nhập";
            string fieldName2 = "Mật khẩu";
            string fieldName3 = "Họ tên";
            string fieldName4 = "Email";
            string fieldName5 = "Phân quyền";
            string fieldName6 = "Trạng thái";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            object value5 = view.GetRowCellValue(rowHandle, fieldName5);
            object value6 = view.GetRowCellValue(rowHandle, fieldName6);
            textTenDN.Text = value1.ToString();
            textMK.Text = value2.ToString();
            textHoTen.Text = value3.ToString();
            textMail.Text = value4.ToString();
            comboBoxQuyen.Text = value5.ToString();
            comboTrangThai.Text = value6.ToString();
        }

        private void dataNguoiDung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataNguoiDung.Rows[e.RowIndex];
                textTenDN.Text = row.Cells[0].Value.ToString();
                textMK.Text = row.Cells[1].Value.ToString();
                textHoTen.Text = row.Cells[2].Value.ToString();
                textMail.Text = row.Cells[3].Value.ToString();
                comboBoxQuyen.Text = row.Cells[4].Value.ToString();
                comboTrangThai.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void butNhapLai_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}