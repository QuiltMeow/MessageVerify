namespace MessageVerify
{
    partial class InitIVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitIVForm));
            this.labelInitIV = new System.Windows.Forms.Label();
            this.txtIVByte1 = new System.Windows.Forms.TextBox();
            this.txtIVByte2 = new System.Windows.Forms.TextBox();
            this.txtIVByte3 = new System.Windows.Forms.TextBox();
            this.txtIVByte4 = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelInitIV
            // 
            this.labelInitIV.AutoSize = true;
            this.labelInitIV.Location = new System.Drawing.Point(12, 9);
            this.labelInitIV.Name = "labelInitIV";
            this.labelInitIV.Size = new System.Drawing.Size(101, 12);
            this.labelInitIV.TabIndex = 0;
            this.labelInitIV.Text = "初始資料 : IV 設定";
            // 
            // txtIVByte1
            // 
            this.txtIVByte1.Location = new System.Drawing.Point(25, 35);
            this.txtIVByte1.Name = "txtIVByte1";
            this.txtIVByte1.Size = new System.Drawing.Size(50, 22);
            this.txtIVByte1.TabIndex = 1;
            this.txtIVByte1.Text = "28";
            this.txtIVByte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIVByte2
            // 
            this.txtIVByte2.Location = new System.Drawing.Point(81, 35);
            this.txtIVByte2.Name = "txtIVByte2";
            this.txtIVByte2.Size = new System.Drawing.Size(50, 22);
            this.txtIVByte2.TabIndex = 2;
            this.txtIVByte2.Text = "1";
            this.txtIVByte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIVByte3
            // 
            this.txtIVByte3.Location = new System.Drawing.Point(137, 35);
            this.txtIVByte3.Name = "txtIVByte3";
            this.txtIVByte3.Size = new System.Drawing.Size(50, 22);
            this.txtIVByte3.TabIndex = 3;
            this.txtIVByte3.Text = "60";
            this.txtIVByte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIVByte4
            // 
            this.txtIVByte4.Location = new System.Drawing.Point(193, 35);
            this.txtIVByte4.Name = "txtIVByte4";
            this.txtIVByte4.Size = new System.Drawing.Size(50, 22);
            this.txtIVByte4.TabIndex = 4;
            this.txtIVByte4.Text = "27";
            this.txtIVByte4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(14, 70);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "確定";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(95, 74);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(48, 16);
            this.chkRandom.TabIndex = 6;
            this.chkRandom.Text = "隨機";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // InitIVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 107);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtIVByte4);
            this.Controls.Add(this.txtIVByte3);
            this.Controls.Add(this.txtIVByte2);
            this.Controls.Add(this.txtIVByte1);
            this.Controls.Add(this.labelInitIV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "InitIVForm";
            this.Text = "IV 設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInitIV;
        private System.Windows.Forms.TextBox txtIVByte1;
        private System.Windows.Forms.TextBox txtIVByte2;
        private System.Windows.Forms.TextBox txtIVByte3;
        private System.Windows.Forms.TextBox txtIVByte4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkRandom;
    }
}