using System;
using System.Collections.Generic;
using System.Linq;
using ProExchange.Common;

namespace ProExchange.Client
{
	class OrderBookBuilder
	{
		private readonly Dictionary<string, OrderBook> orderbooks = new Dictionary<string, OrderBook>();

		public Action<string> RequestFullOrderBook;

		internal class OrderBook
		{
			public int Version;
			public readonly Dictionary<double, OrderBookDetail>[] Sides = { new Dictionary<double, OrderBookDetail>(), new Dictionary<double, OrderBookDetail>() };

			public IEnumerable<OrderBookDetail> GetDetails(OrderSide.Simplified side, int count)
			{
				if (side == OrderSide.Simplified.Sell)
					return Sides[(int) side].Values.OrderBy(o => o.Price).Take(count).Reverse();
				else
					return Sides[(int) side].Values.OrderByDescending(o => o.Price).Take(count);
			}
		}

		internal class OrderBookDetail
		{
			public readonly double Price;
			public double Quantity;

			public OrderBookDetail(double price)
			{
				Price = price;
			}
		}

		public void Update(ProExchange.JSON.API.Notifications.OrderBook response)
		{
			lock (this)
			{
				OrderBook orderbook;
				var isNew = orderbooks.TryGetValue(response.Symbol, out orderbook);

				switch (response.Type)
				{
					case OrderBookType.FULL:
						orderbook = new OrderBook();
						orderbooks[response.Symbol] = orderbook;
						break;
					case OrderBookType.INCREMENTAL:
						var next = NextVersion(orderbook);
						if (next != response.Version)
							RequestFullOrderBook(response.Symbol);
						break;
					default:
						return;
				}

				foreach (var data in response.List)
				{
					var side = orderbook.Sides[(int)data.Side.SimplifyOrderSide()];
					OrderBookDetail detail;
					if (!side.TryGetValue(data.Price, out detail))
					{
						detail = new OrderBookDetail(data.Price);
						side.Add(detail.Price, detail);
					}
					detail.Quantity += data.Size;
					if (detail.Quantity == 0) side.Remove(detail.Price);
				}
				orderbook.Version = response.Version;
			}
		}

		private OrderBook BuildOrderBook(ProExchange.JSON.API.Notifications.OrderBook response)
		{
			var orderbook = new OrderBook { Version = response.Version };
			foreach (var data in response.List)
			{
				orderbook.Sides[(int)data.Side.SimplifyOrderSide()].Add(data.Price, new OrderBookDetail(data.Price) { Quantity = data.Size });
			}
			return orderbook;
		}

		private int NextVersion(OrderBook orderbook)
		{
			return (orderbook.Version == Int16.MaxValue) ? 0 : orderbook.Version + 1;
		}

		public OrderBook GetOrderBook(string symbol)
		{
			return orderbooks[symbol];
		}
	}
}
