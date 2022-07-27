using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FantasyBallers.Controllers
{
    public class FantasyTeamController : Controller
    {
        private readonly Context _context;

        public FantasyTeamController(Context context)
        {
            _context = context;
        }

        // GET: FantasyTeam
        public async Task<IActionResult> Index()
        {
              return _context.FantasyTeams != null ? 
                          View(await _context.FantasyTeams.ToListAsync()) :
                          Problem("Entity set 'Context.FantasyTeams'  is null.");
        }

        // GET: FantasyTeam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FantasyTeams == null)
            {
                return NotFound();
            }

            var fantasyTeam = await _context.FantasyTeams
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fantasyTeam == null)
            {
                return NotFound();
            }

            return View(fantasyTeam);
        }

        // GET: FantasyTeam/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FantasyTeam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,QB1,QB2,RB1,RB2,WR1,WR2,TE,Flex,Kicker,Defense,SkillLevel,TouchdownsScoredLastYear,TouchDownsProjected")] FantasyTeam fantasyTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fantasyTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fantasyTeam);
        }

        // GET: FantasyTeam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FantasyTeams == null)
            {
                return NotFound();
            }

            var fantasyTeam = await _context.FantasyTeams.FindAsync(id);
            if (fantasyTeam == null)
            {
                return NotFound();
            }
            return View(fantasyTeam);
        }

        // POST: FantasyTeam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,QB1,QB2,RB1,RB2,WR1,WR2,TE,Flex,Kicker,Defense,SkillLevel,TouchdownsScoredLastYear,TouchDownsProjected")] FantasyTeam fantasyTeam)
        {
            if (id != fantasyTeam.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fantasyTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FantasyTeamExists(fantasyTeam.ID))
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
            return View(fantasyTeam);
        }

        // GET: FantasyTeam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FantasyTeams == null)
            {
                return NotFound();
            }

            var fantasyTeam = await _context.FantasyTeams
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fantasyTeam == null)
            {
                return NotFound();
            }

            return View(fantasyTeam);
        }

        // POST: FantasyTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FantasyTeams == null)
            {
                return Problem("Entity set 'Context.FantasyTeams'  is null.");
            }
            var fantasyTeam = await _context.FantasyTeams.FindAsync(id);
            if (fantasyTeam != null)
            {
                _context.FantasyTeams.Remove(fantasyTeam);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FantasyTeamExists(int id)
        {
          return (_context.FantasyTeams?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
