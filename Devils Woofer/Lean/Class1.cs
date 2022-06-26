using System;
using System.Linq;
using Microsoft.Win32;

namespace Lean
{
	// Token: 0x02000007 RID: 7
	internal class Class1
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002800 File Offset: 0x00000A00
		public static string randomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Class1.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000284C File Offset: 0x00000A4C
		public void spoofUserMode()
		{
			this.generatedID = Class1.randomString(20);
			for (int i = 0; i < this.registryKeys.Length; i++)
			{
				this.spoofRegistryKey(i);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002888 File Offset: 0x00000A88
		private void spoofRegistryKey(int regKeyIndex)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.registryKeys[regKeyIndex], true);
			bool flag = registryKey == null;
			if (!flag)
			{
				for (int i = 0; i < this.registryKeysValues.GetLength(1); i++)
				{
					bool flag2 = this.registryKeysValues[regKeyIndex, i] == "nop";
					if (flag2)
					{
						break;
					}
					registryKey.SetValue(this.registryKeysValues[regKeyIndex, i], this.generatedID);
					this.generatedID = Class1.randomString(20);
				}
				registryKey.Close();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002920 File Offset: 0x00000B20
		public string[] getSpoofingRegistryKeys()
		{
			return this.registryKeys;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002938 File Offset: 0x00000B38
		public string[,] getSpoofingRegistryKeyValues()
		{
			return this.registryKeysValues;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002950 File Offset: 0x00000B50
		public Class1()
		{
			string[,] array = new string[7, 7];
			array[0, 0] = "SystemProductName";
			array[0, 1] = "Identifier";
			array[0, 2] = "Previous Update Revision";
			array[0, 3] = "ProcessorNameString";
			array[0, 4] = "VendorIdentifier";
			array[0, 5] = "Platform Specific Field1";
			array[0, 6] = "Component Information";
			array[1, 0] = "SerialNumber";
			array[1, 1] = "Identifier";
			array[1, 2] = "SystemManufacturer";
			array[1, 3] = "nop";
			array[1, 4] = "nop";
			array[1, 5] = "nop";
			array[1, 6] = "nop";
			array[2, 0] = "ComputerHardwareId";
			array[2, 1] = "ComputerHardwareIds";
			array[2, 2] = "BIOSVendor";
			array[2, 3] = "ProductId";
			array[2, 4] = "ProcessorNameString";
			array[2, 5] = "BIOSReleaseDate";
			array[2, 6] = "nop";
			array[3, 0] = "ProductId";
			array[3, 1] = "InstallDate";
			array[3, 2] = "InstallTime";
			array[3, 3] = "nop";
			array[3, 4] = "nop";
			array[3, 5] = "nop";
			array[3, 6] = "nop";
			array[4, 0] = "SusClientId";
			array[4, 1] = "nop";
			array[4, 2] = "nop";
			array[4, 3] = "nop";
			array[4, 4] = "nop";
			array[4, 5] = "nop";
			array[4, 6] = "nop";
			array[5, 0] = "NetCfgInstanceId";
			array[5, 1] = "NetLuidIndex";
			array[5, 2] = "nop";
			array[5, 3] = "nop";
			array[5, 4] = "nop";
			array[5, 5] = "nop";
			array[5, 6] = "nop";
			array[6, 0] = "NetworkAddress";
			array[6, 1] = "NetCfgInstanceId";
			array[6, 2] = "NetworkInterfaceInstallTimestamp";
			array[6, 3] = "nop";
			array[6, 4] = "nop";
			array[6, 5] = "nop";
			array[6, 6] = "nop";
			this.registryKeysValues = array;
			base..ctor();
		}

		// Token: 0x0400000C RID: 12
		private string generatedID;

		// Token: 0x0400000D RID: 13
		private static Random random = new Random();

		// Token: 0x0400000E RID: 14
		private string[] registryKeys = new string[]
		{
			"Hardware\\Description\\System\\CentralProcessor\\0",
			"HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
			"SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
			"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
			"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
			"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001",
			"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012"
		};

		// Token: 0x0400000F RID: 15
		private string[,] registryKeysValues;
	}
}
