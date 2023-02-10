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
    public class FeedbacksController : Controller
    {
        public readonly innozenContext _context;

        public FeedbacksController(innozenContext context)
        {
            _context = context;
        }

        // GET: Feedbacks
        public async Task<IActionResult> Index(string SearchString)
        {
            // return _context.Feedback != null ? 
            //View(await _context.Feedback.ToListAsync()) :
            //Problem("Entity set 'innozenContext.Feedback'  is null.");

            ViewData["CurrentFilter"] = SearchString;
            var feedbacksearch = from n in _context.Feedback
                                 select n;
            if (!String.IsNullOrEmpty(SearchString))
            {
                feedbacksearch = feedbacksearch.Where(n => n.Full_Name.Contains(SearchString));
            }
            return View(feedbacksearch);
        }

        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Feedback == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.Feedback_Id == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Infoportal_5()
        {
            return View();
        }
        // POST: Feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Feedback_Id,Full_Name,Comment,Department")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }


            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Infoportal_5([Bind("Feedback_Id,Full_Name,Comment,Department")] Feedback feedback)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(feedback);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Infoportal_5));
                }
                return View(feedback);
            }

            // GET: Feedbacks/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null || _context.Feedback == null)
                {
                    return NotFound();
                }

                var feedback = await _context.Feedback.FindAsync(id);
                if (feedback == null)
                {
                    return NotFound();
                }
                return View(feedback);
            }

            // POST: Feedbacks/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Feedback_Id,Full_Name,Comment,Department")] Feedback feedback)
            {
                if (id != feedback.Feedback_Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(feedback);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FeedbackExists(feedback.Feedback_Id))
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
                return View(feedback);
            }

            // GET: Feedbacks/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null || _context.Feedback == null)
                {
                    return NotFound();
                }

                var feedback = await _context.Feedback
                    .FirstOrDefaultAsync(m => m.Feedback_Id == id);
                if (feedback == null)
                {
                    return NotFound();
                }

                return View(feedback);
            }

            // POST: Feedbacks/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                if (_context.Feedback == null)
                {
                    return Problem("Entity set 'innozenContext.Feedback'  is null.");
                }
                var feedback = await _context.Feedback.FindAsync(id);
                if (feedback != null)
                {
                    _context.Feedback.Remove(feedback);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool FeedbackExists(int id)
            {
                return (_context.Feedback?.Any(e => e.Feedback_Id == id)).GetValueOrDefault();
            }
        }
    } 
