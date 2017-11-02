namespace FileBatchRename {
    partial class FormMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSuffix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSourcePath = new System.Windows.Forms.TextBox();
            this.LBFile = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBTargetPath = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.CBSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件批量重命名";
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOpen.Location = new System.Drawing.Point(43, 80);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(81, 38);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "打开文件夹";
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(34, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "命名规则:";
            // 
            // TBPrefix
            // 
            this.TBPrefix.BackColor = System.Drawing.Color.DarkKhaki;
            this.TBPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPrefix.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBPrefix.Location = new System.Drawing.Point(94, 196);
            this.TBPrefix.Name = "TBPrefix";
            this.TBPrefix.Size = new System.Drawing.Size(86, 19);
            this.TBPrefix.TabIndex = 3;
            this.TBPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(51, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "前缀：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBSuffix
            // 
            this.TBSuffix.BackColor = System.Drawing.Color.DarkKhaki;
            this.TBSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSuffix.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBSuffix.Location = new System.Drawing.Point(94, 221);
            this.TBSuffix.Name = "TBSuffix";
            this.TBSuffix.Size = new System.Drawing.Size(86, 19);
            this.TBSuffix.TabIndex = 3;
            this.TBSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(51, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "后缀：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBSourcePath
            // 
            this.TBSourcePath.BackColor = System.Drawing.Color.DarkKhaki;
            this.TBSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSourcePath.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBSourcePath.ForeColor = System.Drawing.Color.White;
            this.TBSourcePath.Location = new System.Drawing.Point(130, 90);
            this.TBSourcePath.Name = "TBSourcePath";
            this.TBSourcePath.Size = new System.Drawing.Size(192, 19);
            this.TBSourcePath.TabIndex = 3;
            // 
            // LBFile
            // 
            this.LBFile.BackColor = System.Drawing.Color.DarkKhaki;
            this.LBFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBFile.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LBFile.FormattingEnabled = true;
            this.LBFile.ItemHeight = 14;
            this.LBFile.Location = new System.Drawing.Point(15, 250);
            this.LBFile.Margin = new System.Windows.Forms.Padding(5);
            this.LBFile.Name = "LBFile";
            this.LBFile.Size = new System.Drawing.Size(343, 154);
            this.LBFile.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSave.Location = new System.Drawing.Point(43, 130);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(81, 38);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "保存文件夹";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBTargetPath
            // 
            this.TBTargetPath.BackColor = System.Drawing.Color.DarkKhaki;
            this.TBTargetPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTargetPath.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBTargetPath.ForeColor = System.Drawing.Color.White;
            this.TBTargetPath.Location = new System.Drawing.Point(130, 140);
            this.TBTargetPath.Name = "TBTargetPath";
            this.TBTargetPath.Size = new System.Drawing.Size(192, 19);
            this.TBTargetPath.TabIndex = 3;
            this.TBTargetPath.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(630, -4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(44, 32);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.ForeColor = System.Drawing.Color.Yellow;
            this.BtnStart.Location = new System.Drawing.Point(252, 176);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(93, 64);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "开始";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CBSave
            // 
            this.CBSave.AutoSize = true;
            this.CBSave.BackColor = System.Drawing.Color.Transparent;
            this.CBSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBSave.Location = new System.Drawing.Point(354, 90);
            this.CBSave.Name = "CBSave";
            this.CBSave.Size = new System.Drawing.Size(98, 24);
            this.CBSave.TabIndex = 7;
            this.CBSave.Text = "另存文件夹";
            this.CBSave.UseVisualStyleBackColor = false;
            this.CBSave.CheckedChanged += new System.EventHandler(this.CBSave_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 413);
            this.Controls.Add(this.CBSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LBFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSuffix);
            this.Controls.Add(this.TBTargetPath);
            this.Controls.Add(this.TBSourcePath);
            this.Controls.Add(this.TBPrefix);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmMain_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSuffix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSourcePath;
        private System.Windows.Forms.ListBox LBFile;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBTargetPath;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.CheckBox CBSave;
    }
}
