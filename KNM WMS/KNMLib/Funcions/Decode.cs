using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using KNMLib.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KNMLib.Funcions
{
    public class Decode
    {
        public static (string usernameR, string idR) decodeToken(string token)
        {

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            TokenValidationParameters parameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = false,
            };
            try
            {
                // Valida e decodifica o token sem expor a chave secreta
                JwtSecurityToken decodedToken = tokenHandler.ReadJwtToken(token);
                string username = decodedToken.Claims.FirstOrDefault(c => c.Type == "username")?.Value;
                string id = decodedToken.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;

                return (username, id);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao decodificar o token: " + ex.Message);
            }
            return (null, null);
        }
    }
}
