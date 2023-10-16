using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetAmountOfPastry_ReturnAmountOfPastry_Int()
    {
      int newAmountOfPastry = 6;
      Pastry newPastry = new Pastry(newAmountOfPastry);
      int result = newPastry.AmountOfPastry;
      Assert.AreEqual(newAmountOfPastry, result);
    }

    [TestMethod]
    public void SetAmountOfPastry_SetsValueOfAmountOfPastry_Void()
    {
      Pastry newPastry = new Pastry(7);
      int newAmountOfPastry = 47;
      newPastry.AmountOfPastry = newAmountOfPastry;
      Assert.AreEqual(newAmountOfPastry, newPastry.AmountOfPastry);
    }
  }
}