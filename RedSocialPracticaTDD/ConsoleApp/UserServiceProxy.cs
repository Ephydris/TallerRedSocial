
using System.Collections.Generic;
using Core;

namespace ConsoleApp
{
    internal class UserServiceProxy : IUserServiceProxy
    {
        private static UserService _externalService;

        public UserServiceProxy()
        {
            _externalService = new UserService(new UserFileRepo());
        }

        public void Register(string username)
        {
            _externalService.Register(username);
        }

        public List<string> GetFollowers(string username)
        {
            return _externalService.GetFollowers(username);
        }

        public void Follow(string follower, string userFollowed)
        {
            _externalService.Follow(follower, userFollowed);
        }


    }


}
