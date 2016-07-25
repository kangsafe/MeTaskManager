namespace Me.Task.Ctrl
{
    partial class JobFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobFrm));
            this.gvJob = new System.Windows.Forms.DataGridView();
            this.作业Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业显示名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业路径 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInstall = new System.Windows.Forms.ToolStripButton();
            this.btnUninstall = new System.Windows.Forms.ToolStripButton();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvJob)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvJob
            // 
            this.gvJob.AllowUserToOrderColumns = true;
            this.gvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.作业Code,
            this.作业显示名称,
            this.作业路径,
            this.作业状态});
            this.gvJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvJob.Location = new System.Drawing.Point(0, 25);
            this.gvJob.MultiSelect = false;
            this.gvJob.Name = "gvJob";
            this.gvJob.RowTemplate.Height = 23;
            this.gvJob.Size = new System.Drawing.Size(710, 236);
            this.gvJob.TabIndex = 0;
            this.gvJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvImg_CellClick);
            // 
            // 作业Code
            // 
            this.作业Code.HeaderText = "作业Code";
            this.作业Code.Name = "作业Code";
            // 
            // 作业显示名称
            // 
            this.作业显示名称.HeaderText = "作业显示名称";
            this.作业显示名称.Name = "作业显示名称";
            // 
            // 作业路径
            // 
            this.作业路径.HeaderText = "作业路径";
            this.作业路径.Name = "作业路径";
            // 
            // 作业状态
            // 
            this.作业状态.HeaderText = "作业状态";
            this.作业状态.Name = "作业状态";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInstall,
            this.btnUninstall,
            this.btnStart,
            this.btnPause,
            this.btnStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInstall
            // 
            this.btnInstall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInstall.Image = ((System.Drawing.Image)(resources.GetObject("btnInstall.Image")));
            this.btnInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(36, 22);
            this.btnInstall.Text = "安装";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUninstall.Image = ((System.Drawing.Image)(resources.GetObject("btnUninstall.Image")));
            this.btnUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(36, 22);
            this.btnUninstall.Text = "卸载";
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(36, 22);
            this.btnStart.Text = "启动";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(36, 22);
            this.btnPause.Text = "暂停";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(36, 22);
            this.btnStop.Text = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // JobFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 261);
            this.Controls.Add(this.gvJob);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JobFrm";
            this.Text = "JobFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gvJob)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvJob;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业显示名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业路径;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业状态;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInstall;
        private System.Windows.Forms.ToolStripButton btnUninstall;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnStop;
    }
}