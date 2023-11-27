using Microsoft.AspNetCore.Http.HttpResults;

namespace cowboyBurger_C.Controllers;

[ApiController]
[Route("cowboyBurger/[controller]")]
public class BurgersController : ControllerBase
{
    private readonly BurgersService _burgersService;

    public BurgersController(BurgersService burgersService)
    {
        _burgersService = burgersService;
    }

    [HttpGet]
    public ActionResult<List<Burger>> GetBurgers()
    {
        try
        {
            List<Burger> burgers = _burgersService.GetBurgers();
            return Ok(burgers);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpGet("{burgerId}")]
    public ActionResult<Burger> GetBurgerById(int burgerId)
    {
        try
        {
            Burger burger = _burgersService.GetBurgerById(burgerId);
            return Ok(burger);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpPost]
    public ActionResult<Burger> CreateBurger([FromBody] Burger burgerData)
    {
        try
        {
            Burger burger = _burgersService.CreateBurger(burgerData);
            return Ok(burger);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpDelete("{burgerId}")]
    public ActionResult<string> DestroyBurger(int burgerId)
    {
        try
        {
            string message = _burgersService.DestroyBurger(burgerId);
            return Ok(message);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}