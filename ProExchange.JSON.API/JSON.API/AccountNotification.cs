using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public abstract class AccountNotification : JsonMessageOut
	{
		[JsonProperty]
		public string Account;

		protected AccountNotification()
		{
		}
	}
}