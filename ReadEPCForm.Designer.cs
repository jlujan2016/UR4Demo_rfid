namespace UHFAPP
{
    partial class ReadEPCForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUIFast = new System.Windows.Forms.CheckBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScanEPC = new System.Windows.Forms.Button();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rb5s = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb2s = new System.Windows.Forms.RadioButton();
            this.rb3s = new System.Windows.Forms.RadioButton();
            this.rb4s = new System.Windows.Forms.RadioButton();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRSSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filerLen = new System.Windows.Forms.TextBox();
            this.txtPtr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbEPC = new System.Windows.Forms.RadioButton();
            this.rbTID = new System.Windows.Forms.RadioButton();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderANT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(92, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgData);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 829);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbUIFast);
            this.panel2.Controls.Add(this.cmbFormat);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnScanEPC);
            this.panel2.Controls.Add(this.gbAuto);
            this.panel2.Location = new System.Drawing.Point(4, 643);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 183);
            this.panel2.TabIndex = 42;
            // 
            // cbUIFast
            // 
            this.cbUIFast.AutoSize = true;
            this.cbUIFast.Location = new System.Drawing.Point(793, 149);
            this.cbUIFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUIFast.Name = "cbUIFast";
            this.cbUIFast.Size = new System.Drawing.Size(200, 20);
            this.cbUIFast.TabIndex = 35;
            this.cbUIFast.Text = "Fast Inventory Mode Refresh";
            this.cbUIFast.UseVisualStyleBackColor = true;
            this.cbUIFast.Click += new System.EventHandler(this.cbUIFast_Click);
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "Hex",
            "Ascii",
            "Hex+Ascii"});
            this.cmbFormat.Location = new System.Drawing.Point(903, 24);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(181, 28);
            this.cmbFormat.TabIndex = 81;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(1141, 33);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(192, 64);
            this.btnExport.TabIndex = 39;
            this.btnExport.Text = "导出数据";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(789, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 80;
            this.label12.Text = "数据格式:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lto);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(335, 165);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "总次数:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(187, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "0";
            // 
            // lto
            // 
            this.lto.AutoSize = true;
            this.lto.BackColor = System.Drawing.Color.Transparent;
            this.lto.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lto.ForeColor = System.Drawing.Color.Black;
            this.lto.Location = new System.Drawing.Point(24, 48);
            this.lto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lto.Name = "lto";
            this.lto.Size = new System.Drawing.Size(123, 24);
            this.lto.TabIndex = 3;
            this.lto.Text = "标签张数:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(187, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 30);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(964, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 64);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScanEPC
            // 
            this.btnScanEPC.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScanEPC.Location = new System.Drawing.Point(793, 67);
            this.btnScanEPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScanEPC.Name = "btnScanEPC";
            this.btnScanEPC.Size = new System.Drawing.Size(124, 64);
            this.btnScanEPC.TabIndex = 0;
            this.btnScanEPC.Text = "Start";
            this.btnScanEPC.UseVisualStyleBackColor = true;
            this.btnScanEPC.Click += new System.EventHandler(this.btnScanEPC_Click);
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.label11);
            this.gbAuto.Controls.Add(this.txtTime);
            this.gbAuto.Controls.Add(this.rb10);
            this.gbAuto.Controls.Add(this.label10);
            this.gbAuto.Controls.Add(this.lblTime);
            this.gbAuto.Controls.Add(this.rb5s);
            this.gbAuto.Controls.Add(this.label2);
            this.gbAuto.Controls.Add(this.rb2s);
            this.gbAuto.Controls.Add(this.rb3s);
            this.gbAuto.Controls.Add(this.rb4s);
            this.gbAuto.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbAuto.Location = new System.Drawing.Point(347, 5);
            this.gbAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAuto.Size = new System.Drawing.Size(413, 165);
            this.gbAuto.TabIndex = 40;
            this.gbAuto.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "秒";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("SimSun", 12F);
            this.txtTime.Location = new System.Drawing.Point(131, 59);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(132, 30);
            this.txtTime.TabIndex = 5;
            this.txtTime.Text = "0";
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(315, 108);
            this.rb10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(70, 24);
            this.rb10.TabIndex = 4;
            this.rb10.TabStop = true;
            this.rb10.Text = "10秒";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.Click += new System.EventHandler(this.rb10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "盘点时间:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(129, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(23, 24);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "0";
            // 
            // rb5s
            // 
            this.rb5s.AutoSize = true;
            this.rb5s.Location = new System.Drawing.Point(240, 108);
            this.rb5s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb5s.Name = "rb5s";
            this.rb5s.Size = new System.Drawing.Size(60, 24);
            this.rb5s.TabIndex = 3;
            this.rb5s.TabStop = true;
            this.rb5s.Text = "5秒";
            this.rb5s.UseVisualStyleBackColor = true;
            this.rb5s.Click += new System.EventHandler(this.rb5s_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "时间:";
            // 
            // rb2s
            // 
            this.rb2s.AutoSize = true;
            this.rb2s.Location = new System.Drawing.Point(16, 108);
            this.rb2s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb2s.Name = "rb2s";
            this.rb2s.Size = new System.Drawing.Size(60, 24);
            this.rb2s.TabIndex = 0;
            this.rb2s.TabStop = true;
            this.rb2s.Text = "2秒";
            this.rb2s.UseVisualStyleBackColor = true;
            this.rb2s.Click += new System.EventHandler(this.rb2s_Click);
            // 
            // rb3s
            // 
            this.rb3s.AutoSize = true;
            this.rb3s.Location = new System.Drawing.Point(91, 108);
            this.rb3s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb3s.Name = "rb3s";
            this.rb3s.Size = new System.Drawing.Size(60, 24);
            this.rb3s.TabIndex = 2;
            this.rb3s.TabStop = true;
            this.rb3s.Text = "3秒";
            this.rb3s.UseVisualStyleBackColor = true;
            this.rb3s.Click += new System.EventHandler(this.rb3s_Click);
            // 
            // rb4s
            // 
            this.rb4s.AutoSize = true;
            this.rb4s.Location = new System.Drawing.Point(165, 108);
            this.rb4s.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb4s.Name = "rb4s";
            this.rb4s.Size = new System.Drawing.Size(60, 24);
            this.rb4s.TabIndex = 1;
            this.rb4s.TabStop = true;
            this.rb4s.Text = "4秒";
            this.rb4s.UseVisualStyleBackColor = true;
            this.rb4s.Click += new System.EventHandler(this.rb4s_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.epc,
            this.tid,
            this.user,
            this.cRSSI,
            this.count,
            this.ant});
            this.dgData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgData.Location = new System.Drawing.Point(0, 111);
            this.dgData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgData.RowTemplate.Height = 23;
            this.dgData.Size = new System.Drawing.Size(1463, 521);
            this.dgData.TabIndex = 76;
            this.dgData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // epc
            // 
            this.epc.HeaderText = "EPC";
            this.epc.MinimumWidth = 6;
            this.epc.Name = "epc";
            this.epc.Width = 250;
            // 
            // tid
            // 
            this.tid.HeaderText = "TID";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            this.tid.Width = 250;
            // 
            // user
            // 
            this.user.HeaderText = "USER";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.Width = 225;
            // 
            // cRSSI
            // 
            this.cRSSI.HeaderText = "RSSI";
            this.cRSSI.MinimumWidth = 6;
            this.cRSSI.Name = "cRSSI";
            this.cRSSI.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "COUNT";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 50;
            // 
            // ant
            // 
            this.ant.HeaderText = "ANT";
            this.ant.MinimumWidth = 6;
            this.ant.Name = "ant";
            this.ant.Width = 50;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.filerLen);
            this.groupBox8.Controls.Add(this.txtPtr);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.cbSave);
            this.groupBox8.Controls.Add(this.btnSet);
            this.groupBox8.Controls.Add(this.txtData);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(0, 4);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(1416, 99);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(595, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "0";
            // 
            // filerLen
            // 
            this.filerLen.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filerLen.Location = new System.Drawing.Point(908, 43);
            this.filerLen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filerLen.MaxLength = 4;
            this.filerLen.Name = "filerLen";
            this.filerLen.Size = new System.Drawing.Size(53, 30);
            this.filerLen.TabIndex = 34;
            this.filerLen.Tag = "Number";
            this.filerLen.Text = "0";
            this.filerLen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPtr
            // 
            this.txtPtr.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPtr.Location = new System.Drawing.Point(699, 39);
            this.txtPtr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPtr.MaxLength = 4;
            this.txtPtr.Name = "txtPtr";
            this.txtPtr.Size = new System.Drawing.Size(64, 30);
            this.txtPtr.TabIndex = 6;
            this.txtPtr.Tag = "Number";
            this.txtPtr.Text = "32";
            this.txtPtr.TextChanged += new System.EventHandler(this.txtPtr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(772, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "(bit)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(836, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "长度:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1312, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 32;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUser);
            this.groupBox1.Controls.Add(this.rbEPC);
            this.groupBox1.Controls.Add(this.rbTID);
            this.groupBox1.Location = new System.Drawing.Point(1035, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(241, 63);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bank";
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbUser.Location = new System.Drawing.Point(157, 27);
            this.rbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(70, 24);
            this.rbUser.TabIndex = 12;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.Click += new System.EventHandler(this.rbUser_Click);
            // 
            // rbEPC
            // 
            this.rbEPC.AutoSize = true;
            this.rbEPC.Checked = true;
            this.rbEPC.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbEPC.Location = new System.Drawing.Point(8, 25);
            this.rbEPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEPC.Name = "rbEPC";
            this.rbEPC.Size = new System.Drawing.Size(60, 24);
            this.rbEPC.TabIndex = 8;
            this.rbEPC.TabStop = true;
            this.rbEPC.Text = "EPC";
            this.rbEPC.UseVisualStyleBackColor = true;
            this.rbEPC.Click += new System.EventHandler(this.rbEPC_Click);
            // 
            // rbTID
            // 
            this.rbTID.AutoSize = true;
            this.rbTID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTID.Location = new System.Drawing.Point(83, 27);
            this.rbTID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTID.Name = "rbTID";
            this.rbTID.Size = new System.Drawing.Size(60, 24);
            this.rbTID.TabIndex = 9;
            this.rbTID.Text = "TID";
            this.rbTID.UseVisualStyleBackColor = true;
            this.rbTID.Click += new System.EventHandler(this.rbTID_Click);
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSave.Location = new System.Drawing.Point(1284, 49);
            this.cbSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(71, 24);
            this.cbSave.TabIndex = 11;
            this.cbSave.Text = "Save";
            this.cbSave.UseVisualStyleBackColor = true;
            this.cbSave.Visible = false;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(1312, 12);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(92, 39);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtData.Location = new System.Drawing.Point(67, 27);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(517, 53);
            this.txtData.TabIndex = 7;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(8, 40);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 20);
            this.label29.TabIndex = 5;
            this.label29.Text = "Data:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(640, 47);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 20);
            this.label30.TabIndex = 4;
            this.label30.Text = "Ptr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(971, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "(bit)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 50;
            // 
            // columnHeaderEPC
            // 
            this.columnHeaderEPC.Text = "EPC";
            this.columnHeaderEPC.Width = 270;
            // 
            // columnHeaderTID
            // 
            this.columnHeaderTID.Text = "TID";
            this.columnHeaderTID.Width = 270;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "USER";
            this.columnHeaderUser.Width = 270;
            // 
            // columnHeaderRssi
            // 
            this.columnHeaderRssi.Text = "Rssi";
            this.columnHeaderRssi.Width = 90;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Count";
            this.columnHeaderCount.Width = 80;
            // 
            // columnHeaderANT
            // 
            this.columnHeaderANT.Text = "ANT";
            this.columnHeaderANT.Width = 50;
            // 
            // ReadEPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1497, 845);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ReadEPCForm";
            this.Text = "ReadEPC";
            this.Activated += new System.EventHandler(this.ReadEPCForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanEPCForm_FormClosing);
            this.Load += new System.EventHandler(this.ScanEPCForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ReadEPCForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReadEPCForm_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScanEPC;
 
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderEPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.RadioButton rbTID;
        private System.Windows.Forms.RadioButton rbEPC;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPtr;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ColumnHeader columnHeaderTID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeaderRssi;
        private System.Windows.Forms.ColumnHeader columnHeaderCount;
        private System.Windows.Forms.CheckBox cbSave;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filerLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeaderANT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.RadioButton rb5s;
        private System.Windows.Forms.RadioButton rb3s;
        private System.Windows.Forms.RadioButton rb4s;
        private System.Windows.Forms.RadioButton rb2s;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn epc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRSSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ant;
        private System.Windows.Forms.CheckBox cbUIFast;
    }
}