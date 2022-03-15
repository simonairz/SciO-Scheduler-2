#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SciO_Scheduler_2.Data;
using SciO_Scheduler_2.Models;

namespace SciO_Scheduler_2.Controllers
{
    public class GanttsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GanttsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gantts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gantt.ToListAsync());
        }

        // GET: Gantts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gantt = await _context.Gantt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gantt == null)
            {
                return NotFound();
            }

            return View(gantt);
        }

        // GET: Gantts/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Gantts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,studentName,studentLastName,studentEvents,email")] Gantt gantt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gantt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gantt);
        }

        // GET: Gantts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gantt = await _context.Gantt.FindAsync(id);
            if (gantt == null)
            {
                return NotFound();
            }
            return View(gantt);
        }

        // POST: Gantts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,studentName,studentLastName,studentEvents,email")] Gantt gantt)
        {
            if (id != gantt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gantt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GanttExists(gantt.Id))
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
            return View(gantt);
        }

        // GET: Gantts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gantt = await _context.Gantt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gantt == null)
            {
                return NotFound();
            }

            return View(gantt);
        }

        // POST: Gantts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gantt = await _context.Gantt.FindAsync(id);
            _context.Gantt.Remove(gantt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GanttExists(int id)
        {
            return _context.Gantt.Any(e => e.Id == id);
        }
    }
}
