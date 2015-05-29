/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 2013/11/24
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EasyLogin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.textName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textPsd = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.labelTotalFlow = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lableState = new System.Windows.Forms.Label();
			this.useFlow = new System.Windows.Forms.Label();
			this.labelTotalSchool = new System.Windows.Forms.Label();
			this.useSchool = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.labelMoney = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.cbRemember = new System.Windows.Forms.CheckBox();
			this.cbAutoLogin = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.rechargeLinkLabel = new System.Windows.Forms.LinkLabel();
			this.wifiTabPage = new System.Windows.Forms.TabPage();
			this.wifiState = new System.Windows.Forms.Label();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.shareBtn = new System.Windows.Forms.Button();
			this.netComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.wifiPsdText = new System.Windows.Forms.TextBox();
			this.wifiNameText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.weatherWebBrowser = new System.Windows.Forms.WebBrowser();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.schoolWebBrowser = new System.Windows.Forms.WebBrowser();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toqzone = new System.Windows.Forms.ToolStripMenuItem();
			this.toweibo = new System.Windows.Forms.ToolStripMenuItem();
			this.torenren = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.wifiTabPage.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Left;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(20, 327);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Visible = false;
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(150, 119);
			this.textName.MaxLength = 20;
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(143, 21);
			this.textName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "账号：";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(79, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "密码：";
			// 
			// textPsd
			// 
			this.textPsd.Location = new System.Drawing.Point(150, 166);
			this.textPsd.MaxLength = 20;
			this.textPsd.Name = "textPsd";
			this.textPsd.PasswordChar = '*';
			this.textPsd.Size = new System.Drawing.Size(143, 21);
			this.textPsd.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(82, 249);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(74, 30);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "登陆";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(162, 249);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(74, 30);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// labelTotalFlow
			// 
			this.labelTotalFlow.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalFlow.Location = new System.Drawing.Point(74, 10);
			this.labelTotalFlow.Name = "labelTotalFlow";
			this.labelTotalFlow.Size = new System.Drawing.Size(109, 16);
			this.labelTotalFlow.TabIndex = 7;
			// 
			// btnLogout
			// 
			this.btnLogout.AllowDrop = true;
			this.btnLogout.Location = new System.Drawing.Point(279, 249);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(74, 30);
			this.btnLogout.TabIndex = 8;
			this.btnLogout.Text = "下线";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.BtnLogoutClick);
			// 
			// lableState
			// 
			this.lableState.Location = new System.Drawing.Point(74, 223);
			this.lableState.Name = "lableState";
			this.lableState.Size = new System.Drawing.Size(266, 23);
			this.lableState.TabIndex = 9;
			// 
			// useFlow
			// 
			this.useFlow.ForeColor = System.Drawing.SystemColors.ControlText;
			this.useFlow.Location = new System.Drawing.Point(216, 10);
			this.useFlow.Name = "useFlow";
			this.useFlow.Size = new System.Drawing.Size(100, 16);
			this.useFlow.TabIndex = 10;
			// 
			// labelTotalSchool
			// 
			this.labelTotalSchool.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelTotalSchool.Location = new System.Drawing.Point(74, 26);
			this.labelTotalSchool.Name = "labelTotalSchool";
			this.labelTotalSchool.Size = new System.Drawing.Size(109, 17);
			this.labelTotalSchool.TabIndex = 11;
			// 
			// useSchool
			// 
			this.useSchool.ForeColor = System.Drawing.SystemColors.ControlText;
			this.useSchool.Location = new System.Drawing.Point(216, 26);
			this.useSchool.Name = "useSchool";
			this.useSchool.Size = new System.Drawing.Size(100, 17);
			this.useSchool.TabIndex = 12;
			// 
			// labelTime
			// 
			this.labelTime.Location = new System.Drawing.Point(74, 62);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(295, 15);
			this.labelTime.TabIndex = 13;
			// 
			// labelMoney
			// 
			this.labelMoney.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelMoney.Location = new System.Drawing.Point(74, 43);
			this.labelMoney.Name = "labelMoney";
			this.labelMoney.Size = new System.Drawing.Size(125, 13);
			this.labelMoney.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(283, 311);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "564923716@qq.com";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// labelIP
			// 
			this.labelIP.Location = new System.Drawing.Point(12, 311);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(157, 16);
			this.labelIP.TabIndex = 16;
			// 
			// cbRemember
			// 
			this.cbRemember.Location = new System.Drawing.Point(74, 201);
			this.cbRemember.Name = "cbRemember";
			this.cbRemember.Size = new System.Drawing.Size(81, 19);
			this.cbRemember.TabIndex = 17;
			this.cbRemember.Text = "记住密码";
			this.cbRemember.UseVisualStyleBackColor = true;
			// 
			// cbAutoLogin
			// 
			this.cbAutoLogin.Location = new System.Drawing.Point(196, 201);
			this.cbAutoLogin.Name = "cbAutoLogin";
			this.cbAutoLogin.Size = new System.Drawing.Size(97, 19);
			this.cbAutoLogin.TabIndex = 18;
			this.cbAutoLogin.Text = "自动登录";
			this.cbAutoLogin.UseVisualStyleBackColor = true;
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "EasyLogin-帮助您融入中南";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIconDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStripMenuItem1,
									this.ToolStripMenuItem2,
									this.ToolStripMenuItem13});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
			this.ToolStripMenuItem1.Text = "打开主界面";
			this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// ToolStripMenuItem2
			// 
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
			this.ToolStripMenuItem2.Text = "下线";
			this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// ToolStripMenuItem13
			// 
			this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
			this.ToolStripMenuItem13.Size = new System.Drawing.Size(136, 22);
			this.ToolStripMenuItem13.Text = "退出";
			this.ToolStripMenuItem13.Click += new System.EventHandler(this.ToolStripMenuItem13Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(395, 117);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.wifiTabPage);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(0, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(403, 311);
			this.tabControl1.TabIndex = 2;
			this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1Selecting);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.linkLabel2);
			this.tabPage1.Controls.Add(this.linkLabel1);
			this.tabPage1.Controls.Add(this.rechargeLinkLabel);
			this.tabPage1.Controls.Add(this.labelTime);
			this.tabPage1.Controls.Add(this.labelTotalFlow);
			this.tabPage1.Controls.Add(this.useFlow);
			this.tabPage1.Controls.Add(this.lableState);
			this.tabPage1.Controls.Add(this.labelTotalSchool);
			this.tabPage1.Controls.Add(this.cbAutoLogin);
			this.tabPage1.Controls.Add(this.useSchool);
			this.tabPage1.Controls.Add(this.cbRemember);
			this.tabPage1.Controls.Add(this.labelMoney);
			this.tabPage1.Controls.Add(this.textName);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textPsd);
			this.tabPage1.Controls.Add(this.btnReset);
			this.tabPage1.Controls.Add(this.btnLogout);
			this.tabPage1.Controls.Add(this.btnLogin);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(395, 285);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "登录";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(266, 89);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(55, 18);
			this.linkLabel2.TabIndex = 24;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "分享软件";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(182, 89);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(54, 18);
			this.linkLabel1.TabIndex = 23;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "教务系统";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// rechargeLinkLabel
			// 
			this.rechargeLinkLabel.Location = new System.Drawing.Point(102, 89);
			this.rechargeLinkLabel.Name = "rechargeLinkLabel";
			this.rechargeLinkLabel.Size = new System.Drawing.Size(53, 18);
			this.rechargeLinkLabel.TabIndex = 22;
			this.rechargeLinkLabel.TabStop = true;
			this.rechargeLinkLabel.Text = "缴费网站";
			this.rechargeLinkLabel.Visible = false;
			this.rechargeLinkLabel.VisitedLinkColor = System.Drawing.Color.Purple;
			this.rechargeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RechargeLinkLabelLinkClicked);
			// 
			// wifiTabPage
			// 
			this.wifiTabPage.Controls.Add(this.wifiState);
			this.wifiTabPage.Controls.Add(this.deleteBtn);
			this.wifiTabPage.Controls.Add(this.shareBtn);
			this.wifiTabPage.Controls.Add(this.netComboBox);
			this.wifiTabPage.Controls.Add(this.label6);
			this.wifiTabPage.Controls.Add(this.wifiPsdText);
			this.wifiTabPage.Controls.Add(this.wifiNameText);
			this.wifiTabPage.Controls.Add(this.label5);
			this.wifiTabPage.Controls.Add(this.label4);
			this.wifiTabPage.Location = new System.Drawing.Point(4, 22);
			this.wifiTabPage.Name = "wifiTabPage";
			this.wifiTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.wifiTabPage.Size = new System.Drawing.Size(395, 285);
			this.wifiTabPage.TabIndex = 3;
			this.wifiTabPage.Text = "无线分享";
			this.wifiTabPage.UseVisualStyleBackColor = true;
			// 
			// wifiState
			// 
			this.wifiState.Location = new System.Drawing.Point(134, 251);
			this.wifiState.Name = "wifiState";
			this.wifiState.Size = new System.Drawing.Size(101, 19);
			this.wifiState.TabIndex = 8;
			this.wifiState.Text = "wifi分享未开启";
			// 
			// deleteBtn
			// 
			this.deleteBtn.Enabled = false;
			this.deleteBtn.Location = new System.Drawing.Point(218, 201);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 7;
			this.deleteBtn.Text = "删除共享";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// shareBtn
			// 
			this.shareBtn.Location = new System.Drawing.Point(75, 201);
			this.shareBtn.Name = "shareBtn";
			this.shareBtn.Size = new System.Drawing.Size(75, 23);
			this.shareBtn.TabIndex = 6;
			this.shareBtn.Text = "创建共享";
			this.shareBtn.UseVisualStyleBackColor = true;
			this.shareBtn.Click += new System.EventHandler(this.ShareBtnClick);
			// 
			// netComboBox
			// 
			this.netComboBox.FormattingEnabled = true;
			this.netComboBox.Location = new System.Drawing.Point(199, 126);
			this.netComboBox.Name = "netComboBox";
			this.netComboBox.Size = new System.Drawing.Size(136, 20);
			this.netComboBox.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(50, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "要共享的网络连接：";
			// 
			// wifiPsdText
			// 
			this.wifiPsdText.Location = new System.Drawing.Point(199, 86);
			this.wifiPsdText.MaxLength = 16;
			this.wifiPsdText.Name = "wifiPsdText";
			this.wifiPsdText.Size = new System.Drawing.Size(136, 21);
			this.wifiPsdText.TabIndex = 3;
			this.wifiPsdText.Text = "1234567890";
			// 
			// wifiNameText
			// 
			this.wifiNameText.Location = new System.Drawing.Point(199, 49);
			this.wifiNameText.MaxLength = 20;
			this.wifiNameText.Name = "wifiNameText";
			this.wifiNameText.Size = new System.Drawing.Size(136, 21);
			this.wifiNameText.TabIndex = 2;
			this.wifiNameText.Text = "MySharedWifi";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(50, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "密码：";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(50, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "无线名：";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.weatherWebBrowser);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(395, 285);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "天气";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// weatherWebBrowser
			// 
			this.weatherWebBrowser.Location = new System.Drawing.Point(0, 0);
			this.weatherWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.weatherWebBrowser.Name = "weatherWebBrowser";
			this.weatherWebBrowser.ScrollBarsEnabled = false;
			this.weatherWebBrowser.Size = new System.Drawing.Size(389, 279);
			this.weatherWebBrowser.TabIndex = 20;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.schoolWebBrowser);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(395, 285);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "学校通知";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// schoolWebBrowser
			// 
			this.schoolWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schoolWebBrowser.IsWebBrowserContextMenuEnabled = false;
			this.schoolWebBrowser.Location = new System.Drawing.Point(3, 3);
			this.schoolWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.schoolWebBrowser.Name = "schoolWebBrowser";
			this.schoolWebBrowser.ScrollBarsEnabled = false;
			this.schoolWebBrowser.Size = new System.Drawing.Size(389, 279);
			this.schoolWebBrowser.TabIndex = 0;
			this.schoolWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.SchoolWebBrowserDocumentCompleted);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.textBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(395, 285);
			this.tabPage4.TabIndex = 4;
			this.tabPage4.Text = "帮助";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(22, 17);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(350, 251);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "目前已知EasyLogin无法正确登录的可能原因\r\n\r\n\r\n\r\n1.如果你的电脑同时连了无线和有线网络，请关掉其中一个然后重新打开EasyLogin进行登录。\r\n" +
			"\r\n2.账号欠费、线路损毁、服务器繁忙等问题。\r\n\r\n\r\n\r\n\r\n\r\n\r\n欢迎Email：564923716@qq.com\r\n\r\nhttp://www.chen" +
			"zuhuang.com";
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toqzone,
									this.toweibo,
									this.torenren});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(161, 70);
			// 
			// toqzone
			// 
			this.toqzone.Name = "toqzone";
			this.toqzone.Size = new System.Drawing.Size(160, 22);
			this.toqzone.Text = "分享到QQ空间";
			this.toqzone.Click += new System.EventHandler(this.ToqzoneClick);
			// 
			// toweibo
			// 
			this.toweibo.Name = "toweibo";
			this.toweibo.Size = new System.Drawing.Size(160, 22);
			this.toweibo.Text = "分享到新浪微博";
			this.toweibo.Click += new System.EventHandler(this.ToweiboClick);
			// 
			// torenren
			// 
			this.torenren.Name = "torenren";
			this.torenren.Size = new System.Drawing.Size(160, 22);
			this.torenren.Text = "分享到人人";
			this.torenren.Click += new System.EventHandler(this.TorenrenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 327);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.labelIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.webBrowser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(417, 365);
			this.Name = "MainForm";
			this.Text = "EasyLogin V1.1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Resize += new System.EventHandler(this.MainForm_SizeChanged);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.wifiTabPage.ResumeLayout(false);
			this.wifiTabPage.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label wifiState;
		private System.Windows.Forms.Button shareBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox netComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox wifiNameText;
		private System.Windows.Forms.TextBox wifiPsdText;
		private System.Windows.Forms.TabPage wifiTabPage;
		private System.Windows.Forms.ToolStripMenuItem torenren;
		private System.Windows.Forms.ToolStripMenuItem toweibo;
		private System.Windows.Forms.ToolStripMenuItem toqzone;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel rechargeLinkLabel;
		private System.Windows.Forms.WebBrowser schoolWebBrowser;
		private System.Windows.Forms.WebBrowser weatherWebBrowser;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem13;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.CheckBox cbAutoLogin;
		private System.Windows.Forms.CheckBox cbRemember;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelMoney;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Label useSchool;
		private System.Windows.Forms.Label labelTotalSchool;
		private System.Windows.Forms.Label useFlow;
		private System.Windows.Forms.Label lableState;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label labelTotalFlow;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox textPsd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.WebBrowser webBrowser;
		
		void BtnLoginClick(object sender, System.EventArgs e)
		{
			if(textPsd.Text.Equals("") || textName.Text.Equals(""))
			{
				showMessageDialog("用户名和密码都不能为空");
				return;
			}
			sourcePsd = textPsd.Text;
			strUserName = textName.Text;
			savePsd();	//保存密码信息
			login(strUserName, sourcePsd);
		}
		
		void BtnResetClick(object sender, System.EventArgs e)
		{
			textName.ResetText();
			textPsd.ResetText();
		}
		
		//点击缴费网站链接时
		void RechargeLinkLabelLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("iexplore.exe", "http://www.hn.189.cn/hnselfservice/topup/topup!topupIndex.action?isCorp=0");
		}
		
		//点击分享链接时
		void LinkLabel2LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			contextMenuStrip2.Show(MousePosition);
		}
		
		//点击教务系统链接时
		void LinkLabel1LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("iexplore.exe", "http://csujwc.its.csu.edu.cn");
		}
		
		void ToqzoneClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("iexplore.exe", @"http://sns.qzone.qq.com/cgi-bin/qzshare/cgi_qzshare_onekey?url=http%3A%2F%2Fwww.chenzuhuang.com%2Farchives%2F206%236553914-qzone-1-83171-

ea9d9d93bee64e0f704049ba13443333&title=%E6%95%B0%E5%AD%97%E4%B8%AD%E5%8D%97%E7%99%BB%E5%BD%95%E5%99%A8EasyLogin%20V1.1%E5%87%86%E5%A4%87%E5%8F%91%E5%B8%83%20%7C

%20%E9%99%88%E7%A5%96%E7%85%8C%E7%9A%84%E5%8D%9A%E5%AE%A2&desc=&summary=&site=");
		}
		
		
		void ToweiboClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("iexplore.exe", @"http://v.t.sina.com.cn/share/share.php?title=数字中南登录器EasyLogin V1.1,内置wifi分享,全新体验，下载地址: http://www.chenzuhuang.com/archives/206");
		}
		
		void TorenrenClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("iexplore.exe", @"http://widget.renren.com/dialog/share?resourceUrl=http%3A%2F%2Fwww.chenzuhuang.com%2Farchives%2F206%236553914-renren-1-78869-

03366510dc0e89d54fec68610e56b71e&srcUrl=http%3A%2F%2Fwww.chenzuhuang.com%2Farchives%2F206%236553914-renren-1-78869-03366510dc0e89d54fec68610e56b71e&title=

%E6%95%B0%E5%AD%97%E4%B8%AD%E5%8D%97%E7%99%BB%E5%BD%95%E5%99%A8EasyLogin%20V1.1%E5%87%86%E5%A4%87%E5%8F%91%E5%B8%83%20%7C%20%E9%99%88%E7%A5%96%E7%85%8C%E7%9A%84%E5%8D

%9A%E5%AE%A2&description=");
		}
	}
}
