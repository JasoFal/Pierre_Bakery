namespace PierreBakery.Models
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public int TotalBreadCost { get; set;  }
    public Bread(int shopCartBread)
    {
      AmountOfBread = shopCartBread;
      TotalBreadCost = 0;
    }
  }
}