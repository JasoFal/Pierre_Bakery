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

    [TestMethod]
    public void GetTotalPastryCost_ReturnTotalPastryCost_Int()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(0, newPastry.TotalPastryCost);
    }

    [TestMethod]
    public void SetTotalPastryCost_SetsValueOfTotalPastryCost_Void()
    {
      Pastry newPastry = new Pastry(6);
      newPastry.TotalPastryCost += 5;
      Assert.AreEqual(5, newPastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_CalculatesTotalPastryPriceForOnePastry_Void()
    {
      Pastry newPastry = new Pastry(1);
      newPastry.CalculateTotalPastryPrice();
      Assert.AreEqual(2, newPastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_LoopUntilAmountOfBreadIsReached_Void()
    {
      Pastry newPastry = new Pastry(2);
      newPastry.CalculateTotalPastryPrice();
      Assert.AreEqual(4, newPastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_Every4thPastryIsSkipped_Void()
    {
      Pastry newPastry = new Pastry(20);
      newPastry.CalculateTotalPastryPrice();
      Assert.AreEqual(30, newPastry.TotalPastryCost);
    }
  }
}