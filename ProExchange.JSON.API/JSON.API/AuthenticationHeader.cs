using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProExchange.JSON.API
{
	public class AuthenticationHeader
	{
		public string Account
		{
			get;
			private set;
		}

		public AuthenticationHeader(string encoded)
		{
			string str = Encoding.ASCII.GetString(Convert.FromBase64String(encoded.Substring("Basic ".Length)));
			this.Account = str;
		}
	}
}