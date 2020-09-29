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
    }
}
