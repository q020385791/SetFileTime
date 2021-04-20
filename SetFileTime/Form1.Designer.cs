
namespace SetFileTime
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetCreateTime = new System.Windows.Forms.Button();
            this.btnSetLastWriteTime = new System.Windows.Forms.Button();
            this.btnSetLastAccessTime = new System.Windows.Forms.Button();
            this.dtpkCreate = new System.Windows.Forms.DateTimePicker();
            this.dtpkLastWriteTime = new System.Windows.Forms.DateTimePicker();
            this.dtpkLastAccessTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labFilePath = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetCreateTime
            // 
            this.btnSetCreateTime.Location = new System.Drawing.Point(359, 63);
            this.btnSetCreateTime.Name = "btnSetCreateTime";
            this.btnSetCreateTime.Size = new System.Drawing.Size(92, 23);
            this.btnSetCreateTime.TabIndex = 0;
            this.btnSetCreateTime.Text = "設定建立時間";
            this.btnSetCreateTime.UseVisualStyleBackColor = true;
            this.btnSetCreateTime.Click += new System.EventHandler(this.btnSetCreateTime_Click);
            // 
            // btnSetLastWriteTime
            // 
            this.btnSetLastWriteTime.Location = new System.Drawing.Point(359, 94);
            this.btnSetLastWriteTime.Name = "btnSetLastWriteTime";
            this.btnSetLastWriteTime.Size = new System.Drawing.Size(92, 23);
            this.btnSetLastWriteTime.TabIndex = 1;
            this.btnSetLastWriteTime.Text = "設定修改時間";
            this.btnSetLastWriteTime.UseVisualStyleBackColor = true;
            this.btnSetLastWriteTime.Click += new System.EventHandler(this.btnSetLastWriteTime_Click);
            // 
            // btnSetLastAccessTime
            // 
            this.btnSetLastAccessTime.Location = new System.Drawing.Point(359, 123);
            this.btnSetLastAccessTime.Name = "btnSetLastAccessTime";
            this.btnSetLastAccessTime.Size = new System.Drawing.Size(92, 23);
            this.btnSetLastAccessTime.TabIndex = 2;
            this.btnSetLastAccessTime.Text = "設定存取時間";
            this.btnSetLastAccessTime.UseVisualStyleBackColor = true;
            this.btnSetLastAccessTime.Click += new System.EventHandler(this.btnSetLastAccessTime_Click);
            // 
            // dtpkCreate
            // 
            this.dtpkCreate.Location = new System.Drawing.Point(12, 64);
            this.dtpkCreate.Name = "dtpkCreate";
            this.dtpkCreate.Size = new System.Drawing.Size(329, 22);
            this.dtpkCreate.TabIndex = 3;
            // 
            // dtpkLastWriteTime
            // 
            this.dtpkLastWriteTime.Location = new System.Drawing.Point(12, 94);
            this.dtpkLastWriteTime.Name = "dtpkLastWriteTime";
            this.dtpkLastWriteTime.Size = new System.Drawing.Size(329, 22);
            this.dtpkLastWriteTime.TabIndex = 4;
            // 
            // dtpkLastAccessTime
            // 
            this.dtpkLastAccessTime.Location = new System.Drawing.Point(12, 123);
            this.dtpkLastAccessTime.Name = "dtpkLastAccessTime";
            this.dtpkLastAccessTime.Size = new System.Drawing.Size(329, 22);
            this.dtpkLastAccessTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "檔案路徑：";
            // 
            // labFilePath
            // 
            this.labFilePath.AutoSize = true;
            this.labFilePath.Location = new System.Drawing.Point(74, 10);
            this.labFilePath.MaximumSize = new System.Drawing.Size(300, 0);
            this.labFilePath.Name = "labFilePath";
            this.labFilePath.Size = new System.Drawing.Size(56, 12);
            this.labFilePath.TabIndex = 7;
            this.labFilePath.Text = "labFilePath";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(359, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "選擇檔案";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "訊息：";
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.Location = new System.Drawing.Point(49, 157);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(39, 12);
            this.labMsg.TabIndex = 10;
            this.labMsg.Text = "labMsg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 172);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.labFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkLastAccessTime);
            this.Controls.Add(this.dtpkLastWriteTime);
            this.Controls.Add(this.dtpkCreate);
            this.Controls.Add(this.btnSetLastAccessTime);
            this.Controls.Add(this.btnSetLastWriteTime);
            this.Controls.Add(this.btnSetCreateTime);
            this.Name = "Form1";
            this.Text = "ChangeFileTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetCreateTime;
        private System.Windows.Forms.Button btnSetLastWriteTime;
        private System.Windows.Forms.Button btnSetLastAccessTime;
        private System.Windows.Forms.DateTimePicker dtpkCreate;
        private System.Windows.Forms.DateTimePicker dtpkLastWriteTime;
        private System.Windows.Forms.DateTimePicker dtpkLastAccessTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMsg;
    }
}

