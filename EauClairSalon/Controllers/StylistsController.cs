using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClairSalon.Models;
using System.Linq;

namespace EauClairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly EauClairSalonContext _db;

    public StylistsController(EauClairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Stylists.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisStylist = _db.Stylists
        .Include(stylist => stylist.Clients)
        .FirstOrDefault(stylist => stylist.StylistId == id);
        return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      if (thisStylist == null)
      {
        return NotFound();  // Or redirect to a different action/view as you see fit
      }
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      if (thisStylist != null)
      {
        _db.Stylists.Remove(thisStylist);
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}
