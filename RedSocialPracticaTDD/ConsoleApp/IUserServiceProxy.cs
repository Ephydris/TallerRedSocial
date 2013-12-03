
using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IUserServiceProxy
    {
        void Register(string username);
        List<string> GetFollowers(string username);
        void Follow(string follower, string userFollowed);
    }
}
