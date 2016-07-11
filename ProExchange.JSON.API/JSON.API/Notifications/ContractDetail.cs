using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ContractDetail
	{
		[JsonProperty(PropertyName="S")]
		public string Symbol = string.Empty;

		[JsonProperty(PropertyName="TSS")]
		public double TotalSellSize;

		[JsonProperty(PropertyName="TBS")]
		public double TotalBuySize;

		[JsonProperty(PropertyName="OS")]
		public double OpenSize;

		[JsonProperty(PropertyName="AP")]
		public double AveragePrice;

		[JsonProperty(PropertyName="P")]
		public double Profit;

		[JsonProperty(PropertyName="MV")]
		public double MarketValue;

		[JsonProperty(PropertyName="IMF")]
		public double InitialMarginFactor;

		public ContractDetail()
		{
		}
	}
}