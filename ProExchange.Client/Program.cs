using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
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
		private const string url = "wss://pro-ws.btcc.com";
		private const string SYMBOL = "XBTCNY";
		private const string BPI = "BPICNY";

		//private const string url = "wss://prousd-ws.btcc.com";
		//private const string SYMBOL = "XBTUSD";
		//private const string BPI = "BPIUSD";

		// Use the same credentials you would use on the website
		private const string username = "";
		private const string password = "";
		
		static readonly OrderBookBuilder builder = new OrderBookBuilder();

		private static ICredentials credentials;

		static void Main(string[] args)
		{
			if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(username))
				//credentials = new Credentials(username, password);
				credentials = new AccessKey(username, password);

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
			deserializer.On<GetAccountInfoResponse>(response => DisplayAccount(response.AccountInfo));
			deserializer.On<ExecReport>(Console.WriteLine);
			deserializer.On<OrderBook>(DisplayOrderBook);
			deserializer.On<ErrorResponse>(DisplayErrorResponse);
			deserializer.On<QuoteResponse>(response => DisplayOrderBook(response.OrderBook));
			
			ws.OnOpen += (a, b) =>
			{
				Console.WriteLine("Connected");
				ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = SYMBOL, QuoteType = 1 }));
				ws.Send(serializer.Serialize(new QuoteRequest() { Symbol = BPI, QuoteType = 1 }));
				if (credentials != null)
				{
					ws.Send(serializer.Serialize(Sign(new LoginRequest())));
					ws.Send(serializer.Serialize(Sign(new GetAccountInfoRequest())));
				}
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

		private static void DisplayErrorResponse(ErrorResponse obj)
		{
			Console.WriteLine("An error occured : {0}", obj.Reason);
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
			Console.WriteLine("AccountInfo :");
			foreach (var balance in info.BalanceList)
			{
				Console.WriteLine("{1} : {0}", balance.Cash, balance.Currency);
			}
		}

		private static void DisplayTicker(Ticker ticker)
		{
			Console.WriteLine(String.Format("[{2}] Ticker {0} : {1}", ticker.Symbol, ticker.Last, DateTime.Now));
		}

		private static Request Sign(SignedRequest request)
		{
			request.ClientRequestId = Guid.NewGuid().ToString("N");
			request.Account = credentials.Account;
			request.Date = DateTime.UtcNow.ToString("yyyyMMdd");
			request.Signature = SignatureEngine.ComputeSignature(
				SignatureEngine.ComputeHash(credentials.Key),
				SignatureEngine.PrepareMessage(request));
			return request;
		}
	}

	internal interface ICredentials
	{
		string Account { get; }
		string Key { get; }
	}

	internal class AccessKey : ICredentials
	{
		public AccessKey(string access_key, string secret_key)
		{
			Account = access_key;
			Key = secret_key;
		}

		public string Account { get; private set; }
		public string Key { get; private set; }
	}
}
