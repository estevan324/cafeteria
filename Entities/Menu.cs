namespace Cafeteria.Entities;

class Menu
{
    public List<MenuItem> Items { get; }

    public Menu()
    {
        Items = new List<MenuItem>();
    }

    public void AddItem(MenuItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(MenuItem item)
    {
        Items.Remove(item);
    }
}
