using Microsoft.AspNetCore.Mvc;
using Xunit;
using EauClairSalon.Models;
using EauClairSalon.Controllers;
using System.Collections.Generic;

namespace EauClairSalon.Tests.ModelTests
{
  public class StylistTests
  {
    [Fact]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new();
      Assert.Equal(typeof(Stylist), newStylist.GetType());
    }

    [Fact]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Stylist";
      Stylist newStylist = new() { Name = name };
      string result = newStylist.Name;
      Assert.Equal(name, result);
    }

    [Fact]
    public void GetSpecialty_ReturnsSpecialty_String()
    {
      string specialty = "Test Specialty";
      Stylist newStylist = new() { Specialty = specialty };
      string result = newStylist.Specialty;
      Assert.Equal(specialty, result);
    }

    [Fact]
    public void GetClients_ReturnsClients_Collection()
    {
      Stylist newStylist = new();
      Assert.Equal(typeof(HashSet<Client>), newStylist.Clients.GetType());
    }
  }
}
