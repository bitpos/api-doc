using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isTestNet = true;

            const String KEY = "api_key_from_admin_portal";
            const String PASSWORD = "password_used_when_api_key_was_created";

            String authorization = String.Format("{0}:{1}", KEY, PASSWORD);
            String base64credentials = Convert.ToBase64String(new ASCIIEncoding().GetBytes(authorization));
            
            //Note fields mandatory otherwise 500 error
            BitPOS.Models.Order order = new BitPOS.Models.Order() { amount = 200, currency = "AUD", reference = "BitcoinBrisbane", description="Test Ticket", failureURL="https://www.bitcoinbrisbane.com.au/fail/1", successURL="https://www.bitcoinbrisbane.com.au/greatsuccess/1" };
            String json = JsonConvert.SerializeObject(order);

            WebClient webClient = new WebClient() { Credentials = new NetworkCredential(KEY, PASSWORD) };
            webClient.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", base64credentials);
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            
            if (isTestNet == true)
            {
                //Use this for test because of SSL issues
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            }

            String response = webClient.UploadString("https://rest.test.bitpos.me/services/webpay/order/create", json);
        }
    }
}
