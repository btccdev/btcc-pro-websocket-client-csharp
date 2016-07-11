using Newtonsoft.Json;
using ProExchange.Common.Security;
using System;
using System.Reflection;

namespace ProExchange.JSON.API
{
	public class JsonMessage
	{
		[JsonProperty]
		[SignatureHeader(0)]
		public string MsgType;

		public JsonMessage()
		{
			this.MsgType = this.GetType().Name;
		}
	}
}