using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace FileBatchRename {
    public partial class FormMain : Form {
        Point formPoint = new Point();
        string sourcePath = "";
        string targetPath = "";
        public FormMain() {
            InitializeComponent();
        }

        // 实现鼠标拖动窗口
        private void FmMain_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-formPoint.X, -formPoint.Y);
                Location = myPosittion;
            }
        }

        private void FmMain_MouseDown(object sender, MouseEventArgs e) {
            formPoint.X = e.X;
            formPoint.Y = e.Y;
        }

        // 打开文件路径
        private void BtnOpen_Click(object sender, System.EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                TBSourcePath.Text = folderBrowserDialog.SelectedPath;
                sourcePath = folderBrowserDialog.SelectedPath;
                try {
                    DirectoryInfo dirInfo = new DirectoryInfo(@sourcePath);
                    TBSuffix.Text = dirInfo.GetFiles()[0].Extension; // 获取目录下的第一个文件后缀作为默认后缀名
                } catch (Exception) {
                    MessageBox.Show("请确保不是空文件夹");
                }
            }
        }

        // 保存文件路径
        private void BtnSave_Click(object sender, System.EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                TBTargetPath.Text = folderBrowserDialog.SelectedPath;
                targetPath = folderBrowserDialog.SelectedPath;
            }
        }

        // 关闭按钮
        private void BtnClose_Click(object sender, System.EventArgs e) {
            Close();
        }

        // 是否另存为选择框
        private void CBSave_CheckedChanged(object sender, System.EventArgs e) {
            if (CBSave.Checked) {
                BtnSave.Visible = true;
                TBTargetPath.Visible = true;
            } else {
                BtnSave.Visible = false;
                TBTargetPath.Visible = false;
                TBTargetPath.Text = "";
            }
        }

        // 开始
        private void BtnStart_Click(object sender, System.EventArgs e) {
            string prefix = TBPrefix.Text.Trim();
            string suffix = TBSuffix.Text.Trim();
            string oldName;
            string newName;
            string newPath;
            int i = 0;

            DateTime start = DateTime.Now; // 开始时间
            try {
                DirectoryInfo dirInfo = new DirectoryInfo(@sourcePath);
                if (CBSave.Checked) {
                    foreach (FileInfo file in dirInfo.GetFiles()) {
                        i++;
                        oldName = file.Name;
                        newPath = @targetPath + "\\" + prefix + i + suffix;
                        file.CopyTo(newPath, true);
                        newName = newPath;

                        LBFile.Items.Add(oldName + "===>>>" + newName);
                    }
                } else {
                    foreach (FileInfo file in dirInfo.GetFiles()) {
                        i++;
                        oldName = file.Name;
                        newPath = @sourcePath + "\\" + prefix + i + suffix;
                        file.MoveTo(newPath);
                        newName = prefix + i + suffix;

                        LBFile.Items.Add(oldName + "===>>>" + newName);
                    }
                }
                DateTime end = DateTime.Now; // 结束时间
                TimeSpan time = end - start; // 总耗时

                MessageBox.Show(i + "个文件重命名完成，共耗时——" + time.Hours + ":" + time.Minutes + ":" + time.Seconds);
            } catch (Exception) {
                MessageBox.Show("请检查文件名");
            }
        }
    }
}
