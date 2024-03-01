namespace PierreBakery.Models
{
  public class Pastry
  {
    public static int AmountOfPastry { get; set; }
    public static int TotalPastryCost { get; set; }
    public Pastry()
    {
      AmountOfPastry = 0;
      TotalPastryCost = 0;
    }
    public static int CalculateTotalPastryPrice()
    {
      for (int counter = 1; counter <= AmountOfPastry; counter++)
      {
        if (counter % 4 != 0)
        {
          TotalPastryCost += 2;
        }
      }
      return TotalPastryCost;
    }

    public static void ClearAll()
    {
      AmountOfPastry = 0;
      TotalPastryCost = 0;
    }
  }
}