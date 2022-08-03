using ExcelDna.Integration;
using System.Collections.Generic;
using System.Linq;
using WordsAPI.Implementation;

namespace Built_ExcelAddIn
{
    public static class WordsUDF
    {
        private static WordsAPIWrapper wrapper = new WordsAPIWrapper();

        [ExcelFunction(Description = "Word antonyms function")]
        public static string GetWordAntonyms(string word)
        {
            var results = wrapper.GetAntonyms(word);
            return JoinResults(results);
        }

        [ExcelFunction(Description = "Word definitions function")]
        public static string GetWordDefinitions(string word)
        {
            var results = wrapper.GetDefinitions(word).Select(p => $"{p.PartOfSpeech}: {p.Definition}").ToList();
            return JoinResults(results);
        }

        [ExcelFunction(Description = "Word examples function")]
        public static string GetWordExamples(string word)
        {
            var results = wrapper.GetExamples(word);
            return JoinResults(results);
        }

        [ExcelFunction(Description = "Word rhymes function")]
        public static string GetWordRhymes(string word)
        {
            var results = wrapper.GetRhymes(word);
            return JoinResults(results);
        }

        [ExcelFunction(Description = "Word synonyms function")]
        public static string GetWordSynonyms(string word)
        {
            var results = wrapper.GetSynonyms(word);
            return JoinResults(results);
        }

        private static string JoinResults(List<string> results)
        {
            return results != null && results.Count > 0 ? string.Join("|", results) : string.Empty;
        }
    }
}