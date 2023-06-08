using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClairSalon.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EauClairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private EauClairSalonContext _db;

    public ClientsController(EauClairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Clients.ToList());
    }

    public ActionResult Details(int id)
    {
      var thisClient = _db.Clients
        .Include(client => client.Stylist)
        .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Create(int stylistId)
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public IActionResult Create(Client client)
    {
      if (ModelState.IsValid)
      {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      else
      {
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
        return View(client);
      }
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      if (thisClient != null)
      {
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
        return View(thisClient);
      }
      else
      {
        return NotFound();
      }
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      try
      {
        var originalClient = _db.Clients.Find(client.ClientId);
    
        if (originalClient == null)
        {
          return NotFound();
        }
    
        _db.Entry(originalClient).CurrentValues.SetValues(client);
       _db.SaveChanges();
        return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
      }
      catch (DbUpdateConcurrencyException)
      {
        return View("Error");
      }
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      if (thisClient != null)
      {
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Details", "Stylists", new { id = thisClient.StylistId });
      }
      else
      {
        return NotFound();
      }
    }
  }
}
