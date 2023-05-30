using Microsoft.VisualStudio.TestTools.UnitTesting;
using EauClairSalon.Models;

namespace EauClairSalon.Tests.ModelTests
{
  [TestClass]
  public class ClientTests
  {
    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new();
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Client";
      Client newClient = new() { Name = name };
      string result = newClient.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetStylistId_ReturnsStylistId_Int()
    {
      int stylistId = 1;
      Client newClient = new() { StylistId = stylistId };
      int result = newClient.StylistId;
      Assert.AreEqual(stylistId, result);
    }

    [TestMethod]
    public void GetStylist_ReturnsStylist_Stylist()
    {
      Stylist newStylist = new();
      Client newClient = new() { Stylist = newStylist };
      Stylist result = newClient.Stylist;
      Assert.AreEqual(newStylist, result);
    }
  }
}
