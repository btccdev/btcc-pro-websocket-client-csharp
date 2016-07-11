using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class PlaceOrderRequest : SignedRequest<PlaceOrderResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty]
		[SignatureBody(1)]
		public char Side;

		[JsonProperty]
		[SignatureBody(2)]
		public char OrderType;

		[JsonProperty]
		[SignatureBody(3)]
		public double Quantity;

		[JsonProperty]
		[SignatureBody(4)]
		public double Price;

		[JsonProperty]
		[SignatureBody(5)]
		public double StopPrice;

		[JsonProperty]
		[SignatureBody(6)]
		public char TIF;

		[JsonProperty]
		[SignatureBody(7)]
		public long ExprDate;

		[JsonProperty]
		[SignatureBody(8)]
		public TimeSpan ExprTime;

		public PlaceOrderRequest()
		{
		}
	}
}