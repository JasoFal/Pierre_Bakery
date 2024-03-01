using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void AmountOfBread_AmountOfBreadEquals0_Int()
    {
      int result = Bread.AmountOfBread;
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void SetAmountOfBread_SetsValueOfAmountOfBread_Void()
    {
      Bread.AmountOfBread = 10;
      int newAmountOfBread = 44;
      Bread.AmountOfBread = newAmountOfBread;
      Assert.AreEqual(newAmountOfBread, Bread.AmountOfBread);
    }

    [TestMethod]
    public void TotalBreadCost_TotalBreadCostEquals0_Int()
    {
      int result = Bread.TotalBreadCost;
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void SetTotalBreadCost_SetValueOfTotalBreadCost_Int()
    {
      Bread.TotalBreadCost = 50;
      int newTotalBreadCost = 20;
      Bread.TotalBreadCost = newTotalBreadCost;
      Assert.AreEqual(newTotalBreadCost, Bread.TotalBreadCost);
    }

    [TestMethod]
    public void CalculateTotalBreadPrice_CalculateTotalBreadPriceForOneLoaf_Void()
    {
      Bread.AmountOfBread = 1;
      Bread.CalculateTotalBreadPrice();
      Assert.AreEqual(5, Bread.TotalBreadCost);
    }

    [TestMethod]
    public void CalculateTotalBreadPrice_LoopUntilAmountOfBreadIsReached_Void()
    {
      Bread.AmountOfBread = 2;
      Bread.CalculateTotalBreadPrice();
      Assert.AreEqual(10, Bread.TotalBreadCost);
    }
    [TestMethod]
    public void CalculateTotalBreadPrice_Every3rdBreadIsFree_Void()
    {
      Bread.AmountOfBread = 6;
      Bread.CalculateTotalBreadPrice();
      Assert.AreEqual(20, Bread.TotalBreadCost);
    }

    [TestMethod]
    public void ClearAll_ResetsBreadPriceAndBreadAmountValues_Void()
    {
      Bread.AmountOfBread = 100;
      Bread.CalculateTotalBreadPrice();
      Bread.ClearAll();
      int result1 = Bread.TotalBreadCost;
      int result2 = Bread.AmountOfBread;
      Assert.AreEqual(result1, 0);
      Assert.AreEqual(result2, 0);
    }
  }
}