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

		[JsonProperty(PropertyName="G")]
		public string Group = string.Empty;

		[JsonProperty(PropertyName="BL")]
		public List<AccountBalance> BalanceList = new List<AccountBalance>();

		[JsonProperty(PropertyName="CDL")]
		public List<ContractDetail> ContractDetailList = new List<ContractDetail>();

		public AccountInfo()
		{
		}
	}
}