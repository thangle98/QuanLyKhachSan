using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyPhongKhamNhi
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int admin = 0;
        public static string tenDN = "";

        public Form1(string ten)
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
            admin = 0;// quyên nhân viên
            tenDN = ten;
        }
        public Form1(int a,string ten)
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
            admin = 1;// quyên admin
            tenDN = ten;
        }
        private void butPhieuKham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             panel1.Controls.Clear();
             FormQLNV qlnv = new FormQLNV();
             qlnv.TopLevel = false;
             panel1.Controls.Add(qlnv);
             qlnv.Dock = DockStyle.Fill;
             qlnv.Show();
            
        }

        private void butThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void butQuanLyDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(admin == 0)
            {
                XtraMessageBox.Show("Bạn cần đăng nhập với quyền admin");
                butQuanLyDN.Enabled = false;
            }
            else
            {
                butQuanLyDN.Enabled = true;
                panel1.Controls.Clear();
                FormQuanLyDN fQL = new FormQuanLyDN();
                fQL.TopLevel = false;
                panel1.Controls.Add(fQL);
                fQL.Dock = DockStyle.Fill;
                fQL.Show();
            }  
        }

        private void butWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void butPaint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void butExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void butPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FormQLPB fT = new FormQLPB();
            fT.TopLevel = false;
            panel1.Controls.Add(fT);
            fT.Dock = DockStyle.Fill;
            fT.Show();
        }

        private void butMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoiMK f = new FormDoiMK(tenDN);
            f.ShowDialog();
        }

        private void butTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Tên: Bùi Thị Thu Ngà\n Ngày sinh: 16/04/1998\n Email: buithunga7@gmail.com\n Hướng dẫn: Thầy Mai Mạnh Trừng");
        }

        private void butBanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Bản quyền thuộc về sinh viên Bùi Thị Thu Ngà phiên bản 1.0");
        }

        private void butHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Hướng dẫn:\n1.Quản lý tài khoản: có thể thêm sửa xóa tài khoản đối với admin.\n2. Quản lý nhân viên: có thể xem thêm sửa xóa thông tin." +
                "\n3. Quản lý phòng ban: có thể xem thêm sửa xóa thông tin.\n4. Báo cáo: báo cáo thông tin phòng ban và báo cáo thông tin về nhân viên.\n5.Tiện ích: có thể " +
                "khởi động các phần mềm ứng dụng vd: word, excel, paint.\n6.Trợ giúp: có thể xem thông tin tác giả, thông tin bản quyền và xem hướng dẫn");
        }

        private void baoCaoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
