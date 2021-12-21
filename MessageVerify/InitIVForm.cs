using System;
using System.Threading;
using System.Windows.Forms;

namespace MessageVerify
{
    public partial class InitIVForm : Form
    {
        public InitIVForm()
        {
            InitializeComponent();
            txtIVByte1.SelectionStart = txtIVByte1.Text.Length;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Thread createThread = new Thread(createMainForm);
            createThread.SetApartmentState(ApartmentState.STA);
            createThread.Start();
        }

        private void createMainForm()
        {
            if (chkRandom.Checked)
            {
                invokeCloseForm();
                Application.Run(new MainForm());
            }
            else
            {
                try
                {
                    byte[] iv = new byte[] { byte.Parse(txtIVByte1.Text), byte.Parse(txtIVByte2.Text), byte.Parse(txtIVByte3.Text), byte.Parse(txtIVByte4.Text) };
                    invokeCloseForm();
                    Application.Run(new MainForm(iv));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[發生例外狀況] 請輸入正確初始 IV 數值 : " + ex);
                }
            }
        }

        private void invokeCloseForm()
        {
            Invoke((MethodInvoker)delegate ()
            {
                Close();
            });
        }

        private void chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            txtIVByte1.Enabled = txtIVByte2.Enabled = txtIVByte3.Enabled = txtIVByte4.Enabled = !chkRandom.Checked;
        }
    }
}