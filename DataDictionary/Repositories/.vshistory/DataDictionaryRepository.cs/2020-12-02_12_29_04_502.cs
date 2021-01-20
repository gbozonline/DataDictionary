using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDictionary.Data;
using DataDictionary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataDictionary.Repositories
{
    public class DataDictionaryRepository : IDataDictionaryRepository
    {
        private DataDictionaryContext _contextData;

        public DataDictionaryRepository(DataDictionaryContext contextData)
        {
            _contextData = contextData;
        }

        public Application GetApplicationById(int id)
        {
            var application = (from c in _contextData.Applications where c.ApplicationId == id select c).Single();
            return application;
        }

        public KeywordDefinition GetDefinitionById(int id)
        {
            var definition = (from c in _contextData.KeywordDefinitions where c.KeywordDefinitionId == id select c).Single();
            return definition;
        }

        public IEnumerable<Keyword> GetKeywordsById(int id)
        {
            var keywordList = from c in _contextData.Keywords where c.KeywordDefinitionId == id select c;
            return (IEnumerable<Keyword>)keywordList;
        }

        public IEnumerable<Keyword> GetKeywordsByName(string keywordName)
        {
            var keywordList = from c in _contextData.Keywords where c.KeywordDefinitionName == keywordName select c;
            return (IEnumerable<Keyword>)keywordList;
        }

        public List<string> GetKeywordsField1(string keywordName)
        {
            List<string> FieldList = new List<string>;
        }

        public List<string> PopulateKeywordDescriptions(KeywordDefinition theDef)
        {
            List<string> DescriptionList = new List<string>();
            if (theDef.Field1Description == null)
            {
                DescriptionList.Add("This field is not used");
            } else
            {
                DescriptionList.Add(item: theDef.Field1Description);
            }

            if (theDef.Field2Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field2Description);
            }

            if (theDef.Field3Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field3Description);
            }

            if (theDef.Field4Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field4Description);
            }

            if (theDef.Field5Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field5Description);
            }

            if (theDef.Field6Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field6Description);
            }

            if (theDef.Field7Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field7Description);
            }

            if (theDef.Field8Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field8Description);
            }

            if (theDef.Field9Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field9Description);
            }

            if (theDef.Field10Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field10Description);
            }

            if (theDef.Field11Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field11Description);
            }

            if (theDef.Field12Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field12Description);
            }

            if (theDef.Field13Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field13Description);
            }

            if (theDef.Field14Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field14Description);
            }

            if (theDef.Field15Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field15Description);
            }

            if (theDef.Field16Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field16Description);
            }

            if (theDef.Field17Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field17Description);
            }

            if (theDef.Field18Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field18Description);
            }

            if (theDef.Field19Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field19Description);
            }

            if (theDef.Field20Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field20Description);
            }

            if (theDef.Field21Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field21Description);
            }

            if (theDef.Field22Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field22Description);
            }

            if (theDef.Field23Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field23Description);
            }

            if (theDef.Field24Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field24Description);
            }

            if (theDef.Field25Description == null)
            {
                DescriptionList.Add("This field is not used");
            }
            else
            {
                DescriptionList.Add(item: theDef.Field25Description);
            }


            return DescriptionList;
        }
    }
}
