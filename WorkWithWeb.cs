using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsApp2
{
    public class WorkWithWeb
    {
        private static readonly HttpClient _client = new HttpClient();

        public static string GetTextFromCoreApi(string uri)
        {
            string a = _client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            return a;
        }

        public static string Request(string uri, NameValueCollection queryString)
        {
            HttpResponseMessage response = _client.PostAsync(uri + '?' + queryString.ToString(), null).Result;
            response.EnsureSuccessStatusCode();
            var json = response.Content.ReadAsStringAsync().Result;

            return json;
        }
        public static string MakeRequest(string uri, int price, string name, int category_id)
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString.Add(nameof(price), price.ToString());
            queryString.Add(nameof(name), name);
            queryString.Add(nameof(category_id), category_id.ToString());

            return Request(uri,queryString);
        }

        public static string MakeRequest(string uri, string name)
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString.Add(nameof(name), name);

            return Request(uri,queryString);
        }
    }
}
