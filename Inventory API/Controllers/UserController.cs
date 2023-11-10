using Application.User_Service.Interface;
using Domain.Model.User_Model;
using Microsoft.AspNetCore.Mvc;


namespace Inventory_API.Controllers
{
    [ApiController]
    [Route("api/user/")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;            
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserAsync(RegisterUserModel registerModel)
        {
            var response = await _userService.RegisterUserAsync(registerModel);
            return Ok(response);
        }
    }
}
