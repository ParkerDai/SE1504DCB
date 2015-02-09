namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectALL = new System.Windows.Forms.ToolStripMenuItem();
            this.執行TFTPServer = new System.Windows.Forms.ToolStripMenuItem();
            this.內網測試環境建置 = new System.Windows.Forms.ToolStripMenuItem();
            this.chkLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視 = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugMode = new System.Windows.Forms.ToolStripMenuItem();
            this.chkHumanSkip = new System.Windows.Forms.ToolStripMenuItem();
            this.終端機指令 = new System.Windows.Forms.ToolStripMenuItem();
            this.秀出jffs2內容 = new System.Windows.Forms.ToolStripMenuItem();
            this.磁碟空間使用情況ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.當前系統運行的程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEutIP = new System.Windows.Forms.TextBox();
            this.cmbEutCom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDutIP = new System.Windows.Forms.TextBox();
            this.cmbDutCom = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.start_Command2 = new System.Windows.Forms.Button();
            this.start_Command1 = new System.Windows.Forms.Button();
            this.lbl_mac8 = new System.Windows.Forms.Label();
            this.txt_mac8 = new System.Windows.Forms.TextBox();
            this.lbl_access8 = new System.Windows.Forms.Label();
            this.lbl_mac7 = new System.Windows.Forms.Label();
            this.txt_mac7 = new System.Windows.Forms.TextBox();
            this.lbl_access7 = new System.Windows.Forms.Label();
            this.lbl_mac6 = new System.Windows.Forms.Label();
            this.txt_mac6 = new System.Windows.Forms.TextBox();
            this.lbl_access6 = new System.Windows.Forms.Label();
            this.lbl_mac5 = new System.Windows.Forms.Label();
            this.txt_mac5 = new System.Windows.Forms.TextBox();
            this.lbl_access5 = new System.Windows.Forms.Label();
            this.lbl_mac4 = new System.Windows.Forms.Label();
            this.txt_mac4 = new System.Windows.Forms.TextBox();
            this.lbl_access4 = new System.Windows.Forms.Label();
            this.lbl_mac3 = new System.Windows.Forms.Label();
            this.txt_mac3 = new System.Windows.Forms.TextBox();
            this.lbl_access3 = new System.Windows.Forms.Label();
            this.lbl_mac2 = new System.Windows.Forms.Label();
            this.txt_mac2 = new System.Windows.Forms.TextBox();
            this.lbl_mac1 = new System.Windows.Forms.Label();
            this.txt_mac1 = new System.Windows.Forms.TextBox();
            this.lbl_access2 = new System.Windows.Forms.Label();
            this.lbl_access1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbl_cmdTag = new System.Windows.Forms.Label();
            this.cmdOpeFile = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1_splitContainer1_reght = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2_Console = new System.Windows.Forms.Panel();
            this.txt_Rx = new System.Windows.Forms.TextBox();
            this.txt_Tx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3_Results = new System.Windows.Forms.Panel();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.composingTmr = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.從這個測項開始測試ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.無限次測試這個測項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用Putty開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.enterTmr = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1_splitContainer1_reght.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2_Console.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3_Results.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定,
            this.檢視,
            this.關於ToolStripMenuItem,
            this.debugMode,
            this.終端機指令});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定
            // 
            this.設定.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectALL,
            this.執行TFTPServer,
            this.內網測試環境建置,
            this.chkLoop});
            this.設定.Name = "設定";
            this.設定.Size = new System.Drawing.Size(43, 20);
            this.設定.Text = "設定";
            // 
            // disconnectALL
            // 
            this.disconnectALL.Name = "disconnectALL";
            this.disconnectALL.Size = new System.Drawing.Size(226, 22);
            this.disconnectALL.Text = "結束Console以及Telnet的連線";
            this.disconnectALL.Click += new System.EventHandler(this.disconnectALL_Click);
            // 
            // 執行TFTPServer
            // 
            this.執行TFTPServer.Name = "執行TFTPServer";
            this.執行TFTPServer.Size = new System.Drawing.Size(226, 22);
            this.執行TFTPServer.Text = "執行 TFTPServer";
            this.執行TFTPServer.Click += new System.EventHandler(this.執行TFTPServer_Click);
            // 
            // 內網測試環境建置
            // 
            this.內網測試環境建置.Name = "內網測試環境建置";
            this.內網測試環境建置.Size = new System.Drawing.Size(226, 22);
            this.內網測試環境建置.Text = "內網測試環境建置";
            this.內網測試環境建置.Click += new System.EventHandler(this.內網測試環境建置_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.CheckOnClick = true;
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(226, 22);
            this.chkLoop.Text = "無限次全程迴圈測試";
            // 
            // 檢視
            // 
            this.檢視.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.開啟Monitor});
            this.檢視.Name = "檢視";
            this.檢視.Size = new System.Drawing.Size(43, 20);
            this.檢視.Text = "檢視";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Checked = true;
            this.consoleToolStripMenuItem.CheckOnClick = true;
            this.consoleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.consoleToolStripMenuItem_CheckStateChanged);
            // 
            // 開啟Monitor
            // 
            this.開啟Monitor.Name = "開啟Monitor";
            this.開啟Monitor.Size = new System.Drawing.Size(152, 22);
            this.開啟Monitor.Text = "開啟 Monitor";
            this.開啟Monitor.Click += new System.EventHandler(this.開啟Monitor_Click);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本ToolStripMenuItem});
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Visible = false;
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // debugMode
            // 
            this.debugMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkHumanSkip});
            this.debugMode.Name = "debugMode";
            this.debugMode.Size = new System.Drawing.Size(79, 20);
            this.debugMode.Text = "Debug Mode";
            this.debugMode.Visible = false;
            // 
            // chkHumanSkip
            // 
            this.chkHumanSkip.CheckOnClick = true;
            this.chkHumanSkip.Name = "chkHumanSkip";
            this.chkHumanSkip.Size = new System.Drawing.Size(146, 22);
            this.chkHumanSkip.Text = "人工確認略過";
            // 
            // 終端機指令
            // 
            this.終端機指令.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.秀出jffs2內容,
            this.磁碟空間使用情況ToolStripMenuItem,
            this.當前系統運行的程序ToolStripMenuItem});
            this.終端機指令.Enabled = false;
            this.終端機指令.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.終端機指令.Name = "終端機指令";
            this.終端機指令.Size = new System.Drawing.Size(99, 20);
            this.終端機指令.Text = "DUT終端機指令";
            this.終端機指令.ToolTipText = "必須先連線待測物Console";
            // 
            // 秀出jffs2內容
            // 
            this.秀出jffs2內容.Name = "秀出jffs2內容";
            this.秀出jffs2內容.Size = new System.Drawing.Size(201, 22);
            this.秀出jffs2內容.Text = "秀出/jffs2/內容(ls)";
            this.秀出jffs2內容.Click += new System.EventHandler(this.列出jffs2內容_Click);
            // 
            // 磁碟空間使用情況ToolStripMenuItem
            // 
            this.磁碟空間使用情況ToolStripMenuItem.Name = "磁碟空間使用情況ToolStripMenuItem";
            this.磁碟空間使用情況ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.磁碟空間使用情況ToolStripMenuItem.Text = "磁碟空間使用情況(df)";
            this.磁碟空間使用情況ToolStripMenuItem.Click += new System.EventHandler(this.磁碟空間使用情況ToolStripMenuItem_Click);
            // 
            // 當前系統運行的程序ToolStripMenuItem
            // 
            this.當前系統運行的程序ToolStripMenuItem.Name = "當前系統運行的程序ToolStripMenuItem";
            this.當前系統運行的程序ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.當前系統運行的程序ToolStripMenuItem.Text = "當前系統運行的程序(ps)";
            this.當前系統運行的程序ToolStripMenuItem.Click += new System.EventHandler(this.當前系統運行的程序ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdNext);
            this.splitContainer1.Panel1.Controls.Add(this.cmdStop);
            this.splitContainer1.Panel1.Controls.Add(this.cmdStart);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cmdTag);
            this.splitContainer1.Panel1.Controls.Add(this.cmdOpeFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1_splitContainer1_reght);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 616);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 1;
            // 
            // cmdNext
            // 
            this.cmdNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNext.Location = new System.Drawing.Point(439, 48);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 30);
            this.cmdNext.TabIndex = 22;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStop.Location = new System.Drawing.Point(358, 84);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 30);
            this.cmdStop.TabIndex = 21;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(358, 48);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 30);
            this.cmdStart.TabIndex = 20;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEutIP);
            this.groupBox3.Controls.Add(this.cmbEutCom);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(126, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 39);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(84, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "IP:";
            // 
            // txtEutIP
            // 
            this.txtEutIP.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEutIP.Location = new System.Drawing.Point(108, 12);
            this.txtEutIP.MaxLength = 15;
            this.txtEutIP.Name = "txtEutIP";
            this.txtEutIP.Size = new System.Drawing.Size(115, 22);
            this.txtEutIP.TabIndex = 3;
            this.txtEutIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEutIP.TextChanged += new System.EventHandler(this.txtEutIP_TextChanged);
            // 
            // cmbEutCom
            // 
            this.cmbEutCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEutCom.Enabled = false;
            this.cmbEutCom.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbEutCom.FormattingEnabled = true;
            this.cmbEutCom.Location = new System.Drawing.Point(6, 13);
            this.cmbEutCom.Name = "cmbEutCom";
            this.cmbEutCom.Size = new System.Drawing.Size(72, 20);
            this.cmbEutCom.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDutIP);
            this.groupBox2.Controls.Add(this.cmbDutCom);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(126, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 39);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(84, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "IP:";
            // 
            // txtDutIP
            // 
            this.txtDutIP.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDutIP.Location = new System.Drawing.Point(108, 11);
            this.txtDutIP.MaxLength = 15;
            this.txtDutIP.Name = "txtDutIP";
            this.txtDutIP.Size = new System.Drawing.Size(115, 22);
            this.txtDutIP.TabIndex = 1;
            this.txtDutIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDutIP.TextChanged += new System.EventHandler(this.txtDutIP_TextChanged);
            // 
            // cmbDutCom
            // 
            this.cmbDutCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDutCom.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbDutCom.FormattingEnabled = true;
            this.cmbDutCom.Location = new System.Drawing.Point(6, 13);
            this.cmbDutCom.Name = "cmbDutCom";
            this.cmbDutCom.Size = new System.Drawing.Size(72, 20);
            this.cmbDutCom.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Font = new System.Drawing.Font("細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl2.Location = new System.Drawing.Point(3, 125);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(521, 463);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.start_Command2);
            this.tabPage4.Controls.Add(this.start_Command1);
            this.tabPage4.Controls.Add(this.lbl_mac8);
            this.tabPage4.Controls.Add(this.txt_mac8);
            this.tabPage4.Controls.Add(this.lbl_access8);
            this.tabPage4.Controls.Add(this.lbl_mac7);
            this.tabPage4.Controls.Add(this.txt_mac7);
            this.tabPage4.Controls.Add(this.lbl_access7);
            this.tabPage4.Controls.Add(this.lbl_mac6);
            this.tabPage4.Controls.Add(this.txt_mac6);
            this.tabPage4.Controls.Add(this.lbl_access6);
            this.tabPage4.Controls.Add(this.lbl_mac5);
            this.tabPage4.Controls.Add(this.txt_mac5);
            this.tabPage4.Controls.Add(this.lbl_access5);
            this.tabPage4.Controls.Add(this.lbl_mac4);
            this.tabPage4.Controls.Add(this.txt_mac4);
            this.tabPage4.Controls.Add(this.lbl_access4);
            this.tabPage4.Controls.Add(this.lbl_mac3);
            this.tabPage4.Controls.Add(this.txt_mac3);
            this.tabPage4.Controls.Add(this.lbl_access3);
            this.tabPage4.Controls.Add(this.lbl_mac2);
            this.tabPage4.Controls.Add(this.txt_mac2);
            this.tabPage4.Controls.Add(this.lbl_mac1);
            this.tabPage4.Controls.Add(this.txt_mac1);
            this.tabPage4.Controls.Add(this.lbl_access2);
            this.tabPage4.Controls.Add(this.lbl_access1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 435);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "出廠設定";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // start_Command2
            // 
            this.start_Command2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.start_Command2.Enabled = false;
            this.start_Command2.Font = new System.Drawing.Font("細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start_Command2.Location = new System.Drawing.Point(374, 139);
            this.start_Command2.Name = "start_Command2";
            this.start_Command2.Size = new System.Drawing.Size(130, 70);
            this.start_Command2.TabIndex = 77;
            this.start_Command2.Tag = "1";
            this.start_Command2.Text = "初次\r\n出廠設定";
            this.start_Command2.UseVisualStyleBackColor = false;
            this.start_Command2.Click += new System.EventHandler(this.start_Command1_Click);
            // 
            // start_Command1
            // 
            this.start_Command1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.start_Command1.Enabled = false;
            this.start_Command1.Font = new System.Drawing.Font("細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start_Command1.Location = new System.Drawing.Point(374, 63);
            this.start_Command1.Name = "start_Command1";
            this.start_Command1.Size = new System.Drawing.Size(130, 70);
            this.start_Command1.TabIndex = 76;
            this.start_Command1.Tag = "0";
            this.start_Command1.Text = "出廠設定\r\n(更新MAC)\r\n";
            this.start_Command1.UseVisualStyleBackColor = false;
            this.start_Command1.Click += new System.EventHandler(this.start_Command1_Click);
            // 
            // lbl_mac8
            // 
            this.lbl_mac8.AutoSize = true;
            this.lbl_mac8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac8.Location = new System.Drawing.Point(193, 253);
            this.lbl_mac8.Name = "lbl_mac8";
            this.lbl_mac8.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac8.TabIndex = 75;
            this.lbl_mac8.Text = "00:60:E9:";
            // 
            // txt_mac8
            // 
            this.txt_mac8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac8.Location = new System.Drawing.Point(266, 251);
            this.txt_mac8.Name = "txt_mac8";
            this.txt_mac8.ReadOnly = true;
            this.txt_mac8.Size = new System.Drawing.Size(86, 25);
            this.txt_mac8.TabIndex = 74;
            // 
            // lbl_access8
            // 
            this.lbl_access8.AutoSize = true;
            this.lbl_access8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access8.Location = new System.Drawing.Point(8, 253);
            this.lbl_access8.Name = "lbl_access8";
            this.lbl_access8.Size = new System.Drawing.Size(179, 19);
            this.lbl_access8.TabIndex = 73;
            this.lbl_access8.Text = "將設定 MAC address 8 :";
            // 
            // lbl_mac7
            // 
            this.lbl_mac7.AutoSize = true;
            this.lbl_mac7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac7.Location = new System.Drawing.Point(193, 222);
            this.lbl_mac7.Name = "lbl_mac7";
            this.lbl_mac7.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac7.TabIndex = 72;
            this.lbl_mac7.Text = "00:60:E9:";
            // 
            // txt_mac7
            // 
            this.txt_mac7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac7.Location = new System.Drawing.Point(266, 220);
            this.txt_mac7.Name = "txt_mac7";
            this.txt_mac7.ReadOnly = true;
            this.txt_mac7.Size = new System.Drawing.Size(86, 25);
            this.txt_mac7.TabIndex = 71;
            // 
            // lbl_access7
            // 
            this.lbl_access7.AutoSize = true;
            this.lbl_access7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access7.Location = new System.Drawing.Point(8, 222);
            this.lbl_access7.Name = "lbl_access7";
            this.lbl_access7.Size = new System.Drawing.Size(179, 19);
            this.lbl_access7.TabIndex = 70;
            this.lbl_access7.Text = "將設定 MAC address 7 :";
            // 
            // lbl_mac6
            // 
            this.lbl_mac6.AutoSize = true;
            this.lbl_mac6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac6.Location = new System.Drawing.Point(193, 191);
            this.lbl_mac6.Name = "lbl_mac6";
            this.lbl_mac6.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac6.TabIndex = 69;
            this.lbl_mac6.Text = "00:60:E9:";
            // 
            // txt_mac6
            // 
            this.txt_mac6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac6.Location = new System.Drawing.Point(266, 189);
            this.txt_mac6.Name = "txt_mac6";
            this.txt_mac6.ReadOnly = true;
            this.txt_mac6.Size = new System.Drawing.Size(86, 25);
            this.txt_mac6.TabIndex = 68;
            // 
            // lbl_access6
            // 
            this.lbl_access6.AutoSize = true;
            this.lbl_access6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access6.Location = new System.Drawing.Point(8, 191);
            this.lbl_access6.Name = "lbl_access6";
            this.lbl_access6.Size = new System.Drawing.Size(179, 19);
            this.lbl_access6.TabIndex = 67;
            this.lbl_access6.Text = "將設定 MAC address 6 :";
            // 
            // lbl_mac5
            // 
            this.lbl_mac5.AutoSize = true;
            this.lbl_mac5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac5.Location = new System.Drawing.Point(193, 160);
            this.lbl_mac5.Name = "lbl_mac5";
            this.lbl_mac5.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac5.TabIndex = 66;
            this.lbl_mac5.Text = "00:60:E9:";
            // 
            // txt_mac5
            // 
            this.txt_mac5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac5.Location = new System.Drawing.Point(266, 158);
            this.txt_mac5.Name = "txt_mac5";
            this.txt_mac5.ReadOnly = true;
            this.txt_mac5.Size = new System.Drawing.Size(86, 25);
            this.txt_mac5.TabIndex = 65;
            // 
            // lbl_access5
            // 
            this.lbl_access5.AutoSize = true;
            this.lbl_access5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access5.Location = new System.Drawing.Point(8, 160);
            this.lbl_access5.Name = "lbl_access5";
            this.lbl_access5.Size = new System.Drawing.Size(179, 19);
            this.lbl_access5.TabIndex = 64;
            this.lbl_access5.Text = "將設定 MAC address 5 :";
            // 
            // lbl_mac4
            // 
            this.lbl_mac4.AutoSize = true;
            this.lbl_mac4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac4.Location = new System.Drawing.Point(193, 129);
            this.lbl_mac4.Name = "lbl_mac4";
            this.lbl_mac4.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac4.TabIndex = 63;
            this.lbl_mac4.Text = "00:60:E9:";
            // 
            // txt_mac4
            // 
            this.txt_mac4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac4.Location = new System.Drawing.Point(266, 127);
            this.txt_mac4.Name = "txt_mac4";
            this.txt_mac4.ReadOnly = true;
            this.txt_mac4.Size = new System.Drawing.Size(86, 25);
            this.txt_mac4.TabIndex = 62;
            // 
            // lbl_access4
            // 
            this.lbl_access4.AutoSize = true;
            this.lbl_access4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access4.Location = new System.Drawing.Point(8, 129);
            this.lbl_access4.Name = "lbl_access4";
            this.lbl_access4.Size = new System.Drawing.Size(179, 19);
            this.lbl_access4.TabIndex = 61;
            this.lbl_access4.Text = "將設定 MAC address 4 :";
            // 
            // lbl_mac3
            // 
            this.lbl_mac3.AutoSize = true;
            this.lbl_mac3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac3.Location = new System.Drawing.Point(193, 98);
            this.lbl_mac3.Name = "lbl_mac3";
            this.lbl_mac3.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac3.TabIndex = 60;
            this.lbl_mac3.Text = "00:60:E9:";
            // 
            // txt_mac3
            // 
            this.txt_mac3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac3.Location = new System.Drawing.Point(266, 96);
            this.txt_mac3.Name = "txt_mac3";
            this.txt_mac3.ReadOnly = true;
            this.txt_mac3.Size = new System.Drawing.Size(86, 25);
            this.txt_mac3.TabIndex = 59;
            // 
            // lbl_access3
            // 
            this.lbl_access3.AutoSize = true;
            this.lbl_access3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access3.Location = new System.Drawing.Point(8, 98);
            this.lbl_access3.Name = "lbl_access3";
            this.lbl_access3.Size = new System.Drawing.Size(179, 19);
            this.lbl_access3.TabIndex = 58;
            this.lbl_access3.Text = "將設定 MAC address 3 :";
            // 
            // lbl_mac2
            // 
            this.lbl_mac2.AutoSize = true;
            this.lbl_mac2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac2.Location = new System.Drawing.Point(193, 67);
            this.lbl_mac2.Name = "lbl_mac2";
            this.lbl_mac2.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac2.TabIndex = 57;
            this.lbl_mac2.Text = "00:60:E9:";
            // 
            // txt_mac2
            // 
            this.txt_mac2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mac2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mac2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac2.Location = new System.Drawing.Point(266, 65);
            this.txt_mac2.Name = "txt_mac2";
            this.txt_mac2.ReadOnly = true;
            this.txt_mac2.Size = new System.Drawing.Size(86, 25);
            this.txt_mac2.TabIndex = 56;
            // 
            // lbl_mac1
            // 
            this.lbl_mac1.AutoSize = true;
            this.lbl_mac1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac1.Location = new System.Drawing.Point(193, 30);
            this.lbl_mac1.Name = "lbl_mac1";
            this.lbl_mac1.Size = new System.Drawing.Size(67, 19);
            this.lbl_mac1.TabIndex = 55;
            this.lbl_mac1.Text = "00:60:E9:";
            // 
            // txt_mac1
            // 
            this.txt_mac1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_mac1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mac1.Location = new System.Drawing.Point(266, 28);
            this.txt_mac1.MaxLength = 6;
            this.txt_mac1.Name = "txt_mac1";
            this.txt_mac1.Size = new System.Drawing.Size(86, 25);
            this.txt_mac1.TabIndex = 54;
            this.txt_mac1.TextChanged += new System.EventHandler(this.txt_mac1_TextChanged);
            this.txt_mac1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mac1_KeyPress);
            // 
            // lbl_access2
            // 
            this.lbl_access2.AutoSize = true;
            this.lbl_access2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access2.Location = new System.Drawing.Point(8, 67);
            this.lbl_access2.Name = "lbl_access2";
            this.lbl_access2.Size = new System.Drawing.Size(179, 19);
            this.lbl_access2.TabIndex = 53;
            this.lbl_access2.Text = "將設定 MAC address 2 :";
            // 
            // lbl_access1
            // 
            this.lbl_access1.AutoSize = true;
            this.lbl_access1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_access1.Location = new System.Drawing.Point(8, 30);
            this.lbl_access1.Name = "lbl_access1";
            this.lbl_access1.Size = new System.Drawing.Size(179, 19);
            this.lbl_access1.TabIndex = 52;
            this.lbl_access1.Text = "請輸入 MAC address 1 :";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(513, 435);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "測試項目";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbl_cmdTag
            // 
            this.lbl_cmdTag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cmdTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_cmdTag.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmdTag.Location = new System.Drawing.Point(0, 591);
            this.lbl_cmdTag.Name = "lbl_cmdTag";
            this.lbl_cmdTag.Size = new System.Drawing.Size(523, 25);
            this.lbl_cmdTag.TabIndex = 8;
            // 
            // cmdOpeFile
            // 
            this.cmdOpeFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpeFile.Location = new System.Drawing.Point(7, 39);
            this.cmdOpeFile.Name = "cmdOpeFile";
            this.cmdOpeFile.Size = new System.Drawing.Size(116, 80);
            this.cmdOpeFile.TabIndex = 7;
            this.cmdOpeFile.Text = "檔案名稱";
            this.cmdOpeFile.UseVisualStyleBackColor = true;
            this.cmdOpeFile.Click += new System.EventHandler(this.cmdOpeFile_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(7, 9);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(513, 27);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "請選擇檔案名稱，開啟測試項目";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // panel1_splitContainer1_reght
            // 
            this.panel1_splitContainer1_reght.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1_splitContainer1_reght.Controls.Add(this.tabControl1);
            this.panel1_splitContainer1_reght.Location = new System.Drawing.Point(0, 0);
            this.panel1_splitContainer1_reght.Name = "panel1_splitContainer1_reght";
            this.panel1_splitContainer1_reght.Size = new System.Drawing.Size(506, 563);
            this.panel1_splitContainer1_reght.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 563);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2_Console);
            this.tabPage1.Controls.Add(this.txt_Tx);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2_Console
            // 
            this.panel2_Console.Controls.Add(this.txt_Rx);
            this.panel2_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_Console.Location = new System.Drawing.Point(3, 3);
            this.panel2_Console.Name = "panel2_Console";
            this.panel2_Console.Size = new System.Drawing.Size(492, 490);
            this.panel2_Console.TabIndex = 4;
            // 
            // txt_Rx
            // 
            this.txt_Rx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Rx.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Rx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rx.Location = new System.Drawing.Point(0, 0);
            this.txt_Rx.Multiline = true;
            this.txt_Rx.Name = "txt_Rx";
            this.txt_Rx.ReadOnly = true;
            this.txt_Rx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Rx.Size = new System.Drawing.Size(492, 471);
            this.txt_Rx.TabIndex = 1;
            this.txt_Rx.TextChanged += new System.EventHandler(this.txt_Rx_TextChanged);
            // 
            // txt_Tx
            // 
            this.txt_Tx.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_Tx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tx.ForeColor = System.Drawing.Color.Black;
            this.txt_Tx.Location = new System.Drawing.Point(3, 493);
            this.txt_Tx.Multiline = true;
            this.txt_Tx.Name = "txt_Tx";
            this.txt_Tx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Tx.Size = new System.Drawing.Size(492, 42);
            this.txt_Tx.TabIndex = 3;
            this.txt_Tx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tx_KeyDown);
            this.txt_Tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tx_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3_Results);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3_Results
            // 
            this.panel3_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3_Results.Controls.Add(this.txt_Note);
            this.panel3_Results.Location = new System.Drawing.Point(3, 3);
            this.panel3_Results.Name = "panel3_Results";
            this.panel3_Results.Size = new System.Drawing.Size(492, 527);
            this.panel3_Results.TabIndex = 0;
            // 
            // txt_Note
            // 
            this.txt_Note.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Note.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Note.Location = new System.Drawing.Point(0, 0);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ReadOnly = true;
            this.txt_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Note.Size = new System.Drawing.Size(492, 527);
            this.txt_Note.TabIndex = 2;
            this.txt_Note.TextChanged += new System.EventHandler(this.txt_Note_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(498, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSecret);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 563);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提示";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSecret.Location = new System.Drawing.Point(475, 15);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(31, 13);
            this.lblSecret.TabIndex = 18;
            this.lblSecret.Text = "        ";
            this.lblSecret.Click += new System.EventHandler(this.lblSecret_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(382, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "FAIL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label5, "2");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(289, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "設定錯誤";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "3");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(196, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "PASS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "1");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(103, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "測試中";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "未測試";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "0");
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // composingTmr
            // 
            this.composingTmr.Tick += new System.EventHandler(this.composingTmr_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.從這個測項開始測試ToolStripMenuItem,
            this.無限次測試這個測項ToolStripMenuItem,
            this.用Putty開啟ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 70);
            // 
            // 從這個測項開始測試ToolStripMenuItem
            // 
            this.從這個測項開始測試ToolStripMenuItem.Name = "從這個測項開始測試ToolStripMenuItem";
            this.從這個測項開始測試ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.從這個測項開始測試ToolStripMenuItem.Text = "從這個測項開始測試";
            this.從這個測項開始測試ToolStripMenuItem.Click += new System.EventHandler(this.從這個測項開始測試ToolStripMenuItem_Click);
            // 
            // 無限次測試這個測項ToolStripMenuItem
            // 
            this.無限次測試這個測項ToolStripMenuItem.Name = "無限次測試這個測項ToolStripMenuItem";
            this.無限次測試這個測項ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.無限次測試這個測項ToolStripMenuItem.Text = "無限次測試這個測項";
            this.無限次測試這個測項ToolStripMenuItem.Click += new System.EventHandler(this.無限次測試這個測項ToolStripMenuItem_Click);
            // 
            // 用Putty開啟ToolStripMenuItem
            // 
            this.用Putty開啟ToolStripMenuItem.Name = "用Putty開啟ToolStripMenuItem";
            this.用Putty開啟ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.用Putty開啟ToolStripMenuItem.Text = "用 Putty 開啟";
            this.用Putty開啟ToolStripMenuItem.Click += new System.EventHandler(this.用Putty開啟ToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // enterTmr
            // 
            this.enterTmr.Interval = 5000;
            this.enterTmr.Tick += new System.EventHandler(this.enterTmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE1504DCB (DCB4DTE)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1_splitContainer1_reght.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2_Console.ResumeLayout(false);
            this.panel2_Console.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3_Results.ResumeLayout(false);
            this.panel3_Results.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檢視;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdOpeFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_cmdTag;
        private System.Windows.Forms.Timer composingTmr;
        private System.Windows.Forms.Panel panel1_splitContainer1_reght;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Tx;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2_Console;
        private System.Windows.Forms.TextBox txt_Rx;
        private System.Windows.Forms.Panel panel3_Results;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 從這個測項開始測試ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 無限次測試這個測項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用Putty開啟ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button start_Command2;
        private System.Windows.Forms.Button start_Command1;
        public System.Windows.Forms.Label lbl_mac8;
        public System.Windows.Forms.TextBox txt_mac8;
        public System.Windows.Forms.Label lbl_access8;
        public System.Windows.Forms.Label lbl_mac7;
        public System.Windows.Forms.TextBox txt_mac7;
        public System.Windows.Forms.Label lbl_access7;
        public System.Windows.Forms.Label lbl_mac6;
        public System.Windows.Forms.TextBox txt_mac6;
        public System.Windows.Forms.Label lbl_access6;
        public System.Windows.Forms.Label lbl_mac5;
        public System.Windows.Forms.TextBox txt_mac5;
        public System.Windows.Forms.Label lbl_access5;
        public System.Windows.Forms.Label lbl_mac4;
        public System.Windows.Forms.TextBox txt_mac4;
        public System.Windows.Forms.Label lbl_access4;
        public System.Windows.Forms.Label lbl_mac3;
        public System.Windows.Forms.TextBox txt_mac3;
        public System.Windows.Forms.Label lbl_access3;
        public System.Windows.Forms.Label lbl_mac2;
        public System.Windows.Forms.TextBox txt_mac2;
        public System.Windows.Forms.Label lbl_mac1;
        public System.Windows.Forms.TextBox txt_mac1;
        public System.Windows.Forms.Label lbl_access2;
        public System.Windows.Forms.Label lbl_access1;
        private System.Windows.Forms.ToolStripMenuItem chkLoop;
        private System.Windows.Forms.ToolStripMenuItem debugMode;
        private System.Windows.Forms.ToolStripMenuItem chkHumanSkip;
        internal System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem disconnectALL;
        private System.Windows.Forms.ToolStripMenuItem 開啟Monitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDutIP;
        private System.Windows.Forms.ComboBox cmbDutCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEutIP;
        private System.Windows.Forms.ComboBox cmbEutCom;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Timer enterTmr;
        private System.Windows.Forms.ToolStripMenuItem 終端機指令;
        private System.Windows.Forms.ToolStripMenuItem 秀出jffs2內容;
        private System.Windows.Forms.ToolStripMenuItem 磁碟空間使用情況ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 當前系統運行的程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 執行TFTPServer;
        private System.Windows.Forms.ToolStripMenuItem 內網測試環境建置;
    }
}

