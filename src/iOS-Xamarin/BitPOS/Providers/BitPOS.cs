using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Net;
using System.Net.Security;

using Newtonsoft.Json;

namespace BitPOS
{
	public class BitPOS
	{
		private String _key;
		private String _password;

		public BitPOS (String key, String password, Boolean testNet = false)
		{
			_key = key;
			_password = password;
		}

		public Models.BitPOS.OrderResponse CreateOrder(Int32 amountInCents)
		{
			Boolean isTestNet = true;

			//const String KEY = "api_key_from_admin_portal";
			//const String PASSWORD = "password_used_when_api_key_was_created";

			String authorization = String.Format("{0}:{1}", _key, _password);
			String base64credentials = Convert.ToBase64String(new ASCIIEncoding().GetBytes(authorization));

			//Note fields mandatory otherwise 500 error
			Models.BitPOS.OrderRequest request = new Models.BitPOS.OrderRequest() { amount = amountInCents, currency = "AUD", reference = "BitcoinBrisbane", description = "Test Ticket", failureURL="https://www.bitcoinbrisbane.com.au/fail/1", successURL="https://www.bitcoinbrisbane.com.au/greatsuccess/1" };
			String json = JsonConvert.SerializeObject(request);

			WebClient webClient = new WebClient() { Credentials = new NetworkCredential(Settings.Key, Settings.Password) };
			webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", base64credentials);
			webClient.Headers[HttpRequestHeader.ContentType] = "application/json";

			if (isTestNet == true)
			{
				//Use this for test because of SSL issues
				//System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
			}

			String response = webClient.UploadString("https://rest.bitpos.me/services/webpay/order/create", json);

			Models.BitPOS.OrderResponse orderResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.BitPOS.OrderResponse>(response);
			return orderResponse;
		}
	}
}