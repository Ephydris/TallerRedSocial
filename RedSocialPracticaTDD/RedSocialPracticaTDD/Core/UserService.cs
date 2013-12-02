using System;
using System.Collections.Generic;

namespace RedSocialPracticaTDD.Core
{
    public class UserService
    {
     
        private UserRepo _repo;

        public UserService(UserRepo userRepo)
        {
            _repo = userRepo;
        }
        
        public void Register(string newUser)
        {
            if (_repo.ExistUser(newUser))
            {
                throw new Exception();
            }
            _repo.Add(newUser);
        }

        public void Follow(string follower, string userFollowed)
        {
            _repo.Find(userFollowed).AddFollower(follower);

        }
        public List<string> GetFollowers(string user)
        {
            return _repo.Find(user).GetFollowers();
        }
    }
}
