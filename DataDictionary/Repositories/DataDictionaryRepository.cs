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
    }
}
