
namespace BaiGiuXeVer2.Forms.Manager.ManagerUC
{
    partial class chiaCaUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.setting_DGV = new System.Windows.Forms.DataGridView();
            this.automaticShift_DGV = new System.Windows.Forms.DataGridView();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.settingID_CBO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateend_DTP = new System.Windows.Forms.DateTimePicker();
            this.datestart_DTP = new System.Windows.Forms.DateTimePicker();
            this.add2_BT = new Guna.UI.WinForms.GunaButton();
            this.cancel_BT = new Guna.UI.WinForms.GunaButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticShift_DGV)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gunaShadowPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Controls.Add(this.automaticShift_DGV);
            this.gunaShadowPanel1.Controls.Add(this.setting_DGV);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(53, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 8;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(966, 794);
            this.gunaShadowPanel1.TabIndex = 3;
            this.gunaShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // setting_DGV
            // 
            this.setting_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.setting_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.setting_DGV.BackgroundColor = System.Drawing.Color.White;
            this.setting_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.setting_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.setting_DGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.setting_DGV.EnableHeadersVisualStyles = false;
            this.setting_DGV.Location = new System.Drawing.Point(71, 109);
            this.setting_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.setting_DGV.Name = "setting_DGV";
            this.setting_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.setting_DGV.RowHeadersVisible = false;
            this.setting_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.setting_DGV.RowTemplate.DividerHeight = 1;
            this.setting_DGV.RowTemplate.Height = 33;
            this.setting_DGV.RowTemplate.ReadOnly = true;
            this.setting_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.setting_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.setting_DGV.Size = new System.Drawing.Size(208, 469);
            this.setting_DGV.TabIndex = 82;
            // 
            // automaticShift_DGV
            // 
            this.automaticShift_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.automaticShift_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.automaticShift_DGV.BackgroundColor = System.Drawing.Color.White;
            this.automaticShift_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.automaticShift_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.automaticShift_DGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.automaticShift_DGV.EnableHeadersVisualStyles = false;
            this.automaticShift_DGV.Location = new System.Drawing.Point(283, 109);
            this.automaticShift_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.automaticShift_DGV.Name = "automaticShift_DGV";
            this.automaticShift_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.automaticShift_DGV.RowHeadersVisible = false;
            this.automaticShift_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.automaticShift_DGV.RowTemplate.DividerHeight = 1;
            this.automaticShift_DGV.RowTemplate.Height = 33;
            this.automaticShift_DGV.RowTemplate.ReadOnly = true;
            this.automaticShift_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.automaticShift_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.automaticShift_DGV.Size = new System.Drawing.Size(630, 469);
            this.automaticShift_DGV.TabIndex = 83;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaPanel1.Controls.Add(this.settingID_CBO);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Location = new System.Drawing.Point(71, 583);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(208, 100);
            this.gunaPanel1.TabIndex = 84;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaElipsePanel1.Controls.Add(this.cancel_BT);
            this.gunaElipsePanel1.Controls.Add(this.add2_BT);
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.dateend_DTP);
            this.gunaElipsePanel1.Controls.Add(this.datestart_DTP);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(283, 583);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(630, 100);
            this.gunaElipsePanel1.TabIndex = 85;
            // 
            // settingID_CBO
            // 
            this.settingID_CBO.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingID_CBO.FormattingEnabled = true;
            this.settingID_CBO.Location = new System.Drawing.Point(91, 38);
            this.settingID_CBO.Margin = new System.Windows.Forms.Padding(2);
            this.settingID_CBO.Name = "settingID_CBO";
            this.settingID_CBO.Size = new System.Drawing.Size(109, 25);
            this.settingID_CBO.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Setting ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "From:";
            // 
            // dateend_DTP
            // 
            this.dateend_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateend_DTP.Location = new System.Drawing.Point(328, 38);
            this.dateend_DTP.Margin = new System.Windows.Forms.Padding(2);
            this.dateend_DTP.Name = "dateend_DTP";
            this.dateend_DTP.Size = new System.Drawing.Size(121, 25);
            this.dateend_DTP.TabIndex = 75;
            // 
            // datestart_DTP
            // 
            this.datestart_DTP.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart_DTP.Location = new System.Drawing.Point(108, 38);
            this.datestart_DTP.Margin = new System.Windows.Forms.Padding(2);
            this.datestart_DTP.Name = "datestart_DTP";
            this.datestart_DTP.Size = new System.Drawing.Size(121, 25);
            this.datestart_DTP.TabIndex = 74;
            // 
            // add2_BT
            // 
            this.add2_BT.AnimationHoverSpeed = 0.07F;
            this.add2_BT.AnimationSpeed = 0.03F;
            this.add2_BT.BackColor = System.Drawing.Color.Transparent;
            this.add2_BT.BaseColor = System.Drawing.Color.Black;
            this.add2_BT.BorderColor = System.Drawing.Color.Black;
            this.add2_BT.BorderSize = 1;
            this.add2_BT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add2_BT.FocusedColor = System.Drawing.Color.Empty;
            this.add2_BT.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add2_BT.ForeColor = System.Drawing.Color.White;
            this.add2_BT.Image = null;
            this.add2_BT.ImageSize = new System.Drawing.Size(20, 20);
            this.add2_BT.Location = new System.Drawing.Point(484, 17);
            this.add2_BT.Name = "add2_BT";
            this.add2_BT.OnHoverBaseColor = System.Drawing.Color.White;
            this.add2_BT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add2_BT.OnHoverForeColor = System.Drawing.Color.Black;
            this.add2_BT.OnHoverImage = null;
            this.add2_BT.OnPressedColor = System.Drawing.Color.Black;
            this.add2_BT.Radius = 8;
            this.add2_BT.Size = new System.Drawing.Size(126, 32);
            this.add2_BT.TabIndex = 86;
            this.add2_BT.Text = "Add";
            this.add2_BT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancel_BT
            // 
            this.cancel_BT.AnimationHoverSpeed = 0.07F;
            this.cancel_BT.AnimationSpeed = 0.03F;
            this.cancel_BT.BackColor = System.Drawing.Color.Transparent;
            this.cancel_BT.BaseColor = System.Drawing.Color.Black;
            this.cancel_BT.BorderColor = System.Drawing.Color.Black;
            this.cancel_BT.BorderSize = 1;
            this.cancel_BT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancel_BT.FocusedColor = System.Drawing.Color.Empty;
            this.cancel_BT.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancel_BT.ForeColor = System.Drawing.Color.White;
            this.cancel_BT.Image = null;
            this.cancel_BT.ImageSize = new System.Drawing.Size(20, 20);
            this.cancel_BT.Location = new System.Drawing.Point(484, 55);
            this.cancel_BT.Name = "cancel_BT";
            this.cancel_BT.OnHoverBaseColor = System.Drawing.Color.White;
            this.cancel_BT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancel_BT.OnHoverForeColor = System.Drawing.Color.Black;
            this.cancel_BT.OnHoverImage = null;
            this.cancel_BT.OnPressedColor = System.Drawing.Color.Black;
            this.cancel_BT.Radius = 8;
            this.cancel_BT.Size = new System.Drawing.Size(126, 32);
            this.cancel_BT.TabIndex = 86;
            this.cancel_BT.Text = "Cancel";
            this.cancel_BT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chiaCaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "chiaCaUC";
            this.Size = new System.Drawing.Size(1077, 800);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setting_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticShift_DGV)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateend_DTP;
        private System.Windows.Forms.DateTimePicker datestart_DTP;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.ComboBox settingID_CBO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView automaticShift_DGV;
        private System.Windows.Forms.DataGridView setting_DGV;
        private Guna.UI.WinForms.GunaButton cancel_BT;
        private Guna.UI.WinForms.GunaButton add2_BT;
    }
}
