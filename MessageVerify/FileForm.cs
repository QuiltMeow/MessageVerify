using System;
using System.IO;
using System.Windows.Forms;

namespace MessageVerify
{
    public partial class FileForm : Form
    {
        private readonly byte[] iv;
        private readonly short version;

        public FileForm(byte[] iv, short version)
        {
            InitializeComponent();

            this.iv = iv;
            this.version = version;
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "請選擇來源檔案"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtSource.Text = ofd.FileName;
        }

        private string getSaveFileName()
        {
            string path = txtSource.Text;
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            string[] split = txtSource.Text.Split('\\');
            return split[split.Length - 1] + ".crypt";
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = getSaveFileName(),
                Filter = "所有檔案 (*.*)|*.*",
                Title = "請選擇輸出檔案"
            };
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtOutput.Text = sfd.FileName;
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) || string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("請指定來源檔案與輸出檔案");
                return;
            }

            MapleCrypto crypto = new MapleCrypto(iv, version);
            try
            {
                byte[] file = File.ReadAllBytes(txtSource.Text);
                crypto.crypt(file);
                File.WriteAllBytes(txtOutput.Text, file);
                MessageBox.Show("檔案處理完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("處理加解密時發生例外狀況 : " + ex);
            }
        }
    }
}