using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class GetOrdersRequest : SignedRequest<GetOrdersResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty]
		[SignatureBody(1)]
		public long Begin;

		[JsonProperty]
		[SignatureBody(2)]
		public long End;

		[JsonProperty]
		[SignatureBody(3)]
		public string Status;

		public GetOrdersRequest()
		{
		}
	}
}