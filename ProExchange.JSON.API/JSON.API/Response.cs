using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Response : JsonMessageOut
	{
		[JsonProperty("RC")]
		public string ResultCode = "0";

		[JsonProperty("CRID")]
		public string ClientRequestId;

		public Response()
		{
		}
	}
}