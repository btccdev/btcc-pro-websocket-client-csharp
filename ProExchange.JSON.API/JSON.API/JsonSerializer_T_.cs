using BTCC.Common.JSON;
using System;

namespace ProExchange.JSON.API
{
	public class JsonSerializer<T> : BTCC.Common.JSON.JsonSerializer<T>
	where T : JsonMessage
	{
		public JsonSerializer() : base(new JsonSerializer())
		{
		}
	}
}