using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WordsAPI.Models;

namespace WordsAPI.Implementation
{
    public class WordsAPIWrapper
    {
        #region Base Call

        public async Task<WordData> GetWordData(string word, string function)
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

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                retVal = JsonConvert.DeserializeObject<WordData>(body);
            }

            return retVal;
        }

        #endregion Base Call

        #region Data Calls

        public List<string> GetAntonymns(string word)
        {
            var wordData = GetWordData(word, "antonymns");
            return wordData.Result.Antonymns;
        }

        public List<DefinitionData> GetDefinitions(string word)
        {
            var wordData = GetWordData(word, "definitions");
            return wordData.Result.Definitions;
        }

        public List<string> GetExamples(string word)
        {
            var wordData = GetWordData(word, "examples");
            return wordData.Result.Examples;
        }

        public List<string> GetRhymes(string word)
        {
            var wordData = GetWordData(word, "rhymes");
            return wordData.Result.Rhymes.AllRhymes;
        }

        public List<string> GetSynonyms(string word)
        {
            var wordData = GetWordData(word, "synonyms");
            return wordData.Result.Synonyms;
        }

        #endregion Data Calls
    }
}