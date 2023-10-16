namespace PierreBakery.Models
{
  public class Pastry
  {
    public int AmountOfPastry { get; }
    public Pastry(int shopCartPastry)
    {
      AmountOfPastry = shopCartPastry;
    }
  }
}