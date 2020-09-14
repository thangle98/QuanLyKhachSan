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
    public partial class FormDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public static string tenDN = "";
        public FormDoiMK(string ten)
        {
            InitializeComponent();
            tenDN = ten;
        }
        public bool check()
        {
            if(textMKmoi.Text == "" || textNhapMKmoi.Text == "")
            {
                return false;
            }
            else
            {
                if(string.Compare(textMKmoi.Text,textNhapMKmoi.Text)!= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void butXacNhan_Click(object sender, EventArgs e)
        {
            if(check())
            {
                KetNoi kn = new KetNoi();
                kn.TaiKhoan("DOiMK", tenDN, textMKmoi.Text);
                XtraMessageBox.Show("Thay đổi mật khẩu thành công");
            }
            else
            {
                XtraMessageBox.Show("Quá trình thay đổi không hợp lệ");
            }
        }
    }
}