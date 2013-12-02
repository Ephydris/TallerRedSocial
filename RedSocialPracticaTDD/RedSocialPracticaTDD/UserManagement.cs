using System;
using System.Collections.Generic;

namespace RedSocialPracticaTDD
{
    public class UserManagement
    {
        List<string> _userList= new List<string>();
        public void Register(string newUser)
        {
            if (_userList.Contains(newUser))
            {
                throw new Exception();
            }
            _userList.Add(newUser);
        }
    }
}
