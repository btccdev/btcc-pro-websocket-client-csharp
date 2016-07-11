using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public class JsonMessageOut : JsonMessage
	{
		public JsonMessageOut()
		{
		}
	}
}