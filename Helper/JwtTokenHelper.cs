using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthentication.Helper
{
    public class JwtTokenHelper
    {
        private const string Secret_Key = "this is my custom Secret key for authnetication and what not";

        public static readonly SymmetricSecurityKey Signing_key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret_Key));

        public static string GenerateToken()
        {
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                (Signing_key, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(credentials);

            DateTime expiry = DateTime.UtcNow.AddMinutes(12);

            var ts = (int)(expiry - new DateTime(1970, 1, 1)).TotalSeconds;

            var payload = new JwtPayload
            {
                {"name", "abc" },
                {"exp", ts },
                {"iss", "https://localhost:44365/" },
                {"aud", "https://localhost:44365/" }
            };

            var secToken = new JwtSecurityToken(header, payload);

            var handler = new JwtSecurityTokenHandler();

            var token = handler.WriteToken(secToken);

            Console.WriteLine(token);
            Console.WriteLine("consume token");

            return token;

        }
    }
}
