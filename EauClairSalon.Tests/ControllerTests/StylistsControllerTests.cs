using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EauClairSalon.Models;
using EauClairSalon.Controllers;
using System.Collections.Generic;

namespace EauClairSalon.Tests.ControllerTests
{
  [TestClass]
  public class StylistsControllerTests
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      StylistsController controller = new(null);
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectView_True()
    {
      StylistsController controller = new(null);
      ActionResult createView = controller.Create();
      Assert.IsInstanceOfType(createView, typeof(ViewResult));
    }

    [TestMethod]
    public void Details_ReturnsCorrectView_True()
    {
      StylistsController controller = new(null);
      ActionResult detailsView = controller.Details(1);
      Assert.IsInstanceOfType(detailsView, typeof(ViewResult));
    }

    [TestMethod]
    public void Edit_ReturnsCorrectView_True()
    {
      StylistsController controller = new(null);
      ActionResult editView = controller.Edit(1);
      Assert.IsInstanceOfType(editView, typeof(ViewResult));
    }

    [TestMethod]
    public void Delete_ReturnsCorrectView_True()
    {
      StylistsController controller = new(null);
      ActionResult deleteView = controller.Delete(1);
      Assert.IsInstanceOfType(deleteView, typeof(ViewResult));
    }
  }
}
