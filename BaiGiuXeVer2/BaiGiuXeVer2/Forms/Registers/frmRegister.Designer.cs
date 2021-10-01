
namespace BaiGiuXeVer2.Forms.Registers
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.textUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.textConfirmPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.cbShowPassword = new Guna.UI.WinForms.GunaCheckBox();
            this.rdoManager = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoStaff = new Guna.UI.WinForms.GunaRadioButton();
            this.buttonRegister = new Guna.UI.WinForms.GunaGradientButton();
            this.iconLogin = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.White;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textPassword.Location = new System.Drawing.Point(30, 260);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(425, 37);
            this.textPassword.TabIndex = 74;
            this.textPassword.Text = "Password";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textUser.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.LineColor = System.Drawing.Color.Gainsboro;
            this.textUser.Location = new System.Drawing.Point(30, 200);
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.SelectedText = "";
            this.textUser.Size = new System.Drawing.Size(425, 37);
            this.textUser.TabIndex = 73;
            this.textUser.Text = "Username";
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.BackColor = System.Drawing.Color.White;
            this.textConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textConfirmPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textConfirmPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmPassword.LineColor = System.Drawing.Color.Gainsboro;
            this.textConfirmPassword.Location = new System.Drawing.Point(30, 320);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '\0';
            this.textConfirmPassword.SelectedText = "";
            this.textConfirmPassword.Size = new System.Drawing.Size(425, 37);
            this.textConfirmPassword.TabIndex = 80;
            this.textConfirmPassword.Text = "Confirm Password";
            this.textConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.BaseColor = System.Drawing.Color.White;
            this.cbShowPassword.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbShowPassword.FillColor = System.Drawing.Color.White;
            this.cbShowPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(30, 378);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(150, 22);
            this.cbShowPassword.TabIndex = 81;
            this.cbShowPassword.Text = "Hiển thị mật khẩu";
            // 
            // rdoManager
            // 
            this.rdoManager.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoManager.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoManager.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoManager.FillColor = System.Drawing.Color.White;
            this.rdoManager.Location = new System.Drawing.Point(332, 422);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(69, 20);
            this.rdoManager.TabIndex = 83;
            this.rdoManager.Text = "Quản lý";
            // 
            // rdoStaff
            // 
            this.rdoStaff.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoStaff.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoStaff.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoStaff.FillColor = System.Drawing.Color.White;
            this.rdoStaff.Location = new System.Drawing.Point(76, 422);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(81, 20);
            this.rdoStaff.TabIndex = 82;
            this.rdoStaff.Text = "Nhân viên";
            // 
            // buttonRegister
            // 
            this.buttonRegister.AnimationHoverSpeed = 0.07F;
            this.buttonRegister.AnimationSpeed = 0.03F;
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.buttonRegister.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.buttonRegister.BorderColor = System.Drawing.Color.Black;
            this.buttonRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonRegister.FocusedColor = System.Drawing.Color.Empty;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Image = null;
            this.buttonRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonRegister.Location = new System.Drawing.Point(30, 474);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.buttonRegister.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.buttonRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonRegister.OnHoverImage = null;
            this.buttonRegister.OnPressedColor = System.Drawing.Color.Black;
            this.buttonRegister.Radius = 10;
            this.buttonRegister.Size = new System.Drawing.Size(425, 65);
            this.buttonRegister.TabIndex = 84;
            this.buttonRegister.Text = "Đăng ký";
            this.buttonRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.Transparent;
            this.iconLogin.BaseColor = System.Drawing.Color.Black;
            this.iconLogin.Image = global::BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
            this.iconLogin.Location = new System.Drawing.Point(177, 45);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(130, 130);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogin.TabIndex = 1;
            this.iconLogin.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 568);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.rdoManager);
            this.Controls.Add(this.rdoStaff);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.iconLogin);
            this.Name = "frmRegister";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox iconLogin;
        private Guna.UI.WinForms.GunaLineTextBox textPassword;
        private Guna.UI.WinForms.GunaLineTextBox textUser;
        private Guna.UI.WinForms.GunaLineTextBox textConfirmPassword;
        private Guna.UI.WinForms.GunaCheckBox cbShowPassword;
        private Guna.UI.WinForms.GunaRadioButton rdoManager;
        private Guna.UI.WinForms.GunaRadioButton rdoStaff;
        private Guna.UI.WinForms.GunaGradientButton buttonRegister;
    }
}