namespace PierreBakery.Models
{
  public class Pastry
  {
    public int AmountOfPastry { get; set; }
    public int TotalPastryCost { get; }
    public Pastry(int shopCartPastry)
    {
      AmountOfPastry = shopCartPastry;
      TotalPastryCost = 0;
    }
  }
}