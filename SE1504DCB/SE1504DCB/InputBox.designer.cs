namespace SE190X
{
    partial class InputBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTester = new System.Windows.Forms.TextBox();
            this.txtProductNum = new System.Windows.Forms.TextBox();
            this.txtCoreSN = new System.Windows.Forms.TextBox();
            this.txtLanSN = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUartSN = new System.Windows.Forms.TextBox();
            this.txtSerial1SN = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkcoreEnable = new System.Windows.Forms.CheckBox();
            this.chklanEnable = new System.Windows.Forms.CheckBox();
            this.chkuartEnable = new System.Windows.Forms.CheckBox();
            this.chkserial1Enable = new System.Windows.Forms.CheckBox();
            this.chkserial2Enable = new System.Windows.Forms.CheckBox();
            this.txtSerial2SN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkserial3Enable = new System.Windows.Forms.CheckBox();
            this.txtSerial3SN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkserial4Enable = new System.Windows.Forms.CheckBox();
            this.txtSerial4SN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CORE SN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAN/EVM SN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(53, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "UART SN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(38, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "SERIAL1 SN:";
            // 
            // txtTester
            // 
            this.txtTester.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTester.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTester.Location = new System.Drawing.Point(115, 21);
            this.txtTester.MaxLength = 20;
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(246, 23);
            this.txtTester.TabIndex = 4;
            this.txtTester.TextChanged += new System.EventHandler(this.txtTester_TextChanged);
            // 
            // txtProductNum
            // 
            this.txtProductNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductNum.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductNum.Location = new System.Drawing.Point(115, 50);
            this.txtProductNum.MaxLength = 20;
            this.txtProductNum.Name = "txtProductNum";
            this.txtProductNum.Size = new System.Drawing.Size(246, 23);
            this.txtProductNum.TabIndex = 5;
            this.txtProductNum.TextChanged += new System.EventHandler(this.txtProductNum_TextChanged);
            // 
            // txtCoreSN
            // 
            this.txtCoreSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCoreSN.Enabled = false;
            this.txtCoreSN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCoreSN.Location = new System.Drawing.Point(115, 79);
            this.txtCoreSN.MaxLength = 20;
            this.txtCoreSN.Name = "txtCoreSN";
            this.txtCoreSN.Size = new System.Drawing.Size(246, 23);
            this.txtCoreSN.TabIndex = 6;
            this.txtCoreSN.TextChanged += new System.EventHandler(this.txtCoreSN_TextChanged);
            // 
            // txtLanSN
            // 
            this.txtLanSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLanSN.Enabled = false;
            this.txtLanSN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLanSN.Location = new System.Drawing.Point(115, 108);
            this.txtLanSN.MaxLength = 20;
            this.txtLanSN.Name = "txtLanSN";
            this.txtLanSN.Size = new System.Drawing.Size(246, 23);
            this.txtLanSN.TabIndex = 7;
            this.txtLanSN.TextChanged += new System.EventHandler(this.txtLanSN_TextChanged);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(205, 292);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 25);
            this.cmdOK.TabIndex = 12;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(44, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "* 測試人員:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(44, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "* 工單號碼:";
            // 
            // txtUartSN
            // 
            this.txtUartSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUartSN.Enabled = false;
            this.txtUartSN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUartSN.Location = new System.Drawing.Point(115, 137);
            this.txtUartSN.MaxLength = 20;
            this.txtUartSN.Name = "txtUartSN";
            this.txtUartSN.Size = new System.Drawing.Size(246, 23);
            this.txtUartSN.TabIndex = 8;
            this.txtUartSN.TextChanged += new System.EventHandler(this.txtUartSN_TextChanged);
            // 
            // txtSerial1SN
            // 
            this.txtSerial1SN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial1SN.Enabled = false;
            this.txtSerial1SN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerial1SN.Location = new System.Drawing.Point(115, 166);
            this.txtSerial1SN.MaxLength = 20;
            this.txtSerial1SN.Name = "txtSerial1SN";
            this.txtSerial1SN.Size = new System.Drawing.Size(246, 23);
            this.txtSerial1SN.TabIndex = 11;
            this.txtSerial1SN.TextChanged += new System.EventHandler(this.txtSerial1SN_TextChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(286, 292);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 25);
            this.cmdCancel.TabIndex = 13;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // chkcoreEnable
            // 
            this.chkcoreEnable.AutoSize = true;
            this.chkcoreEnable.Location = new System.Drawing.Point(12, 82);
            this.chkcoreEnable.Name = "chkcoreEnable";
            this.chkcoreEnable.Size = new System.Drawing.Size(15, 14);
            this.chkcoreEnable.TabIndex = 14;
            this.chkcoreEnable.UseVisualStyleBackColor = true;
            this.chkcoreEnable.Click += new System.EventHandler(this.chkcoreEnable_Click);
            // 
            // chklanEnable
            // 
            this.chklanEnable.AutoSize = true;
            this.chklanEnable.Location = new System.Drawing.Point(12, 111);
            this.chklanEnable.Name = "chklanEnable";
            this.chklanEnable.Size = new System.Drawing.Size(15, 14);
            this.chklanEnable.TabIndex = 15;
            this.chklanEnable.UseVisualStyleBackColor = true;
            this.chklanEnable.Click += new System.EventHandler(this.chklanEnable_Click);
            // 
            // chkuartEnable
            // 
            this.chkuartEnable.AutoSize = true;
            this.chkuartEnable.Location = new System.Drawing.Point(12, 140);
            this.chkuartEnable.Name = "chkuartEnable";
            this.chkuartEnable.Size = new System.Drawing.Size(15, 14);
            this.chkuartEnable.TabIndex = 16;
            this.chkuartEnable.UseVisualStyleBackColor = true;
            this.chkuartEnable.Click += new System.EventHandler(this.chkuartEnable_Click);
            // 
            // chkserial1Enable
            // 
            this.chkserial1Enable.AutoSize = true;
            this.chkserial1Enable.Location = new System.Drawing.Point(12, 169);
            this.chkserial1Enable.Name = "chkserial1Enable";
            this.chkserial1Enable.Size = new System.Drawing.Size(15, 14);
            this.chkserial1Enable.TabIndex = 17;
            this.chkserial1Enable.UseVisualStyleBackColor = true;
            this.chkserial1Enable.Click += new System.EventHandler(this.chkserial1Enable_Click);
            // 
            // chkserial2Enable
            // 
            this.chkserial2Enable.AutoSize = true;
            this.chkserial2Enable.Location = new System.Drawing.Point(12, 198);
            this.chkserial2Enable.Name = "chkserial2Enable";
            this.chkserial2Enable.Size = new System.Drawing.Size(15, 14);
            this.chkserial2Enable.TabIndex = 20;
            this.chkserial2Enable.UseVisualStyleBackColor = true;
            this.chkserial2Enable.Click += new System.EventHandler(this.chkserial2Enable_Click);
            // 
            // txtSerial2SN
            // 
            this.txtSerial2SN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial2SN.Enabled = false;
            this.txtSerial2SN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerial2SN.Location = new System.Drawing.Point(115, 195);
            this.txtSerial2SN.MaxLength = 20;
            this.txtSerial2SN.Name = "txtSerial2SN";
            this.txtSerial2SN.Size = new System.Drawing.Size(246, 23);
            this.txtSerial2SN.TabIndex = 19;
            this.txtSerial2SN.TextChanged += new System.EventHandler(this.txtSerial2SN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(38, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "SERIAL2 SN:";
            // 
            // chkserial3Enable
            // 
            this.chkserial3Enable.AutoSize = true;
            this.chkserial3Enable.Location = new System.Drawing.Point(12, 227);
            this.chkserial3Enable.Name = "chkserial3Enable";
            this.chkserial3Enable.Size = new System.Drawing.Size(15, 14);
            this.chkserial3Enable.TabIndex = 23;
            this.chkserial3Enable.UseVisualStyleBackColor = true;
            this.chkserial3Enable.Click += new System.EventHandler(this.chkserial3Enable_Click);
            // 
            // txtSerial3SN
            // 
            this.txtSerial3SN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial3SN.Enabled = false;
            this.txtSerial3SN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerial3SN.Location = new System.Drawing.Point(115, 224);
            this.txtSerial3SN.MaxLength = 20;
            this.txtSerial3SN.Name = "txtSerial3SN";
            this.txtSerial3SN.Size = new System.Drawing.Size(246, 23);
            this.txtSerial3SN.TabIndex = 22;
            this.txtSerial3SN.TextChanged += new System.EventHandler(this.txtSerial3SN_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(38, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "SERIAL3 SN:";
            // 
            // chkserial4Enable
            // 
            this.chkserial4Enable.AutoSize = true;
            this.chkserial4Enable.Location = new System.Drawing.Point(12, 256);
            this.chkserial4Enable.Name = "chkserial4Enable";
            this.chkserial4Enable.Size = new System.Drawing.Size(15, 14);
            this.chkserial4Enable.TabIndex = 26;
            this.chkserial4Enable.UseVisualStyleBackColor = true;
            this.chkserial4Enable.Click += new System.EventHandler(this.chkserial4Enable_Click);
            // 
            // txtSerial4SN
            // 
            this.txtSerial4SN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerial4SN.Enabled = false;
            this.txtSerial4SN.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerial4SN.Location = new System.Drawing.Point(115, 253);
            this.txtSerial4SN.MaxLength = 20;
            this.txtSerial4SN.Name = "txtSerial4SN";
            this.txtSerial4SN.Size = new System.Drawing.Size(246, 23);
            this.txtSerial4SN.TabIndex = 25;
            this.txtSerial4SN.TextChanged += new System.EventHandler(this.txtSerial4SN_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(38, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "SERIAL4 SN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(12, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "* 為重要資料必須填寫";
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 331);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkserial4Enable);
            this.Controls.Add(this.txtSerial4SN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkserial3Enable);
            this.Controls.Add(this.txtSerial3SN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkserial2Enable);
            this.Controls.Add(this.txtSerial2SN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkserial1Enable);
            this.Controls.Add(this.chkuartEnable);
            this.Controls.Add(this.chklanEnable);
            this.Controls.Add(this.chkcoreEnable);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtSerial1SN);
            this.Controls.Add(this.txtUartSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtLanSN);
            this.Controls.Add(this.txtCoreSN);
            this.Controls.Add(this.txtProductNum);
            this.Controls.Add(this.txtTester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "請輸入產品序號";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputBox_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtTester;
        private System.Windows.Forms.TextBox txtProductNum;
        private System.Windows.Forms.TextBox txtCoreSN;
        private System.Windows.Forms.TextBox txtLanSN;
        private System.Windows.Forms.TextBox txtUartSN;
        private System.Windows.Forms.TextBox txtSerial1SN;
        private System.Windows.Forms.CheckBox chkcoreEnable;
        private System.Windows.Forms.CheckBox chklanEnable;
        private System.Windows.Forms.CheckBox chkuartEnable;
        private System.Windows.Forms.CheckBox chkserial1Enable;
        private System.Windows.Forms.CheckBox chkserial2Enable;
        private System.Windows.Forms.TextBox txtSerial2SN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkserial3Enable;
        private System.Windows.Forms.TextBox txtSerial3SN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkserial4Enable;
        private System.Windows.Forms.TextBox txtSerial4SN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}