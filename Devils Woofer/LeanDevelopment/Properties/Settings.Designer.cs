using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LeanDevelopment.Properties
{
	// Token: 0x02000006 RID: 6
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002760 File Offset: 0x00000960
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002778 File Offset: 0x00000978
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000279A File Offset: 0x0000099A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000027AC File Offset: 0x000009AC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000027CE File Offset: 0x000009CE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
