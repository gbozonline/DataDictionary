using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataDictionary.Data;
using DataDictionary.Models;
using DataDictionary.Repositories;

namespace DataDictionary.Controllers
{
    public class KeywordsController : Controller
    {
        private readonly DataDictionaryContext _context;
        private IDataDictionaryRepository _dataDictionaryRepository;

        public KeywordsController(DataDictionaryContext context, IDataDictionaryRepository dataDictionaryRepository)
        {
            _context = context;
            _dataDictionaryRepository = dataDictionaryRepository;
        }

        // GET: Keywords
        public async Task<IActionResult> Index()
        {
            var dataDictionaryContext = _context.Keywords.Include(k => k.KeywordDefinition);
            return View(await dataDictionaryContext.OrderBy(a => a.KeywordDefinitionName).ToListAsync());
        }

        // GET: Keywords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords
                .Include(k => k.KeywordDefinition)
                .FirstOrDefaultAsync(m => m.KeywordId == id);
            if (keyword == null)
            {
                return NotFound();
            }

            KeywordDefinition thisDef = _dataDictionaryRepository.GetDefinitionById(keyword.KeywordDefinitionId);
            if (thisDef != null)
            {
                var descriptions = _dataDictionaryRepository.PopulateKeywordDescriptions(thisDef);
                ViewBag.Descriptions = descriptions;
            }

            return View(keyword);
        }

        // GET: Keywords/Create
        public IActionResult Create()
        {
            ViewData["KeywordDefinitionId"] = new SelectList(_context.KeywordDefinitions, "KeywordDefinitionId", "KeywordDefinitionName");
            return View();
        }

        // POST: Keywords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KeywordId,KeywordDefinitionId,KeywordDefinitionName,Field1,Field2,Field3,Field4,Field5,Field6,Field7,Field8,Field9,Field10,Field11,Field12,Field13,Field14,Field15,Field16,Field17,Field18,Field19,Field20,Field21,Field22,Field23,Field24,Field25")] Keyword keyword)
        {
            if (ModelState.IsValid)
            {
                _context.Add(keyword);
                await _context.SaveChangesAsync();

                var thisDef = _dataDictionaryRepository.GetDefinitionById(keyword.KeywordDefinitionId);
                if (thisDef != null)
                {
                    keyword.KeywordDefinitionName = thisDef.KeywordDefinitionName;
                    _context.SaveChanges();
                }

                //Dispaly the Keyword Definition only for selection, hit Save and then display the whole model for editing
                return RedirectToAction("Edit", "Keywords", new { id = keyword.KeywordId });
            }
            ViewData["KeywordDefinitionId"] = new SelectList(_context.KeywordDefinitions, "KeywordDefinitionId", "KeywordDefinitionName", keyword.KeywordDefinitionId);
            return View(keyword);
        }

        // GET: Keywords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords.FindAsync(id);
            if (keyword == null)
            {
                return NotFound();
            }

            KeywordDefinition thisDef = _dataDictionaryRepository.GetDefinitionById(keyword.KeywordDefinitionId);
            if (thisDef != null)
            {
                var descriptions = _dataDictionaryRepository.PopulateKeywordDescriptions(thisDef);
                ViewBag.Descriptions = descriptions;
            }

            ViewData["KeywordDefinitionId"] = new SelectList(_context.KeywordDefinitions, "KeywordDefinitionId", "KeywordDefinitionName", keyword.KeywordDefinitionId);
            return View(keyword);
        }

        // POST: Keywords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KeywordId,KeywordDefinitionId,KeywordDefinitionName,Field1,Field2,Field3,Field4,Field5,Field6,Field7,Field8,Field9,Field10,Field11,Field12,Field13,Field14,Field15,Field16,Field17,Field18,Field19,Field20,Field21,Field22,Field23,Field24,Field25")] Keyword keyword)
        {
            if (id != keyword.KeywordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(keyword);
                    await _context.SaveChangesAsync();

                    var thisDef = _dataDictionaryRepository.GetDefinitionById(keyword.KeywordDefinitionId);
                    if (thisDef != null)
                    {
                        keyword.KeywordDefinitionName = thisDef.KeywordDefinitionName;
                        _context.SaveChanges();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KeywordExists(keyword.KeywordId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["KeywordDefinitionId"] = new SelectList(_context.KeywordDefinitions, "KeywordDefinitionId", "KeywordDefinitionName", keyword.KeywordDefinitionId);
            return View(keyword);
        }

        // GET: Keywords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords
                .Include(k => k.KeywordDefinition)
                .FirstOrDefaultAsync(m => m.KeywordId == id);
            if (keyword == null)
            {
                return NotFound();
            }

            return View(keyword);
        }

        // POST: Keywords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var keyword = await _context.Keywords.FindAsync(id);
            _context.Keywords.Remove(keyword);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KeywordExists(int id)
        {
            return _context.Keywords.Any(e => e.KeywordId == id);
        }
    }
}
