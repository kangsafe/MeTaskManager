using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Me.Task.Ctrl
{
    public partial class JobFrm : Form
    {
        public JobFrm()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = false;
        }

        //单机
        private void gvImg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击的是第一个单元格
            if (e.ColumnIndex == 2)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    gvJob.Rows[e.RowIndex].Cells[2].Value = openFileDialog1.FileName;
                }
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {

        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
