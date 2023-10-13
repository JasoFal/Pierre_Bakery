using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetAmountOfBread_ReturnAmountOfBread_Int()
    {
      int newAmountOfBread = 6;
      Bread newBread = new Bread(newAmountOfBread);
      int result = newBread.AmountOfBread;
      Assert.AreEqual(newAmountOfBread, result);
    }

    [TestMethod]
    public void SetAmountOfBread_SetsValueOfAmountOfBread_Void()
    {
      Bread newBread = new Bread(6);
      int newAmountOfBread = 44;
      newBread.AmountOfBread = newAmountOfBread;
      Assert.AreEqual(newAmountOfBread, newBread.AmountOfBread);
    }
  }
}