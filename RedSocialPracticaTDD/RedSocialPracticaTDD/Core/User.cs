
using System.Collections.Generic;

namespace Core
{
    public class User
    {
       private List<string> _followers;

        public string Name{get; set;}

        public User(string name)
        {
            Name = name;
            _followers=new List<string>();
        }

        public List<string> GetFollowers()
        {
            return _followers;
        }

        public void AddFollower(string otherUser)
        {
           _followers.Add(otherUser);
        }
    }
}
