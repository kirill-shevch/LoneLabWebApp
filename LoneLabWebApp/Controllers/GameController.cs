using LoneLabWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoneLabWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly ILoginService _loginService;
        public GameController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(string userName)
        {
            _loginService.AddUserName(userName);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveUser(string userName)
        {
            _loginService.RemoveUserName(userName);
            return Ok();
        }
    }
}
