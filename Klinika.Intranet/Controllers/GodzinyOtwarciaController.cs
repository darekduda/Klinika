using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Klinika.Data.Data;
using Klinika.Data.Data.CMS;

namespace Klinika.Intranet.Controllers
{
    public class GodzinyOtwarciaController : Controller
    {
        private readonly KlinikaContext _context;

        public GodzinyOtwarciaController(KlinikaContext context)
        {
            _context = context;
        }

        // GET: GodzinyOtwarcia
        public async Task<IActionResult> Index()
        {
            return View(await _context.GodzinyOtwarcia.ToListAsync());
        }

        // GET: GodzinyOtwarcia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyOtwarcia = await _context.GodzinyOtwarcia
                .FirstOrDefaultAsync(m => m.IdGodzinyOtwarcia == id);
            if (godzinyOtwarcia == null)
            {
                return NotFound();
            }

            return View(godzinyOtwarcia);
        }

        // GET: GodzinyOtwarcia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GodzinyOtwarcia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGodzinyOtwarcia,Dzien,GodzinaOtwarciaOd,GodzinaOtwarciaDo,PozycjaWyswietlania,CzyAktywny")] GodzinyOtwarcia godzinyOtwarcia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(godzinyOtwarcia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(godzinyOtwarcia);
        }

        // GET: GodzinyOtwarcia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyOtwarcia = await _context.GodzinyOtwarcia.FindAsync(id);
            if (godzinyOtwarcia == null)
            {
                return NotFound();
            }
            return View(godzinyOtwarcia);
        }

        // POST: GodzinyOtwarcia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGodzinyOtwarcia,Dzien,GodzinaOtwarciaOd,GodzinaOtwarciaDo,PozycjaWyswietlania,CzyAktywny")] GodzinyOtwarcia godzinyOtwarcia)
        {
            if (id != godzinyOtwarcia.IdGodzinyOtwarcia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(godzinyOtwarcia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GodzinyOtwarciaExists(godzinyOtwarcia.IdGodzinyOtwarcia))
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
            return View(godzinyOtwarcia);
        }

        // GET: GodzinyOtwarcia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyOtwarcia = await _context.GodzinyOtwarcia
                .FirstOrDefaultAsync(m => m.IdGodzinyOtwarcia == id);
            if (godzinyOtwarcia == null)
            {
                return NotFound();
            }

            return View(godzinyOtwarcia);
        }

        // POST: GodzinyOtwarcia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var godzinyOtwarcia = await _context.GodzinyOtwarcia.FindAsync(id);
            _context.GodzinyOtwarcia.Remove(godzinyOtwarcia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GodzinyOtwarciaExists(int id)
        {
            return _context.GodzinyOtwarcia.Any(e => e.IdGodzinyOtwarcia == id);
        }
    }
}
