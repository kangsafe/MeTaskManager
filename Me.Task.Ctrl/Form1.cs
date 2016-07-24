using Ionic.Zip;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
            //保存路径
            if (Directory.Exists(tbSave.Text))
            {
                Directory.CreateDirectory(tbSave.Text);
            }
            for (int r = 0; r < gv.Rows.Count - 1; r++)
            {
                string path = tbSave.Text + "\\" + Guid.NewGuid().ToString().Replace("-", "").ToLower() + ".zip";
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
        ///// <summary>
        ///// 压缩打包文件
        ///// </summary>
        //private byte[] ZipFolder(string zips)
        //{
        //    MemoryStream ms = new MemoryStream();
        //    byte[] buffer = null;

        //    using (ZipFile file = ZipFile.Create(ms))
        //    {
        //        file.BeginUpdate();
        //        //file.NameTransform = new MyNameTransfom();//通过这个名称格式化器，可以将里面的文件名进行一些处理。默认情况下，会自动根据文件的路径在zip中创建有关的文件夹。
        //        foreach (string fpath in Directory.GetFiles(zips))
        //        {
        //            file.Add(fpath);
        //        }
        //        foreach (string dir in Directory.GetDirectories(zips))
        //        {
        //            ZipFolder(dir);

        //        }

        //        file.CommitUpdate();

        //        buffer = new byte[ms.Length];
        //        ms.Position = 0;
        //        ms.Read(buffer, 0, buffer.Length);
        //    }

        //    return buffer;
        //}

    }

}
