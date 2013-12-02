using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialPracticaTDD
{
    public class UserManagement
    {
        List<string> _userList= new List<string>();
        public void Register(string newUser)
        {
            _userList.Add(newUser);
        }
    }
}
