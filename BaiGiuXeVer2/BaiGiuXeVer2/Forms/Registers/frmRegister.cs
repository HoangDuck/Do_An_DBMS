using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Registers
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
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
                if (!cbShowPassword.Checked)
                {
                    textPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textConfirmPassword.UseSystemPasswordChar = false;
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

        private void textConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "Confirm Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textConfirmPassword.UseSystemPasswordChar = true;
                }
                else 
                {
                    textConfirmPassword.UseSystemPasswordChar = false;
                }
                textConfirmPassword.Text = "";
            }
        }

        private void textConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textConfirmPassword.Text == "")
            {
                textConfirmPassword.UseSystemPasswordChar = false;
                textConfirmPassword.Text = "Confirm Password";
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
                textConfirmPassword.UseSystemPasswordChar = false;
            }
            else if (textPassword.Text != "Password" && textConfirmPassword.Text != "Confirm Password")
            {
                textPassword.UseSystemPasswordChar = true;
                textConfirmPassword.UseSystemPasswordChar = true;

            }
            else if (textPassword.Text == "Password" && textConfirmPassword.Text != "Confirm Password")
            {
                textConfirmPassword.UseSystemPasswordChar = true;
            }
            else if (textPassword.Text != "Password" && textConfirmPassword.Text == "Confirm Password")
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }
        //--------------------------------------------------------------------------------
    }
}
