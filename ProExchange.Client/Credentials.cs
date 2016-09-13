using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ProExchange.Client
{
	class Credentials
	{
		public string Account { get; private set; }
		public string Key { get; private set; }

		public Credentials(string username, string password)
		{
			GetCredentials(GetJsonWebToken(username, password));
		}

		private string GetJsonWebToken(string username, string password)
		{
			var request = WebRequest.CreateHttp("https://api.btcc.com/api.php/account/authenticate");
			request.Method = WebRequestMethods.Http.Post;
			request.ContentType = "application/x-www-form-urlencoded";

			String encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
			request.Headers.Add("Authorization", "Basic " + encoded);
			request.Headers.Add("Cache-Control", "no-cache");

			var bytes = Encoding.UTF8.GetBytes("captcha=&twofactorpwd=&keepLogin=false&msie10=false");

			var stream = request.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
			stream.Flush();
			stream.Close();

			request.Timeout = 1000;

			var r = request.GetResponse();
			return r.Headers["Json-Web-Token"];
		}

		private void GetCredentials(string token)
		{
			var request = WebRequest.CreateHttp("https://api.btcc.com/api.php/account");
			request.Method = WebRequestMethods.Http.Post;
			request.ContentType = "text/json";
			request.Headers.Add("Json-Web-Token", token);

			var bytes = Encoding.UTF8.GetBytes("{\"jsonrpc\":\"2.0\",\"method\":\"getUserAccountInfo\",\"id\":\"" + Guid.NewGuid() + "\"}");

			var stream = request.GetRequestStream();
			stream.Write(bytes, 0, bytes.Length);
			stream.Flush();
			stream.Close();

			request.Timeout = 1000;

			using (var response = new StreamReader(request.GetResponse().GetResponseStream()))
			{
				var json = response.ReadToEnd();
				var jobject = JObject.Parse(json);
				var result = jobject["result"];
				var account = result["account"];
				Account = account["id"].ToString();
				Key = account["account_key"].ToString();
			}
		}
	}
}
