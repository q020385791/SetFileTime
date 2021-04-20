using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetFileTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) 
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    labFilePath.Text = ofd.FileName;

                    dtpkCreate.Value= File.GetCreationTime(ofd.FileName);
                    dtpkLastWriteTime.Value = File.GetLastWriteTime(ofd.FileName);
                    dtpkLastAccessTime.Value = File.GetLastAccessTime(ofd.FileName);
                     labMsg.Text = "已取得檔案時間資訊";
                }
                else 
                {
                    labFilePath.Text = "請選擇檔案";
                }
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labFilePath.Text = "請選擇檔案";
            labMsg.Text = "";
        }

        private void btnSetCreateTime_Click(object sender, EventArgs e)
        {
            if (SelectedFile(labFilePath.Text))
            {
                if (dtpkCreate.Checked)
                {
                    System.IO.File.SetCreationTime(labFilePath.Text, dtpkCreate.Value);
                    labMsg.Text = "修改完成";
                }
                else
                {
                    labMsg.Text = "請設定建立時間";
                }
            }
            else 
            {
                labMsg.Text = "請選擇檔案";
            }
        }

        public bool  SelectedFile(string Filepath) 
        {
            if (System.IO.File.Exists(Filepath))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void btnSetLastWriteTime_Click(object sender, EventArgs e)
        {
            if (SelectedFile(labFilePath.Text))
            {
                if (dtpkLastWriteTime.Checked)
                {
                    System.IO.File.SetLastWriteTime(labFilePath.Text, dtpkLastWriteTime.Value);
                    labMsg.Text = "修改完成";
                }
                else
                {
                    labMsg.Text = "請設定最後更新時間";
                }
            }
            else
            {
                labMsg.Text = "請選擇檔案";
            }
        }

        private void btnSetLastAccessTime_Click(object sender, EventArgs e)
        {
            if (SelectedFile(labFilePath.Text))
            {
                if (dtpkLastAccessTime.Checked)
                {
                    System.IO.File.SetLastAccessTime(labFilePath.Text, dtpkLastAccessTime.Value);
                    labMsg.Text = "修改完成";
                }
                else
                {
                    labMsg.Text = "請設定最後存取時間";
                }
            }
            else
            {
                labMsg.Text = "請選擇檔案";
            }
        }
    }
}
