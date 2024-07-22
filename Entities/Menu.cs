using System.Text;

namespace Cafeteria.Entities;

class Menu
{
    public List<MenuItem> Items { get; }
    public double Total
    {
        get
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Quantity * item.Snack.Price;
            }

            return total;
        }
    }

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

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("---------------------------------------------------------");
        foreach (var item in Items)
        {
            var subtotal = item.Quantity * item.Snack.Price;
            sb.AppendLine($"{item.Quantity} x\t{item.Snack.Description} - R$ {subtotal.ToString("F2")}");
        }
        sb.AppendLine("---------------------------------------------------------");

        return sb.ToString();
    }
}
