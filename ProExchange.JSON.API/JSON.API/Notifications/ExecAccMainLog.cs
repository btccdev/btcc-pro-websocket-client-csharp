using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ExecAccMainLog
	{
		[JsonProperty]
		public string OpType;

		[JsonProperty]
		public double Cash;

		[JsonProperty]
		public long CrCreated;

		public ExecAccMainLog()
		{
		}
	}
}