using Microsoft.VisualStudio.TestTools.UnitTesting;
using EauClairSalon.Models;
using System.Collections.Generic;

namespace EauClairSalon.Tests.ModelTests
{
  [TestClass]
  public class StylistTests
  {
    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new();
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Stylist";
      Stylist newStylist = new() { Name = name };
      string result = newStylist.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetSpecialty_ReturnsSpecialty_String()
    {
      string specialty = "Test Specialty";
      Stylist newStylist = new() { Specialty = specialty };
      string result = newStylist.Specialty;
      Assert.AreEqual(specialty, result);
    }

    [TestMethod]
    public void GetClients_ReturnsClients_Collection()
    {
      Stylist newStylist = new();
      Assert.AreEqual(typeof(HashSet<Client>), newStylist.Clients.GetType());
    }
  }
}
