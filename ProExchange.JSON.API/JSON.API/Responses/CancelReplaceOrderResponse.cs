using Newtonsoft.Json;
using ProExchange.JSON.API.Requests;
using ProExchange.JSON.API.Responses.Base;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class CancelReplaceOrderResponse : CancelResponse<CancelReplaceOrderRequest>
	{
		public CancelReplaceOrderResponse()
		{
		}
	}
}