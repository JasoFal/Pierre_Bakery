namespace PierreBakery.Models
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public int TotalBreadCost { get; set; }
    public Bread(int shopCartBread)
    {
      AmountOfBread = shopCartBread;
      TotalBreadCost = 0;
    }
    public void CalculateBreadPrice()
    {
      for (int counter = 1; counter <= AmountOfBread; counter++)
      {
        if (counter % 3 != 0)
        {
          TotalBreadCost += 5;
        }
      }
    }
  }
}