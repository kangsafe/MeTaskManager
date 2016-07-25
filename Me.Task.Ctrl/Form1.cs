using Ionic.Zip;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// 打包dll到exe文件用到的工具 http://tech.trailmax.info/2014/01/bundling-all-your-assemblies-into-one-or-alternative-to-ilmerge/
/// 或者http://www.cnblogs.com/huangcong/archive/2010/03/29/1699904.html
/// </summary>
namespace Me.Task.Ctrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbar.Minimum = 0;
            pbar.Maximum = 100;
            pbar.Hide();
            tbSave.Text = AppDomain.CurrentDomain.BaseDirectory;
        }
        //选择保存位置
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSave.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        //添加备份计划目录
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow row = new DataGridViewRow();
                //路径
                DataGridViewTextBoxCell path = new DataGridViewTextBoxCell();
                path.Value = folderBrowserDialog1.SelectedPath;
                row.Cells.Add(path);
                //保存文件名
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                name.Value = "";
                row.Cells.Add(name);
                //状态
                DataGridViewTextBoxCell px = new DataGridViewTextBoxCell();
                px.Value = "未开始";
                row.Cells.Add(px);
                //开始时间
                DataGridViewTextBoxCell deep = new DataGridViewTextBoxCell();
                deep.Value = "";
                row.Cells.Add(deep);
                //结束时间
                DataGridViewTextBoxCell deep1 = new DataGridViewTextBoxCell();
                deep1.Value = "";
                row.Cells.Add(deep1);
                gv.Rows.Add(row);
            }
        }
        //开始执行
        private void btnStart_Click(object sender, EventArgs e)
        {
            pbar.Minimum = 0;
            pbar.Maximum = gv.Rows.Count;
            pbar.Value = 0;
            pbar.Show();
            string dpath = tbSave.Text + "\\" + DateTime.Now.ToString("yyyyMM");
            //保存路径
            if (Directory.Exists(dpath))
            {
                Directory.CreateDirectory(tbSave.Text);
            }
            for (int r = 0; r < gv.Rows.Count - 1; r++)
            {
                string tp = gv.Rows[r].Cells[0].Value.ToString();
                int st = tp.LastIndexOf('\\');
                tp = tp.Substring(st + 1, tp.Length - st - 1);
                string path = dpath + "\\" + tp + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + (new Random().Next(1000)).ToString().PadLeft(3, '0') + ".zip";
                gv.Rows[r].Cells[1].Value = path;
                gv.Rows[r].Cells[3].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                if (File.Exists(path))
                {
                    gv.Rows[r].Cells[2].Value = "失败:已存在该文件";
                    gv.Rows[r].Cells[4].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
                else
                {
                    //byte[] buffer = ZipFolder(gv.Rows[r].Cells[0].Value.ToString());
                    //File.WriteAllBytes(path, buffer);
                    using (ZipFile zip = new ZipFile(Encoding.UTF8))
                    {
                        zip.AddDirectory(gv.Rows[r].Cells[0].Value.ToString());
                        zip.Save(path);
                    }
                    gv.Rows[r].Cells[2].Value = "成功";
                    gv.Rows[r].Cells[4].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
            }
            pbar.Hide();
        }
    }

}
