using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataDictionary.Data;
using DataDictionary.Models;
using DataDictionary.Repositories;

namespace DataDictionary.ViewComponents
{
    public class EmbeddedKeywordsViewComponent : ViewComponent
    {
        private IDataDictionaryRepository _dataDictionaryRepository;

        public EmbeddedKeywordsViewComponent(IDataDictionaryRepository dataDictionaryRepository)
        {
            _dataDictionaryRepository = dataDictionaryRepository;
        }

        public IViewComponentResult Invoke(int keywordDefinitionId)
        {
            ViewBag.EmbeddedKeywords = _dataDictionaryRepository.GetKeywordsById(keywordDefinitionId);
            return View("EmbeddedKeywords");
        }
    }
}
