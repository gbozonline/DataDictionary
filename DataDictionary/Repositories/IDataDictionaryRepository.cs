using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDictionary.Models;

namespace DataDictionary.Repositories
{
    public interface IDataDictionaryRepository
    {
        Application GetApplicationById(int id);
        KeywordDefinition GetDefinitionById(int keywordDefinitionId);
        IEnumerable<Keyword> GetKeywordsById(int keywordDefinitionId);
        IEnumerable<Keyword> GetKeywordsByName(string keywordName);
        List<string> GetKeywordsField1(IEnumerable<Keyword> keywordList);
        List<string> PopulateKeywordDescriptions(KeywordDefinition theDef);
    }
}
