using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        //------------DESIGN EVENT FORM----------------------------------------------------------
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Username")
            {
                textUser.Text = "";
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Username";
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                if (!CheckBox_HienThiMK.Checked)
                {
                    textPassword.UseSystemPasswordChar = true;
                }
                textPassword.Text = "";
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.Text = "Password";
            }
        }

        private void CheckBox_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HienThiMK.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else if (textPassword.Text != "Password")
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }
        //--------------------------------------------------------------------------------

    }
}
