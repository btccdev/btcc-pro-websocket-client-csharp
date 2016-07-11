using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API
{
	[JsonObject(MemberSerialization.OptIn)]
	public abstract class Response<TRequest> : Response
	where TRequest : Request
	{
		protected Response()
		{
		}
	}
}