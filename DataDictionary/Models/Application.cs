using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataDictionary.Models
{
    public class Application
    {
        [Display(Name = "Application Name")]
        [Required(ErrorMessage = "Please enter an Application Name")]
        public string ApplicationId { get; set; }

        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public string FileName { get; set; }

        public virtual ICollection<KeywordDefinition> KeywordDefinitions { get; set; }
    }
}
