using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public abstract class Notification : JsonMessageOut
	{
		protected Notification()
		{
		}
	}
}