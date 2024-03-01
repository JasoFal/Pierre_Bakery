using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {

    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void AmountOfPastry_AmountOfPastryEquals0_Int()
    {
      int result = Pastry.AmountOfPastry;
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void SetAmountOfPastry_SetsValueOfAmountOfPastry_Void()
    {
      Pastry.AmountOfPastry = 10;
      int newAmountOfPastry = 47;
      Pastry.AmountOfPastry = newAmountOfPastry;
      Assert.AreEqual(newAmountOfPastry, Pastry.AmountOfPastry);
    }

    [TestMethod]
    public void TotalPastryCost_TotalPastryCostEquals0_Int()
    {
      int result = Pastry.TotalPastryCost;
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void SetTotalPastryCost_SetsValueOfTotalPastryCost_Void()
    {
      Pastry.TotalPastryCost = 10;
      int newPastryCost = 20;
      Pastry.TotalPastryCost = newPastryCost;
      Assert.AreEqual(20, Pastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_CalculatesTotalPastryPriceForOnePastry_Void()
    {
      Pastry.AmountOfPastry = 1;
      Pastry.CalculateTotalPastryPrice();
      Assert.AreEqual(2, Pastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_LoopUntilAmountOfBreadIsReached_Void()
    {
      Pastry.AmountOfPastry = 2;
      Pastry.CalculateTotalPastryPrice();
      Assert.AreEqual(4, Pastry.TotalPastryCost);
    }

    [TestMethod]
    public void CalculateTotalPastryPrice_Every4thPastryIsSkipped_Void()
    {
      Pastry.AmountOfPastry = 4;
      Pastry.CalculateTotalPastryPrice();
      Assert.AreEqual(6, Pastry.TotalPastryCost);
    }

    [TestMethod]
    public void ClearAll_ResetsPastryPriceAndPastryAmountValues_Void()
    {
      Pastry.AmountOfPastry = 500;
      Pastry.CalculateTotalPastryPrice();
      Pastry.ClearAll();
      int result1 = Pastry.TotalPastryCost;
      int result2 = Pastry.AmountOfPastry;
      Assert.AreEqual(result1, 0);
      Assert.AreEqual(result2, 0);
    }
  }
}