using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class Heartbeat : Notification
	{
		public Heartbeat()
		{
		}
	}
}