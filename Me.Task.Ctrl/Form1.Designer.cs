namespace Me.Task.Ctrl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbSave = new System.Windows.Forms.ToolStripTextBox();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gv = new System.Windows.Forms.DataGridView();
            this.backsource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begintime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbSave,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnAdd,
            this.btnStart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel2.Text = "保存路径";
            // 
            // tbSave
            // 
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(100, 25);
            this.tbSave.ToolTipText = "保存目录";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.Text = "选择目录";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.Text = "添加备份";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gv
            // 
            this.gv.AllowUserToOrderColumns = true;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.backsource,
            this.savepath,
            this.taskstatus,
            this.begintime,
            this.endtime});
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(0, 25);
            this.gv.Name = "gv";
            this.gv.RowTemplate.Height = 23;
            this.gv.Size = new System.Drawing.Size(685, 236);
            this.gv.TabIndex = 1;
            // 
            // backsource
            // 
            this.backsource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.backsource.FillWeight = 40F;
            this.backsource.HeaderText = "路径";
            this.backsource.Name = "backsource";
            // 
            // savepath
            // 
            this.savepath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.savepath.FillWeight = 40F;
            this.savepath.HeaderText = "保存位置";
            this.savepath.Name = "savepath";
            // 
            // taskstatus
            // 
            this.taskstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskstatus.FillWeight = 4F;
            this.taskstatus.HeaderText = "任务状态";
            this.taskstatus.Name = "taskstatus";
            // 
            // begintime
            // 
            this.begintime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.begintime.FillWeight = 8F;
            this.begintime.HeaderText = "开始时间";
            this.begintime.Name = "begintime";
            // 
            // endtime
            // 
            this.endtime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endtime.FillWeight = 8F;
            this.endtime.HeaderText = "结束时间";
            this.endtime.Name = "endtime";
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(180, 89);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(302, 23);
            this.pbar.TabIndex = 2;
            this.pbar.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 22);
            this.btnStart.Text = "开始执行";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 261);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbSave;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn backsource;
        private System.Windows.Forms.DataGridViewTextBoxColumn savepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn begintime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.ToolStripButton btnStart;
    }
}

