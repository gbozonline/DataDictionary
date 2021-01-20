using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataDictionary.Models
{
    public Application Application { get; set; }
    public KeywordDefinition KeywordDefinition { get; set; }
    public Keyword Keyword { get; set; }
    public class ApplicationViewModel
    {
        public IEnumerable<Application> Applications { get; set; }
        public IEnumerable<KeywordDefinition> KeywordDefinitions { get; set; }
        public IEnumerable<Keyword> Keywords { get; set; }
    }
}
