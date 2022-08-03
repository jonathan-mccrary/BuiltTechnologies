using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsAPI.Implementation;
using WordsAPI.Models;

namespace Built_ExcelAddIn
{
    public static class WordsUDF
    {
        [ExcelFunction(Description = "Word definitions function")]
        public static List<DefinitionData> GetWordDefinitions(string word)
        {
            WordsAPIWrapper wrapper = new WordsAPIWrapper();
            return wrapper.GetDefinitions(word);
        }

        [ExcelFunction(Description = "Word definition function")]
        public static DefinitionData GetWordFirstDefinitions(string word)
        {
            WordsAPIWrapper wrapper = new WordsAPIWrapper();
            return wrapper.GetDefinitions(word).FirstOrDefault();
        }
    }
}
