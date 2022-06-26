using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Lean.Resources
{
	// Token: 0x02000013 RID: 19
	public class api
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00010FBC File Offset: 0x0000F1BC
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Security error, please reinstall the software!");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001105C File Offset: 0x0000F25C
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				MessageBox.Show("Missing dll files, extract whole folder", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00011208 File Offset: 0x0000F408
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001121C File Offset: 0x0000F41C
		public void Checkinit()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				bool isDebugRelease = api.IsDebugRelease;
				if (isDebugRelease)
				{
					api.error("Security error, please reinstall the software! (2)");
				}
				else
				{
					api.error("Security error, please reinstall the software! (2)");
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00011260 File Offset: 0x0000F460
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001152C File Offset: 0x0000F72C
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001165C File Offset: 0x0000F85C
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001179C File Offset: 0x0000F99C
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001187C File Offset: 0x0000FA7C
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00011990 File Offset: 0x0000FB90
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00011B88 File Offset: 0x0000FD88
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.msg> result;
			if (success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00011DCC File Offset: 0x0000FFCC
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00011EF8 File Offset: 0x000100F8
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001201C File Offset: 0x0001021C
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00012180 File Offset: 0x00010380
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			byte[] result;
			if (success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001229C File Offset: 0x0001049C
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00012390 File Offset: 0x00010590
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012410 File Offset: 0x00010610
		public static void error(string message)
		{
			MessageBox.Show(message, "Lean Protection", MessageBoxButtons.OK);
			Environment.Exit(0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012428 File Offset: 0x00010628
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure, Try again!");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You are connecting too fast to Woofer, please wait!");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000124DC File Offset: 0x000106DC
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00012544 File Offset: 0x00010744
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000125C0 File Offset: 0x000107C0
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0001262A File Offset: 0x0001082A
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000092 RID: 146
		public string name;

		// Token: 0x04000093 RID: 147
		public string ownerid;

		// Token: 0x04000094 RID: 148
		public string secret;

		// Token: 0x04000095 RID: 149
		public string version;

		// Token: 0x04000096 RID: 150
		private string sessionid;

		// Token: 0x04000097 RID: 151
		private string enckey;

		// Token: 0x04000098 RID: 152
		private bool initzalized;

		// Token: 0x04000099 RID: 153
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400009A RID: 154
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400009B RID: 155
		public api.response_class response = new api.response_class();

		// Token: 0x0400009C RID: 156
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000014 RID: 20
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00012651 File Offset: 0x00010851
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x00012659 File Offset: 0x00010859
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00012662 File Offset: 0x00010862
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x0001266A File Offset: 0x0001086A
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x00012673 File Offset: 0x00010873
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x0001267B File Offset: 0x0001087B
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x00012684 File Offset: 0x00010884
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x0001268C File Offset: 0x0001088C
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00012695 File Offset: 0x00010895
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x0001269D File Offset: 0x0001089D
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000FA RID: 250 RVA: 0x000126A6 File Offset: 0x000108A6
			// (set) Token: 0x060000FB RID: 251 RVA: 0x000126AE File Offset: 0x000108AE
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000FC RID: 252 RVA: 0x000126B7 File Offset: 0x000108B7
			// (set) Token: 0x060000FD RID: 253 RVA: 0x000126BF File Offset: 0x000108BF
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000FE RID: 254 RVA: 0x000126C8 File Offset: 0x000108C8
			// (set) Token: 0x060000FF RID: 255 RVA: 0x000126D0 File Offset: 0x000108D0
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000126D9 File Offset: 0x000108D9
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000126E1 File Offset: 0x000108E1
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000015 RID: 21
		public class msg
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000103 RID: 259 RVA: 0x000126EA File Offset: 0x000108EA
			// (set) Token: 0x06000104 RID: 260 RVA: 0x000126F2 File Offset: 0x000108F2
			public string message { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000105 RID: 261 RVA: 0x000126FB File Offset: 0x000108FB
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00012703 File Offset: 0x00010903
			public string author { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000107 RID: 263 RVA: 0x0001270C File Offset: 0x0001090C
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00012714 File Offset: 0x00010914
			public string timestamp { get; set; }
		}

		// Token: 0x02000016 RID: 22
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600010A RID: 266 RVA: 0x0001271D File Offset: 0x0001091D
			// (set) Token: 0x0600010B RID: 267 RVA: 0x00012725 File Offset: 0x00010925
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600010C RID: 268 RVA: 0x0001272E File Offset: 0x0001092E
			// (set) Token: 0x0600010D RID: 269 RVA: 0x00012736 File Offset: 0x00010936
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600010E RID: 270 RVA: 0x0001273F File Offset: 0x0001093F
			// (set) Token: 0x0600010F RID: 271 RVA: 0x00012747 File Offset: 0x00010947
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00012750 File Offset: 0x00010950
			// (set) Token: 0x06000111 RID: 273 RVA: 0x00012758 File Offset: 0x00010958
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00012761 File Offset: 0x00010961
			// (set) Token: 0x06000113 RID: 275 RVA: 0x00012769 File Offset: 0x00010969
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00012772 File Offset: 0x00010972
			// (set) Token: 0x06000115 RID: 277 RVA: 0x0001277A File Offset: 0x0001097A
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00012783 File Offset: 0x00010983
			// (set) Token: 0x06000118 RID: 280 RVA: 0x0001278B File Offset: 0x0001098B
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00012794 File Offset: 0x00010994
			// (set) Token: 0x0600011A RID: 282 RVA: 0x0001279C File Offset: 0x0001099C
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000127A5 File Offset: 0x000109A5
			// (set) Token: 0x0600011C RID: 284 RVA: 0x000127AD File Offset: 0x000109AD
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000127B6 File Offset: 0x000109B6
			// (set) Token: 0x0600011E RID: 286 RVA: 0x000127BE File Offset: 0x000109BE
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600011F RID: 287 RVA: 0x000127C7 File Offset: 0x000109C7
			// (set) Token: 0x06000120 RID: 288 RVA: 0x000127CF File Offset: 0x000109CF
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000121 RID: 289 RVA: 0x000127D8 File Offset: 0x000109D8
			// (set) Token: 0x06000122 RID: 290 RVA: 0x000127E0 File Offset: 0x000109E0
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000018 RID: 24
		public class app_data_class
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000124 RID: 292 RVA: 0x000127E9 File Offset: 0x000109E9
			// (set) Token: 0x06000125 RID: 293 RVA: 0x000127F1 File Offset: 0x000109F1
			public string numUsers { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000126 RID: 294 RVA: 0x000127FA File Offset: 0x000109FA
			// (set) Token: 0x06000127 RID: 295 RVA: 0x00012802 File Offset: 0x00010A02
			public string numOnlineUsers { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000128 RID: 296 RVA: 0x0001280B File Offset: 0x00010A0B
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00012813 File Offset: 0x00010A13
			public string numKeys { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600012A RID: 298 RVA: 0x0001281C File Offset: 0x00010A1C
			// (set) Token: 0x0600012B RID: 299 RVA: 0x00012824 File Offset: 0x00010A24
			public string version { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600012C RID: 300 RVA: 0x0001282D File Offset: 0x00010A2D
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00012835 File Offset: 0x00010A35
			public string customerPanelLink { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600012E RID: 302 RVA: 0x0001283E File Offset: 0x00010A3E
			// (set) Token: 0x0600012F RID: 303 RVA: 0x00012846 File Offset: 0x00010A46
			public string downloadLink { get; set; }
		}

		// Token: 0x02000019 RID: 25
		public class user_data_class
		{
			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000131 RID: 305 RVA: 0x0001284F File Offset: 0x00010A4F
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00012857 File Offset: 0x00010A57
			public string username { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00012860 File Offset: 0x00010A60
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00012868 File Offset: 0x00010A68
			public string ip { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00012871 File Offset: 0x00010A71
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00012879 File Offset: 0x00010A79
			public string hwid { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00012882 File Offset: 0x00010A82
			// (set) Token: 0x06000138 RID: 312 RVA: 0x0001288A File Offset: 0x00010A8A
			public string createdate { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00012893 File Offset: 0x00010A93
			// (set) Token: 0x0600013A RID: 314 RVA: 0x0001289B File Offset: 0x00010A9B
			public string lastlogin { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600013B RID: 315 RVA: 0x000128A4 File Offset: 0x00010AA4
			// (set) Token: 0x0600013C RID: 316 RVA: 0x000128AC File Offset: 0x00010AAC
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001A RID: 26
		public class Data
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600013E RID: 318 RVA: 0x000128B5 File Offset: 0x00010AB5
			// (set) Token: 0x0600013F RID: 319 RVA: 0x000128BD File Offset: 0x00010ABD
			public string subscription { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000140 RID: 320 RVA: 0x000128C6 File Offset: 0x00010AC6
			// (set) Token: 0x06000141 RID: 321 RVA: 0x000128CE File Offset: 0x00010ACE
			public string expiry { get; set; }

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000142 RID: 322 RVA: 0x000128D7 File Offset: 0x00010AD7
			// (set) Token: 0x06000143 RID: 323 RVA: 0x000128DF File Offset: 0x00010ADF
			public string timeleft { get; set; }
		}

		// Token: 0x0200001B RID: 27
		public class response_class
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000145 RID: 325 RVA: 0x000128E8 File Offset: 0x00010AE8
			// (set) Token: 0x06000146 RID: 326 RVA: 0x000128F0 File Offset: 0x00010AF0
			public bool success { get; set; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000147 RID: 327 RVA: 0x000128F9 File Offset: 0x00010AF9
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00012901 File Offset: 0x00010B01
			public string message { get; set; }
		}
	}
}
