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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadDataUser(textTen.Text, textMK.Text);
            if (dt.Rows.Count == 1)
            {
                if(dt.Rows[0][4].ToString().CompareTo("1") != 0)
                {
                    Form1 f = new Form1(dt.Rows[0][0].ToString());
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    Form1 f = new Form1(1, dt.Rows[0][0].ToString());
                    this.Hide();
                    f.ShowDialog();
                }
            }
            else
            {
                XtraMessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng");
            }
        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkMK.Checked == true)
            {
                textMK.UseSystemPasswordChar = false;
            }
            else
            {
                textMK.UseSystemPasswordChar = true;
            }
        }
    }
}