using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataDictionary.Models
{
    public class KeywordDefinition
    {
        [Display(Name = "Keyword Description")]
        [Required(ErrorMessage = "Please enter a Keyword Description (Key)")]
        public string KeywordDefinitionId { get; set; }

        [Display(Name = "Applications")]
        [Required(ErrorMessage = "Please select an application")]
        public string ApplicationId { get; set; }

        [Required(ErrorMessage = "Please enter a Field 1 Description")]
        public string Field1Description { get; set; }
        public string Field2Description { get; set; }
        public string Field3Description { get; set; }
        public string Field4Description { get; set; }
        public string Field5Description { get; set; }
        public string Field6Description { get; set; }
        public string Field7Description { get; set; }
        public string Field8Description { get; set; }
        public string Field9Description { get; set; }
        public string Field10Description { get; set; }
        public string Field11Description { get; set; }
        public string Field12Description { get; set; }
        public string Field13Description { get; set; }
        public string Field14Description { get; set; }
        public string Field15Description { get; set; }
        public string Field16Description { get; set; }
        public string Field17Description { get; set; }
        public string Field18Description { get; set; }
        public string Field19Description { get; set; }
        public string Field20Description { get; set; }
        public string Field21Description { get; set; }
        public string Field22Description { get; set; }
        public string Field23Description { get; set; }
        public string Field24Description { get; set; }
        public string Field25Description { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }
        public virtual Application Application { get; set; }


    }
}
