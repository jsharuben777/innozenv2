using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_web_1.Models;
using Test_web_1.Services.Business;

namespace Test_web_1.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly innozenContext _context;

        public RegistrationsController(innozenContext context)
        {
            _context = context;
        }

        // GET: Registrations & Live Search AJAX fucntion to search by Name
        public async Task<IActionResult> Index(string SearchString)
        {
              //return _context.RegisterData != null ? 
             //View(await _context.RegisterData.ToListAsync()) :
            //Problem("Entity set 'innozenContext.RegisterData'  is null.");
            //
            ViewData["CurrentFilter"] = SearchString;
            var namesearch = from n in _context.RegisterData
                             select n;
            if(!String.IsNullOrEmpty(SearchString))
            {
                namesearch = namesearch.Where(n => n.FullName.Contains(SearchString));
            }
            return View(namesearch);
        }
       
        // GET: Registrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RegisterData == null)
            {
                return NotFound();
            }

            var registration = await _context.RegisterData
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }

        // GET: Registrations/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult testpage()
        {
            return View();
        }

        // POST: Registrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,FullName,BadgeNum,Department,ManagerName,Email")] Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registration);
        }

        // POST: Registrations/testpage
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> testpage([Bind("UserId,Username,Password,FullName,BadgeNum,Department,ManagerName,Email")] Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(testpage));
            }
            return View(registration);
        }

        // GET: Registrations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RegisterData == null)
            {
                return NotFound();
            }

            var registration = await _context.RegisterData.FindAsync(id);
            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,FullName,BadgeNum,Department,ManagerName,Email")] Registration registration)
        {
            if (id != registration.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationExists(registration.UserId))
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
            return View(registration);
        }

        // GET: Registrations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RegisterData == null)
            {
                return NotFound();
            }

            var registration = await _context.RegisterData
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }

        // POST: Registrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RegisterData == null)
            {
                return Problem("Entity set 'innozenContext.RegisterData'  is null.");
            }
            var registration = await _context.RegisterData.FindAsync(id);
            if (registration != null)
            {
                _context.RegisterData.Remove(registration);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationExists(int id)
        {
          return (_context.RegisterData?.Any(e => e.UserId == id)).GetValueOrDefault();
        }

        public string Login(Registration userModel)
        {
            SecurityServices securityService = new SecurityServices();
            Boolean success = securityService.Authenticate(userModel);

            if (success)
            {
                return "Success login !";
            }
            else
            {
                return "Failure . No Login !";
            }
        }
     
    }
}
