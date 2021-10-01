using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2
{
    public partial class DeleteHopDong : Form
    {
        public DeleteHopDong()
        {
            InitializeComponent();
        }
        Classes.HopDong.HopDong hd = new Classes.HopDong.HopDong();
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if ((MessageBox.Show("Are you sure you wanna delete this Contract?", "Delete Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (hd.XoaHD(id))
                    {
                        MessageBox.Show("Contract Deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contract cannot be deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Khach hang", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteHopDong_Load(object sender, EventArgs e)
        {

        }
    }
}
