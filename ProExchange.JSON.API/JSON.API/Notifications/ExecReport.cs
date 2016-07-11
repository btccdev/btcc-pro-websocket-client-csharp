using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;
using System.Collections.Generic;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ExecReport : AccountNotification
	{
		[JsonProperty]
		public long Timestamp;

		[JsonProperty("CRID")]
		public string ClientRequestId;

		[JsonProperty("OID")]
		public string OrderId;

		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public char Side;

		[JsonProperty]
		public char OrderType;

		[JsonProperty]
		public double LastQty;

		[JsonProperty]
		public double CumQty;

		[JsonProperty]
		public double LeaveQty;

		[JsonProperty]
		public double Price;

		[JsonProperty]
		public double StopPrice;

		[JsonProperty]
		public char Status;

		[JsonProperty]
		public string Text;

		[JsonProperty]
		public char TimeInForce;

		[JsonProperty]
		public long ExprDate;

		[JsonProperty]
		public TimeSpan ExprTime;

		[JsonProperty]
		public double SettlementQty;

		[JsonProperty]
		public double AveragePrice;

		[JsonProperty]
		public List<ExecutionDetail> ExecutionDetails = new List<ExecutionDetail>();

		[JsonProperty]
		public long Created;

		[JsonProperty]
		public double FeeExchange;

		[JsonProperty]
		public double FeeExchangeOvernight;

		[JsonProperty]
		public List<ExecTradeFeeLog> TradeFeeLogs = new List<ExecTradeFeeLog>();

		[JsonProperty]
		public bool IsLiquidation;

		[JsonProperty]
		public bool IsEarlyProfit;

		[JsonProperty]
		public bool IsDelivery;

		public ExecReport()
		{
		}
	}
}