using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class receiveCarUC : UserControl
    {
        public receiveCarUC()
        {
            InitializeComponent();
        }
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            dtmNgayGui.Value = DateTime.Now;
            dtmNgayTra.Value = DateTime.Now.AddDays(30);
            if (verif())
            {
                MessageBox.Show("Nội dung mới không khớp", "Nhận Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String bienso = TextBox_BienSo.Text;
                String ten = TextBox_TenKH.Text;
                String diachi = TextBox_DiaChi.Text;
                DateTime ngaydk = dtmNgayGui.Value;
                DateTime ngayhh = dtmNgayTra.Value;
                String sdt = TextBox_SDT.Text;
                int phi = int.Parse(TextBox_Phi.Text);
                MemoryStream anh = new MemoryStream();
                pic_bienso.Image.Save(anh, pic_bienso.Image.RawFormat);
                if (kh.dangkyThang(bienso,ngaydk,ngayhh,phi) && kh.themKhachHang(bienso,ten,diachi,sdt,anh))
                {
                    MessageBox.Show("Đã thêm xe của khách hàng mới", "Them xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool verif()
        {
            if ((TextBox_BienSo.Text.Trim() == "") ||
                (TextBox_TenKH.Text.Trim() == "") ||
                (TextBox_DiaChi.Text.Trim() == "") ||
                (TextBox_SDT.Text.Trim() == "")||
                (TextBox_Phi.Text.Trim()==""))
                return false;
            else
                return true;
        }
    }
}
