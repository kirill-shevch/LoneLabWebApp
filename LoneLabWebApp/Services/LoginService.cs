using LoneLabWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace LoneLabWebApp.Services
{
    public class LoginService : ILoginService
    {
        private List<string> _userNames = new List<string>();
        public void AddUserName(string userName)
        {
            _userNames.Add(userName);
        }

        public List<string> GetUserNames()
        {
            return _userNames;
        }

        public void RemoveUserName(string userName)
        {
            _userNames.Remove(userName);
        }
    }
}
