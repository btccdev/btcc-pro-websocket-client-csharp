using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ExecutionDetail
	{
		[JsonProperty]
		public int Index;

		[JsonProperty]
		public long Timestamp;

		[JsonProperty]
		public double Price;

		[JsonProperty]
		public double TotalQuantity;

		[JsonProperty]
		public double OpenedQuantity;

		[JsonProperty]
		public double ClosedQuantity;

		public ExecutionDetail()
		{
		}
	}
}