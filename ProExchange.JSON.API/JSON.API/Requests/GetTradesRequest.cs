using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class GetTradesRequest : Request<GetTradesResponse>
	{
		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public int Count;

		public GetTradesRequest()
		{
		}
	}
}