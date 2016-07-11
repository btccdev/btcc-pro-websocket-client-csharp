using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class RetrieveTransactionsResponse : Response
	{
		[JsonProperty]
		public ExecReport[] Reports;

		[JsonProperty]
		public ExecAccMainLog[] AccMainLogs;

		[JsonProperty]
		public ExecTradeFeeLog[] TradeFeeLogs;

		[JsonProperty]
		public int TotalCount;

		public RetrieveTransactionsResponse()
		{
		}

		public RetrieveTransactionsResponse(ExecReport[] aReports, ExecAccMainLog[] aAccMainLogs, ExecTradeFeeLog[] aTradeFeeLogs, int aTotalCounts, string aResultCode)
		{
			this.Reports = aReports;
			this.AccMainLogs = aAccMainLogs;
			this.TradeFeeLogs = aTradeFeeLogs;
			this.TotalCount = aTotalCounts;
			this.ResultCode = aResultCode;
		}
	}
}