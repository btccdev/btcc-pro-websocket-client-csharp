using Newtonsoft.Json;
using ProExchange.Common.Security;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Request : JsonMessage
	{
		[JsonProperty("CRID")]
		[SignatureHeader(1)]
		public string ClientRequestId;

		public Request()
		{
		}
	}
}