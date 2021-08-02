using LoneLabWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddUser(string userName)
        {
            await _loginService.AddUserName(userName);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUser(string userName)
        {
            await _loginService.RemoveUserName(userName);
            return Ok();
        }
    }
}
