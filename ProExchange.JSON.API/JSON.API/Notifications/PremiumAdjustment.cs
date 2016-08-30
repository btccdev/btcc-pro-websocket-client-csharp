using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class PremiumAdjustment : Notification
	{
		[JsonProperty(PropertyName="PBM")]
		public decimal PriceBandMidpoint;

		[JsonProperty(PropertyName="APP")]
		public decimal AveragePricePremium;

		[JsonProperty(PropertyName="LCCR")]
		public decimal LongCarryingChargeRate;

		[JsonProperty(PropertyName="SCCR")]
		public decimal ShortCarryingChargeRate;

		[JsonProperty(PropertyName="CCF")]
		public int CarryingChargeFrequency;

		[JsonProperty(PropertyName="ELCCR")]
		public decimal ExpectedLongCarryingChargeRate;

		[JsonProperty(PropertyName="ESCCR")]
		public decimal ExpectedShortCarryingChargeRate;

		[JsonProperty(PropertyName="ECCF")]
		public int ExpectedCarryingChargeFrequency;

		public PremiumAdjustment()
		{
		}
	}
}