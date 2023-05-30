using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EauClairSalon.Models;
using System.Linq;

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
      ViewBag.StylistId = stylistId;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      if (thisClient != null)
      {
        ViewBag.StylistId = thisClient.StylistId;
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
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
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
