using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClairSalon.Models;
using System.Linq;
using System.Threading.Tasks;

namespace EauClairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly EauClairSalonContext _db;

    public StylistsController(EauClairSalonContext db)
    {
      _db = db;
    }

    public async Task<IActionResult> Index()
    {
      return View(await _db.Stylists.ToListAsync());
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Stylist stylist)
    {
      if(ModelState.IsValid)
      {
        _db.Stylists.Add(stylist);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }

      return View(stylist);
    }

    public async Task<IActionResult> Details(int id)
    {
      var thisStylist = await _db.Stylists
        .Include(stylist => stylist.Clients)
        .FirstOrDefaultAsync(stylist => stylist.StylistId == id);
      if(thisStylist == null)
      {
        return NotFound();
      }
      return View(thisStylist);
    }

    public async Task<IActionResult> Edit(int id)
    {
      var thisStylist = await _db.Stylists.FindAsync(id);
      if(thisStylist == null)
      {
        return NotFound();
      }
      return View(thisStylist);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, Stylist stylist)
    {
      if(id != stylist.StylistId)
      {
        return NotFound();
      }

      if(ModelState.IsValid)
      {
        try
        {
          _db.Update(stylist);
          await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!StylistExists(stylist.StylistId))
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
      return View(stylist);
    }

    public async Task<IActionResult> Delete(int id)
    {
      var thisStylist = await _db.Stylists.FindAsync(id);
      if (thisStylist == null)
      {
        return NotFound();
      }
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var thisStylist = await _db.Stylists.FindAsync(id);
      if (thisStylist != null)
      {
        _db.Stylists.Remove(thisStylist);
        await _db.SaveChangesAsync();
      }
      return RedirectToAction(nameof(Index));
    }

    private bool StylistExists(int id)
    {
      return _db.Stylists.Any(e => e.StylistId == id);
    }
  }
}
