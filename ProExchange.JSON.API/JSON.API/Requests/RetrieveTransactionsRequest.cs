using Newtonsoft.Json;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Responses;
using System;

namespace ProExchange.JSON.API.Requests
{
	[JsonObject]
	public class RetrieveTransactionsRequest : SignedRequest<RetrieveTransactionsResponse>
	{
		[JsonProperty]
		[SignatureBody(0)]
		public long Start;

		[JsonProperty]
		[SignatureBody(1)]
		public long End;

		[JsonProperty]
		[SignatureBody(2)]
		public string Filter;

		[JsonProperty]
		[SignatureBody(3)]
		public int PageIndex;

		[JsonProperty]
		[SignatureBody(4)]
		public int RecCountsPerPage;

		public RetrieveTransactionsRequest()
		{
		}
	}
}