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
        public int KeywordDefinitionId { get; set; }

        [Display(Name = "Keyword Description")]
        [Required(ErrorMessage = "Please enter a Keyword Description (Key)")]
        public string KeywordDefinitionName { get; set; }

        [Display(Name = "Primary Application")]
        [Required(ErrorMessage = "Please select the Primary application")]
        public int ApplicationId { get; set; }

        [Display(Name = "Application")]
        public string ApplicationName { get; set; }

        [Required(ErrorMessage = "Please enter a Field 1 Description")]
        [Display(Name = "Field1 Description")]
        public string Field1Description { get; set; }
        [Display(Name = "Field2 Description")]
        public string Field2Description { get; set; }
        [Display(Name = "Field3 Description")]
        public string Field3Description { get; set; }
        [Display(Name = "Field4 Description")]
        public string Field4Description { get; set; }
        [Display(Name = "Field5 Description")]
        public string Field5Description { get; set; }
        [Display(Name = "Field6 Description")]
        public string Field6Description { get; set; }
        [Display(Name = "Field7 Description")]
        public string Field7Description { get; set; }
        [Display(Name = "Field8 Description")]
        public string Field8Description { get; set; }
        [Display(Name = "Field9 Description")]
        public string Field9Description { get; set; }
        [Display(Name = "Field10 Description")]
        public string Field10Description { get; set; }
        [Display(Name = "Field11 Description")]
        public string Field11Description { get; set; }
        [Display(Name = "Field12 Description")]
        public string Field12Description { get; set; }
        [Display(Name = "Field13 Description")]
        public string Field13Description { get; set; }
        [Display(Name = "Field14 Description")]
        public string Field14Description { get; set; }
        [Display(Name = "Field15 Description")]
        public string Field15Description { get; set; }
        [Display(Name = "Field16 Description")]
        public string Field16Description { get; set; }
        [Display(Name = "Field17 Description")]
        public string Field17Description { get; set; }
        [Display(Name = "Field18 Description")]
        public string Field18Description { get; set; }
        [Display(Name = "Field19 Description")]
        public string Field19Description { get; set; }
        [Display(Name = "Field20 Description")]
        public string Field20Description { get; set; }
        [Display(Name = "Field21 Description")]
        public string Field21Description { get; set; }
        [Display(Name = "Field22 Description")]
        public string Field22Description { get; set; }
        [Display(Name = "Field23 Description")]
        public string Field23Description { get; set; }
        [Display(Name = "Field24 Description")]
        public string Field24Description { get; set; }
        [Display(Name = "Field25 Description")]
        public string Field25Description { get; set; }

        public virtual ICollection<Keyword> Keywords { get; set; }

        public virtual Application Application { get; set; }


    }
}
