using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE190X
{
    public partial class InputBox : Form
    {
        public static string[] snArray;
        public static string tester, productNum;
        public static string coreSN, lanSN, uartSN, serial1SN, serial2SN, serial3SN, serial4SN;
        public static bool CancelButton;

        string filePATH = Application.StartupPath + @"\inputbox.ini";

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            String line;
            // Create new FileInfo object and get the Length.
            FileInfo f = new FileInfo(filePATH);
            if (File.Exists(filePATH))
            {
                if (f.Length != 0) // 檔案大小不等於0個位元組
                {
                    using (StreamReader sr = new StreamReader(filePATH, Encoding.ASCII))
                    {
                        line = sr.ReadLine();
                        if (line != string.Empty)
                        {
                            tester = line;
                            txtTester.Text = tester;
                        }

                        line = sr.ReadLine();
                        while (line != null)
                        {
                            if (line != string.Empty)
                            {
                                snArray = line.Split(':');
                                switch (snArray[0].ToLower())
                                {
                                    case "pn":
                                        txtProductNum.Text = snArray[1];
                                        break;
                                    case "c":
                                        txtCoreSN.Text = snArray[1];
                                        chkcoreEnable.Checked = true;
                                        txtCoreSN.Enabled = true;
                                        break;
                                    case "l":
                                        txtLanSN.Text = snArray[1];
                                        chklanEnable.Checked = true;
                                        txtLanSN.Enabled = true;
                                        break;
                                    case "u":
                                        txtUartSN.Text = snArray[1];
                                        chkuartEnable.Checked = true;
                                        txtUartSN.Enabled = true;
                                        break;
                                    case "s1":
                                        txtSerial1SN.Text = snArray[1];
                                        chkserial1Enable.Checked = true;
                                        txtSerial1SN.Enabled = true;
                                        break;
                                    case "s2":
                                        txtSerial2SN.Text = snArray[1];
                                        chkserial2Enable.Checked = true;
                                        txtSerial2SN.Enabled = true;
                                        break;
                                    case "s3":
                                        txtSerial3SN.Text = snArray[1];
                                        chkserial3Enable.Checked = true;
                                        txtSerial3SN.Enabled = true;
                                        break;
                                    case "s4":
                                        txtSerial4SN.Text = snArray[1];
                                        chkserial4Enable.Checked = true;
                                        txtSerial4SN.Enabled = true;
                                        break;
                                }
                            }
                            line = sr.ReadLine();
                        }
                    }
                }
            }

            CancelButton = false;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            string temp;
            string swCoreSN, swLanSN, swUartSN, swSerial1SN, swSerial2SN, swSerial3SN, swSerial4SN;
            swCoreSN = string.Empty;
            swLanSN = string.Empty;
            swUartSN = string.Empty;
            swSerial1SN = string.Empty;
            swSerial2SN = string.Empty;
            swSerial3SN = string.Empty;
            swSerial4SN = string.Empty;
            try
            {
                // 序號遞增
                if (txtCoreSN.Text != string.Empty)         // SN ex:A145660000-1114
                {
                    temp = txtCoreSN.Text.Substring(txtCoreSN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + 1).ToString();   // +1
                    temp = temp.Substring(temp.Length - 4);
                    swCoreSN = txtCoreSN.Text.Substring(0, 11) + temp;
                }
                if (txtLanSN.Text != string.Empty)
                {
                    temp = txtLanSN.Text.Substring(txtLanSN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + 1).ToString();   // +1
                    temp = temp.Substring(temp.Length - 4);
                    swLanSN = txtLanSN.Text.Substring(0, 11) + temp;
                }
                if (txtUartSN.Text != string.Empty)
                {
                    temp = txtUartSN.Text.Substring(txtUartSN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + 1).ToString();   // +1
                    temp = temp.Substring(temp.Length - 4);
                    swUartSN = txtUartSN.Text.Substring(0, 11) + temp;
                }
                // Serial板片數判斷
                int quantity = 0;
                if (txtSerial1SN.Enabled && !txtSerial2SN.Enabled && !txtSerial3SN.Enabled && !txtSerial4SN.Enabled)
                {
                    quantity = 1;
                }
                else if (txtSerial1SN.Enabled && txtSerial2SN.Enabled && !txtSerial3SN.Enabled && !txtSerial4SN.Enabled)
                {
                    quantity = 2;
                }
                else if (txtSerial1SN.Enabled && txtSerial2SN.Enabled && txtSerial3SN.Enabled && !txtSerial4SN.Enabled)
                {
                    quantity = 3;
                }
                else if (txtSerial1SN.Enabled && txtSerial2SN.Enabled && txtSerial3SN.Enabled && txtSerial4SN.Enabled)
                {
                    quantity = 4;
                }
                //
                if (txtSerial1SN.Text != string.Empty)
                {
                    temp = txtSerial1SN.Text.Substring(txtSerial1SN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + quantity).ToString();   // +quantity
                    temp = temp.Substring(temp.Length - 4);
                    swSerial1SN = txtSerial1SN.Text.Substring(0, 11) + temp;
                }
                if (txtSerial2SN.Text != string.Empty)
                {
                    temp = txtSerial2SN.Text.Substring(txtSerial2SN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + quantity).ToString();   // +quantity
                    temp = temp.Substring(temp.Length - 4);
                    swSerial2SN = txtSerial2SN.Text.Substring(0, 11) + temp;
                }
                if (txtSerial3SN.Text != string.Empty)
                {
                    temp = txtSerial3SN.Text.Substring(txtSerial3SN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + quantity).ToString();   // +quantity
                    temp = temp.Substring(temp.Length - 4);
                    swSerial3SN = txtSerial3SN.Text.Substring(0, 11) + temp;
                }
                if (txtSerial4SN.Text != string.Empty)
                {
                    temp = txtSerial4SN.Text.Substring(txtSerial4SN.Text.Length - 4);
                    temp = "0000" + (Convert.ToInt32(temp) + quantity).ToString();   // +quantity
                    temp = temp.Substring(temp.Length - 4);
                    swSerial4SN = txtSerial4SN.Text.Substring(0, 11) + temp;
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("偵測到有序號(SN)少於15個字元，請確認序號(SN)是否輸入正確 ?\n\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }
            }

            // 寫入inputbox.ini文件
            using (StreamWriter sw = new StreamWriter(filePATH, false, Encoding.Default))
            {
                // 使用者有可能更改 textbox 內容，所以存 textbox
                sw.WriteLine(txtTester.Text);
                if (txtProductNum.Text != string.Empty)
                {
                    sw.WriteLine("pn:" + txtProductNum.Text);
                }
                if (txtCoreSN.Text != string.Empty)         // SN ex:A145660000-1114
                {
                    sw.WriteLine("c:" + swCoreSN);
                }
                if (txtLanSN.Text != string.Empty)
                {
                    sw.WriteLine("l:" + swLanSN);
                }
                if (txtUartSN.Text != string.Empty)
                {
                    sw.WriteLine("u:" + swUartSN);
                }
                if (txtSerial1SN.Text != string.Empty)
                {
                    sw.WriteLine("s1:" + swSerial1SN);
                }
                if (txtSerial2SN.Text != string.Empty)
                {
                    sw.WriteLine("s2:" + swSerial2SN);
                }
                if (txtSerial3SN.Text != string.Empty)
                {
                    sw.WriteLine("s3:" + swSerial3SN);
                }
                if (txtSerial4SN.Text != string.Empty)
                {
                    sw.WriteLine("s4:" + swSerial4SN);
                }
                //sw.Close();
            }

            InputBox_FormClosed(null, null);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CancelButton = true;
            InputBox_FormClosed(null, null);
        }

        private void InputBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txtTester_TextChanged(object sender, EventArgs e)
        {
            tester = txtTester.Text;
        }

        private void txtProductNum_TextChanged(object sender, EventArgs e)
        {
            productNum = txtProductNum.Text;
        }

        private void txtCoreSN_TextChanged(object sender, EventArgs e)
        {
            coreSN = txtCoreSN.Text;
        }

        private void txtLanSN_TextChanged(object sender, EventArgs e)
        {
            lanSN = txtLanSN.Text;
        }

        private void txtUartSN_TextChanged(object sender, EventArgs e)
        {
            uartSN = txtUartSN.Text;
        }

        private void txtSerial1SN_TextChanged(object sender, EventArgs e)
        {
            serial1SN = txtSerial1SN.Text;
        }

        private void txtSerial2SN_TextChanged(object sender, EventArgs e)
        {
            serial2SN = txtSerial2SN.Text;
        }

        private void txtSerial3SN_TextChanged(object sender, EventArgs e)
        {
            serial3SN = txtSerial3SN.Text;
        }

        private void txtSerial4SN_TextChanged(object sender, EventArgs e)
        {
            serial4SN = txtSerial4SN.Text;
        }

        private void chkcoreEnable_Click(object sender, EventArgs e)
        {
            if (chkcoreEnable.Checked)
            {
                txtCoreSN.Enabled = true;
            }
            else
            {
                txtCoreSN.Enabled = false;
                txtCoreSN.Text = string.Empty;
            }
        }

        private void chklanEnable_Click(object sender, EventArgs e)
        {
            if (chklanEnable.Checked)
            {
                txtLanSN.Enabled = true;
            }
            else
            {
                txtLanSN.Enabled = false;
                txtLanSN.Text = string.Empty;
            }
        }

        private void chkuartEnable_Click(object sender, EventArgs e)
        {
            if (chkuartEnable.Checked)
            {
                txtUartSN.Enabled = true;
            }
            else
            {
                txtUartSN.Enabled = false;
                txtUartSN.Text = string.Empty;
            }
        }

        private void chkserial1Enable_Click(object sender, EventArgs e)
        {
            if (chkserial1Enable.Checked)
            {
                txtSerial1SN.Enabled = true;
            }
            else
            {
                txtSerial1SN.Enabled = false;
                txtSerial1SN.Text = string.Empty;
            }
        }

        private void chkserial2Enable_Click(object sender, EventArgs e)
        {
            if (chkserial2Enable.Checked)
            {
                txtSerial2SN.Enabled = true;
            }
            else
            {
                txtSerial2SN.Enabled = false;
                txtSerial2SN.Text = string.Empty;
            }
        }

        private void chkserial3Enable_Click(object sender, EventArgs e)
        {
            if (chkserial3Enable.Checked)
            {
                txtSerial3SN.Enabled = true;
            }
            else
            {
                txtSerial3SN.Enabled = false;
                txtSerial3SN.Text = string.Empty;
            }
        }

        private void chkserial4Enable_Click(object sender, EventArgs e)
        {
            if (chkserial4Enable.Checked)
            {
                txtSerial4SN.Enabled = true;
            }
            else
            {
                txtSerial4SN.Enabled = false;
                txtSerial4SN.Text = string.Empty;
            }
        }
    }
}