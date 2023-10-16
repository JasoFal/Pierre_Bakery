namespace PierreBakery.Models
{
  public class Pastry
  {
    public int AmountOfPastry { get; set; }
    public Pastry(int shopCartPastry)
    {
      AmountOfPastry = shopCartPastry;
    }
  }
}