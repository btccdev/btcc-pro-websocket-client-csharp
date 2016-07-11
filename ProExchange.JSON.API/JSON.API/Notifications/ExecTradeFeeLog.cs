using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ExecTradeFeeLog
	{
		[JsonProperty(PropertyName="A")]
		public string Account;

		[JsonProperty(PropertyName="C")]
		public long Created;

		[JsonProperty(PropertyName="FTP")]
		public string FeeType;

		[JsonProperty(PropertyName="FST")]
		public string FeeSubType;

		[JsonProperty(PropertyName="Q")]
		public double Quantity;

		[JsonProperty(PropertyName="FT")]
		public double FeeTotal;

		public ExecTradeFeeLog()
		{
		}
	}
}