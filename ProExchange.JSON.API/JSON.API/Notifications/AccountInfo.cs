using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;
using System.Collections.Generic;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class AccountInfo : AccountNotification
	{
		[JsonProperty(PropertyName="RP")]
		public string RiskProfile = string.Empty;

		[JsonProperty(PropertyName="IL")]
		public bool IsLiquidating;

		[JsonProperty(PropertyName="LP")]
		public double LiquidationPrice;

		[JsonProperty(PropertyName="SOD")]
		public double SumOfDeposit;

		[JsonProperty(PropertyName="C")]
		public double Cash;

		[JsonProperty(PropertyName="P")]
		public double Profit;

		[JsonProperty(PropertyName="TS")]
		public double TotalSize;

		[JsonProperty(PropertyName="IMR")]
		public double InitialMarginRequired;

		[JsonProperty(PropertyName="UM")]
		public double UsableMargin;

		[JsonProperty(PropertyName="CDL")]
		public List<ContractDetail> ContractDetailList = new List<ContractDetail>();

		public AccountInfo()
		{
		}
	}
}