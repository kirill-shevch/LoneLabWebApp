using LoneLabWebApp.Services.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace LoneLabWebApp.Hubs
{
    public class UserListHub : Hub
    {
        private readonly ILoginService _loginService;
        public UserListHub(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public async Task GetUserList()
        {
            await Clients.All.SendAsync("ReceiveUserList", string.Join(", ", _loginService.GetUserNames()));
        }
    }
}
