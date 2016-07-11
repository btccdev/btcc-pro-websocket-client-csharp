using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class GetAccountInfoResponse : Response<GetAccountInfoRequest>
	{
		public ProExchange.JSON.API.Notifications.AccountInfo AccountInfo;

		public GetAccountInfoResponse()
		{
		}
	}
}