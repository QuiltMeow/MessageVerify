using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MessageVerify
{
    public partial class VerifyForm : Form
    {
        public VerifyForm()
        {
            InitializeComponent();
        }

        public VerifyForm(string message, string hash) : this()
        {
            txtMessage.Text = message;
            txtHash.Text = hash;
            Visible = true;
        }

        private void VerifyForm_Load(object sender, EventArgs e)
        {
            byte[] message = Encoding.UTF8.GetBytes(txtMessage.Text);
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] hash = sha512.ComputeHash(message);
            txtComputeHash.Text = Convert.ToBase64String(hash);

            bool success = txtHash.Text == txtComputeHash.Text;
            labelVerify.Text = "驗證" + (success ? "成功" : "失敗");
        }
    }
}