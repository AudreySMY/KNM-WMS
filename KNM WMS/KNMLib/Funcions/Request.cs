using Newtonsoft.Json;
using KNMLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace KNMLib.Functions
{
    public class Request
    {
        public static async Task<string> RequestLogin(string username, string password)
        {
            var clienteHttp = new HttpClient();

            var url = "https://localhost:7143/user/Login";

            var user = new User(username, password);
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");


            var response = await clienteHttp.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var jsonR = await response.Content.ReadAsStringAsync();
                return jsonR;
            }
            var e = new ApplicationException("erro");
            return e.Message;
        }

       public static async Task<List<StockID>> getStockID(string? request)
       {

            var clienteHttp = new HttpClient();

            var url = "https://localhost:7057/Ean"+request;
            var response = (await clienteHttp.GetAsync(url));
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var stockIDs = JsonConvert.DeserializeObject<List<StockID>>(json);
                return stockIDs;
            }
            else 
            {
                throw new Exception("erro ao fazer a requisicao"); 
            }





        }
        
    }
}
