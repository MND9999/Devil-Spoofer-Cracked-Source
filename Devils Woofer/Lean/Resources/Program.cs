using System;
using System.Windows.Forms;
using Lean.Forms;

namespace Lean.Resources
{
	// Token: 0x0200001E RID: 30
	internal static class Program
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00012D2A File Offset: 0x00010F2A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
