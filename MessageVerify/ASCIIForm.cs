using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MessageVerify
{
    public partial class ASCIIForm : Form
    {
        public ASCIIForm()
        {
            InitializeComponent();
        }

        private void btnToASCII_Click(object sender, EventArgs e)
        {
            string rawByte = txtByte.Text.Replace(" ", string.Empty);
            if (rawByte.Length % 2 != 0 || rawByte.Length % 2 != 0)
            {
                MessageBox.Show("輸入位元組資料長度錯誤");
                return;
            }
            if (!HexEncoding.onlyHexInString(rawByte) || !HexEncoding.onlyHexInString(rawByte))
            {
                MessageBox.Show("輸入位元組資料格式錯誤");
                return;
            }

            string formatByte = Regex.Replace(rawByte, ".{2}", "$0 ");
            txtByte.Text = formatByte.Substring(0, formatByte.Length - 1);

            byte[] asciiByte = HexEncoding.GetBytes(txtByte.Text);
            txtASCII.Text = Encoding.UTF8.GetString(asciiByte);
        }

        private void btnToByte_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.UTF8.GetBytes(txtASCII.Text);
            txtByte.Text = BitConverter.ToString(result).Replace("-", " ");
        }
    }
}