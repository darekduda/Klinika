using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Klinika.Intranet.Data;
using Klinika.Intranet.Models.CMS;

namespace Klinika.Intranet.Controllers
{
    public class ParametrController : Controller
    {
        private readonly KlinikaIntranetContext _context;

        public ParametrController(KlinikaIntranetContext context)
        {
            _context = context;
        }

        // GET: Parametr
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parametry.ToListAsync());
        }

        // GET: Parametr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametry = await _context.Parametry
                .FirstOrDefaultAsync(m => m.IdParametru == id);
            if (parametry == null)
            {
                return NotFound();
            }

            return View(parametry);
        }

        // GET: Parametr/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parametr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParametru,Nazwa,Opis,CzyAktywny")] Parametry parametry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parametry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parametry);
        }

        // GET: Parametr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametry = await _context.Parametry.FindAsync(id);
            if (parametry == null)
            {
                return NotFound();
            }
            return View(parametry);
        }

        // POST: Parametr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdParametru,Nazwa,Opis,CzyAktywny")] Parametry parametry)
        {
            if (id != parametry.IdParametru)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parametry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametryExists(parametry.IdParametru))
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
            return View(parametry);
        }

        // GET: Parametr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametry = await _context.Parametry
                .FirstOrDefaultAsync(m => m.IdParametru == id);
            if (parametry == null)
            {
                return NotFound();
            }

            return View(parametry);
        }

        // POST: Parametr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parametry = await _context.Parametry.FindAsync(id);
            _context.Parametry.Remove(parametry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParametryExists(int id)
        {
            return _context.Parametry.Any(e => e.IdParametru == id);
        }
    }
}
