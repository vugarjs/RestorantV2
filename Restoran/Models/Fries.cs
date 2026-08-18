namespace Restoran.Models;

public class Fries : Food
{
    public bool IsSalty { get; set; }
    public decimal Weight {  get; set; }

    public Fries(string name,decimal weight) : base(name)
    {
        Weight = weight;
        PrepareTime = TimeSpan.FromMinutes(20);
    }

    public override void CalcPrice()
    {
        Weight /= 1000;
        decimal price = Weight;
        if (IsSalty)//duzludursa elave 0.80azn
        {
            price += 0.8m;
        }
        else
        {
            price += Weight;
        }
    }
    public override string ToString() // to string methodu override
    {
        return $"Name : {Name}| Weight : {Weight}| Price : {Weight}|";
    }
}
