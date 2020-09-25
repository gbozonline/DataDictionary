﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataDictionary.Data;
using DataDictionary.Models;

namespace DataDictionary.Controllers
{
    public class KeywordDefinitionsController : Controller
    {
        private readonly DataDictionaryContext _context;

        public KeywordDefinitionsController(DataDictionaryContext context)
        {
            _context = context;
        }

        // GET: KeywordDefinitions
        public async Task<IActionResult> Index()
        {
            var dataDictionaryContext = _context.KeywordDefinitions.Include(k => k.Application);
            return View(await dataDictionaryContext.ToListAsync());
        }

        // GET: KeywordDefinitions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keywordDefinition = await _context.KeywordDefinitions
                .Include(k => k.Application)
                .FirstOrDefaultAsync(m => m.KeywordDefinitionId == id);
            if (keywordDefinition == null)
            {
                return NotFound();
            }

            return View(keywordDefinition);
        }

        // GET: KeywordDefinitions/Create
        public IActionResult Create()
        {
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "ApplicationId", "ApplicationId");
            return View();
        }

        // POST: KeywordDefinitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KeywordDefinitionId,ApplicationId,Field1Description,Field2Description,Field3Description,Field4Description,Field5Description,Field6Description,Field7Description,Field8Description,Field9Description,Field10Description,Field11Description,Field12Description,Field13Description,Field14Description,Field15Description,Field16Description,Field17Description,Field18Description,Field19Description,Field20Description,Field21Description,Field22Description,Field23Description,Field24Description,Field25Description")] KeywordDefinition keywordDefinition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(keywordDefinition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "ApplicationId", "ApplicationId", keywordDefinition.ApplicationId);
            return View(keywordDefinition);
        }

        // GET: KeywordDefinitions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keywordDefinition = await _context.KeywordDefinitions.FindAsync(id);
            if (keywordDefinition == null)
            {
                return NotFound();
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "ApplicationId", "ApplicationId", keywordDefinition.ApplicationId);
            return View(keywordDefinition);
        }

        // POST: KeywordDefinitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KeywordDefinitionId,ApplicationId,Field1Description,Field2Description,Field3Description,Field4Description,Field5Description,Field6Description,Field7Description,Field8Description,Field9Description,Field10Description,Field11Description,Field12Description,Field13Description,Field14Description,Field15Description,Field16Description,Field17Description,Field18Description,Field19Description,Field20Description,Field21Description,Field22Description,Field23Description,Field24Description,Field25Description")] KeywordDefinition keywordDefinition)
        {
            if (id != keywordDefinition.KeywordDefinitionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(keywordDefinition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KeywordDefinitionExists(keywordDefinition.KeywordDefinitionId))
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
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "ApplicationId", "ApplicationId", keywordDefinition.ApplicationId);
            return View(keywordDefinition);
        }

        // GET: KeywordDefinitions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keywordDefinition = await _context.KeywordDefinitions
                .Include(k => k.Application)
                .FirstOrDefaultAsync(m => m.KeywordDefinitionId == id);
            if (keywordDefinition == null)
            {
                return NotFound();
            }

            return View(keywordDefinition);
        }

        // POST: KeywordDefinitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var keywordDefinition = await _context.KeywordDefinitions.FindAsync(id);
            _context.KeywordDefinitions.Remove(keywordDefinition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KeywordDefinitionExists(string id)
        {
            return _context.KeywordDefinitions.Any(e => e.KeywordDefinitionId == id);
        }
    }
}
