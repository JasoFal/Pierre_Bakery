using System;
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
      Console.WriteLine("For the next week if you buy 2 loaves of bread you get 1 free and if you buy 3 pastries you get 1 free.");
      Console.WriteLine("Hurry now because the offer won't last.");
      Console.WriteLine("If you wish to purchase bread type in 'bread' below, if you wish to purchase pastries type in pastry below.");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "bread" || userResponse.ToLower() == "loaves")
      {
        PurchaseBreadUIResponse();
      }
      else if (userResponse.ToLower() == "pastry" || userResponse.ToLower() == "pastries")
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
      Console.WriteLine("Please enter how many loaves you desire.");
      string userInputBread = Console.ReadLine();
      try
      {
        int shoppingCartBread = int.Parse(userInputBread);
        Bread.AmountOfBread = shoppingCartBread;
        ConfirmOrEditShopBread();
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
        Pastry.AmountOfPastry = shoppingCartPastries;
        ConfirmOrEditShopPastry();
      }
      catch
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!");
        Console.WriteLine("Error: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please try again...");
        Main();
      }
    }
    static void ConfirmOrEditShopBread()
    {
      Console.WriteLine("Please confirm purchase.");
      Console.WriteLine("Shopping Cart:");
      Console.WriteLine("-----------------------");
      Console.WriteLine($"Bread: {Bread.AmountOfBread}");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Is this correct? If so enter 'yes' below, if not enter any key.");
      string correctAmountOfBread = Console.ReadLine();
      if (correctAmountOfBread.ToLower() == "yes")
      {
        if (Pastry.AmountOfPastry == 0)
        {
          Console.WriteLine("Would you like to purchase pastries as well.");
          Console.WriteLine("If so enter 'pastry' below.");
          Console.WriteLine("Otherwise press any key.");
          string response = Console.ReadLine();
          if (response == "pastry" || response == "pastries")
          {
            PurchasePastryUIResponse();
          }
        }
        ShoppingCart();
      }
      else
      {
        Console.WriteLine("Please reenter the amount of loaves desired:");
        string reenteredShopCartBread = Console.ReadLine();
        Bread.AmountOfBread = int.Parse(reenteredShopCartBread);
        ConfirmOrEditShopBread();
      }
    }
    static void ConfirmOrEditShopPastry()
    {
      Console.WriteLine("Please confirm purchase");
      Console.WriteLine("Shopping Cart:");
      Console.WriteLine("-----------------------");
      Console.WriteLine($"Pastry: {Pastry.AmountOfPastry}");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Is this correct? If so enter 'yes' below, if not enter any other key.");
      string correctAmountOfPastry = Console.ReadLine();
      if (correctAmountOfPastry.ToLower() == "yes")
      {
        if (Bread.AmountOfBread == 0)
        {
          Pastry.CalculateTotalPastryPrice();
          Console.WriteLine("Would you like to purchase bread as well.");
          Console.WriteLine("If so enter 'bread' below.");
          string response = Console.ReadLine();
          if (response.ToLower() == "bread" || response.ToLower() == "loaves")
          {
            PurchaseBreadUIResponse();
          }
        }
        ShoppingCart();
      }
      else
      {
        Console.WriteLine("Please reenter the amount of pastries desired:");
        string reenteredShopCartPastry = Console.ReadLine();
        Pastry.AmountOfPastry = int.Parse(reenteredShopCartPastry);
        ConfirmOrEditShopPastry();
      }
    }
    static void ShoppingCart()
    {
      Bread.CalculateTotalBreadPrice();
      Pastry.CalculateTotalPastryPrice();
      Console.WriteLine("----------------------------------------------------------");
      if (Bread.AmountOfBread != 0)
      {
        Console.WriteLine($"Amount of Bread: {Bread.AmountOfBread}");
        Console.WriteLine($"Bread Cost: ${Bread.TotalBreadCost}");
      }
      if (Pastry.AmountOfPastry != 0)
      {
        Console.WriteLine($"Amount of Pastry: {Pastry.AmountOfPastry}");
        Console.WriteLine($"Pastry Cost: ${Pastry.TotalPastryCost}");
      }
      Console.WriteLine("Your total is:");
      Console.WriteLine($"${Pastry.TotalPastryCost + Bread.TotalBreadCost}");
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Thank you for shopping with us today!");
      Console.WriteLine("Goodbye!");
    }
  }
}