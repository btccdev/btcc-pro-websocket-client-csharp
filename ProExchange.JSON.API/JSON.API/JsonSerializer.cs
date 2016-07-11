using BTCC.Common.JSON;
using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	internal class JsonSerializer : IJsonSerializer
	{
		public JsonSerializer()
		{
		}

		public T DeserializeObject<T>(string json)
		{
			return JsonConvert.DeserializeObject<T>(json);
		}

		public string SerializeObject(object message)
		{
			return JsonConvert.SerializeObject(message);
		}
	}
}