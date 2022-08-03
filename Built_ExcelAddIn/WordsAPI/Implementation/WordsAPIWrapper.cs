using Newtonsoft.Json;
using System;
using System.Net.Http;
using WordsAPI.Models;

namespace WordsAPI.Implementation
{
    public class WordsAPIWrapper
    {
        public WordData GetWordData(string word, string function)
        {
            WordData retVal = new WordData();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://wordsapiv1.p.rapidapi.com/words/{word}/{function}"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ec1464670fmshb58f6114ac95042p10a826jsn67c62eb1febf" },
                    { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
                },
            };
            
            using (var response = client.SendAsync(request))
            {
                var result = response.Result;
                result.EnsureSuccessStatusCode();
                var body = result.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                retVal = JsonConvert.DeserializeObject<WordData>(body.Result);
            }

            return retVal;
        }
    }
}