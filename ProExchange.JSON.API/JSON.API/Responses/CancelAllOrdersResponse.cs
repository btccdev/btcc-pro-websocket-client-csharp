using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Requests;
using System;
using System.Collections.Generic;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class CancelAllOrdersResponse : Response<CancelAllOrdersRequest>
	{
		[JsonProperty]
		public List<string> CancelledOrdersId = new List<string>();

		public CancelAllOrdersResponse()
		{
		}
	}
}