using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeekendWindow.Data;
using WeekendWindow.Models;

namespace WeekendWindow.Controllers
{
    public class WarriorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarriorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Warriors
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var applicationDbContext = _context.Warriors.Include(w => w.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Warriors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warrior = await _context.Warriors
                .Include(w => w.IdentityUser)
                .FirstOrDefaultAsync(m => m.WarriorId == id);
            if (warrior == null)
            {
                return NotFound();
            }

            return View(warrior);
        }

        // GET: Warriors/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Warriors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WarriorId,IdentityUserId,FirstName,LastName,Address,City,State,Zipcode")] Warrior warrior)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warrior);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", warrior.IdentityUserId);
            return View(warrior);
        }

        // GET: Warriors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warrior = await _context.Warriors.FindAsync(id);
            if (warrior == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", warrior.IdentityUserId);
            return View(warrior);
        }

        // POST: Warriors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarriorId,IdentityUserId,FirstName,LastName,Address,City,State,Zipcode")] Warrior warrior)
        {
            if (id != warrior.WarriorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warrior);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarriorExists(warrior.WarriorId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", warrior.IdentityUserId);
            return View(warrior);
        }

        // GET: Warriors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warrior = await _context.Warriors
                .Include(w => w.IdentityUser)
                .FirstOrDefaultAsync(m => m.WarriorId == id);
            if (warrior == null)
            {
                return NotFound();
            }

            return View(warrior);
        }

        // POST: Warriors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warrior = await _context.Warriors.FindAsync(id);
            _context.Warriors.Remove(warrior);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarriorExists(int id)
        {
            return _context.Warriors.Any(e => e.WarriorId == id);
        }
    }
}
