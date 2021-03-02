﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BazaPoklona.Models;

namespace BazaPoklona.Controllers
{
    public class PoklonsController : Controller
    {
        private readonly BazaPoklonaContext _context;

        public PoklonsController(BazaPoklonaContext context)
        {
            _context = context;
        }

        // GET: Poklons
        public async Task<IActionResult> Index()
        {
            var bazaPoklonaContext = _context.Poklons
                .Include(p => p.VrstaRobeNavigation);
            return View(await bazaPoklonaContext.ToListAsync());
        }

        public IActionResult OstvareniPrometPoklon()
        {
            // return View(await _context.VrstaRobes.ToListAsync());

            // SELECT
            // max(Naziv) as NazivRobe,
            // VrstaRobe,
            // sum(Cijena) AS UkupnoLovePoVrstiRobe
            // FROM dbo.Poklon
            // GROUP BY VrstaRobe

            //TODO Sredi Lambda expression

            var promet = _context.Poklons
                .Select(p => new { p.Naziv, p.VrstaRobe, p.Cijena})
                //.Sum(p => p.Cijena)
                //.GroupBy(p => p.VrstaRobe)
                //TODO podatke iz tablice vrstarobe ili Poklon???
                .ToList();

            //var promet = (from p in _context.Poklons 
            //              group p by p.VrstaRobe into vr
            //              select vr.ToList());

            //TODO Sredi raw SQL // NE MOGU => u MS Dokumentaciji piše: "The SQL query must return data for all properties of the entity type", a kada probam uvijek traži ID 
            //var promet = _context.Poklons
            //.FromSqlRaw("SELECT max(Naziv) as NazivRobe, VrstaRobe, sum(Cijena) AS UkupnoLovePoVrstiRobe FROM dbo.Poklon GROUP BY VrstaRobe")
            //.ToList();

            // GROUP BY IdPoklon, VrstaRobe

            //var promet = _context.Poklons
            //    .FromSqlRaw("SELECT * FROM dbo.Poklon").ToList();

            return View(promet);
            // return View(await _context.VrstaRobes.ToListAsync());
        }

        // GET: Poklons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poklon = await _context.Poklons
                .Include(p => p.VrstaRobeNavigation)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (poklon == null)
            {
                return NotFound();
            }

            return View(poklon);
        }

        // GET: Poklons/Create
        public IActionResult Create()
        {
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "ID", "Naziv");
            return View();
        }

        // POST: Poklons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Naziv,VrstaRobe,Kupljen")] Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poklon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "ID", "Naziv", poklon.VrstaRobe);
            return View(poklon);
        }

        // GET: Poklons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poklon = await _context.Poklons.FindAsync(id);
            if (poklon == null)
            {
                return NotFound();
            }
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "ID", "Naziv", poklon.VrstaRobe);
            return View(poklon);
        }

        // POST: Poklons/Kupljen/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Kupljen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poklon = await _context.Poklons.FindAsync(id);
            if (poklon == null)
            {
                return NotFound();
            }

            //Postavi svojstvo kupljen
            poklon.Kupljen = true;
            
            // spremi izmjenjeni objekt u bazu
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");  // Kad preusmjerimo na akciju ona posalje popunjenu listu na view Index
           // return View("Index");  // Ne mogu se vratiti na view bez Modela popunjenog Poklonima!!!!
        }

        // POST: Poklons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naziv,VrstaRobe,Kupljen")] Poklon poklon)
        {
            if (id != poklon.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poklon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoklonExists(poklon.ID))
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
            ViewData["VrstaRobe"] = new SelectList(_context.VrstaRobes, "ID", "Naziv", poklon.VrstaRobe);
            return View(poklon);
        }

        // GET: Poklons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poklon = await _context.Poklons
                .Include(p => p.VrstaRobeNavigation)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (poklon == null)
            {
                return NotFound();
            }

            return View(poklon);
        }

        // POST: Poklons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poklon = await _context.Poklons.FindAsync(id);
            _context.Poklons.Remove(poklon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoklonExists(int id)
        {
            return _context.Poklons.Any(e => e.ID == id);
        }
    }
}
