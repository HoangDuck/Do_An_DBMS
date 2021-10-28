
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class showListCarInPackUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.TextBox_Search = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.TextBox_Phat = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_SDT = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Textbox_TenKH = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxt_DiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmNgayGui = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtmNgayTra = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TextBox_BienSo = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewXe = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.radiobtnThang = new Guna.UI.WinForms.GunaRadioButton();
            this.radiobtnNgay = new Guna.UI.WinForms.GunaRadioButton();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BaseColor = System.Drawing.Color.White;
            this.GroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.GroupBox1.Controls.Add(this.gunaPanel1);
            this.GroupBox1.Controls.Add(this.btnEdit);
            this.GroupBox1.Controls.Add(this.TextBox_Search);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.LineColor = System.Drawing.Color.Gray;
            this.GroupBox1.Location = new System.Drawing.Point(32, 107);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Radius = 10;
            this.GroupBox1.Size = new System.Drawing.Size(429, 295);
            this.GroupBox1.TabIndex = 45;
            this.GroupBox1.Text = "Tìm Kiếm";
            this.GroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderSize = 3;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(282, 209);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 8;
            this.btnEdit.Size = new System.Drawing.Size(131, 62);
            this.btnEdit.TabIndex = 109;
            this.btnEdit.Text = "Tìm";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Search.BaseColor = System.Drawing.Color.White;
            this.TextBox_Search.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_Search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_Search.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Search.Location = new System.Drawing.Point(21, 209);
            this.TextBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.PasswordChar = '\0';
            this.TextBox_Search.Radius = 10;
            this.TextBox_Search.SelectedText = "";
            this.TextBox_Search.Size = new System.Drawing.Size(253, 62);
            this.TextBox_Search.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nhập biển số xe cần tìm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BaseColor = System.Drawing.Color.White;
            this.groupBox2.BorderColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.TextBox_Phat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Textbox_SDT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Textbox_TenKH);
            this.groupBox2.Controls.Add(this.TextBoxt_DiaChi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtmNgayGui);
            this.groupBox2.Controls.Add(this.dtmNgayTra);
            this.groupBox2.Controls.Add(this.TextBox_BienSo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.LineColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(464, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Radius = 10;
            this.groupBox2.Size = new System.Drawing.Size(940, 295);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.Text = "Thông tin xe";
            this.groupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TextBox_Phat
            // 
            this.TextBox_Phat.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Phat.BaseColor = System.Drawing.Color.White;
            this.TextBox_Phat.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_Phat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Phat.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_Phat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_Phat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_Phat.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_Phat.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Phat.Location = new System.Drawing.Point(628, 217);
            this.TextBox_Phat.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Phat.Name = "TextBox_Phat";
            this.TextBox_Phat.PasswordChar = '\0';
            this.TextBox_Phat.Radius = 10;
            this.TextBox_Phat.SelectedText = "";
            this.TextBox_Phat.Size = new System.Drawing.Size(249, 54);
            this.TextBox_Phat.TabIndex = 45;
            this.TextBox_Phat.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(488, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "Phạt:";
            // 
            // Textbox_SDT
            // 
            this.Textbox_SDT.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_SDT.BaseColor = System.Drawing.Color.White;
            this.Textbox_SDT.BorderColor = System.Drawing.Color.Silver;
            this.Textbox_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_SDT.FocusedBaseColor = System.Drawing.Color.White;
            this.Textbox_SDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Textbox_SDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Textbox_SDT.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Textbox_SDT.ForeColor = System.Drawing.Color.Black;
            this.Textbox_SDT.Location = new System.Drawing.Point(628, 164);
            this.Textbox_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_SDT.Name = "Textbox_SDT";
            this.Textbox_SDT.PasswordChar = '\0';
            this.Textbox_SDT.Radius = 10;
            this.Textbox_SDT.SelectedText = "";
            this.Textbox_SDT.Size = new System.Drawing.Size(249, 54);
            this.Textbox_SDT.TabIndex = 43;
            this.Textbox_SDT.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(488, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 35);
            this.label3.TabIndex = 42;
            this.label3.Text = "SĐT: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 35);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ngày Trả:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(25, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 35);
            this.label17.TabIndex = 26;
            this.label17.Text = "Biển số:";
            // 
            // Textbox_TenKH
            // 
            this.Textbox_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.Textbox_TenKH.BaseColor = System.Drawing.Color.White;
            this.Textbox_TenKH.BorderColor = System.Drawing.Color.Silver;
            this.Textbox_TenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_TenKH.FocusedBaseColor = System.Drawing.Color.White;
            this.Textbox_TenKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Textbox_TenKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Textbox_TenKH.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Textbox_TenKH.ForeColor = System.Drawing.Color.Black;
            this.Textbox_TenKH.Location = new System.Drawing.Point(628, 58);
            this.Textbox_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_TenKH.Name = "Textbox_TenKH";
            this.Textbox_TenKH.PasswordChar = '\0';
            this.Textbox_TenKH.Radius = 10;
            this.Textbox_TenKH.SelectedText = "";
            this.Textbox_TenKH.Size = new System.Drawing.Size(249, 54);
            this.Textbox_TenKH.TabIndex = 41;
            this.Textbox_TenKH.Visible = false;
            // 
            // TextBoxt_DiaChi
            // 
            this.TextBoxt_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxt_DiaChi.BaseColor = System.Drawing.Color.White;
            this.TextBoxt_DiaChi.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxt_DiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxt_DiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBoxt_DiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBoxt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.TextBoxt_DiaChi.Location = new System.Drawing.Point(628, 111);
            this.TextBoxt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxt_DiaChi.Name = "TextBoxt_DiaChi";
            this.TextBoxt_DiaChi.PasswordChar = '\0';
            this.TextBoxt_DiaChi.Radius = 10;
            this.TextBoxt_DiaChi.SelectedText = "";
            this.TextBoxt_DiaChi.Size = new System.Drawing.Size(249, 54);
            this.TextBoxt_DiaChi.TabIndex = 41;
            this.TextBoxt_DiaChi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày gửi: ";
            // 
            // dtmNgayGui
            // 
            this.dtmNgayGui.BackColor = System.Drawing.Color.Transparent;
            this.dtmNgayGui.BaseColor = System.Drawing.Color.White;
            this.dtmNgayGui.BorderColor = System.Drawing.Color.Silver;
            this.dtmNgayGui.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayGui.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmNgayGui.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgayGui.ForeColor = System.Drawing.Color.Black;
            this.dtmNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayGui.Location = new System.Drawing.Point(176, 119);
            this.dtmNgayGui.Margin = new System.Windows.Forms.Padding(4);
            this.dtmNgayGui.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgayGui.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgayGui.Name = "dtmNgayGui";
            this.dtmNgayGui.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmNgayGui.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayGui.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayGui.OnPressedColor = System.Drawing.Color.Black;
            this.dtmNgayGui.Radius = 10;
            this.dtmNgayGui.Size = new System.Drawing.Size(249, 37);
            this.dtmNgayGui.TabIndex = 39;
            this.dtmNgayGui.Text = "22/04/2021";
            this.dtmNgayGui.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            this.dtmNgayGui.Visible = false;
            // 
            // dtmNgayTra
            // 
            this.dtmNgayTra.BackColor = System.Drawing.Color.Transparent;
            this.dtmNgayTra.BaseColor = System.Drawing.Color.White;
            this.dtmNgayTra.BorderColor = System.Drawing.Color.Silver;
            this.dtmNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayTra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmNgayTra.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgayTra.ForeColor = System.Drawing.Color.Black;
            this.dtmNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayTra.Location = new System.Drawing.Point(176, 172);
            this.dtmNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtmNgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgayTra.Name = "dtmNgayTra";
            this.dtmNgayTra.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmNgayTra.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgayTra.OnPressedColor = System.Drawing.Color.Black;
            this.dtmNgayTra.Radius = 10;
            this.dtmNgayTra.Size = new System.Drawing.Size(249, 37);
            this.dtmNgayTra.TabIndex = 39;
            this.dtmNgayTra.Text = "22/04/2021";
            this.dtmNgayTra.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            this.dtmNgayTra.Visible = false;
            // 
            // TextBox_BienSo
            // 
            this.TextBox_BienSo.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_BienSo.BaseColor = System.Drawing.Color.White;
            this.TextBox_BienSo.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_BienSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_BienSo.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_BienSo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_BienSo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_BienSo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_BienSo.ForeColor = System.Drawing.Color.Black;
            this.TextBox_BienSo.Location = new System.Drawing.Point(176, 58);
            this.TextBox_BienSo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_BienSo.Name = "TextBox_BienSo";
            this.TextBox_BienSo.PasswordChar = '\0';
            this.TextBox_BienSo.Radius = 10;
            this.TextBox_BienSo.SelectedText = "";
            this.TextBox_BienSo.Size = new System.Drawing.Size(213, 54);
            this.TextBox_BienSo.TabIndex = 29;
            this.TextBox_BienSo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(488, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Địa chỉ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(488, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên KH: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(284, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(861, 89);
            this.label8.TabIndex = 108;
            this.label8.Text = "DANH SÁCH XE TRONG BÃI";
            // 
            // dataGridViewXe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewXe.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewXe.EnableHeadersVisualStyles = false;
            this.dataGridViewXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewXe.Location = new System.Drawing.Point(32, 410);
            this.dataGridViewXe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXe.Name = "dataGridViewXe";
            this.dataGridViewXe.RowHeadersVisible = false;
            this.dataGridViewXe.RowHeadersWidth = 51;
            this.dataGridViewXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXe.Size = new System.Drawing.Size(1372, 556);
            this.dataGridViewXe.TabIndex = 109;
            this.dataGridViewXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridViewXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewXe.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewXe.ThemeStyle.ReadOnly = false;
            this.dataGridViewXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewXe.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.radiobtnNgay);
            this.gunaPanel1.Controls.Add(this.radiobtnThang);
            this.gunaPanel1.Location = new System.Drawing.Point(39, 111);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(315, 66);
            this.gunaPanel1.TabIndex = 110;
            // 
            // radiobtnThang
            // 
            this.radiobtnThang.BaseColor = System.Drawing.SystemColors.Control;
            this.radiobtnThang.CheckedOffColor = System.Drawing.Color.Gray;
            this.radiobtnThang.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radiobtnThang.FillColor = System.Drawing.Color.White;
            this.radiobtnThang.ForeColor = System.Drawing.Color.Black;
            this.radiobtnThang.Location = new System.Drawing.Point(182, 18);
            this.radiobtnThang.Name = "radiobtnThang";
            this.radiobtnThang.Size = new System.Drawing.Size(93, 27);
            this.radiobtnThang.TabIndex = 0;
            this.radiobtnThang.Text = "Tháng";
            // 
            // radiobtnNgay
            // 
            this.radiobtnNgay.BaseColor = System.Drawing.SystemColors.Control;
            this.radiobtnNgay.CheckedOffColor = System.Drawing.Color.Gray;
            this.radiobtnNgay.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radiobtnNgay.FillColor = System.Drawing.Color.White;
            this.radiobtnNgay.ForeColor = System.Drawing.Color.Black;
            this.radiobtnNgay.Location = new System.Drawing.Point(22, 18);
            this.radiobtnNgay.Name = "radiobtnNgay";
            this.radiobtnNgay.Size = new System.Drawing.Size(82, 27);
            this.radiobtnNgay.TabIndex = 1;
            this.radiobtnNgay.Text = "Ngày";
            // 
            // showListCarInPackUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewXe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "showListCarInPackUC";
            this.Size = new System.Drawing.Size(1436, 985);
            this.Load += new System.EventHandler(this.showListCarInPackUC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox GroupBox1;
        private Guna.UI.WinForms.GunaGroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaTextBox TextBoxt_DiaChi;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker dtmNgayTra;
        private Guna.UI.WinForms.GunaTextBox TextBox_BienSo;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox TextBox_Search;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaTextBox TextBox_Phat;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox Textbox_SDT;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox Textbox_TenKH;
        private Guna.UI.WinForms.GunaDateTimePicker dtmNgayGui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDataGridView dataGridViewXe;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaRadioButton radiobtnNgay;
        private Guna.UI.WinForms.GunaRadioButton radiobtnThang;
    }
}
