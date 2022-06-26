using System;
using System.Collections.Specialized;
using System.Net;

namespace Lean.Resources
{
	// Token: 0x02000012 RID: 18
	internal class Http
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00010F80 File Offset: 0x0000F180
		public static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.UploadValues(uri, pairs);
			}
			return result;
		}
	}
}
