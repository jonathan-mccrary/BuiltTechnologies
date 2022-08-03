using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using WordsAPI.Models;

namespace WordsAPI.Implementation
{
    public class WordsAPIWrapper
    {
        #region Base Call

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
                //result.EnsureSuccessStatusCode();
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    retVal = new WordData();
                }
                else
                {
                    var body = result.Content.ReadAsStringAsync();
                    retVal = JsonConvert.DeserializeObject<WordData>(body.Result);
                }
            }

            return retVal;
        }

        #endregion Base Call

        #region Data Calls

        public List<string> GetAntonyms(string word)
        {
            var wordData = GetWordData(word, "antonyms");
            return wordData.Antonyms;
        }

        public List<DefinitionData> GetDefinitions(string word)
        {
            var wordData = GetWordData(word, "definitions");
            return wordData.Definitions;
        }

        public List<string> GetExamples(string word)
        {
            var wordData = GetWordData(word, "examples");
            return wordData.Examples;
        }

        public List<string> GetRhymes(string word)
        {
            var wordData = GetWordData(word, "rhymes");
            return wordData.Rhymes.AllRhymes;
        }

        public List<string> GetSynonyms(string word)
        {
            var wordData = GetWordData(word, "synonyms");
            return wordData.Synonyms;
        }

        #endregion Data Calls
    }
}