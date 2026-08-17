namespace Restoran.Models;

public class Fries : Food
{
    public bool IsSalty { get; set; }
    public decimal Weight {  get; set; }

    public Fries(string name) : base(name)
    {
        
    }

    public override void CalcPrice()
    {
        Weight /= 1000;
        decimal price = Weight;
        if (IsSalty)
        {
            price += 0.8m;
        }
        else
        {
            price += Weight;
        }
    }
}
