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
    public partial class FormQLPB : DevExpress.XtraEditors.XtraForm
    {
        public static int kt = 0;// biến kiểm tra thêm, sửa, xóa
        public FormQLPB()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
           
            KetNoi kn = new KetNoi();
            dataPB.DataSource = kn.LoadData("DanhSachPB");
            kn.OpenConnection();
            DataTable dt = kn.LoadData("DanhSachPB");
            dt.Columns["maPB"].ColumnName = "Mã phòng ban";
            dt.Columns["tenPB"].ColumnName = "Tên phòng ban";
            dt.Columns["emailPB"].ColumnName = "Email";
            dt.Columns["dienThoai"].ColumnName = "Số điện thoại";
            searchLookUpEdit1.Properties.DataSource = dt;
        }
        public bool kiemtra()
        {
            if (maPB.Text == "" || tenPB.Text == "" || emailPB.Text == "" || dienThoai.Text == "")
                return false;
            return true;
        }
        public void clear()
        {
            maPB.Text = "";
            tenPB.Text = "";
            emailPB.Text = "";
            dienThoai.Text = "";
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            layoutPhongBan.Enabled = true;
            butLuu.Enabled = true;
            maPB.Enabled = true;
            clear();
            butThem.ForeColor = Color.White;
            butSua.ForeColor = Color.Black;
            butXoa.ForeColor = Color.Black;
        }

        private void butSuaPB_Click(object sender, EventArgs e)
        {
            kt = 2;
            layoutPhongBan.Enabled = true;
            butLuu.Enabled = true;
            maPB.Enabled = false;
            butThem.ForeColor = Color.Black;
            butSua.ForeColor = Color.White;
            butXoa.ForeColor = Color.Black;
        }

        private void butXoaPB_Click(object sender, EventArgs e)
        {
            kt = 3;
            layoutPhongBan.Enabled = false;
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
                if (kn.LoadDataDK("PhongBanDK", "@maPB", maPB.Text).Rows.Count == 1)
                    XtraMessageBox.Show("Phòng ban này đã có trong danh sách");
                else
                {
                    kn.OpenConnection();
                    kn.PhongBan("ThemPB", maPB.Text, tenPB.Text, emailPB.Text, dienThoai.Text);
                }
            }
            else if (kt == 2)
            {
                if (kn.LoadDataDK("PhongBanDK", "@maPB", maPB.Text).Rows.Count == 0)
                    XtraMessageBox.Show("Không tìm thấy phòng ban này để sửa ");
                else
                {
                    kn.OpenConnection();
                    kn.PhongBan("SuaPB", maPB.Text, tenPB.Text, emailPB.Text, dienThoai.Text);
                }
            
            }
            else if (kt == 3)
            {
                try
                {
                    if (kn.LoadDataDK("PhongBanDK", "@maPB", maPB.Text).Rows.Count == 0)
                        XtraMessageBox.Show("Không tìm thấy phòng ban này để xóa ");
                    else
                    {
                        kn.OpenConnection();
                        kn.Xoa("XoaPB", "@maPB", maPB.Text);
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

        private void dataPB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataPB.Rows[e.RowIndex];
                maPB.Text = row.Cells[0].Value.ToString();
                tenPB.Text = row.Cells[1].Value.ToString();
                emailPB.Text = row.Cells[2].Value.ToString();
                dienThoai.Text = row.Cells[3].Value.ToString();
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
            string fieldName1 = "Mã phòng ban";
            string fieldName2 = "Tên phòng ban";
            string fieldName3 = "Email";
            string fieldName4 = "Số điện thoại";

            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
       
            maPB.Text = value1.ToString();
            tenPB.Text = value2.ToString();
            emailPB.Text = value3.ToString();
            dienThoai.Text = value4.ToString();
        }

        private void butSapXep_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            dataPB.DataSource = kn.LoadData("SapXepPB");
        }
    }
}