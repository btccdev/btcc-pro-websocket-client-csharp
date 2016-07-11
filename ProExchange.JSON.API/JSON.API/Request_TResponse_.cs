using System;

namespace ProExchange.JSON.API
{
	public abstract class Request<TResponse> : Request
	where TResponse : Response
	{
		protected Request()
		{
		}
	}
}