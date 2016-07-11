using BTCC.Common.JSON;
using System;
using System.Runtime.CompilerServices;

namespace ProExchange.JSON.API
{
	public class JsonDeserializer<T> : JsonDeserializer<T, JsonDeserializerWrapper<T>>
	where T : JsonMessage
	{
		public JsonDeserializer() : base(new JsonSerializer())
		{
		}

		public bool Deserialize(string data)
		{
			return base.Deserialize(new JsonDeserializerWrapper<T>(data));
		}

		public bool On<TMessage>(Action<TMessage> callback)
		where TMessage : T
		{
			return base.On<TMessage>((TMessage message, JsonDeserializerWrapper<T> wrapper) => callback(message));
		}
	}
}