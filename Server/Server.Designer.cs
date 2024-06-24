using System;
using System.Windows.Forms;

namespace Server
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.startButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AllowSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FlashStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.labelIntenetStatus = new System.Windows.Forms.Label();
            this.labelFlash = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxSites = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameSites = new System.Windows.Forms.TextBox();
            this.textBoxListSites = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 13);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 28);
            this.startButton.TabIndex = 23;
            this.startButton.TabStop = false;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Location = new System.Drawing.Point(410, 21);
            this.portLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(35, 13);
            this.portLabel.TabIndex = 22;
            this.portLabel.Text = "Порт:";
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.BackColor = System.Drawing.Color.Transparent;
            this.localaddrLabel.Location = new System.Drawing.Point(210, 21);
            this.localaddrLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(41, 13);
            this.localaddrLabel.TabIndex = 21;
            this.localaddrLabel.Text = "Адрес:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(447, 18);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.MaxLength = 10;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(132, 20);
            this.portTextBox.TabIndex = 20;
            this.portTextBox.TabStop = false;
            this.portTextBox.Text = "7000";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logTextBox.Location = new System.Drawing.Point(13, 159);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(566, 300);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(13, 123);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 28);
            this.clearButton.TabIndex = 25;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(463, 123);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(116, 28);
            this.disconnectButton.TabIndex = 26;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.Text = "Отключить все";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(13, 488);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendTextBox.Size = new System.Drawing.Size(566, 20);
            this.sendTextBox.TabIndex = 27;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendLabel.Location = new System.Drawing.Point(10, 467);
            this.sendLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(116, 13);
            this.sendLabel.TabIndex = 28;
            this.sendLabel.Text = "Отправка сообщения";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.Location = new System.Drawing.Point(284, 138);
            this.logLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 13);
            this.logLabel.TabIndex = 29;
            this.logLabel.Text = "Логи";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToResizeColumns = false;
            this.clientsDataGridView.AllowUserToResizeRows = false;
            this.clientsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.ColumnHeadersHeight = 24;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.IP,
            this.dc,
            this.AllowSite,
            this.Status,
            this.AddRule,
            this.DeleteRule,
            this.FlashStatus});
            this.clientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.clientsDataGridView.EnableHeadersVisualStyles = false;
            this.clientsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clientsDataGridView.Location = new System.Drawing.Point(587, 13);
            this.clientsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidth = 40;
            this.clientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.RowTemplate.ReadOnly = true;
            this.clientsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.ShowCellErrors = false;
            this.clientsDataGridView.ShowCellToolTips = false;
            this.clientsDataGridView.ShowEditingIcon = false;
            this.clientsDataGridView.ShowRowErrors = false;
            this.clientsDataGridView.Size = new System.Drawing.Size(1042, 495);
            this.clientsDataGridView.TabIndex = 30;
            this.clientsDataGridView.TabStop = false;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellClick);
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            this.clientsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.clientsDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // identifier
            // 
            this.identifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.identifier.HeaderText = "ID";
            this.identifier.MaxInputLength = 20;
            this.identifier.MinimumWidth = 20;
            this.identifier.Name = "identifier";
            this.identifier.Width = 30;
            // 
            // IP
            // 
            this.IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IP.DefaultCellStyle = dataGridViewCellStyle3;
            this.IP.HeaderText = "IP";
            this.IP.MaxInputLength = 20;
            this.IP.MinimumWidth = 20;
            this.IP.Name = "IP";
            this.IP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dc
            // 
            this.dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dc.HeaderText = "Встав. из сп.";
            this.dc.MinimumWidth = 20;
            this.dc.Name = "dc";
            this.dc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.Text = "Вставить";
            this.dc.UseColumnTextForButtonValue = true;
            this.dc.Width = 80;
            // 
            // AllowSite
            // 
            this.AllowSite.HeaderText = "Разрешённые сайты";
            this.AllowSite.Name = "AllowSite";
            this.AllowSite.Width = 350;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // AddRule
            // 
            this.AddRule.HeaderText = "Доб. сайты";
            this.AddRule.Name = "AddRule";
            this.AddRule.Text = "Добавить";
            this.AddRule.UseColumnTextForButtonValue = true;
            // 
            // DeleteRule
            // 
            this.DeleteRule.HeaderText = "Откл. сайты";
            this.DeleteRule.Name = "DeleteRule";
            this.DeleteRule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteRule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteRule.Text = "Отключить";
            this.DeleteRule.UseColumnTextForButtonValue = true;
            // 
            // FlashStatus
            // 
            this.FlashStatus.HeaderText = "Флешки";
            this.FlashStatus.Items.AddRange(new object[] {
            "По умолчанию",
            "Запрещено",
            "Разрешено"});
            this.FlashStatus.Name = "FlashStatus";
            this.FlashStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlashStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(1710, 516);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(204, 15);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Подключённых компьютеров: 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Location = new System.Drawing.Point(210, 49);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(32, 13);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Имя:";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(266, 46);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 20);
            this.usernameTextBox.TabIndex = 34;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.Text = "Server";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(266, 18);
            this.addrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addrTextBox.MaxLength = 200;
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(132, 20);
            this.addrTextBox.TabIndex = 37;
            this.addrTextBox.TabStop = false;
            this.addrTextBox.Text = "172.19.2.63";
            this.addrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 43;
            this.button1.Text = "Запретить доступ в интернет на всех компьютерах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 43);
            this.button2.TabIndex = 44;
            this.button2.Text = "Запретить подключение флеш-накопителей на всех комьютерах";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 40);
            this.button3.TabIndex = 45;
            this.button3.Text = "Разрешить доступ в интернет на всех компьютерах";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 40);
            this.button4.TabIndex = 46;
            this.button4.Text = "Разрешить подключение флеш-накопителей на всех компьютерах";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(473, 563);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 86);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Разрешённые сайты для всех компьютеров:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(775, 591);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 54);
            this.button5.TabIndex = 49;
            this.button5.Text = "Заблокировать интернет на всех компьютерах, кроме разрешённых сайтов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelIntenetStatus
            // 
            this.labelIntenetStatus.Location = new System.Drawing.Point(13, 701);
            this.labelIntenetStatus.Name = "labelIntenetStatus";
            this.labelIntenetStatus.Size = new System.Drawing.Size(432, 43);
            this.labelIntenetStatus.TabIndex = 50;
            this.labelIntenetStatus.Text = "Интернет разрешён";
            // 
            // labelFlash
            // 
            this.labelFlash.AutoSize = true;
            this.labelFlash.Location = new System.Drawing.Point(584, 701);
            this.labelFlash.Name = "labelFlash";
            this.labelFlash.Size = new System.Drawing.Size(161, 13);
            this.labelFlash.TabIndex = 51;
            this.labelFlash.Text = "Флеш-накопители разрешены";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(910, 531);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 42);
            this.button6.TabIndex = 53;
            this.button6.Text = "Добавить в разрешённые";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxSites
            // 
            this.listBoxSites.FormattingEnabled = true;
            this.listBoxSites.Location = new System.Drawing.Point(1007, 520);
            this.listBoxSites.Name = "listBoxSites";
            this.listBoxSites.Size = new System.Drawing.Size(333, 121);
            this.listBoxSites.TabIndex = 52;
            this.listBoxSites.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1004, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1004, 691);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Сайты:";
            // 
            // textBoxNameSites
            // 
            this.textBoxNameSites.Location = new System.Drawing.Point(1070, 654);
            this.textBoxNameSites.Name = "textBoxNameSites";
            this.textBoxNameSites.Size = new System.Drawing.Size(270, 20);
            this.textBoxNameSites.TabIndex = 56;
            // 
            // textBoxListSites
            // 
            this.textBoxListSites.Location = new System.Drawing.Point(1045, 688);
            this.textBoxListSites.Name = "textBoxListSites";
            this.textBoxListSites.Size = new System.Drawing.Size(295, 20);
            this.textBoxListSites.TabIndex = 57;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1219, 721);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 23);
            this.button7.TabIndex = 58;
            this.button7.Text = "Добавить в список";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1070, 721);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 23);
            this.button8.TabIndex = 59;
            this.button8.Text = "Удалить из списка";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 676);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Статус интернета:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(584, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Статус флеш-накопителей:";
            // 
            // Server
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1684, 756);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxListSites);
            this.Controls.Add(this.textBoxNameSites);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBoxSites);
            this.Controls.Add(this.labelFlash);
            this.Controls.Add(this.labelIntenetStatus);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.localaddrLabel);
            this.Controls.Add(this.portTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервер файерволл";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label labelIntenetStatus;
        private System.Windows.Forms.Label labelFlash;
        private Button button6;
        private ListBox listBoxSites;
        private Label label2;
        private Label label3;
        private TextBox textBoxNameSites;
        private TextBox textBoxListSites;
        private Button button7;
        private Button button8;
        private DataGridViewTextBoxColumn identifier;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewButtonColumn dc;
        private DataGridViewTextBoxColumn AllowSite;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn AddRule;
        private DataGridViewButtonColumn DeleteRule;
        private DataGridViewComboBoxColumn FlashStatus;
        private Label label4;
        private Label label5;
    }
}

