using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class RetrieveOrderRequest : SignedRequest<RetrieveOrderResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty("OID")]
		[SignatureBody(1)]
		public string OrderID;

		public RetrieveOrderRequest()
		{
		}
	}
}