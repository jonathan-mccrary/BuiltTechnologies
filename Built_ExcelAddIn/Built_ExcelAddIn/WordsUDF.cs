using ExcelDna.Integration;
using System.Collections.Generic;
using WordsAPI.Implementation;
using WordsAPI.Models;

namespace Built_ExcelAddIn
{
    public static class WordsUDF
    {
        private static WordsAPIWrapper wrapper = new WordsAPIWrapper();

        public static List<string> GetWordAntonyms(string word)
        {
            return wrapper.GetAntonyms(word);
        }

        public static List<DefinitionData> GetWordDefinitions(string word)
        {
            return wrapper.GetDefinitions(word);
        }

        public static List<string> GetWordExamples(string word)
        {
            return wrapper.GetExamples(word);
        }

        public static List<string> GetWordRhymes(string word)
        {
            return wrapper.GetRhymes(word);
        }

        public static List<string> GetWordSynonyms(string word)
        {
            return wrapper.GetSynonyms(word);
        }

        [ExcelFunction(Description = "Word synonyms function")]
        public static string GetWordSynonymsUDF(string word)
        {
            var result = wrapper.GetSynonyms(word);
            return result != null && result.Count > 0 ? string.Join(",", wrapper.GetSynonyms(word)) : string.Empty;
        }
    }
}