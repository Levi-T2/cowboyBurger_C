



namespace cowboyBurger_C.Repositories;

public class BurgersRepository
{
    private List<Burger> _burgers;
    public BurgersRepository()
    {
        _burgers = [
            new Burger(1, "Cowboy Burger", "Its So Good!", 10, true),
            new Burger(2, "Western Burger", "BBQ Bacon Burger", 12, true),
            new Burger(3, "Kids Burger", "Small Kids Burger", 6, false)
        ];
    }

    internal List<Burger> GetBurgers()
    {
        return _burgers;
    }
    internal Burger GetBurgerById(int burgerId)
    {
        Burger foundBurger = _burgers.Find(burger => burger.Id == burgerId);
        return foundBurger;
    }

    internal Burger CreateBurger(Burger burgerData)
    {
        Burger lastBurger = _burgers[_burgers.Count - 1];
        if (lastBurger == null)
        {
            burgerData.Id = 1;
        }
        else
        {
            burgerData.Id = lastBurger.Id + 1;
        }
        _burgers.Add(burgerData);
        return burgerData;
    }

    internal void DestroyBurger(Burger burger)
    {
        _burgers.Remove(burger);
    }
}