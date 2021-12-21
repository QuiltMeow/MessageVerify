using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MessageVerify
{
    public partial class MainForm : Form
    {
        private const int GENERATE_RANDOM_LENGTH = 1000;
        private const string NUMBER = "0123456789";
        private const short VERSION = 8093;

        private static readonly Random random = new Random();
        private readonly byte[] iv;

        public MainForm()
        {
            InitializeComponent();
            iv = new byte[] { (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256) };
        }

        public MainForm(byte[] iv)
        {
            InitializeComponent();
            this.iv = iv;
        }

        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= GENERATE_RANDOM_LENGTH; ++i)
            {
                sb.Append(NUMBER[random.Next(NUMBER.Length)]);
            }
            txtSendRawMessage.Text = sb.ToString();
        }

        private void btnRecvDecrypt_Click(object sender, EventArgs e)
        {
            string rawCheckMessage = txtRecvEncrypt.Text.Replace(" ", string.Empty), rawCheckHash = txtRecvEncryptHash.Text.Replace(" ", string.Empty);
            if (rawCheckMessage == "" || rawCheckHash == "")
            {
                MessageBox.Show("請輸入接收訊息與摘要");
                return;
            }

            if (rawCheckMessage.Length % 2 != 0 || rawCheckHash.Length % 2 != 0)
            {
                MessageBox.Show("輸入位元組資料長度錯誤");
                return;
            }
            if (!HexEncoding.onlyHexInString(rawCheckMessage) || !HexEncoding.onlyHexInString(rawCheckHash))
            {
                MessageBox.Show("輸入位元組資料格式錯誤");
                return;
            }

            string formatMessage = Regex.Replace(rawCheckMessage, ".{2}", "$0 ");
            string formatHash = Regex.Replace(rawCheckHash, ".{2}", "$0 ");

            txtRecvEncrypt.Text = formatMessage.Substring(0, formatMessage.Length - 1);
            txtRecvEncryptHash.Text = formatHash.Substring(0, formatHash.Length - 1);

            byte[] message = HexEncoding.GetBytes(txtRecvEncrypt.Text);
            byte[] hash = HexEncoding.GetBytes(txtRecvEncryptHash.Text);

            MapleCrypto mc = new MapleCrypto(iv, VERSION);
            mc.crypt(message);
            mc.crypt(hash);

            txtRecvDecrypt.Text = Encoding.UTF8.GetString(message);
            txtRecvDecryptHash.Text = Convert.ToBase64String(hash);

            btnRecvVerify.Enabled = true;
        }

        private void btnRecvVerify_Click(object sender, EventArgs e)
        {
            new VerifyForm(txtRecvDecrypt.Text, txtRecvDecryptHash.Text);
        }

        private void btnSendEncrypt_Click(object sender, EventArgs e)
        {
            if (txtSendRawMessage.Text == "")
            {
                MessageBox.Show("請輸入原始訊息");
                return;
            }

            byte[] message = Encoding.UTF8.GetBytes(txtSendRawMessage.Text);
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] hash = sha512.ComputeHash(message);
            txtSendHash.Text = Convert.ToBase64String(hash);

            MapleCrypto mc = new MapleCrypto(iv, VERSION);
            mc.crypt(message);
            mc.crypt(hash);

            txtSendEncrypt.Text = BitConverter.ToString(message).Replace("-", " ");
            txtSendEncryptHash.Text = BitConverter.ToString(hash).Replace("-", " ");
        }

        private void btnASCIITool_Click(object sender, EventArgs e)
        {
            new ASCIIForm().Show();
        }

        private void btnFileCrypt_Click(object sender, EventArgs e)
        {
            new FileForm(iv, VERSION).Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelIV.Text = "IV : " + BitConverter.ToString(iv).Replace("-", " ");
        }
    }
}