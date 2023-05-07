using BESAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            Console.WriteLine("3 - Get Material");
            Console.WriteLine("4 - Get ID");
            Console.WriteLine("======================");
        }
        static async Task RequestPost(object jsonR) 
        {
            var json = JsonSerializer.Serialize(jsonR);
            var client = new HttpClient();
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var resposta = await client.PostAsync("https://localhost:7057/Material", stringContent);
            if (resposta.IsSuccessStatusCode)
            {

                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                Console.WriteLine(conteudoResposta);
            }

        }
        static async Task Main(string[] args)
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

                            var requisicao = new Material(material,volume);

                            await RequestPost(requisicao);

                            break; }
                    case "2": {

                            Console.WriteLine("Por Favor Digite o codigo da cor");
                            var collor = Console.ReadLine();
                            Console.WriteLine("Por Favor Digite o tamanho");
                            var size = Console.ReadLine();

                            var requisicao = new Grid(collor, size);

                             await RequestPost(requisicao);

                            break; }
                    case "3": { 
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
