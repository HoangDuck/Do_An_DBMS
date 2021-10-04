using BaiGiuXeVer2.Forms.Registers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Manager
{
    public partial class mainFormManager : Form
    {
        public mainFormManager()
        {
            InitializeComponent();
        }

        private void mainFormManager_Load(object sender, EventArgs e)
        {
            this.closeAllUC();
        }
        private void closeAllUC()
        {
            changePasswordUC1.Visible = false;
            editProfileUC1.Visible = false;
            showInfoStaffUC1.Visible = false;
            showListCarInPackUC1.Visible = false;
            statisticUC1.Visible = false;
        }
        
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmRegister fReg = new frmRegister();
            fReg.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            editProfileUC1.Visible = true;
            editProfileUC1.BringToFront();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            changePasswordUC1.Visible = true;
            changePasswordUC1.BringToFront();
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            showInfoStaffUC1.Visible = true;
            showInfoStaffUC1.BringToFront();
        }

        private void btnXeTrongBai_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            showListCarInPackUC1.Visible = true;
            showListCarInPackUC1.BringToFront();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            statisticUC1.Visible = true;
            statisticUC1.BringToFront();
        }

    }
}
