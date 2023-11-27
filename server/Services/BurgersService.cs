

namespace cowboyBurger_C.Services;

public class BurgersService
{
    private readonly BurgersRepository _burgersRepository;
    public BurgersService(BurgersRepository burgersRepository)
    {
        _burgersRepository = burgersRepository;
    }


    internal List<Burger> GetBurgers()
    {
        List<Burger> burgers = _burgersRepository.GetBurgers();
        return burgers;
    }
    internal Burger GetBurgerById(int burgerId)
    {
        Burger burger = _burgersRepository.GetBurgerById(burgerId);
        if (burger == null)
        {
            throw new Exception($"Invalid Id: {burgerId}");
        }
        return burger;
    }
    internal Burger CreateBurger(Burger burgerData)
    {
        if (burgerData.Name == null)
        {
            throw new Exception("Please provide a name");
        }
        Burger burger = _burgersRepository.CreateBurger(burgerData);
        return burger;
    }
    internal string DestroyBurger(int burgerId)
    {
        Burger burger = GetBurgerById(burgerId);

        _burgersRepository.DestroyBurger(burger);

        return $"{burger.Name} has been taken off the menu";
    }
}