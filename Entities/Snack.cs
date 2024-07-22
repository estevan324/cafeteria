namespace Cafeteria.Entities;

class Snack
{
    public int Code { get; }
    public string Description { get; }
    public double Price { get; }

    public Snack(int code, string description, double price)
    {
        Code = code;
        Description = description;
        Price = price;
    }
}
