using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class ErrorResponse : Response
	{
		[JsonProperty]
		public string Reason;

		[JsonProperty]
		public string OriginalMsgType;

		public ErrorResponse()
		{
		}

		public ErrorResponse(string reason)
		{
			this.Reason = reason;
			this.ResultCode = "-1";
		}
	}
}