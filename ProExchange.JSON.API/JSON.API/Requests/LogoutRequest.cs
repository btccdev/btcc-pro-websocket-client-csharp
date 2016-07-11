using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class LogoutRequest : SignedRequest<LogoutResponse>
	{
		public LogoutRequest()
		{
		}
	}
}