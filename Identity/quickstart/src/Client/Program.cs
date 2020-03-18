using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var disco = client.GetDiscoveryDocumentAsync("http://localhost:5000");
            if (disco.Result.IsError)
            {
                Console.WriteLine(disco.Result.Error);
                return;
            }
            var tokenResponse = client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest()
            {
                Address = disco.Result.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "123",
                Scope = "api1"
            });

            if (tokenResponse.Result.IsError)
            {
                Console.WriteLine(tokenResponse.Result.Error);
                return;
            }
            Console.WriteLine(tokenResponse.Result.Json);


            // call api
            var clieTtwo = new HttpClient();
            client.SetBearerToken(tokenResponse.Result.AccessToken);

            var response =   client.GetAsync("http://localhost:5001/identity");
            if (!response.Result.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Result.StatusCode);
            }
            else
            {
                var content = response.Result.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content.Result));
            }



        }
    }
}
