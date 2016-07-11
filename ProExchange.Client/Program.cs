using System;
using ProExchange.Common;
using ProExchange.Common.Security;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using ProExchange.JSON.API.Responses;
using WebSocketSharp;

namespace ProExchange.Client
{
	class Program
	{
		private const string url = "wss://pro-ws.btcc.com:433";
		private const string SYMBOL = "XBTCNY";
		private const string BPI = "BPICNY";

		//private const string url = "wss://prousd-ws.btcc.com:443";
		//private const string SYMBOL = "XBTUSD";
		//private const string BPI = "BPIUSD";

		// Get the credentials from the LoginRequest that is sent from your browser's WebSocket
		private const string password = "";
		private const string account = "";
		private const string email = "";

		static readonly OrderBookBuilder builder = new OrderBookBuilder();
		static void Main(string[] args)
		{
			WebSocket ws = new WebSocket(url);
			var serializer = new JsonSerializer<Request>();
			var deserializer = new JsonDeserializer<JsonMessageOut>();

			builder.RequestFullOrderBook += (symbol) =>
			{
				ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = symbol, QuoteType = 2 }));
			};

			// Add a callback to listen to the messages you are interested in
			deserializer.On<Ticker>(DisplayTicker);
			deserializer.On<AccountInfo>(DisplayAccount);
			deserializer.On<ExecReport>(Console.WriteLine);
			deserializer.On<OrderBook>(DisplayOrderBook);
			deserializer.On<QuoteResponse>(response => DisplayOrderBook(response.OrderBook));
			
			ws.OnOpen += (a, b) =>
			{
				Console.WriteLine("Connected");
				ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = SYMBOL, QuoteType = 1 }));
				//ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = BPI, QuoteType = 1 }));
				if(!String.IsNullOrEmpty(password))
					ws.Send(serializer.Serialize(Sign(new LoginRequest())));
			};
			ws.OnMessage += (a, b) => deserializer.Deserialize(b.Data);
			ws.OnError += (a, b) =>
			{
				Console.WriteLine("An error occured");
			};
			ws.OnClose += (a, b) =>
			{
				Console.WriteLine("[{0}] Connection closed", DateTime.Now);
			};

			ws.ConnectAsync();

			while (Console.ReadKey().Key != ConsoleKey.Escape)
				ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = SYMBOL, QuoteType = 2 }));
		}

		private static void DisplayOrderBook(OrderBook obj)
		{
			if (obj == null) return;
			builder.Update(obj);
			var orderbook = builder.GetOrderBook(obj.Symbol);
			Console.WriteLine("----------OrderBook Version : {0}----------", orderbook.Version);
			foreach (var detail in orderbook.GetDetails(OrderSide.Simplified.Sell, 10))
			{
				Console.WriteLine("Price : {0} Quantity : {1}", detail.Price.ToString("n2"), detail.Quantity);
			}
			Console.WriteLine("-------------------------------------------");
			foreach (var detail in orderbook.GetDetails(OrderSide.Simplified.Buy, 10))
			{
				Console.WriteLine("Price : {0} Quantity : {1}", detail.Price.ToString("n2"), detail.Quantity);
			}
			Console.WriteLine("-------------------------------------------");
		}

		private static void DisplayAccount(AccountInfo info)
		{
			Console.WriteLine(String.Format("Logged in ! Cash : {0}", info.Cash));
		}

		private static void DisplayTicker(Ticker ticker)
		{
			Console.WriteLine(String.Format("[{2}] Ticker {0} : {1}", ticker.Symbol, ticker.Last, DateTime.Now));
		}

		private static Request Sign(SignedRequest request)
		{
			request.ClientRequestId = Guid.NewGuid().ToString("N");
			request.Account = account;
			request.Date = DateTime.UtcNow.ToString("yyyyMMdd");
			request.Signature = SignatureEngine.ComputeSignature(
				SignatureEngine.ComputeHash(password),
				SignatureEngine.PrepareMessage(request));
			return request;
		}
	}
}
