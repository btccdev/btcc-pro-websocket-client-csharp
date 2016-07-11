using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Responses.Base
{
	[JsonObject]
	public abstract class CancelResponse<T> : Response<T>
	where T : Request
	{
		[JsonProperty("OID")]
		public string OrderID;

		[JsonProperty]
		public char OrdStatus;

		[JsonProperty]
		public int CxlRejReason;

		protected CancelResponse()
		{
		}
	}
}