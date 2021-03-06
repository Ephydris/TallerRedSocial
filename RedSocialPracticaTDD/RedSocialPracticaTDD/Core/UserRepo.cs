﻿using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class UserRepo:IUserRepo
    {
        List<User> _userList = new List<User>();
        public void Add(string newUser)
        {
            _userList.Add( new User(newUser));
        }

        public bool ExistUser(string user)
        {
            return _userList.Any(p => p.Name==user);
        }

        public User Find(string user)
        {
            return _userList.First(p => p.Name == user);
        }

        public void Save()
        {
            
        }
    }
}
