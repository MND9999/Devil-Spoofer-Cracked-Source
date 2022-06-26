using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Timers;
using System.Windows.Forms;
using Lean.Resources;
using Newtonsoft.Json;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class Login : Form
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000E4B5 File Offset: 0x0000C6B5
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000E4BD File Offset: 0x0000C6BD
		public object JsonConvert { get; private set; }

		// Token: 0x060000A7 RID: 167 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public Login()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Login.MyMethod;
			timer.Start();
			this.InitializeComponent();
			this.label4.Hide();
			this.siticoneTextBox2.Hide();
			this.label5.Hide();
			this.siticoneTextBox3.Hide();
			this.label6.Hide();
			this.siticoneTextBox4.Hide();
			this.siticoneButton2.Hide();
			this.siticoneButton3.Hide();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000E57C File Offset: 0x0000C77C
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Login.DimisProtection();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002CE3 File Offset: 0x00000EE3
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000E588 File Offset: 0x0000C788
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

		// Token: 0x060000AB RID: 171 RVA: 0x0000E810 File Offset: 0x0000CA10
		private void Login_Load(object sender, EventArgs e)
		{
			Login.DimisProtection();
			string path = "C:\\Program Files\\Sounds";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
				directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			else
			{
				Directory.CreateDirectory("C:\\Program Files\\Sounds");
				DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
				directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			this.siticoneLabel8.Show();
			bool flag2 = File.Exists("C:\\Program Files\\duser.txt");
			if (flag2)
			{
				string text = File.ReadAllText("C:\\Program Files\\duser.txt");
				this.UsernameTB.Text = text;
			}
			bool flag3 = File.Exists("C:\\Program Files\\dpass.txt");
			if (flag3)
			{
				string text2 = File.ReadAllText("C:\\Program Files\\dpass.txt");
				this.siticoneTextBox1.Text = text2;
			}
			base.Size = new Size(219, 235);
			Login.KeyAuthApp.init();
			bool flag4 = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			if (flag4)
			{
				bool flag5 = !Login.KeyAuthApp.response.success;
				if (flag5)
				{
					DialogResult dialogResult = MessageBox.Show("A new version is unavailable, do you want to use it or exit?", "Dimis CDN - Auto Updater", MessageBoxButtons.OKCancel);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.OK)
					{
						if (dialogResult3 == DialogResult.Cancel)
						{
							Application.Exit();
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
			}
			else
			{
				MessageBox.Show("Please Run As Admin", "Devils Woofer", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000E98C File Offset: 0x0000CB8C
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
		public static void sendWebHook(string Url, string msg, string Username, string Plan)
		{
			Http.Post(Url, new NameValueCollection
			{
				{
					"username",
					Username
				},
				{
					"content",
					msg
				},
				{
					"content",
					Plan
				}
			});
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		public static void sendWebHookregister(string Url, string msg, string Username, string Plan, string Key)
		{
			Http.Post(Url, new NameValueCollection
			{
				{
					"username",
					Username
				},
				{
					"content",
					msg
				},
				{
					"content",
					Plan
				},
				{
					"content",
					Key
				}
			});
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		private void PingButton_Click(object sender, EventArgs e)
		{
			try
			{
				Login.KeyAuthApp.login(this.UsernameTB.Text, this.siticoneTextBox1.Text);
				bool success = Login.KeyAuthApp.response.success;
				if (success)
				{
					string[] array = new string[]
					{
						this.UsernameTB.Text
					};
					string path = "C:\\Program Files";
					string path2 = "C:\\Program Files\\duser.txt";
					bool flag = File.Exists(path2);
					if (flag)
					{
						File.Delete(path2);
					}
					using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, "duser.txt")))
					{
						foreach (string value in array)
						{
							streamWriter.WriteLine(value);
						}
					}
					string[] array3 = new string[]
					{
						this.siticoneTextBox1.Text
					};
					string path3 = "C:\\Program Files";
					string path4 = "C:\\Program Files\\dpass.txt";
					bool flag2 = File.Exists(path4);
					if (flag2)
					{
						File.Delete(path4);
					}
					using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, "dpass.txt")))
					{
						foreach (string value2 in array3)
						{
							streamWriter2.WriteLine(value2);
						}
					}
					Main main = new Main();
					main.Show();
					base.Hide();
					string path5 = "C:\\Program Files\\Sounds";
					bool flag3 = !Directory.Exists(path5);
					if (flag3)
					{
						Directory.CreateDirectory(path5);
					}
					bool flag4 = File.Exists("C:\\Program Files\\Sounds\\welcome.wav");
					if (flag4)
					{
					}
				}
				else
				{
					MessageBox.Show(Login.KeyAuthApp.response.message, "Devils Woofer: Failed to login", MessageBoxButtons.OK);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000EC90 File Offset: 0x0000CE90
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			this.siticoneLabel8.Hide();
			base.Size = new Size(219, 266);
			this.UsernameTB.Hide();
			this.label10.Hide();
			this.label3.Hide();
			this.siticoneTextBox1.Hide();
			this.PingButton.Hide();
			this.siticoneButton1.Hide();
			this.siticoneTextBox1.Hide();
			this.label4.Show();
			this.siticoneTextBox2.Show();
			this.label5.Show();
			this.siticoneTextBox3.Show();
			this.label6.Show();
			this.siticoneTextBox4.Show();
			this.siticoneButton2.Show();
			this.siticoneButton3.Show();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000030F6 File Offset: 0x000012F6
		private void UsernameTB_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000030F6 File Offset: 0x000012F6
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000030F6 File Offset: 0x000012F6
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000030F6 File Offset: 0x000012F6
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000ED74 File Offset: 0x0000CF74
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.siticoneTextBox2.Text, this.siticoneTextBox3.Text, this.siticoneTextBox4.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				string[] array = new string[]
				{
					this.siticoneTextBox2.Text
				};
				string path = "C:\\Program Files";
				string path2 = "C:\\Program Files\\duser.txt";
				bool flag = File.Exists(path2);
				if (flag)
				{
					File.Delete(path2);
				}
				using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, "duser.txt")))
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
					File.SetAttributes("C:\\Program Files\\duser.txt", FileAttributes.Hidden);
				}
				string[] array3 = new string[]
				{
					this.siticoneTextBox3.Text
				};
				string path3 = "C:\\Program Files";
				string path4 = "C:\\Program Files\\dpass.txt";
				bool flag2 = File.Exists(path4);
				if (flag2)
				{
					File.Delete(path4);
				}
				using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, "dpass.txt")))
				{
					foreach (string value2 in array3)
					{
						streamWriter2.WriteLine(value2);
					}
					File.SetAttributes("C:\\Program Files\\dpass.txt", FileAttributes.Hidden);
				}
				bool flag3 = Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer";
				if (flag3)
				{
				}
				string requestUriString = "https://canary.discord.com/api/webhooks/987225200921821184/S4lfjkXj6t_aLdfkFd5rdn_j8VhTQQu2ZqdenbzeEJHmjkaZkS9WFmuB53X2Q-PtMUOO";
				WebRequest webRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				webRequest.ContentType = "application/json";
				webRequest.Method = "POST";
				using (StreamWriter streamWriter3 = new StreamWriter(webRequest.GetRequestStream()))
				{
					string value3 = Newtonsoft.Json.JsonConvert.SerializeObject(new
					{
						username = "Devils Woofer",
						embeds = new <>f__AnonymousType1<string, string, string, <>f__AnonymousType2<string, string>>[]
						{
							new
							{
								description = "\ud83d\udd0b Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription + "\n\ud83d\udd11 License: " + this.siticoneTextBox4.Text,
								title = this.siticoneTextBox2.Text + " Just Registered! \ud83c\udf89",
								color = "7419530",
								footer = new
								{
									icon_url = "https://cdn.discordapp.com/icons/985838360851542026/66fed4f46ace410b7f0f2ce940074ebb.png",
									text = "Thanks for buying Devils Woofer \ud83d\udc9c "
								}
							}
						}
					});
					streamWriter3.Write(value3);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				Main main = new Main();
				main.Show();
				base.Hide();
				MessageBox.Show("Thanks For Choosing Devils Woofer, Welcome!", "Devils Woofer", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show(Login.KeyAuthApp.response.message, "Devils Woofer: Failed to login", MessageBoxButtons.OK);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000F068 File Offset: 0x0000D268
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			this.siticoneLabel8.Show();
			base.Size = new Size(219, 235);
			this.UsernameTB.Hide();
			this.label10.Show();
			this.label3.Show();
			this.siticoneTextBox1.Show();
			this.PingButton.Show();
			this.siticoneButton1.Show();
			this.siticoneTextBox1.Show();
			this.UsernameTB.Show();
			this.label4.Hide();
			this.siticoneTextBox2.Hide();
			this.label5.Hide();
			this.siticoneTextBox3.Hide();
			this.label6.Hide();
			this.siticoneTextBox4.Hide();
			this.siticoneButton2.Hide();
			this.siticoneButton3.Hide();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000071F8 File Offset: 0x000053F8
		private void siticoneLabel8_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/devilwoofer");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000030F6 File Offset: 0x000012F6
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000F158 File Offset: 0x0000D358
		private void Label2_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000F170 File Offset: 0x0000D370
		private void Label2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.mouseDown;
			if (flag)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000F1DF File Offset: 0x0000D3DF
		private void Label2_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000030F6 File Offset: 0x000012F6
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000063 RID: 99
		public static api KeyAuthApp = new api("DevilsWoofer", "2aoIJN4UxG", "cac093a7db3a68521b02cf806aaa275d46b01aa82ca72a4286e12c167fad1583", "1.3");

		// Token: 0x04000065 RID: 101
		private bool mouseDown;

		// Token: 0x04000066 RID: 102
		private Point lastLocation;
	}
}
