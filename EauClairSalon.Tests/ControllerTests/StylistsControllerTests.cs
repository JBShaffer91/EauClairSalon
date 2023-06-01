using Microsoft.AspNetCore.Mvc;
using Xunit;
using EauClairSalon.Models;
using EauClairSalon.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EauClairSalon.Tests.ControllerTests
{
  public class StylistsControllerTests
  {
    [Fact]
    public async Task Index_ReturnsCorrectView_True()
    {
      // Arrange
      StylistsController controller = new(null);

      // Act
      IActionResult actionResult = await controller.Index();

      // Assert
      Assert.IsType<ViewResult>(actionResult);
    }

    [Fact]
    public void Create_ReturnsCorrectView_True()
    {
      // Arrange
      StylistsController controller = new(null);

      // Act
      IActionResult actionResult = controller.Create();

      // Assert
      Assert.IsType<ViewResult>(actionResult);
    }

    [Fact]
    public async Task Details_ReturnsCorrectView_True()
    {
      // Arrange
      StylistsController controller = new(null);

      // Act
      IActionResult actionResult = await controller.Details(1);

      // Assert
      Assert.IsType<ViewResult>(actionResult);
    }

    [Fact]
    public async Task Edit_ReturnsCorrectView_True()
    {
      // Arrange
      StylistsController controller = new(null);

      // Act
      IActionResult actionResult = await controller.Edit(1);

      // Assert
      Assert.IsType<ViewResult>(actionResult);
    }

    [Fact]
    public async Task Delete_ReturnsCorrectView_True()
    {
      // Arrange
      StylistsController controller = new(null);

      // Act
      IActionResult actionResult = await controller.Delete(1);

      // Assert
      Assert.IsType<ViewResult>(actionResult);
    }
  }
}
