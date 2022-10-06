﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using locadoradeveiculos.Models;

namespace locadoradeveiculos.Controllers
{
    public class AlugueisController : Controller
    {
        private readonly Contexto _context;

        public AlugueisController(Contexto context)
        {
            _context = context;
        }

        // GET: Alugueis
        public async Task<IActionResult> Index()
        {
              return View(await _context.alugueis.ToListAsync());
        }

        // GET: Alugueis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.alugueis == null)
            {
                return NotFound();
            }

            var aluguel = await _context.alugueis
                .FirstOrDefaultAsync(m => m.id == id);
            if (aluguel == null)
            {
                return NotFound();
            }

            return View(aluguel);
        }

        // GET: Alugueis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alugueis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,dataAluguel")] Aluguel aluguel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluguel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluguel);
        }

        // GET: Alugueis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.alugueis == null)
            {
                return NotFound();
            }

            var aluguel = await _context.alugueis.FindAsync(id);
            if (aluguel == null)
            {
                return NotFound();
            }
            return View(aluguel);
        }

        // POST: Alugueis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,dataAluguel")] Aluguel aluguel)
        {
            if (id != aluguel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluguel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AluguelExists(aluguel.id))
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
            return View(aluguel);
        }

        // GET: Alugueis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.alugueis == null)
            {
                return NotFound();
            }

            var aluguel = await _context.alugueis
                .FirstOrDefaultAsync(m => m.id == id);
            if (aluguel == null)
            {
                return NotFound();
            }

            return View(aluguel);
        }

        // POST: Alugueis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.alugueis == null)
            {
                return Problem("Entity set 'Contexto.alugueis'  is null.");
            }
            var aluguel = await _context.alugueis.FindAsync(id);
            if (aluguel != null)
            {
                _context.alugueis.Remove(aluguel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AluguelExists(int id)
        {
          return _context.alugueis.Any(e => e.id == id);
        }
    }
}