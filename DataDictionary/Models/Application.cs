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
        public int ApplicationId { get; set; }

        [Display(Name = "Application Name")]
        [Required(ErrorMessage = "Please enter an Application Name")]
        public string ApplicationName { get; set; }

        [Required(ErrorMessage = "Please enter a Description")]
        public string Description { get; set; }

        public string Owner { get; set; }

        [Display(Name = "Secondary Contact")]
        public string SecAppExpert { get; set; }

        [Display(Name = "IS Contact")]
        public string ISContact { get; set; }

        public string FileName { get; set; }

        public virtual ICollection<KeywordDefinition> KeywordDefinitions { get; set; }
    }
}
