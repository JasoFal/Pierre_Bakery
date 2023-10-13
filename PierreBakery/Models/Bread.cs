namespace PierreBakery.Models
{
  public class Bread
  {
    public int AmountOfBread { get; set; }
    public int TotalBreadCost { get; }
    public Bread(int shopCartBread)
    {
      AmountOfBread = shopCartBread;
      TotalBreadCost = 0;
    }
  }
}