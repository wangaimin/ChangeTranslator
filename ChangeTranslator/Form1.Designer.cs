namespace ChangeTranslator
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
            this.btnSelectConfig = new System.Windows.Forms.Button();
            this.tbConfigUrl = new System.Windows.Forms.TextBox();
            this.tbExcelUrl = new System.Windows.Forms.TextBox();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.btnChangeJson = new System.Windows.Forms.Button();
            this.btnChangeConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectConfig
            // 
            this.btnSelectConfig.Location = new System.Drawing.Point(254, 80);
            this.btnSelectConfig.Name = "btnSelectConfig";
            this.btnSelectConfig.Size = new System.Drawing.Size(146, 52);
            this.btnSelectConfig.TabIndex = 0;
            this.btnSelectConfig.Text = "选择文件夹";
            this.btnSelectConfig.UseVisualStyleBackColor = true;
            this.btnSelectConfig.Click += new System.EventHandler(this.btnSelectConfig_Click);
            // 
            // tbConfigUrl
            // 
            this.tbConfigUrl.Location = new System.Drawing.Point(456, 80);
            this.tbConfigUrl.Multiline = true;
            this.tbConfigUrl.Name = "tbConfigUrl";
            this.tbConfigUrl.Size = new System.Drawing.Size(674, 52);
            this.tbConfigUrl.TabIndex = 1;
            this.tbConfigUrl.Text = "C:\\Users\\admin\\Desktop\\测试翻译";
            // 
            // tbExcelUrl
            // 
            this.tbExcelUrl.Location = new System.Drawing.Point(456, 175);
            this.tbExcelUrl.Multiline = true;
            this.tbExcelUrl.Name = "tbExcelUrl";
            this.tbExcelUrl.Size = new System.Drawing.Size(674, 52);
            this.tbExcelUrl.TabIndex = 3;
            this.tbExcelUrl.Text = "C:\\Users\\admin\\Desktop\\测试翻译\\翻译.xlsx";
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(254, 175);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(146, 52);
            this.btnSelectExcel.TabIndex = 2;
            this.btnSelectExcel.Text = "选择Excel";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // btnChangeJson
            // 
            this.btnChangeJson.Location = new System.Drawing.Point(746, 320);
            this.btnChangeJson.Name = "btnChangeJson";
            this.btnChangeJson.Size = new System.Drawing.Size(146, 52);
            this.btnChangeJson.TabIndex = 4;
            this.btnChangeJson.Text = "替换Json";
            this.btnChangeJson.UseVisualStyleBackColor = true;
            this.btnChangeJson.Click += new System.EventHandler(this.btnChangeJson_Click);
            // 
            // btnChangeConfig
            // 
            this.btnChangeConfig.Location = new System.Drawing.Point(497, 320);
            this.btnChangeConfig.Name = "btnChangeConfig";
            this.btnChangeConfig.Size = new System.Drawing.Size(146, 52);
            this.btnChangeConfig.TabIndex = 5;
            this.btnChangeConfig.Text = "替换Config";
            this.btnChangeConfig.UseVisualStyleBackColor = true;
            this.btnChangeConfig.Click += new System.EventHandler(this.btnChangeConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 580);
            this.Controls.Add(this.btnChangeConfig);
            this.Controls.Add(this.btnChangeJson);
            this.Controls.Add(this.tbExcelUrl);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.tbConfigUrl);
            this.Controls.Add(this.btnSelectConfig);
            this.Name = "Form1";
            this.Text = "替换翻译";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectConfig;
        private System.Windows.Forms.TextBox tbConfigUrl;
        private System.Windows.Forms.TextBox tbExcelUrl;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.Button btnChangeJson;
        private System.Windows.Forms.Button btnChangeConfig;
    }
}

