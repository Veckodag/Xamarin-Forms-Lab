using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MobileCloudLab
{
    public class GameManager
    {

        public static async Task<Game> GameApiCall()
        {
            Game myGame;
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            using (var client = new HttpClient(handler))
            {
                string responseBody;
                var requestUri = "https://erikberg.com/nba/boxscore/20180127-boston-celtics-at-golden-state-warriors.json";
                client.BaseAddress = new Uri(requestUri);

                string accessToken = "f6c8dd3c-4644-441f-a1a7-a48858453834";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("User-Agent", "Veckodag");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    responseBody = await content.ReadAsStringAsync();
                    myGame = JsonConvert.DeserializeObject<Game>(responseBody);
                }
            }
            return myGame;
        }
    }
}

