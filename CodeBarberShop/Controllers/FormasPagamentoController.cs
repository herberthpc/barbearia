using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeBarberShop.Data;
using CodeBarberShop.Models;

namespace CodeBarberShop.Controllers
{
    public class FormasPagamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormasPagamentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FormasPagamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormaPagamennto.ToListAsync());
        }

        // GET: FormasPagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamennto = await _context.FormaPagamennto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaPagamennto == null)
            {
                return NotFound();
            }

            return View(formaPagamennto);
        }

        // GET: FormasPagamento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormasPagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sigla")] FormaPagamennto formaPagamennto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaPagamennto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaPagamennto);
        }

        // GET: FormasPagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamennto = await _context.FormaPagamennto.FindAsync(id);
            if (formaPagamennto == null)
            {
                return NotFound();
            }
            return View(formaPagamennto);
        }

        // POST: FormasPagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sigla")] FormaPagamennto formaPagamennto)
        {
            if (id != formaPagamennto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaPagamennto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaPagamenntoExists(formaPagamennto.Id))
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
            return View(formaPagamennto);
        }

        // GET: FormasPagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamennto = await _context.FormaPagamennto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaPagamennto == null)
            {
                return NotFound();
            }

            return View(formaPagamennto);
        }

        // POST: FormasPagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaPagamennto = await _context.FormaPagamennto.FindAsync(id);
            _context.FormaPagamennto.Remove(formaPagamennto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaPagamenntoExists(int id)
        {
            return _context.FormaPagamennto.Any(e => e.Id == id);
        }
    }
}
