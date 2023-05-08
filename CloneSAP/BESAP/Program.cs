using BESAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BESAP
{
    public class Program
    {
        static void Menu() 
        {
            Console.WriteLine("======================");
            Console.WriteLine("Seja Bem Vindo");
            Console.WriteLine("Escolha uma  opcao");
            Console.WriteLine("======================");
            Console.WriteLine("1 - Register Material");
            Console.WriteLine("2 - Register Grid");
            Console.WriteLine("3 - Get Materials");
            Console.WriteLine("4 - Get Grids");
            Console.WriteLine("======================");
        }
        static async Task RequestPost(object jsonR,string url) 
        {
            var json = JsonSerializer.Serialize(jsonR);
            var client = new HttpClient();
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var resposta = await client.PostAsync(url, stringContent);
            if (resposta.IsSuccessStatusCode)
            {

                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                Console.WriteLine(conteudoResposta);
            }

        }
        static async Task RequestGet(string url)
        {
            var clienteHttp = new HttpClient();
            var resposta = await clienteHttp.GetAsync(url);
            var corpoResposta = await resposta.Content.ReadAsStringAsync();
            var resultadoQuebra = corpoResposta.Replace("}", Environment.NewLine);
            Console.WriteLine(resultadoQuebra);

        }

        static async Task GetMaterial(string? material) { }
        static async Task GetGrid() { }
        static async Task GetstockId() { }
        static async Task GetStorageUnit() { }



        static async Task Main()
        {
            
            bool menuOpt = true ;

            while (menuOpt) {
                Program.Menu();
                string mOption = null;
                Console.WriteLine("Escolha uma  opcao");
                mOption = Console.ReadLine();
                Console.WriteLine(mOption);

                switch (mOption)
                {
                    case "1": {

                            Console.WriteLine("Por Favor Digite O material");
                            var material = Console.ReadLine();
                            Console.WriteLine("Por Favor Digite O volume");
                            var volume = float.Parse(Console.ReadLine());
                            string url = "https://localhost:7057/Material";
                            var requisicao = new Material(material,volume);

                            await RequestPost(requisicao,url);

                            break; }
                    case "2": {

                            Console.WriteLine("Por Favor Digite o codigo da cor");
                            var collor = Console.ReadLine();
                            Console.WriteLine("Por Favor Digite o tamanho");
                            var size = Console.ReadLine();
                            string url = "https://localhost:7057/Grid";
                            var requisicao = new Grid(collor, size);

                             await RequestPost(requisicao,url);

                            break; }
                    case "3": {
                            
                            string url = "https://localhost:7057/Material";
                            await RequestGet(url);

                            break; }
                    case "4": { 
                            break; }
                    case "5": { 
                            break; }
                }

               

            }

            

        }
    }
}
