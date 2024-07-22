namespace Cafeteria.Entities;
class MenuItem
{
    public Snack Snack { get; set; }
    public int Quantity { get; set; }

    public MenuItem(Snack snack, int quantity)
    {
        Snack = snack;
        Quantity = quantity;
    }
}
