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
using Microsoft.AspNetCore.Authorization;

namespace DataDictionary.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly DataDictionaryContext _context;

        public ApplicationsController(DataDictionaryContext context)
        {
            _context = context;
        }

        // GET: Applications
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["OwnerSortParm"] = sortOrder == "Owner" ? "owner_desc" : "Owner";
            ViewData["FileSortParm"] = sortOrder == "Filename" ? "filename_desc" : "Filename";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var applications = from s in _context.Applications
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                applications = applications.Where(s => s.ApplicationName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    applications = applications.OrderByDescending(s => s.ApplicationName);
                    break;
                case "Owner":
                    applications = applications.OrderBy(s => s.Owner);
                    break;
                case "owner_desc":
                    applications = applications.OrderByDescending(s => s.Owner);
                    break;
                case "Filename":
                    applications = applications.OrderBy(s => s.FileName);
                    break;
                case "filename_desc":
                    applications = applications.OrderByDescending(s => s.FileName);
                    break;
                default:
                    applications = applications.OrderBy(s => s.ApplicationName);
                    break;
            }

            int pageSize = 3;

            return View(await PaginatedList<Application>.CreateAsync(applications.AsNoTracking(), pageNumber ?? 1, pageSize));
            //return View(await applications.AsNoTracking().ToListAsync());
            //return View(await _context.Applications.OrderBy(a => a.ApplicationName).ToListAsync());
        }

        // GET: Applications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .Include(s => s.KeywordDefinitions)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ApplicationId == id);

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Applications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationId,ApplicationName,Description,Owner,SecAppExpert,ISContact,FileName")] Application application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        // GET: Applications/Edit/5
        [Authorize(Policy = "AtLeast21")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationId,ApplicationName,Description,Owner,SecAppExpert,ISContact,FileName")] Application application)
        {
            if (id != application.ApplicationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ApplicationId))
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
            return View(application);
        }

        // GET: Applications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationId == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ApplicationId == id);
        }
    }
}
