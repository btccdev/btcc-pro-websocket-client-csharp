using Newtonsoft.Json;
using ProExchange.Common.Security;
using System;

namespace ProExchange.JSON.API
{
	public abstract class SignedRequest : Request
	{
		[JsonProperty]
		[SignatureHeader(2)]
		public string Date;

		[JsonProperty]
		[SignatureHeader(3)]
		public string Account;

		[JsonProperty("SIG")]
		public string Signature;

		protected SignedRequest()
		{
		}
	}
}