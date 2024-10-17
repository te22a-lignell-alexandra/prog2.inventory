public class Inventory
{
    public List<Item> items = new();
    public void Display()
    {
        System.Console.WriteLine("\nInventory:");
        foreach (Item item in items)
        {
            System.Console.WriteLine("1. " + item);
        }
    }
}
