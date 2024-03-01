namespace PierreBakery.Models
{
  public class Bread
  {
    public static int AmountOfBread { get; set; }
    public static int TotalBreadCost { get; set; }
    public Bread()
    {
      AmountOfBread = 0;
      TotalBreadCost = 0;
    }
    public static int CalculateTotalBreadPrice()
    {
      for (int counter = 1; counter <= AmountOfBread; counter++)
      {
        if (counter % 3 != 0)
        {
          TotalBreadCost += 5;
        }
      }
      return TotalBreadCost;
    }

    public static void ClearAll()
    {
      AmountOfBread = 0;
      TotalBreadCost = 0;
    }
  }
}