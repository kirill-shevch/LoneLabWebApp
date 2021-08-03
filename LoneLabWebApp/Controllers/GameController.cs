using LoneLabWebApp.Services.Hubs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoneLabWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly UserListHub _userListHub;
        public GameController(UserListHub userListHub)
        {
            _userListHub = userListHub;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(string userName)
        {
            await _userListHub.AddUserName(userName);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUser(string userName)
        {
            await _userListHub.RemoveUserName(userName);
            return Ok();
        }
    }
}
