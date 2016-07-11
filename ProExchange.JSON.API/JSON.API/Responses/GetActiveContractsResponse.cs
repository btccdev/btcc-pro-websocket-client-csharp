using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using System;
using System.Collections.Generic;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class GetActiveContractsResponse : Response<GetActiveContractsRequest>
	{
		public List<ActiveContract> Contracts = new List<ActiveContract>();

		public GetActiveContractsResponse()
		{
		}
	}
}