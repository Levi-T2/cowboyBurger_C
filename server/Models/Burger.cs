namespace cowboyBurger_C.Models;

public class Burger
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public bool HasCheese { get; set; }

    public Burger(int id, string name, string description, int price, bool hasCheese)
    {

    }
}