using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.XtraEditors;
using System.Configuration;

namespace QuanLyPhongKhamNhi
{
     
    class KetNoi
    {
        public SqlConnection connection = new SqlConnection();
       
        public KetNoi()
        {
            try
            {
                connection.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
                connection.Open();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
                connection.Open();
        }

        // load data user
        public DataTable LoadDataUser(string name, string pass)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "checkDangNhap";
            command.Parameters.AddWithValue("@userName", SqlDbType.VarChar).Value = name;
            command.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }


       
        // load du lieu khong dieu kien
        public DataTable LoadData(string TT)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = TT;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        // load du lieu co dieu kien 1 tham so(mã BN, mã BS...)
        public DataTable LoadDataDK(string proc,string param,string value)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = value;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }

      
        
        // Them, sua Benh Nhan
        public void BenhNhan(string pro,string MaBN, string HoTen, string GioiTinh, string NgaySinh, string DiaChi, string SDT)
        {
            try
            {
                SqlCommand command = new SqlCommand(pro, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaBN", SqlDbType.VarChar).Value = MaBN;
                command.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                command.Parameters.AddWithValue("@GioiTinh", SqlDbType.Char).Value = GioiTinh;
                command.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
                command.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                command.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = SDT;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        // Xoa benh nhan, bac sy, duoc sy,phieu kham,toathuoc,hoadon
        public void Xoa(string proc,string paramMa, string ma)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramMa, SqlDbType.VarChar).Value = ma;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        // Them, sua taikhoan
      

        public DataTable TaiKhoan(string proc,string Ten, string MK,string hoTen, string email, string phanQuyen, string trangThai)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue("@TenTK", SqlDbType.VarChar).Value = Ten;
            command.Parameters.AddWithValue("@MK", SqlDbType.VarChar).Value = MK;
            command.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.AddWithValue("@phanquyen", SqlDbType.Char).Value = phanQuyen;
            command.Parameters.AddWithValue("@trangThai", SqlDbType.Char).Value = trangThai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public DataTable TaiKhoan(string proc, string Ten, string MK)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue("@TenDN", SqlDbType.VarChar).Value = Ten;
            command.Parameters.AddWithValue("@MK", SqlDbType.VarChar).Value = MK;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable NhanVien(string proc, string maNV, string hoTenNV, string ngaySinh, string namLV, string gioiTinh, string Luong, string maPB)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = maNV;
            command.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTenNV;
            command.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
            command.Parameters.AddWithValue("@NamLamViec", SqlDbType.Int).Value = namLV;
            command.Parameters.AddWithValue("@GioiTinh", SqlDbType.NChar).Value = gioiTinh;
            command.Parameters.AddWithValue("@Luong", SqlDbType.Int).Value = Luong;
            command.Parameters.AddWithValue("@MaPB", SqlDbType.VarChar).Value = maPB;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable PhongBan(string proc, string maPB, string tenPB, string email, string dienThoai)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue("@maPB", SqlDbType.VarChar).Value = maPB;
            command.Parameters.AddWithValue("@tenPB", SqlDbType.NVarChar).Value = tenPB;
            command.Parameters.AddWithValue("@emailPB", SqlDbType.VarChar).Value = email;
            command.Parameters.AddWithValue("@dienThoai", SqlDbType.VarChar).Value = dienThoai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
