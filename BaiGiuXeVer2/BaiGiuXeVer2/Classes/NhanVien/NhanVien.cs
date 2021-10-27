using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.NhanVien
{
    class NhanVien
    {
        protected MyDB.MyDBNV myDB = new MyDB.MyDBNV();
        public NhanVien()
        {
        }
        public bool changePass(String oldPass,String newPass, int maNV)
        {
            myDB.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT [dbo].[f_Lay_MK_NV]("+maNV+")",myDB.GetSqlConnection);
            String passTemp = (String)command.ExecuteScalar();
            if (oldPass == passTemp)
            {
                command = new SqlCommand("EXEC [dbo].[update_account_nhan_vien] "+maNV+","+ newPass, myDB.GetSqlConnection);
                command.Parameters.Add("@maNV", SqlDbType.Int).Value = maNV;
                if (command.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                    return true;
                }
                else
                {
                    myDB.CloseConnection();
                    return false;
                }
            }
            return false;
        }
        public DataTable getNhanVien(SqlCommand command)
        {
            command.Connection = myDB.GetSqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateNhanVien(int id, string hoten, DateTime ngaysinh, string gioitinh, string sodt, string diachi, MemoryStream anh)
        {
            SqlCommand command = new SqlCommand("EXEC [dbo].[update_thong_tin_nhan_vien]"+hoten+","+gioitinh+","+sodt+","+diachi+","+anh+","+ngaysinh, myDB.GetSqlConnection);
            
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection();
                return true;
            }
            else
            {
                myDB.CloseConnection();
                return false;
            }
        }
    }
}
