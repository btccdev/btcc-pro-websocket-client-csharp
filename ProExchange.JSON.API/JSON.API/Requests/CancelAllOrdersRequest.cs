using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class CancelAllOrdersRequest : SignedRequest<CancelAllOrdersResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty]
		[SignatureBody(1)]
		public char Side;

		[JsonProperty]
		[SignatureBody(2)]
		public double HighPrice;

		[JsonProperty]
		[SignatureBody(3)]
		public double LowPrice;

		public CancelAllOrdersRequest()
		{
		}
	}
}