namespace PierreBakery.Models
{
  public class Bread
  {
    public int AmountOfBread { get; } 
    public Bread(int shopCartBread)
    {
      AmountOfBread = shopCartBread;
    }
  }
}