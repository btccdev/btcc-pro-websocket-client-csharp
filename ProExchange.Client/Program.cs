using System;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Requests;
using ProExchange.JSON.API.Responses;
using WebSocketSharp;

namespace ProExchange.Client
{
	class Program
	{
		private const string url = "wss://pro-ws.btcc.com:2012";
		// Get the credentials from the LoginRequest that is sent from your browser's WebSocket
		private const string password = "";
		private const string account = "";
		private const string email = "";

		static void Main(string[] args)
		{
			WebSocket ws = new WebSocket(url);
			var serializer = new JsonSerializer<Request>();
			var deserializer = new JsonDeserializer<Response>();

			// Add a callback to listen to the messages you are interested in
			deserializer.On<Ticker>(DisplayTicker);
			deserializer.On<AccountInfo>(DisplayAccount);
			deserializer.On<ExecReport>(Console.WriteLine);
			
			ws.OnOpen += (a, b) =>
			{
				Console.WriteLine("Connected");
				ws.Send(serializer.Serialize(new QuoteRequest("XBTCNY", 2)));
				ws.Send(serializer.Serialize(new QuoteRequest("BPICNY", 2)));
				ws.Send(serializer.Serialize(Sign(new LoginRequest(email, account, password))));
			};
			ws.OnMessage += (a, b) => deserializer.Deserialize(b.Data);
			ws.OnError += (a, b) =>
			{
				Console.WriteLine("An error occured");
			};

			ws.ConnectAsync();

			Console.ReadKey();
		}

		private static void DisplayAccount(AccountInfo info)
		{
			Console.WriteLine(String.Format("Logged in ! Cash : {0}", info.Cash));
		}

		private static void DisplayTicker(Ticker ticker)
		{
			Console.WriteLine(String.Format("Ticker {0} : {1}", ticker.Symbol, ticker.Last));
		}

		private static Request Sign(Request request)
		{
			request.Signature = SignatureEngine.ComputeSignature(
				SignatureEngine.ComputeHash(password),
				SignatureEngine.PrepareMessage(request));
			return request;
		}
	}
}
