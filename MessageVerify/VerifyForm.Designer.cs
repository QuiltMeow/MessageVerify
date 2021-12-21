namespace MessageVerify
{
    partial class VerifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.labelHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.labelComputeHash = new System.Windows.Forms.Label();
            this.txtComputeHash = new System.Windows.Forms.TextBox();
            this.labelVerifyTip = new System.Windows.Forms.Label();
            this.labelVerify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(13, 13);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(77, 12);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "接收解密訊息";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 28);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(457, 100);
            this.txtMessage.TabIndex = 1;
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(13, 131);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(77, 12);
            this.labelHash.TabIndex = 2;
            this.labelHash.Text = "接收解密摘要";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(15, 146);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(457, 50);
            this.txtHash.TabIndex = 3;
            // 
            // labelComputeHash
            // 
            this.labelComputeHash.AutoSize = true;
            this.labelComputeHash.Location = new System.Drawing.Point(13, 199);
            this.labelComputeHash.Name = "labelComputeHash";
            this.labelComputeHash.Size = new System.Drawing.Size(77, 12);
            this.labelComputeHash.TabIndex = 4;
            this.labelComputeHash.Text = "計算訊息摘要";
            // 
            // txtComputeHash
            // 
            this.txtComputeHash.Location = new System.Drawing.Point(15, 214);
            this.txtComputeHash.Multiline = true;
            this.txtComputeHash.Name = "txtComputeHash";
            this.txtComputeHash.ReadOnly = true;
            this.txtComputeHash.Size = new System.Drawing.Size(457, 50);
            this.txtComputeHash.TabIndex = 5;
            // 
            // labelVerifyTip
            // 
            this.labelVerifyTip.AutoSize = true;
            this.labelVerifyTip.Location = new System.Drawing.Point(13, 267);
            this.labelVerifyTip.Name = "labelVerifyTip";
            this.labelVerifyTip.Size = new System.Drawing.Size(59, 12);
            this.labelVerifyTip.TabIndex = 6;
            this.labelVerifyTip.Text = "驗證結果 :";
            // 
            // labelVerify
            // 
            this.labelVerify.AutoSize = true;
            this.labelVerify.Location = new System.Drawing.Point(78, 267);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(53, 12);
            this.labelVerify.TabIndex = 7;
            this.labelVerify.Text = "等待中 ...";
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 296);
            this.Controls.Add(this.labelVerify);
            this.Controls.Add(this.labelVerifyTip);
            this.Controls.Add(this.txtComputeHash);
            this.Controls.Add(this.labelComputeHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "VerifyForm";
            this.Text = "訊息驗證";
            this.Load += new System.EventHandler(this.VerifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label labelComputeHash;
        private System.Windows.Forms.TextBox txtComputeHash;
        private System.Windows.Forms.Label labelVerifyTip;
        private System.Windows.Forms.Label labelVerify;
    }
}