using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class CancelReplaceOrderRequest : SignedRequest<CancelReplaceOrderResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty("OID")]
		[SignatureBody(1)]
		public string OrderId;

		[JsonProperty]
		[SignatureBody(2)]
		public double Quantity;

		[JsonProperty]
		[SignatureBody(3)]
		public double Price;

		[JsonProperty]
		[SignatureBody(4)]
		public double StopPrice;

		[JsonProperty]
		[SignatureBody(5)]
		public double OldQuantity;

		public CancelReplaceOrderRequest()
		{
		}
	}
}