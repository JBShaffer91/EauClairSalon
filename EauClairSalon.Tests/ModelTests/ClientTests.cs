using Microsoft.AspNetCore.Mvc;
using Xunit;
using EauClairSalon.Models;
using EauClairSalon.Controllers;
using System.Collections.Generic;

namespace EauClairSalon.Tests.ModelTests
{
  public class ClientTests
  {
    [Fact]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new();
      Assert.Equal(typeof(Client), newClient.GetType());
    }

    [Fact]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Client";
      Client newClient = new() { Name = name };
      string result = newClient.Name;
      Assert.Equal(name, result);
    }

    [Fact]
    public void GetStylistId_ReturnsStylistId_Int()
    {
      int stylistId = 1;
      Client newClient = new() { StylistId = stylistId };
      int result = newClient.StylistId;
      Assert.Equal(stylistId, result);
    }

    [Fact]
    public void GetStylist_ReturnsStylist_Stylist()
    {
      Stylist newStylist = new();
      Client newClient = new() { Stylist = newStylist };
      Stylist result = newClient.Stylist;
      Assert.Equal(newStylist, result);
    }
  }
}
