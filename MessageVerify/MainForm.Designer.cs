namespace MessageVerify
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcCrypto = new System.Windows.Forms.TabControl();
            this.tpSend = new System.Windows.Forms.TabPage();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.txtSendEncryptHash = new System.Windows.Forms.TextBox();
            this.labelSendEncryptHash = new System.Windows.Forms.Label();
            this.txtSendHash = new System.Windows.Forms.TextBox();
            this.labelSendHash = new System.Windows.Forms.Label();
            this.txtSendEncrypt = new System.Windows.Forms.TextBox();
            this.labelSendEncrypt = new System.Windows.Forms.Label();
            this.btnSendEncrypt = new System.Windows.Forms.Button();
            this.txtSendRawMessage = new System.Windows.Forms.TextBox();
            this.labelSendRawMessage = new System.Windows.Forms.Label();
            this.tpRecv = new System.Windows.Forms.TabPage();
            this.btnRecvVerify = new System.Windows.Forms.Button();
            this.txtRecvDecryptHash = new System.Windows.Forms.TextBox();
            this.btnRecvDecrypt = new System.Windows.Forms.Button();
            this.labelRecvDecryptHash = new System.Windows.Forms.Label();
            this.txtRecvDecrypt = new System.Windows.Forms.TextBox();
            this.labelRecvDecrypt = new System.Windows.Forms.Label();
            this.txtRecvEncryptHash = new System.Windows.Forms.TextBox();
            this.labelRecvEncryptHash = new System.Windows.Forms.Label();
            this.txtRecvEncrypt = new System.Windows.Forms.TextBox();
            this.labelRecvEncrypt = new System.Windows.Forms.Label();
            this.tpTool = new System.Windows.Forms.TabPage();
            this.btnFileCrypt = new System.Windows.Forms.Button();
            this.btnASCIITool = new System.Windows.Forms.Button();
            this.labelIV = new System.Windows.Forms.Label();
            this.tcCrypto.SuspendLayout();
            this.tpSend.SuspendLayout();
            this.tpRecv.SuspendLayout();
            this.tpTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCrypto
            // 
            this.tcCrypto.Controls.Add(this.tpSend);
            this.tcCrypto.Controls.Add(this.tpRecv);
            this.tcCrypto.Controls.Add(this.tpTool);
            this.tcCrypto.Location = new System.Drawing.Point(0, 0);
            this.tcCrypto.Name = "tcCrypto";
            this.tcCrypto.SelectedIndex = 0;
            this.tcCrypto.Size = new System.Drawing.Size(531, 517);
            this.tcCrypto.TabIndex = 0;
            // 
            // tpSend
            // 
            this.tpSend.Controls.Add(this.labelIV);
            this.tpSend.Controls.Add(this.btnGenerateRandom);
            this.tpSend.Controls.Add(this.txtSendEncryptHash);
            this.tpSend.Controls.Add(this.labelSendEncryptHash);
            this.tpSend.Controls.Add(this.txtSendHash);
            this.tpSend.Controls.Add(this.labelSendHash);
            this.tpSend.Controls.Add(this.txtSendEncrypt);
            this.tpSend.Controls.Add(this.labelSendEncrypt);
            this.tpSend.Controls.Add(this.btnSendEncrypt);
            this.tpSend.Controls.Add(this.txtSendRawMessage);
            this.tpSend.Controls.Add(this.labelSendRawMessage);
            this.tpSend.Location = new System.Drawing.Point(4, 22);
            this.tpSend.Name = "tpSend";
            this.tpSend.Padding = new System.Windows.Forms.Padding(3);
            this.tpSend.Size = new System.Drawing.Size(523, 491);
            this.tpSend.TabIndex = 0;
            this.tpSend.Text = "發送端";
            this.tpSend.UseVisualStyleBackColor = true;
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(8, 124);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(250, 23);
            this.btnGenerateRandom.TabIndex = 2;
            this.btnGenerateRandom.Text = "產生亂數訊息";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
            // 
            // txtSendEncryptHash
            // 
            this.txtSendEncryptHash.Location = new System.Drawing.Point(8, 351);
            this.txtSendEncryptHash.Multiline = true;
            this.txtSendEncryptHash.Name = "txtSendEncryptHash";
            this.txtSendEncryptHash.ReadOnly = true;
            this.txtSendEncryptHash.Size = new System.Drawing.Size(510, 50);
            this.txtSendEncryptHash.TabIndex = 9;
            // 
            // labelSendEncryptHash
            // 
            this.labelSendEncryptHash.AutoSize = true;
            this.labelSendEncryptHash.Location = new System.Drawing.Point(6, 336);
            this.labelSendEncryptHash.Name = "labelSendEncryptHash";
            this.labelSendEncryptHash.Size = new System.Drawing.Size(100, 12);
            this.labelSendEncryptHash.TabIndex = 8;
            this.labelSendEncryptHash.Text = "加密摘要 (位元組)";
            // 
            // txtSendHash
            // 
            this.txtSendHash.Location = new System.Drawing.Point(8, 283);
            this.txtSendHash.Multiline = true;
            this.txtSendHash.Name = "txtSendHash";
            this.txtSendHash.ReadOnly = true;
            this.txtSendHash.Size = new System.Drawing.Size(510, 50);
            this.txtSendHash.TabIndex = 7;
            // 
            // labelSendHash
            // 
            this.labelSendHash.AutoSize = true;
            this.labelSendHash.Location = new System.Drawing.Point(6, 268);
            this.labelSendHash.Name = "labelSendHash";
            this.labelSendHash.Size = new System.Drawing.Size(114, 12);
            this.labelSendHash.TabIndex = 6;
            this.labelSendHash.Text = "訊息摘要 (SHA - 512)";
            // 
            // txtSendEncrypt
            // 
            this.txtSendEncrypt.Location = new System.Drawing.Point(8, 165);
            this.txtSendEncrypt.Multiline = true;
            this.txtSendEncrypt.Name = "txtSendEncrypt";
            this.txtSendEncrypt.ReadOnly = true;
            this.txtSendEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendEncrypt.Size = new System.Drawing.Size(510, 100);
            this.txtSendEncrypt.TabIndex = 5;
            // 
            // labelSendEncrypt
            // 
            this.labelSendEncrypt.AutoSize = true;
            this.labelSendEncrypt.Location = new System.Drawing.Point(6, 150);
            this.labelSendEncrypt.Name = "labelSendEncrypt";
            this.labelSendEncrypt.Size = new System.Drawing.Size(100, 12);
            this.labelSendEncrypt.TabIndex = 4;
            this.labelSendEncrypt.Text = "加密訊息 (位元組)";
            // 
            // btnSendEncrypt
            // 
            this.btnSendEncrypt.Location = new System.Drawing.Point(268, 124);
            this.btnSendEncrypt.Name = "btnSendEncrypt";
            this.btnSendEncrypt.Size = new System.Drawing.Size(250, 23);
            this.btnSendEncrypt.TabIndex = 3;
            this.btnSendEncrypt.Text = "加密 / 產生摘要";
            this.btnSendEncrypt.UseVisualStyleBackColor = true;
            this.btnSendEncrypt.Click += new System.EventHandler(this.btnSendEncrypt_Click);
            // 
            // txtSendRawMessage
            // 
            this.txtSendRawMessage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSendRawMessage.Location = new System.Drawing.Point(8, 18);
            this.txtSendRawMessage.Multiline = true;
            this.txtSendRawMessage.Name = "txtSendRawMessage";
            this.txtSendRawMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendRawMessage.Size = new System.Drawing.Size(510, 100);
            this.txtSendRawMessage.TabIndex = 1;
            // 
            // labelSendRawMessage
            // 
            this.labelSendRawMessage.AutoSize = true;
            this.labelSendRawMessage.Location = new System.Drawing.Point(6, 3);
            this.labelSendRawMessage.Name = "labelSendRawMessage";
            this.labelSendRawMessage.Size = new System.Drawing.Size(53, 12);
            this.labelSendRawMessage.TabIndex = 0;
            this.labelSendRawMessage.Text = "原始訊息";
            // 
            // tpRecv
            // 
            this.tpRecv.Controls.Add(this.btnRecvVerify);
            this.tpRecv.Controls.Add(this.txtRecvDecryptHash);
            this.tpRecv.Controls.Add(this.btnRecvDecrypt);
            this.tpRecv.Controls.Add(this.labelRecvDecryptHash);
            this.tpRecv.Controls.Add(this.txtRecvDecrypt);
            this.tpRecv.Controls.Add(this.labelRecvDecrypt);
            this.tpRecv.Controls.Add(this.txtRecvEncryptHash);
            this.tpRecv.Controls.Add(this.labelRecvEncryptHash);
            this.tpRecv.Controls.Add(this.txtRecvEncrypt);
            this.tpRecv.Controls.Add(this.labelRecvEncrypt);
            this.tpRecv.Location = new System.Drawing.Point(4, 22);
            this.tpRecv.Name = "tpRecv";
            this.tpRecv.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecv.Size = new System.Drawing.Size(523, 491);
            this.tpRecv.TabIndex = 1;
            this.tpRecv.Text = "接收端";
            this.tpRecv.UseVisualStyleBackColor = true;
            // 
            // btnRecvVerify
            // 
            this.btnRecvVerify.Enabled = false;
            this.btnRecvVerify.Location = new System.Drawing.Point(8, 459);
            this.btnRecvVerify.Name = "btnRecvVerify";
            this.btnRecvVerify.Size = new System.Drawing.Size(509, 23);
            this.btnRecvVerify.TabIndex = 9;
            this.btnRecvVerify.Text = "驗證";
            this.btnRecvVerify.UseVisualStyleBackColor = true;
            this.btnRecvVerify.Click += new System.EventHandler(this.btnRecvVerify_Click);
            // 
            // txtRecvDecryptHash
            // 
            this.txtRecvDecryptHash.Location = new System.Drawing.Point(8, 403);
            this.txtRecvDecryptHash.Multiline = true;
            this.txtRecvDecryptHash.Name = "txtRecvDecryptHash";
            this.txtRecvDecryptHash.ReadOnly = true;
            this.txtRecvDecryptHash.Size = new System.Drawing.Size(509, 50);
            this.txtRecvDecryptHash.TabIndex = 8;
            // 
            // btnRecvDecrypt
            // 
            this.btnRecvDecrypt.Location = new System.Drawing.Point(8, 218);
            this.btnRecvDecrypt.Name = "btnRecvDecrypt";
            this.btnRecvDecrypt.Size = new System.Drawing.Size(509, 23);
            this.btnRecvDecrypt.TabIndex = 4;
            this.btnRecvDecrypt.Text = "解密";
            this.btnRecvDecrypt.UseVisualStyleBackColor = true;
            this.btnRecvDecrypt.Click += new System.EventHandler(this.btnRecvDecrypt_Click);
            // 
            // labelRecvDecryptHash
            // 
            this.labelRecvDecryptHash.AutoSize = true;
            this.labelRecvDecryptHash.Location = new System.Drawing.Point(6, 388);
            this.labelRecvDecryptHash.Name = "labelRecvDecryptHash";
            this.labelRecvDecryptHash.Size = new System.Drawing.Size(53, 12);
            this.labelRecvDecryptHash.TabIndex = 7;
            this.labelRecvDecryptHash.Text = "解密摘要";
            // 
            // txtRecvDecrypt
            // 
            this.txtRecvDecrypt.Location = new System.Drawing.Point(8, 259);
            this.txtRecvDecrypt.Multiline = true;
            this.txtRecvDecrypt.Name = "txtRecvDecrypt";
            this.txtRecvDecrypt.ReadOnly = true;
            this.txtRecvDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecvDecrypt.Size = new System.Drawing.Size(509, 126);
            this.txtRecvDecrypt.TabIndex = 6;
            // 
            // labelRecvDecrypt
            // 
            this.labelRecvDecrypt.AutoSize = true;
            this.labelRecvDecrypt.Location = new System.Drawing.Point(6, 244);
            this.labelRecvDecrypt.Name = "labelRecvDecrypt";
            this.labelRecvDecrypt.Size = new System.Drawing.Size(53, 12);
            this.labelRecvDecrypt.TabIndex = 5;
            this.labelRecvDecrypt.Text = "解密訊息";
            // 
            // txtRecvEncryptHash
            // 
            this.txtRecvEncryptHash.Location = new System.Drawing.Point(8, 162);
            this.txtRecvEncryptHash.Multiline = true;
            this.txtRecvEncryptHash.Name = "txtRecvEncryptHash";
            this.txtRecvEncryptHash.Size = new System.Drawing.Size(509, 50);
            this.txtRecvEncryptHash.TabIndex = 3;
            // 
            // labelRecvEncryptHash
            // 
            this.labelRecvEncryptHash.AutoSize = true;
            this.labelRecvEncryptHash.Location = new System.Drawing.Point(6, 147);
            this.labelRecvEncryptHash.Name = "labelRecvEncryptHash";
            this.labelRecvEncryptHash.Size = new System.Drawing.Size(100, 12);
            this.labelRecvEncryptHash.TabIndex = 2;
            this.labelRecvEncryptHash.Text = "加密摘要 (位元組)";
            // 
            // txtRecvEncrypt
            // 
            this.txtRecvEncrypt.Location = new System.Drawing.Point(8, 18);
            this.txtRecvEncrypt.Multiline = true;
            this.txtRecvEncrypt.Name = "txtRecvEncrypt";
            this.txtRecvEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecvEncrypt.Size = new System.Drawing.Size(509, 126);
            this.txtRecvEncrypt.TabIndex = 1;
            // 
            // labelRecvEncrypt
            // 
            this.labelRecvEncrypt.AutoSize = true;
            this.labelRecvEncrypt.Location = new System.Drawing.Point(6, 3);
            this.labelRecvEncrypt.Name = "labelRecvEncrypt";
            this.labelRecvEncrypt.Size = new System.Drawing.Size(100, 12);
            this.labelRecvEncrypt.TabIndex = 0;
            this.labelRecvEncrypt.Text = "加密訊息 (位元組)";
            // 
            // tpTool
            // 
            this.tpTool.Controls.Add(this.btnFileCrypt);
            this.tpTool.Controls.Add(this.btnASCIITool);
            this.tpTool.Location = new System.Drawing.Point(4, 22);
            this.tpTool.Name = "tpTool";
            this.tpTool.Size = new System.Drawing.Size(523, 491);
            this.tpTool.TabIndex = 2;
            this.tpTool.Text = "工具";
            this.tpTool.UseVisualStyleBackColor = true;
            // 
            // btnFileCrypt
            // 
            this.btnFileCrypt.Location = new System.Drawing.Point(15, 55);
            this.btnFileCrypt.Name = "btnFileCrypt";
            this.btnFileCrypt.Size = new System.Drawing.Size(485, 23);
            this.btnFileCrypt.TabIndex = 1;
            this.btnFileCrypt.Text = "檔案加密工具";
            this.btnFileCrypt.UseVisualStyleBackColor = true;
            this.btnFileCrypt.Click += new System.EventHandler(this.btnFileCrypt_Click);
            // 
            // btnASCIITool
            // 
            this.btnASCIITool.Location = new System.Drawing.Point(15, 15);
            this.btnASCIITool.Name = "btnASCIITool";
            this.btnASCIITool.Size = new System.Drawing.Size(485, 23);
            this.btnASCIITool.TabIndex = 0;
            this.btnASCIITool.Text = "字串內碼轉換工具";
            this.btnASCIITool.UseVisualStyleBackColor = true;
            this.btnASCIITool.Click += new System.EventHandler(this.btnASCIITool_Click);
            // 
            // labelIV
            // 
            this.labelIV.AutoSize = true;
            this.labelIV.Location = new System.Drawing.Point(8, 474);
            this.labelIV.Name = "labelIV";
            this.labelIV.Size = new System.Drawing.Size(74, 12);
            this.labelIV.TabIndex = 10;
            this.labelIV.Text = "IV : 等待中 ...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 517);
            this.Controls.Add(this.tcCrypto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "加密工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcCrypto.ResumeLayout(false);
            this.tpSend.ResumeLayout(false);
            this.tpSend.PerformLayout();
            this.tpRecv.ResumeLayout(false);
            this.tpRecv.PerformLayout();
            this.tpTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCrypto;
        private System.Windows.Forms.TabPage tpSend;
        private System.Windows.Forms.TabPage tpRecv;
        private System.Windows.Forms.TextBox txtSendHash;
        private System.Windows.Forms.Label labelSendHash;
        private System.Windows.Forms.TextBox txtSendEncrypt;
        private System.Windows.Forms.Label labelSendEncrypt;
        private System.Windows.Forms.Button btnSendEncrypt;
        private System.Windows.Forms.TextBox txtSendRawMessage;
        private System.Windows.Forms.Label labelSendRawMessage;
        private System.Windows.Forms.TextBox txtRecvEncryptHash;
        private System.Windows.Forms.Label labelRecvEncryptHash;
        private System.Windows.Forms.TextBox txtRecvEncrypt;
        private System.Windows.Forms.Label labelRecvEncrypt;
        private System.Windows.Forms.Label labelSendEncryptHash;
        private System.Windows.Forms.TextBox txtSendEncryptHash;
        private System.Windows.Forms.Button btnRecvVerify;
        private System.Windows.Forms.TextBox txtRecvDecryptHash;
        private System.Windows.Forms.Button btnRecvDecrypt;
        private System.Windows.Forms.Label labelRecvDecryptHash;
        private System.Windows.Forms.TextBox txtRecvDecrypt;
        private System.Windows.Forms.Label labelRecvDecrypt;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.TabPage tpTool;
        private System.Windows.Forms.Button btnFileCrypt;
        private System.Windows.Forms.Button btnASCIITool;
        private System.Windows.Forms.Label labelIV;
    }
}

