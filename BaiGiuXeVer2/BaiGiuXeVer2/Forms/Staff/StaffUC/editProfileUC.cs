using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class editProfileUC : UserControl
    {
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public editProfileUC()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nội dung mới không khớp", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(TextBox_MaSo.Text);
                String ten = TextBox_HoTen.Text;
                String gtinh = cboGioiTinh.SelectedValue.ToString();
                DateTime ngsinh = dtmNgaySinh.Value;
                String sdt = TextBox_SDT.Text;
                String diachi = TextBox_DiaChi.Text;
                MemoryStream pic = new MemoryStream();
                pic_bienso.Image.Save(pic, pic_bienso.Image.RawFormat);
                if (nv.updateNhanVien(id,ten,ngsinh,gtinh,sdt,diachi,pic))
                {
                    MessageBox.Show("Đã cập nhật nhân viên", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool verif()
        {
            if ((TextBox_MaSo.Text.Trim() == "") ||
                (TextBox_HoTen.Text.Trim() == "") ||
                (TextBox_DiaChi.Text.Trim() == "") ||
                (TextBox_SDT.Text.Trim() == ""))
                return false;
            else
                return true;
        }
        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void editProfileUC_Load(object sender, EventArgs e)
        {
            MyDB.MyDBNV myDB = new MyDB.MyDBNV();
            SqlCommand command = new SqlCommand("SELECT * From [dbo].[f_Thong_Tin_NV](" + id + ")",myDB.GetSqlConnection);
            DataTable table = nv.getNhanVien(command);
            TextBox_MaSo.Text= table.Rows[0]["Id"].ToString();
            TextBox_HoTen.Text = table.Rows[0]["TenNV"].ToString();
            if (table.Rows[0]["GioiTinh"].ToString() == "Nam")
                cboGioiTinh.SelectedValue = "Nam";
            else
                cboGioiTinh.SelectedValue = "Nữ";           
            dtmNgaySinh.Value = (DateTime)table.Rows[0]["NgaySinh"];
            TextBox_SDT.Text = table.Rows[0]["SoDT"].ToString();
            TextBox_DiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            TextBox_TenQuanLy.Text = table.Rows[0]["TenQL"].ToString();
            byte[] pic = (byte[])table.Rows[0]["Anh"];
            MemoryStream picture = new MemoryStream(pic);
            pic_bienso.Image = Image.FromStream(picture);
        }

        private void pic_bienso_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            pic_bienso.Image = Image.FromFile(opf.FileName);
        }
    }
}
