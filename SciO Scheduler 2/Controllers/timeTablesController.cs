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
    public class timeTablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public timeTablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: timeTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.timeTable.ToListAsync());
        }

        // GET: timeTables/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeTable = await _context.timeTable
                .FirstOrDefaultAsync(m => m.venue == id);
            if (timeTable == null)
            {
                return NotFound();
            }

            return View(timeTable);
        }

        // GET: timeTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: timeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("venue,blockAStartTime,blockAEndTime,blockBStartTime,blockBEndTime,blockCStartTime,blockCEndTime,blockDStartTime,blockDEndTime,blockEStartTime,blockEEndTime,blockFStartTime,blockFEndTime,bridgesStartTime,bridgesEndTime,gravityVehicleStartTime,gravityVehicleEndTime,pingPongParachuteStartTime,pingPongParachuteEndTime,trajectoryStartTime,trajectoryEndTime,wrightStuffStartTime,wrightStuffEndTime")] timeTable timeTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeTable);
        }

        // GET: timeTables/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeTable = await _context.timeTable.FindAsync(id);
            if (timeTable == null)
            {
                return NotFound();
            }
            return View(timeTable);
        }

        // POST: timeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("venue,blockAStartTime,blockAEndTime,blockBStartTime,blockBEndTime,blockCStartTime,blockCEndTime,blockDStartTime,blockDEndTime,blockEStartTime,blockEEndTime,blockFStartTime,blockFEndTime,bridgesStartTime,bridgesEndTime,gravityVehicleStartTime,gravityVehicleEndTime,pingPongParachuteStartTime,pingPongParachuteEndTime,trajectoryStartTime,trajectoryEndTime,wrightStuffStartTime,wrightStuffEndTime")] timeTable timeTable)
        {
            if (id != timeTable.venue)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!timeTableExists(timeTable.venue))
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
            return View(timeTable);
        }

        // GET: timeTables/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeTable = await _context.timeTable
                .FirstOrDefaultAsync(m => m.venue == id);
            if (timeTable == null)
            {
                return NotFound();
            }

            return View(timeTable);
        }

        // POST: timeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var timeTable = await _context.timeTable.FindAsync(id);
            _context.timeTable.Remove(timeTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool timeTableExists(string id)
        {
            return _context.timeTable.Any(e => e.venue == id);
        }
    }
}
