using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PiggyBank.Models;

namespace PiggyBank.Controllers
{
    public class SavingsGoalsController : Controller
    {
        private readonly PiggyBankContext _context;

        public SavingsGoalsController(PiggyBankContext context)
        {
            _context = context;
        }

        // GET: SavingsGoals
        public async Task<IActionResult> Index()
        {
            return View(await _context.SavingsGoals.ToListAsync());
        }

        // GET: SavingsGoals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savingsGoal = await _context.SavingsGoals
                .FirstOrDefaultAsync(m => m.ID == id);
            if (savingsGoal == null)
            {
                return NotFound();
            }

            return View(savingsGoal);
        }

        // GET: SavingsGoals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SavingsGoals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,GoalPrice,Description,LinkToPage,LinkToImage")] SavingsGoal savingsGoal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(savingsGoal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(savingsGoal);
        }

        // GET: SavingsGoals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savingsGoal = await _context.SavingsGoals.FindAsync(id);
            if (savingsGoal == null)
            {
                return NotFound();
            }
            return View(savingsGoal);
        }

        // POST: SavingsGoals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,GoalPrice,Description,LinkToPage,LinkToImage")] SavingsGoal savingsGoal)
        {
            if (id != savingsGoal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(savingsGoal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SavingsGoalExists(savingsGoal.ID))
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
            return View(savingsGoal);
        }

        // GET: SavingsGoals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savingsGoal = await _context.SavingsGoals
                .FirstOrDefaultAsync(m => m.ID == id);
            if (savingsGoal == null)
            {
                return NotFound();
            }

            return View(savingsGoal);
        }

        // POST: SavingsGoals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var savingsGoal = await _context.SavingsGoals.FindAsync(id);
            _context.SavingsGoals.Remove(savingsGoal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SavingsGoalExists(int id)
        {
            return _context.SavingsGoals.Any(e => e.ID == id);
        }
    }
}
