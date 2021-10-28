using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class showListCarInPackUC : UserControl
    {
        MyDB.MyDBNV myDB = new MyDB.MyDBNV();
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        public showListCarInPackUC()
        {
            InitializeComponent();
        }

        private void showListCarInPackUC_Load(object sender, EventArgs e)
        {
            radiobtnNgay.Checked = true;
            SqlCommand command1 = new SqlCommand("SELECT * From [dbo].[f_thong_tin_xe_thang_trong_bai]()", myDB.GetSqlConnection);
            SqlCommand command2 = new SqlCommand("SELECT * From [dbo].[f_Thong_Tin_All_Xe_Ve_Ngay_Trong_Bai]()", myDB.GetSqlConnection);
            DataTable xengay =kh.getXeTrongbai(command2);
            DataTable xethang =kh.getXeTrongbai(command1);
            DataTable table = new DataTable();
            table.Merge(xengay);
            table.Merge(xethang);
            dataGridViewXe.DataSource = table;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String tempSearch = TextBox_Search.Text;
            if (tempSearch == "")
            {
                MessageBox.Show("Vui lòng nhập biển số", "Tìm Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(radiobtnNgay.Checked == true)
                {
                    SqlCommand command = new SqlCommand("Select * From [dbo].[f_Thong_Tin_Xe_Ve_Ngay]("+tempSearch+")", myDB.GetSqlConnection);
                    DataTable table = kh.getKhNgay(command);
                    TextBox_BienSo.Text = table.Rows[0]["BienXe"].ToString();
                    dtmNgayGui.Value =(DateTime) table.Rows[0]["Check_in"];
                }
                else
                {
                    SqlCommand command = new SqlCommand("Select * From [dbo].[f_thong_tin_xe_thang_trong_bai_theo_bien](" + tempSearch + ")", myDB.GetSqlConnection);
                    DataTable table = kh.getKhNgay(command);
                    TextBox_BienSo.Text = table.Rows[0]["BienXe"].ToString();
                    dtmNgayGui.Value = (DateTime)table.Rows[0]["Check_in"];
                    TextBoxt_DiaChi.Text = table.Rows[0]["DiaChi"].ToString();
                    Textbox_SDT.Text = table.Rows[0]["SDT"].ToString();
                    Textbox_TenKH.Text = table.Rows[0]["TenKH"].ToString();
                }
            }
        }
    }
}
