using Microsoft.AspNetCore.Mvc;
using Xunit;
using EauClairSalon.Models;
using EauClairSalon.Controllers;
using System.Collections.Generic;

namespace EauClairSalon.Tests.ControllerTests
{
  public class ClientsControllerTests
  {
    [Fact]
    public void Index_ReturnsCorrectView_True()
    {
      ClientsController controller = new(null);
      ActionResult indexView = controller.Index();
      Assert.IsType<ViewResult>(indexView);
    }

    [Fact]
    public void Details_ReturnsCorrectView_True()
    {
      ClientsController controller = new(null);
      ActionResult detailsView = controller.Details(1);
      Assert.IsType<ViewResult>(detailsView);
    }

    [Fact]
    public void Create_ReturnsCorrectView_True()
    {
      ClientsController controller = new(null);
      ActionResult createView = controller.Create(1);
      Assert.IsType<ViewResult>(createView);
    }

    [Fact]
    public void Edit_ReturnsCorrectView_True()
    {
      ClientsController controller = new(null);
      ActionResult editView = controller.Edit(1);
      Assert.IsType<ViewResult>(editView);
    }

    [Fact]
    public void Delete_ReturnsCorrectView_True()
    {
      ClientsController controller = new(null);
      ActionResult deleteView = controller.Delete(1);
      Assert.IsType<ViewResult>(deleteView);
    }
  }
}
