namespace Restoran.Models;

public abstract class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public TimeSpan PrepareTime { get; set; }
    public abstract void CalcPrice();

    protected Food(string name)
    {
        Name = name;
        Created = DateTime.Now;
    }
    public decimal Calori
    {
        get
        {
            return field;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                value = field;
            }
        }
    }
}
