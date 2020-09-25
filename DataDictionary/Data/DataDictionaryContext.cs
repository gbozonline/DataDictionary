using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataDictionary.Models;

namespace DataDictionary.Data
{
    public class DataDictionaryContext : DbContext
    {
        public DataDictionaryContext(DbContextOptions<DataDictionaryContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
