using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class DeliveryRequest : SignedRequest<DeliveryResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public string Symbol;

		[JsonProperty]
		[SignatureBody(1)]
		public double Quantity;

		public DeliveryRequest()
		{
		}
	}
}