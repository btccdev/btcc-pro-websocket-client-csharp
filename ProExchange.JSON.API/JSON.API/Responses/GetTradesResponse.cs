using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class GetTradesResponse : Response<GetTradesRequest>
	{
		[JsonProperty]
		public ExecTrade[] Trades;

		public GetTradesResponse()
		{
		}

		public GetTradesResponse(ExecTrade[] aTrades, string aResultCode)
		{
			this.Trades = aTrades;
			this.ResultCode = aResultCode;
		}
	}
}