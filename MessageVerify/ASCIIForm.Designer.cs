namespace MessageVerify
{
    partial class ASCIIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASCIIForm));
            this.txtByte = new System.Windows.Forms.TextBox();
            this.labelByte = new System.Windows.Forms.Label();
            this.labelASCII = new System.Windows.Forms.Label();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.btnToASCII = new System.Windows.Forms.Button();
            this.btnToByte = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtByte
            // 
            this.txtByte.Location = new System.Drawing.Point(35, 75);
            this.txtByte.Multiline = true;
            this.txtByte.Name = "txtByte";
            this.txtByte.Size = new System.Drawing.Size(400, 125);
            this.txtByte.TabIndex = 2;
            // 
            // labelByte
            // 
            this.labelByte.AutoSize = true;
            this.labelByte.Location = new System.Drawing.Point(25, 50);
            this.labelByte.Name = "labelByte";
            this.labelByte.Size = new System.Drawing.Size(78, 12);
            this.labelByte.TabIndex = 1;
            this.labelByte.Text = "Byte 陣列資料";
            // 
            // labelASCII
            // 
            this.labelASCII.AutoSize = true;
            this.labelASCII.Location = new System.Drawing.Point(25, 250);
            this.labelASCII.Name = "labelASCII";
            this.labelASCII.Size = new System.Drawing.Size(53, 12);
            this.labelASCII.TabIndex = 5;
            this.labelASCII.Text = "字串資料";
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(35, 275);
            this.txtASCII.Multiline = true;
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(400, 125);
            this.txtASCII.TabIndex = 6;
            // 
            // btnToASCII
            // 
            this.btnToASCII.Location = new System.Drawing.Point(27, 210);
            this.btnToASCII.Name = "btnToASCII";
            this.btnToASCII.Size = new System.Drawing.Size(100, 23);
            this.btnToASCII.TabIndex = 3;
            this.btnToASCII.Text = "轉換為字串";
            this.btnToASCII.UseVisualStyleBackColor = true;
            this.btnToASCII.Click += new System.EventHandler(this.btnToASCII_Click);
            // 
            // btnToByte
            // 
            this.btnToByte.Location = new System.Drawing.Point(335, 210);
            this.btnToByte.Name = "btnToByte";
            this.btnToByte.Size = new System.Drawing.Size(100, 23);
            this.btnToByte.TabIndex = 4;
            this.btnToByte.Text = "轉換為內碼";
            this.btnToByte.UseVisualStyleBackColor = true;
            this.btnToByte.Click += new System.EventHandler(this.btnToByte_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(137, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "字串內碼轉換工具";
            // 
            // ASCIIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 422);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnToByte);
            this.Controls.Add(this.btnToASCII);
            this.Controls.Add(this.labelASCII);
            this.Controls.Add(this.txtASCII);
            this.Controls.Add(this.labelByte);
            this.Controls.Add(this.txtByte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "ASCIIForm";
            this.Text = "字串內碼轉換工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtByte;
        private System.Windows.Forms.Label labelByte;
        private System.Windows.Forms.Label labelASCII;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Button btnToASCII;
        private System.Windows.Forms.Button btnToByte;
        private System.Windows.Forms.Label labelTitle;
    }
}