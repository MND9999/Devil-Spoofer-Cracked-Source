using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Lean.Resources
{
	// Token: 0x0200001D RID: 29
	public class json_wrapper
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00012C58 File Offset: 0x00010E58
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00012C78 File Offset: 0x00010E78
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00012D1C File Offset: 0x00010F1C
		public T string_to_generic<T>(string json)
		{
			return (!!0)((object)this.string_to_object(json));
		}

		// Token: 0x040000C6 RID: 198
		private DataContractJsonSerializer serializer;

		// Token: 0x040000C7 RID: 199
		private object current_object;
	}
}
