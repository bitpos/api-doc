using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POS8.Repositories
{
    public class BitPOS
    {
        private String _password;

        public String APIKey { get; set; }

        public BitPOS(String apiKey, String password)
        {
            this.APIKey = apiKey;
            _password = password;
        }

        public async void AddOrder(Double amount, String currencyCode, String description, String reference)
        {
            String authorization = String.Format("{0}:{1}", this.APIKey, _password);

            Encoding utf8 = Encoding.UTF8;
            String base64credentials = Convert.ToBase64String(utf8.GetBytes(authorization));

            //Note fields mandatory otherwise 500 error
            Models.BitPOS.Order order = new Models.BitPOS.Order(currencyCode, Convert.ToInt32(amount * 100), description, reference);
            order.successURL = "https://www.bitcoinbrisbane.com.au/s";
            order.failureURL = "https://www.bitcoinbrisbane.com.au/f";

            String json = JsonConvert.SerializeObject(order);

            //Create client and post
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64credentials);

            Models.BitPOS.OrderResponse responseModel = new Models.BitPOS.OrderResponse();

            //HttpResponseMessage task = await client.PostAsync(new Uri("https://rest.bitpos.me/services/webpay/order/create"), new StringContent(json, Encoding.UTF8, "application/json"))
            //    .ContinueWith((taskwithresponse) =>
            //{
            //    //var response = taskwithresponse.Result;
            //    //var jsonTask = response.Content.ReadAsAsync<Models.BitPOS.OrderResponse>();
            //    //jsonTask.Wait();
            //    //responseModel = jsonTask.Result;
            //});
            
            if (App.Settings.TestNet == true)
            {
                //Use this for test because of SSL issues
                //System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            }

            //String response = webClient.UploadString("", json);
            
        }
    }
}
