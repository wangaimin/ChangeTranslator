using log4net;
using Npoi.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectConfig_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                tbConfigUrl.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                tbExcelUrl.Text = openFileDialog.FileName;
            }
        }

        private void btnChangeConfig_Click(object sender, EventArgs e)
        {

            ILog logger = LogManager.GetLogger("errorMsg");
            logger.Error("错误信息");

            //记录错误日志
            logger.Error("error", new Exception("发生了一个异常"));
            //记录严重错误
            logger.Fatal("fatal", new Exception("发生了一个致命错误"));
            //记录一般信息
            logger.Info("info");
            //记录调试信息
            logger.Debug("debug");
            //记录警告信息
            logger.Warn("warn");

            #region 验证

            if (tbConfigUrl.Text.Trim()=="")
            {
                MessageBox.Show("配置文件路径不能为空！");
                return;
            }
            if (tbExcelUrl.Text.Trim() == "")
            {
                MessageBox.Show("Excel路径不能为空！");
                return;
            }
            if (tbExcelUrl.Text.Trim().IndexOf(".xlsx")<=0)
            {
                MessageBox.Show("请选择正确的Excel！");
                return;
            }

            #endregion

            //翻译资源
            //Dictionary<string, string> dicResource = new Dictionary<string, string>();

            //var mapper = new Mapper(tbExcelUrl.Text.Trim());

            //var resultData = mapper.Take<LanguageResource>(0);

            //resultData.ForEach(m=> {
            //    var value = m.Value;
            //    if (!dicResource.ContainsKey(value.Chinese))
            //    {
            //        dicResource.Add(value.Chinese, value.OtherLanguage);
            //    }
            //});



        }

        private void btnChangeJson_Click(object sender, EventArgs e)
        {
            string a = "";
            int.Parse(a);
        }
    }
}
