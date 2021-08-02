using LoneLabWebApp.Services.Hubs;
using LoneLabWebApp.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoneLabWebApp.Services
{
    public class LoginService : ILoginService
    {
        private List<string> _userNames = new List<string>();
        private readonly UserListHub _userListHub;
        public LoginService(UserListHub userListHub)
        {
            _userListHub = userListHub;
        }
        public async Task AddUserName(string userName)
        {
            _userNames.Add(userName);
            await _userListHub.SendUserList(_userNames);
        }

        public async Task RemoveUserName(string userName)
        {
            _userNames.Remove(userName);
            await _userListHub.SendUserList(_userNames);
        }
    }
}
