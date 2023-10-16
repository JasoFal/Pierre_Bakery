namespace PierreBakery.Models
{
  public class Pastry
  {
    public int AmountOfPastry { get; set; }
    public int TotalPastryCost { get; set; }
    public Pastry(int shopCartPastry)
    {
      AmountOfPastry = shopCartPastry;
      TotalPastryCost = 0;
    }
  }
}