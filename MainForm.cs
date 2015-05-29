/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 2013/11/24
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;
using System.Diagnostics;		//process类在的
using System.Net.NetworkInformation;
using System.Data;
using System.Net.Sockets;
using NETCONLib;

namespace EasyLogin
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string sourcePsd = "123456";		//原密码
		public string strUserName = "";			//用户名
		public string lockedPsd = "";			//加密后的密码
		public bool isLogin = false;
		public string ip = ""; 
		public string weather = "";
		public bool isShare = false;
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//获取IP地址
			IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName()); 
			//IPAddress ipAddr = ipHost.AddressList[3]; 
			//ipAddr.AddressFamily.ToString();
			for(int i = 0; i < ipHost.AddressList.Length; i++) 
			{
				//MessageBox.Show(ipHost.AddressList[i].ToString());
				if(ipHost.AddressList[i].ToString().StartsWith("10"))
				{
					ip = ipHost.AddressList[i].ToString();
				}
			}
			labelIP.Text = "内网地址为" + ip;
			//如果ip为空怎么办？
			if(ip.Equals(""))
			{
				MessageBox.Show("获取IP失败，无法登录，请检查网络连接或者重新打开程序！");
			}
			//读取记住的密码文件信息
			readPsd();
			
		}
		/******************************************************************************************/
		//加密函数
		public void psdLockAndLogin()
		{
			//WebBrowser webBrowser = new WebBrowser();
			//读取html模板
            string html = File.ReadAllText("elfile\\sec.el");//string html = File.ReadAllText("F:\\工程\\nini\\do.html");
            //将用户输入的密码替换html文件中的123456
            html = html.Replace("123456", sourcePsd);
            webBrowser.DocumentText = html;//加载替换后的html模板页面
            //webBrowser.Navigate(new Uri("F:\\456.html"));
            //webBrowser.Navigate("F:\\工程\\nini\\123.html");
            //webBrowser.Document.GetElementById("aa").SetAttribute("value", "1");
            //string str = webBrowser.Document.All["a"].GetAttribute("value");
            //webBrowser.ShowPrintDialog();
           // MessageBox.Show(str);
		}
	
		//这个函数是webborwser加载完后才执行的
		//获取加密后的密码
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			lockedPsd = webBrowser.Document.GetElementById("psd").GetAttribute("value");	//从html里面获取加密后的密码
			//MessageBox.Show(lockedPsd);
			postLogin();		//发送登陆消息
		}
		/******************************************************************************************/
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		//登陆函数
		void login(string strUser, string strPsd)
		{
			lableState.Text = "正在准备登录...";
			psdLockAndLogin();		//加密密码并登陆
			//MessageBox.Show(strUser+"\n"+strPsd);
			//System.Threading.Thread.Sleep(2000);
			//for(int i = 0; i <= 100000; i++);
			//postLogin();
			
		}
		//发送上线请求
		void postLogin()
		{
			lableState.Text = "正在请求服务器验证账号密码...";
			/*
			//获取IP地址
			IPHostEntry ipHost = Dns.Resolve(Dns.GetHostName()); 
			IPAddress ipAddr = ipHost.AddressList[0]; 
			string ip = ipAddr.ToString(); 
			//Console.WriteLine(ip);
			//if(lockedPsd.Equals(""))
			*/
			//设置目标地址
			HttpWebRequest req = (HttpWebRequest) HttpWebRequest.Create("http://61.137.86.87:8080/portalNat444/AccessServices/login");
			//构造消息头header
			req.Referer = "http://61.137.86.87:8080/portalNat444/index.jsp";		//服务器防盗链，必须设置referer为此值
			req.Accept = "application/json, text/javascript, */*; q=0.01";
			req.Headers["Accept-Language"] = "zh-cn";
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";	//这步必须有
			//构造要发送的数据postData
			string postMsg = "accountID="+strUserName+"@zndx.inter" +
				"&password=" + lockedPsd + 
				"&brasAddress=59df7586" +
				"&userIntranetAddress="+ip;
			//编码
			Console.WriteLine(lockedPsd+"123");
			Encoding encoding = Encoding.UTF8;
			byte[] bs = encoding.GetBytes(postMsg);
			req.ContentLength = bs.Length;
			
			//发送
			Stream reqStream = req.GetRequestStream();
			reqStream.Write(bs, 0, bs.Length);
			//获取返回的消息
			HttpWebResponse response = (HttpWebResponse)req.GetResponse();  
			Stream responseStream = response.GetResponseStream();  
			StreamReader streamReader = new StreamReader(responseStream, encoding);
			string retString = streamReader.ReadToEnd();  
			
			lableState.Text = "";			//重置状态显示lable
			
			int resultCode = doMessage(retString);		//分析服务器返回的消息，并取得函数返回的resultCode
			
			//MessageBox.Show(resultCode.ToString());
			//MessageBox.Show(retString);
			//MessageBox.Show("done");
		}
		
		//下线的函数
		void logout()
		{
			postLogout();
		}
		void postLogout()
		{
			//下线
			/*
			//获取IP地址
			IPHostEntry ipHost = Dns.Resolve(Dns.GetHostName()); 
			IPAddress ipAddr = ipHost.AddressList[0]; 
			string ip = ipAddr.ToString(); 
			*/
			
			//向服务器发送下线消息
			HttpWebRequest req2 = (HttpWebRequest) HttpWebRequest.Create("http://61.137.86.87:8080/portalNat444/AccessServices/logout?");
			req2.Referer = "http://61.137.86.87:8080/portalNat444/main.jsp";
			req2.Method = "POST";
			req2.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
			string postMsg2 = "brasAddress=59df7586&userIntranetAddress="+ip;
			Encoding encoding = Encoding.UTF8;
			byte[] bs2 = encoding.GetBytes(postMsg2);
			req2.ContentLength = bs2.Length;
			Stream reqStream2 = req2.GetRequestStream();
			reqStream2.Write(bs2, 0, bs2.Length);
			HttpWebResponse response2 = (HttpWebResponse)req2.GetResponse();  
			Stream responseStream2 = response2.GetResponseStream();  
			StreamReader streamReader2 = new StreamReader(responseStream2, encoding);
			string retString2 = streamReader2.ReadToEnd();
			int resultCode = doLogoutMessage(retString2);
			//MessageBox.Show(retString2);
			//MessageBox.Show("已下线");
			lableState.Text = "";
		}
		
		
		void BtnLogoutClick(object sender, EventArgs e)
		{
			lableState.Text = "正在向服务器发送下线请求";
			logout();
		}
		
		void showMessageDialog(string msg)
		{
			MessageBox.Show(msg);
		}
		
		//发送登陆请求后对服务器返回的信息进行处理
		int doMessage( string retString)
		{
			int resultCode = -1;
			//处理返回的字符串
			string[] str = retString.Split(new char[]{':', ','});
			//寻找resultCode
			int index = 0;
			for(int i = 0; i < str.Length; i++)
			{
				if(str[i].Contains("resultCode"))
				{
					index = i;   	
				}
			}
			//获得resultCode
			resultCode = int.Parse(str[index+1].Substring(1, str[index+1].Length-2));
			
			//逐一处理resultCode
			if(0 == resultCode)		//表示登陆成功
			{
				int index0 = containsString(str, "userSchoolOctets");
				if(index0 != -1)	useSchool.Text = "已用"+str[index0+1].Substring(1, str[index0+1].Length-2)+"M";
				
				index0 = containsString(str, "surplusflow");
				if(index0 != -1)	labelTotalSchool.Text = "校内流量共"+str[index0+1].Substring(1, str[index0+1].Length-2)+"M";
				
				index0 = containsString(str, "totalflow");
				if(index0 != -1)	labelTotalFlow.Text = "公共流量共"+str[index0+1].Substring(1, str[index0+1].Length-2)+"M";
				
				index0 = containsString(str, "usedflow");
				if(index0 != -1)	useFlow.Text = "已用"+str[index0+1].Substring(1, str[index0+1].Length-2)+"M";
				
				index0 = containsString(str, "lastupdate");
				if(index0 != -1)	labelTime.Text = "以上流量消费信息截止至"+
					str[index0+1].Substring(1, str[index0+1].Length-1)+":"+str[index0+2]+":"+str[index0+3].Substring(0,str[index0+3].Length-1);
				
				index0 = containsString(str, "surplusmoney");
				if(index0 != -1)	labelMoney.Text = "账号内剩余金额"+str[index0+1].Substring(1, str[index0+1].Length-2)+"元";
				
				//隐藏图片
				pictureBox1.Hide();
				//更改linkLabel的显示状态
				rechargeLinkLabel.Visible = true;

				//更改状态
				isLogin = true;
				//设置按钮、用户输入框、密码输入框不可用
				btnLogin.Enabled = false;
				btnReset.Enabled = false;
				textName.Enabled = false;
				textPsd.Enabled = false;
				cbAutoLogin.Enabled = false;
				cbRemember.Enabled = false;
				
				//获取并获取天气信息
				getWeather();
				//获取校内通知
				getSchoolMsg();
			}
			else if(1 == resultCode)
			{
				int index0 = containsString(str, "resultDescribe");		//获得结果描述的表单下标
				if(index0 == -1)
				{
					MessageBox.Show("网络传输，请重试！");
					return resultCode;
				}
			
				string result = str[index0+1].Substring(1, str[index0+1].Length-2);	//得到结果描述
				if(result.Equals("") || result == null)
				{
					MessageBox.Show("其他原因拒绝认证");
					return resultCode;
				}
				MessageBox.Show(result);			//账号已在线的可能在这里
			}
			else if(2 == resultCode)
			{
				MessageBox.Show("本机已经上了一个账号了!若要重新登陆，你可以点一下下线然后重登。");
			}
			else if(3 == resultCode)
			{
				MessageBox.Show("接入服务繁忙，请重试！(PS:数字中南不会崩了吧？)");
			}
			else if(4 == resultCode)
			{
				MessageBox.Show("未知错误！(PS:数字中南这么说的，我也没办法)");
			}
			else if(6 == resultCode)
			{
				MessageBox.Show("认证响应超时，请重试！(PS:数字中南这么说的，我也没办法)");
			}
			else if(7 == resultCode || 12 == resultCode || 13 == resultCode)
			{
				MessageBox.Show("获取内网地址错误，请检测你的IP地址设置。(PS：确认你在中南内上的网？)");
			}
			else if(8 == resultCode)
			{
				MessageBox.Show("网络连接异常！(PS:数字中南这么说的，我也没办法)");
			}
			else if(9 == resultCode)
			{
				MessageBox.Show("认证服务脚本错误，请重试！");
			}
			/*else if(10 == resultCode)
			{
				MessageBox.Show("验证码错误");
			}*/
			else if(11 == resultCode)
			{
				MessageBox.Show("你的密码相对简单，请及时修改密码！");
			}
			else if(14 == resultCode)
			{
				MessageBox.Show("无法获取你的套餐信息！(PS:你开户了没有？)");
			}
			else if(16 == resultCode)
			{
				MessageBox.Show("请输入任意其它网站导航至本认证页面,并按正常PORTAL正常流程认证(PS:Referer改了)");
			}
			else if(17 == resultCode)
			{
				MessageBox.Show("连接已失效(PS:点一次下线，然后重新登陆一下~)");
			}
			else MessageBox.Show("未知错误！(PS:数字中南这么说的，我也没办法)");
			
			return resultCode;
		}
		
		//处理发送下线请求后从服务器返回的消息
		int doLogoutMessage(string retString)
		{
			int resultCode = -1;
			//处理返回的字符串
			string[] str = retString.Split(new char[]{':', ','});
			//寻找resultCode
			int index = 0;
			for(int i = 0; i < str.Length; i++)
			{
				if(str[i].Contains("resultCode"))
				{
					index = i;   	
				}
			}
			//获得resultCode
			resultCode = int.Parse(str[index+1].Substring(1, str[index+1].Length-2));
			
			if(0 == resultCode)			//下线成功
			{
				MessageBox.Show("下线成功");
				//更改标志
				isLogin = false;
				//更改6个label的显示状态
				labelTime.Text = "";
				labelMoney.Text = "";
				labelTotalFlow.Text = "";
				labelTotalSchool.Text = "";
				useFlow.Text = "";
				useSchool.Text = "";
				//更改linkLabel的显示状态
				rechargeLinkLabel.Visible = false;
				//设置按钮、用户输入框、密码输入框可用
				btnLogin.Enabled = true;
				btnReset.Enabled = true;
				textName.Enabled = true;
				textPsd.Enabled = true;
				cbAutoLogin.Enabled = true;
				cbRemember.Enabled = true;
				
				//显示图片
				pictureBox1.Show();
			}
			else if(1 == resultCode)
			{
				MessageBox.Show("服务器拒绝请求，请重试！");
			}
			else if(2 == resultCode)
			{
				MessageBox.Show("下线请求执行失败，请重试！");
			}
			else if(3 == resultCode)
			{
				MessageBox.Show("本机并没有登录账号。");
				//更改标志
				isLogin = false;
				//更改6个label的显示状态
				labelTime.Text = "";
				labelMoney.Text = "";
				labelTotalFlow.Text = "";
				labelTotalSchool.Text = "";
				useFlow.Text = "";
				useSchool.Text = "";
				//更改linkLabel的显示状态
				rechargeLinkLabel.Visible = false;
				//设置按钮、用户输入框、密码输入框可用
				btnLogin.Enabled = true;
				btnReset.Enabled = true;
				textName.Enabled = true;
				textPsd.Enabled = true;
				cbAutoLogin.Enabled = true;
				cbRemember.Enabled = true;
				//显示图片
				pictureBox1.Show();
			}
			else if(4 == resultCode)
			{
				MessageBox.Show("服务器响应超时，请重试！");
			}
			else if(5 == resultCode)
			{
				MessageBox.Show("后台网络连接异常，请重试！");
			}
			else if(6 == resultCode)
			{
				MessageBox.Show("服务脚本执行异常，请重试！");
			}
			else if(7 == resultCode || 8 == resultCode || 9 == resultCode)
			{
				MessageBox.Show("获取IP地址错误！(PS:你是否在中南内登录呢？)");
			}
			else MessageBox.Show("未知错误");
			
			return resultCode;
		}
		
		//寻找string数组str中包含子字符串substring的字符串元素，返回第一个符合这样条件的字符串的下标
		int containsString(string[] str, string substring)
		{
			for(int i = 0; i < str.Length; i++)
			{
				if(str[i].Contains(substring))
				{
					return i;
				}
			}
			return -1;
		}
		
		string loadHtmlModel()
		{
			string temp = "";
			return temp;
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		//记住密码功能,把几个复选框状态、连同账号密码一起保存
		void savePsd()
		{
			string path = "elfile\\sec2.el";
			/*if(!File.Exists(path))
			{
				File.Create(path);
			}
			else	//删除原来的，新建一个
			{
				File.Delete(path);
				File.Create(path);
			}*/
			if(File.Exists(path))	//删除原来的
			{
				File.Delete(path);
			}
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			StreamWriter sw = new StreamWriter(fs);
			//如果选中保存密码功能
			if(cbRemember.Checked)
				sw.Write("true#");
			else 
				sw.Write("false#");
			
			//如果选中开机登录
			if(cbAutoLogin.Checked)
				sw.Write("true#");
			else
				sw.Write("false#");
			
			sw.Write(textName.Text + "#");
			sw.Write(textPsd.Text);
			sw.Close();
			fs.Close();
		}
		//从密码信息文件中读取
		void readPsd()
		{
			string path = "elfile\\sec2.el";
			if(!File.Exists(path))
			{
				return;
			}
			FileStream fs = new FileStream(path, FileMode.Open);
			StreamReader sr = new StreamReader(fs);
			string msg = sr.ReadToEnd();
			//MessageBox.Show(msg);
			string[] str = msg.Split('#');
			
			/////////////////////////////////////////////////////
			//检查用户有没有选择记住密码,有则加载密码
			if(str[0].Equals("true"))
			{
				cbRemember.Checked = true;
				//判断用户名或者密码框是否为空的情况
				if(str.Length == 4)
				{
					textName.Text = str[2];
					textPsd.Text = str[3];
				}
			}
			else
			{
				cbRemember.Checked = false;
			}
			//////////////////////////////////////////////////
			//检查用户有没有设置自动登录
			if(str[1].Equals("true"))
			{
				//设置了自动登录，必须记住密码
				cbAutoLogin.Checked = true;
				cbRemember.Checked = true;
				//判断用户名或者密码框是否为空的情况
				if(str.Length == 4)
				{
					textName.Text = str[2];
					textPsd.Text = str[3];
				}
				
				//登录
				if(textPsd.Text.Equals("") || textName.Text.Equals(""))
				{
					showMessageDialog("用户名和密码都不能为空");
					return;
				}
				sourcePsd = textPsd.Text;
				strUserName = textName.Text;
				login(strUserName, sourcePsd);
			}
			else
			{
				cbAutoLogin.Checked = false;
			}
			//////////////////////////////////////////////////////////
			sr.Close();
			fs.Close();
		}

		//点击最小化按钮
		private void MainForm_SizeChanged(object sender, System.EventArgs e)
		{
			if(this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				this.ShowInTaskbar = false;
			}
			
		}
		//双击托盘图标
		void NotifyIconDoubleClick(object sender, EventArgs e)
		{
			this.Visible = true;
			this.WindowState = FormWindowState.Normal;
			this.ShowInTaskbar = true;
			this.Show();
		}
		
		//一登陆了就获取天气信息
		void getWeather()
		{
			//Thread getWeatherThread = new Thread(new ThreadStart(toGetWeather));
			//getWeatherThread.Start();
			
			string html = File.ReadAllText("elfile\\csweather");      
            weatherWebBrowser.DocumentText = html;//加载html模板页面
            
		}
		
		//加载学校通知信息
		void getSchoolMsg()
		{
			schoolWebBrowser.Navigate("http://tz.its.csu.edu.cn/");
			schoolWebBrowser.Document.Window.ScrollTo(200,200);
		}
		//加载完学校信息后
		void SchoolWebBrowserDocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
		{
			HtmlDocument document = schoolWebBrowser.Document;
			document.Window.ScrollTo(235,250);
		}
		
		//托盘菜单显示主界面
		void ToolStripMenuItem1Click(object sender, System.EventArgs e)
		{
			this.Visible = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.ShowInTaskbar = true;
			this.Show();
		}
		
		//托盘菜单下线
		void ToolStripMenuItem2Click(object sender, System.EventArgs e)
		{
			lableState.Text = "正在向服务器发送下线请求";
			logout();			
		}
		//托盘菜单退出
		void ToolStripMenuItem13Click(object sender, System.EventArgs e)
		{
			if(BeforeExit())		//判断是否可以退出
			{
				notifyIcon.Visible = false;
				this.Close();
				this.Dispose();
				Environment.Exit(0);
			}
		}
		
		//退出程序的函数
		bool BeforeExit()
		{
			if(isLogin && !isShare)	//如果当前处于在线状态,且wifi分享未开启
			{
				//如果用户选择继续退出
				if(
					MessageBox.Show("现在正处于登录状态，如果退出将会下线，是否继续退出？",
				                "是否继续退出",
				               MessageBoxButtons.OKCancel,
				               MessageBoxIcon.Question) 
					== DialogResult.OK
				  )
				{
					//下线
					lableState.Text = "正在向服务器发送下线请求";
					logout();
					return true;		//退出程序
				}
				else
				{
					return false;		//不退出
				}
			}
			else if(isLogin && isShare)		//如果登录状态且wifi共享开启状态
			{
				//如果用户选择继续退出
				if(
					MessageBox.Show("现在正处于登录状态，并且开启了wifi无线分享，如果退出将会关闭wifi无线分享并且下线，是否继续退出？",
				                "是否继续退出",
				               MessageBoxButtons.OKCancel,
				               MessageBoxIcon.Question) 
					== DialogResult.OK
				  )
				{
					DeleteShare();		//删除热点分享
					lableState.Text = "正在向服务器发送下线请求";
					logout();			//登出
					return true;		//退出程序
				}
				else
				{
					return false;		//不退出
				}
			}
			else if(!isLogin && isShare)	//如果未登录，但开启了wifi热点分享
			{
				if(
					MessageBox.Show("现在正处于wifi热点分享状态，如果退出将会删除热点分享，是否继续退出？",
				                "是否继续退出",
				               MessageBoxButtons.OKCancel,
				               MessageBoxIcon.Question) 
					== DialogResult.OK
				  )
				{
					DeleteShare();		//删除热点分享
					return true;		//退出程序
				}
				else
				{
					return false;		//不退出
				}
			}
			
			else return true;
		}
		
		//点击关闭窗口前的处理
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(!BeforeExit())		//如果用户取消了退出，那么不退出，e.Cancle = true;
			{
				e.Cancel = true;
			}
		}
		
		//当选择无线选项卡时
		void TabControl1Selecting(object sender, TabControlCancelEventArgs e)
		{
			if(e.TabPage == wifiTabPage)
			{
				//读取保存的wifi名称和密码
				readWifiPsd();
				
				//给wifi下拉列表加载网络连接选项
				List<string> items = new List<string>();
			
				NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface ni in interfaces)
            	{
              	  if (ni.OperationalStatus == OperationalStatus.Up)
               	 {
                 	   //Console.WriteLine("当前正在连接的IP是："+ni.Name);
                 	   items.Add(ni.Name);
               	 }
                	/*else
                	{
                 	    Console.WriteLine("当前IP"+ni.Name+"处于静止或者中断状态。");
                	}*/
            	}
				netComboBox.ValueMember = "text";		
				netComboBox.DisplayMember = "value";
				netComboBox.DataSource = items;
			}
			
		}
		
		//创建共享按钮
		void ShareBtnClick(object sender, EventArgs e)
		{
			if(wifiNameText.Text.Equals("") || wifiPsdText.Text.Equals("") || netComboBox.Text.Equals(""))
			{
				showMessageDialog("无线名、密码、要共享的连接名都不能为空");
			}
			else if(wifiPsdText.Text.Length < 8)
			{
				showMessageDialog("密码不能少于8位");
			}
			//创建无线分享
			else{
				//记录记住密码信息
				saveWifiPsd();
				//调用创建无线分享功能
				CreateWifiShare(wifiNameText.Text, wifiPsdText.Text, netComboBox.Text);
			}
		}
		/**********************************************************************************/
		//记住密码功能
		void saveWifiPsd()
		{
			string path = "elfile\\msg.wf";
			
			if(File.Exists(path))	//删除原来的
			{
				File.Delete(path);
			}
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			StreamWriter sw = new StreamWriter(fs);
			
			sw.Write(wifiNameText.Text + "#");
			sw.Write(wifiPsdText.Text);
			sw.Close();
			fs.Close();
		}
		/**********************************************************************************/
		//从保存密码文件中读取信息
		void readWifiPsd()
		{
			string path = "elfile\\msg.wf";
			if(!File.Exists(path))
			{
				return;
			}
			FileStream fs = new FileStream(path, FileMode.Open);
			StreamReader sr = new StreamReader(fs);
			string msg = sr.ReadToEnd();
			//MessageBox.Show(msg);
			string[] str = msg.Split('#');
			
			/////////////////////////////////////////////////////
			
			if(str.Length == 2)//判断是否密码或用户名为空
			{
				wifiNameText.Text = str[0];
				wifiPsdText.Text = str[1];
			}

			sr.Close();
			fs.Close();
		}
		/**********************************************************************************/
		//创建无线共享的方法
		void CreateWifiShare(string name, string key, string netName)
		{
			//新建网络
			string command = "netsh wlan set hostednetwork mode=allow ssid=" + name + " key=" + key;
            string str2 = executeCmd(command);
            
            executeCmd("netsh wlan start hostednetwork");
            //设置共享映射
            try
            {
               	string connectionToShare = netName; // 被共享的网络连接
               	string sharedForConnection = "";//"Microsoft Virtual wlan Miniport Adapter";无线网络连接 2
               	//得到需要共享的网络连接的名字
               	System.Net.NetworkInformation.NetworkInterface[] interfaces = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
           		foreach (System.Net.NetworkInformation.NetworkInterface ni in interfaces)
            	{
           			//根据IP来找虚拟无线网卡
           			IPInterfaceProperties fIPInterfaceProperties = ni.GetIPProperties();
                	UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = fIPInterfaceProperties.UnicastAddresses;
                	foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                	{
                    	if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    	{
                    		//Console.WriteLine("Ip Address .......... : {0}", UnicastIPAddressInformation.Address); // Ip 地址
                    		if(UnicastIPAddressInformation.Address.ToString().Equals("192.168.137.1"))
                    		{
                    			sharedForConnection = ni.Name;
                    		}
                    	}
                       	 		
                	}
                
            	}
                		
                var manager = new NetSharingManager();
                var connections = manager.EnumEveryConnection;
 
                foreach (INetConnection c in connections)
                {
                    var props = manager.NetConnectionProps[c];
                    var sharingCfg = manager.INetSharingConfigurationForINetConnection[c];
                    if (props.Name == connectionToShare)
                    {
                       	sharingCfg.EnableSharing(tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PUBLIC);
                    }
                    else if (props.Name == sharedForConnection)
                    {
                    			
                        sharingCfg.EnableSharing(tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PRIVATE);
                    }
                }
 				wifiState.Text = "wifi共享已开启";
 				isShare = true;
 				shareBtn.Enabled = false;
 				wifiNameText.Enabled = false;
 				wifiPsdText.Enabled = false;
 				netComboBox.Enabled = false;
 				deleteBtn.Enabled = true;
               			
            }
            catch
            {
                MessageBox.Show("共享失败，请打开网络和共享中心.查看要共享的连接名称是否和上面选择的一致!",
                   "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
          	}    	
		}
		//控制台命令，并返回结果
		public string executeCmd(string Command)
        {
			ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c C:\\Windows\\System32\\cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute =false ;
            startInfo.CreateNoWindow = true;			//新加的，用来不显示控制台
            startInfo.Verb = "RunAs";
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.WriteLine(Command);
            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            string strRst = process.StandardOutput.ReadToEnd();
            process.Close();
            return strRst;
        }
		
		//单机删除wifi共享按钮
		void DeleteBtnClick(object sender, EventArgs e)
		{
			DeleteShare();
		}
		//删除无线共享的方法
		void DeleteShare()
		{
			executeCmd("netsh wlan stop hostednetwork");
			executeCmd("netsh wlan set hostednetwork mode=disallow");
			wifiState.Text = "wifi分享未开启";
      		isShare = false;
      		shareBtn.Enabled = true;
      		wifiNameText.Enabled = true;
      		wifiPsdText.Enabled = true;
      		netComboBox.Enabled = true;
      		deleteBtn.Enabled = false;
		}
	}
}
