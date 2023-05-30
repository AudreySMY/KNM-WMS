using KNMLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Script
{
    internal class Program
    {

        public static async Task AddPositionDB(int HallInitial, int QuantHall, int QuantBin, int VolumeBin, int ModelIDDefault) 
        {


            for (int i = HallInitial; i<=HallInitial+QuantHall; i++)
            {

                for (int j = 1; j <= QuantBin; j++)
                {

                    

                    string identifier;
                    //=============================================LAYER A========================================================
                    identifier = "P" + i.ToString("00") + j.ToString("000") + "A";

                    var clienteHttp = new HttpClient();

                    var url = "https://localhost:7057/Position";

                    var posicao = new Position(identifier, VolumeBin, ModelIDDefault);

                    var json = JsonConvert.SerializeObject(posicao);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await clienteHttp.PostAsync(url, content);
                    Console.WriteLine($"Criacao da Posicao : {identifier} Com volume de : 5000 e Ean padrao : 2 - Status da Operacao {response.StatusCode}");
                    //=============================================LAYER B========================================================

                    identifier = "P" + i.ToString("00") + j.ToString("000") + "B";

                    var posicaoa = new Position(identifier, VolumeBin, ModelIDDefault);

                    json = JsonConvert.SerializeObject(posicaoa);
                    content = new StringContent(json, Encoding.UTF8, "application/json");

                    response = await clienteHttp.PostAsync(url, content);
                    Console.WriteLine($"Criacao da Posicao : {identifier} Com volume de : 5000 e Ean padrao : 2 - Status da Operacao {response.StatusCode}");
                    //=============================================LAYER C========================================================

                    identifier = "P" + i.ToString("00") + j.ToString("000") + "C";

                    var posicaob = new Position(identifier, VolumeBin, ModelIDDefault);

                    json = JsonConvert.SerializeObject(posicaob);
                    content = new StringContent(json, Encoding.UTF8, "application/json");

                    response = await clienteHttp.PostAsync(url, content);
                    Console.WriteLine($"Criacao da Posicao : {identifier} Com volume de : 5000 e Ean padrao : 2 - Status da Operacao {response.StatusCode}" );

                }

            }

            
        }
        public static async Task addModel()
        {
            for (int j = 1000, k = 1; j <= 2000; j++, k++)
            {
                string marca;
                int modelnbr;
                if (k >= 8) k = 1;
                if (k == 1) marca = "0RB";
                if (k == 2) marca = "0DG";
                if (k == 3) marca = "0MK";
                if (k == 4) marca = "0PR";
                if (k == 5) marca = "0J8";
                if (k == 6) marca = "0OO";
                if (k == 7) marca = "0RY";
                else { marca = "0RX"; }

                Random rand = new Random();
                modelnbr = rand.Next(1, 9999);

                var clienteHttp = new HttpClient();

                var url = "https://localhost:7057/Model";

                var model = new Model(marca, modelnbr.ToString(), 300);

                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await clienteHttp.PostAsync(url, content);
                string identifier = marca + modelnbr.ToString();
                Console.WriteLine($"Criacao da Posicao : {identifier} Com volume de : 5000 e Ean padrao : 2 - Status da Operacao {response.StatusCode}");


            }

        }
        public static async Task addGrid()
        {
            for (int j = 1000, k = 1; j <= 2000; j++, k++)
            {
                int gridcod;
              
                Random rand = new Random();
                gridcod = rand.Next(1000, 9999);

                var clienteHttp = new HttpClient();

                var url = "https://localhost:7057/Grid";

                var model = new grid(gridcod.ToString());

                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await clienteHttp.PostAsync(url, content);
                string identifier = gridcod.ToString();
                Console.WriteLine($"Criacao da Posicao : {identifier} Com volume de : 5000 e Ean padrao : 2 - Status da Operacao {response.StatusCode}");


            }

        }

        static async Task Main()
        {
            int HallInitial = 20; // primeiro corredor a ser criado
            int QuantHall = 10; // quantidade de corredores a ser criado apos o inicial

            int QuantBin = 100; //quantidade de posicao por corredor
            int VolumeBin = 5000; // Capacidade em volume da posicao para cubagem
            int ModelIDDefault = 2; // numero do model padrao a ser criado



            //await AddPositionDB(HallInitial,QuantHall,QuantBin,VolumeBin,ModelIDDefault);
            //await addModel();
            await addGrid();
        }
    }
}
