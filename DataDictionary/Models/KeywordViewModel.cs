using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataDictionary.Models
{
    public class KeywordViewModel
    {
        public Keyword Keyword { get; set; }
        public KeywordDefinition KeywordDefinition { get; set; }
        public KeywordViewModel (Keyword keyword, KeywordDefinition keywordDefinition)
        {
            Keyword = keyword;
            KeywordDefinition = keywordDefinition;
        }
    }
}
