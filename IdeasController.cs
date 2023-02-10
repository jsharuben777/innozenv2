using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_web_1.Models;

namespace Test_web_1.Controllers
{
    public class IdeasController : Controller
    {
        private readonly innozenContext _context;

        public IdeasController(innozenContext context)
        {
            _context = context;
        }

        // GET: Ideas
        public async Task<IActionResult> Index(string SearchString)
        {
            //return _context.Ideas != null ? 
            //View(await _context.Ideas.ToListAsync()) :
            //Problem("Entity set 'innozenContext.Ideas'  is null.");

            ViewData["CurrentFilter"] = SearchString;
            var ideasearch = from n in _context.Ideas
                             select n;
            if (!String.IsNullOrEmpty(SearchString))
            {
                ideasearch = ideasearch.Where(n => n.Full_Name.Contains(SearchString));
            }
            return View(ideasearch);
        }

        // GET: Ideas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ideas == null)
            {
                return NotFound();
            }

            var ideas = await _context.Ideas
                .FirstOrDefaultAsync(m => m.Ideas_Id == id);
            if (ideas == null)
            {
                return NotFound();
            }

            return View(ideas);
        }

        // GET: Ideas/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Empideas() //This is a TestPg1 METHOD , it looks for TestPg1 page in Home folder
        {


            return View(); // it returns the view page
        }
       

        // POST: Ideas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ideas_Id,Full_Name,Manager_Name,Problem,Cause,Solution")] Ideas ideas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ideas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ideas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Empideas([Bind("Ideas_Id,Full_Name,Manager_Name,Problem,Cause,Solution")] Ideas ideas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ideas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Empideas));
            }
            return View(ideas);
        }


        // GET: Ideas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ideas == null)
            {
                return NotFound();
            }

            var ideas = await _context.Ideas.FindAsync(id);
            if (ideas == null)
            {
                return NotFound();
            }
            return View(ideas);
        }

        // POST: Ideas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ideas_Id,Full_Name,Manager_Name,Problem,Cause,Solution")] Ideas ideas)
        {
            if (id != ideas.Ideas_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ideas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdeasExists(ideas.Ideas_Id))
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
            return View(ideas);
        }

        // GET: Ideas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ideas == null)
            {
                return NotFound();
            }

            var ideas = await _context.Ideas
                .FirstOrDefaultAsync(m => m.Ideas_Id == id);
            if (ideas == null)
            {
                return NotFound();
            }

            return View(ideas);
        }

        // POST: Ideas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ideas == null)
            {
                return Problem("Entity set 'innozenContext.Ideas'  is null.");
            }
            var ideas = await _context.Ideas.FindAsync(id);
            if (ideas != null)
            {
                _context.Ideas.Remove(ideas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdeasExists(int id)
        {
          return (_context.Ideas?.Any(e => e.Ideas_Id == id)).GetValueOrDefault();
        }
    }
}
