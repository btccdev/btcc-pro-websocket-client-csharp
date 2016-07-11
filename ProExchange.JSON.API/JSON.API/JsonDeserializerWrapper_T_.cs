using BTCC.Common.JSON;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace ProExchange.JSON.API
{
	public class JsonDeserializerWrapper<T> : IJsonDeserializable<T>
	where T : JsonMessage
	{
		public string Json
		{
			get
			{
				return JustDecompileGenerated_get_Json();
			}
			set
			{
				JustDecompileGenerated_set_Json(value);
			}
		}

		private string JustDecompileGenerated_Json_k__BackingField;

		public string JustDecompileGenerated_get_Json()
		{
			return this.JustDecompileGenerated_Json_k__BackingField;
		}

		private void JustDecompileGenerated_set_Json(string value)
		{
			this.JustDecompileGenerated_Json_k__BackingField = value;
		}

		public T Object
		{
			get
			{
				return JustDecompileGenerated_get_Object();
			}
			set
			{
				JustDecompileGenerated_set_Object(value);
			}
		}

		private T JustDecompileGenerated_Object_k__BackingField;

		public T JustDecompileGenerated_get_Object()
		{
			return this.JustDecompileGenerated_Object_k__BackingField;
		}

		private void JustDecompileGenerated_set_Object(T value)
		{
			this.JustDecompileGenerated_Object_k__BackingField = value;
		}

		public string Type
		{
			get
			{
				return this.Object.MsgType;
			}
		}

		public JsonDeserializerWrapper(string json)
		{
			this.Json = json;
			this.Object = JsonConvert.DeserializeObject<T>(json);
		}
	}
}