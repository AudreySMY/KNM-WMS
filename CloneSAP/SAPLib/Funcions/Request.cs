﻿using Newtonsoft.Json;
using SAPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SAPLib.Functions
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
        
    }
}