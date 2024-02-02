using Microsoft.AspNetCore.Mvc;

namespace final_mongodb_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly UsersService _usersService;

    public UsersController(UsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public ActionResult<List<UserData>> Get()
    {
        return _usersService.Get();
    }

}

