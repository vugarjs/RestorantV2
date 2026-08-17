namespace Restoran.Models;

public class Pizza : Food
{
    public decimal Radius { get; set; }
    public bool IsHot { get; set; }
    decimal Price = 0.10m;
    public Pizza(string Name, decimal radius): base(Name)
    {
        Radius = radius;
    }

    public override void CalcPrice()
    {
        
        decimal area = 3.14m * (radius * radius);
        if (area > 0)
        {
            Price *= area;
            if (IsHot)
            {
                Price += 1.15m;
            }
        }
        Console.WriteLine($"Pizza price is {Price}");
    }
    public override string ToString()
    {
        return $"{Name},{Price},{radius}";
    }
}
