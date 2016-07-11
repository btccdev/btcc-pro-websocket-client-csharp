using System;

namespace ProExchange.JSON.API
{
	public abstract class SignedRequest<TResponse> : SignedRequest
	where TResponse : Response
	{
		protected SignedRequest()
		{
		}
	}
}