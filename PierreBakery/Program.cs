using System;
using System.Runtime.CompilerServices;
using PierreBakery.Models;

namespace PierreBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre Bakery.");
      Console.WriteLine("On our menu we have two options.");
      Console.WriteLine("Bread costs $5 each.");
      Console.WriteLine("Pastries cost $2 each.");
      Console.WriteLine("We are currently running a limited time promotion.");
      Console.WriteLine("For the next week if you buy 2 bread you get 1 free and if you buy 3 pastries you get 1 free.");
      Console.WriteLine("Hurry now because the offer won't last.");
      Console.WriteLine("If you wish to purchase bread type in 'bread' below, if you wish to purchase pastries type in pastry below.");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "bread")
      {
        PurchaseBreadUIResponse();
      }
      else if (userResponse.ToLower() == "pastry")
      {
        PurchasePastryUIResponse();
      }
      else
      {
        Console.WriteLine("Please enter something we actually sell!");
        Main();
      }
    }
    static void PurchaseBreadUIResponse()
    {
      Console.WriteLine("Please enter how many loafs you desire.");
      string userInputBread = Console.ReadLine();
      try
      {
        int shoppingCartBread = int.Parse(userInputBread);
        Bread shopBread = new Bread(shoppingCartBread);
        ConfirmOrEditShopBread(shopBread);
      }
      catch
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!");
        Console.WriteLine("Error: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please try again...");
        Main();
      }
    }
    static void PurchasePastryUIResponse()
    {
      Console.WriteLine("Please enter how many pastries you desire.");
      string userInputPastry = Console.ReadLine();
      try
      {
        int shoppingCartPastries = int.Parse(userInputPastry);
        Pastry shopPastry = new Pastry(shoppingCartPastries);
        ConfirmOrEditShopPastry(shopPastry);
      }
      catch
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!");
        Console.WriteLine("Error: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please try again...");
        Main();
      }
    }
    static void ConfirmOrEditShopBread(Bread shopBread)
    {
      Console.WriteLine("Please confirm purchase.");
      Console.WriteLine("Shopping Cart:");
      Console.WriteLine("-----------------------");
      Console.WriteLine($"Bread: {shopBread.AmountOfBread}");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Is this correct? If so enter 'yes' below, if not enter any other key.");
      string correctAmountOfBread = Console.ReadLine();
      if (correctAmountOfBread.ToLower() == "yes")
      {
        CalculateShoppingCartBread(shopBread);
      }
      else
      {
        Console.WriteLine("Please reenter the amount of loafs desired:");
        string reenteredShopCartBread = Console.ReadLine();
        shopBread.AmountOfBread = int.Parse(reenteredShopCartBread);
        ConfirmOrEditShopBread(shopBread);
      }
    }
    static void ConfirmOrEditShopPastry(Pastry shopPastry)
    {
      Console.WriteLine("Please confirm purchase");
      Console.WriteLine("Shopping Cart:");
      Console.WriteLine("-----------------------");
      Console.WriteLine($"Pastry: {shopPastry.AmountOfPastry}");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Is this correct? If so enter 'yes' below, if not enter any other key.");
      string correctAmountOfPastry = Console.ReadLine();
      if (correctAmountOfPastry.ToLower() == "yes")
      {
        CalculateShoppingCartPastry(shopPastry);
      }
      else
      {
        Console.WriteLine("Please reenter the amount of pastries desired:");
        string reenteredShopCartPastry = Console.ReadLine();
        shopPastry.AmountOfPastry = int.Parse(reenteredShopCartPastry);
        ConfirmOrEditShopPastry(shopPastry);
      }
    }
    static void CalculateShoppingCartBread(Bread shopBread)
    {
      shopBread.CalculateTotalBreadPrice();
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Your total is:");
      Console.WriteLine($"${shopBread.TotalBreadCost}");
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Thank you for shopping with us today!");
      Console.WriteLine("Would you like to try some of our pastries as well?");
      Console.WriteLine("If so enter 'pastries' below otherwise enter any key to exit.");
      string newOrder = Console.ReadLine();
      if (newOrder.ToLower() == "pastries")
      {
        PurchasePastryUIResponse();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
    static void CalculateShoppingCartPastry(Pastry shopPastry)
    {
      shopPastry.CalculateTotalPastryPrice();
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Your total is:");
      Console.WriteLine($"${shopPastry.TotalPastryCost}");
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Thank you for shopping with us today!");
      Console.WriteLine("Would you like to try some of our bread as well?");
      Console.WriteLine("If so enter 'bread' below otherwise enter any key to exit.");
      string newOrder = Console.ReadLine();
      if (newOrder.ToLower() == "bread")
      {
        PurchaseBreadUIResponse();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}