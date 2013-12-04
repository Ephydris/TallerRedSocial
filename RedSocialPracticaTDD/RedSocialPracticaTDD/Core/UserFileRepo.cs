using System;
using System.Collections.Generic;
using System.IO;

namespace Core
{
    public class UserFileRepo : IUserRepo
    {
        private List<User> _userList = new List<User>();
        private const string FileRepo = "UserRepo.txt";

        public UserFileRepo()
        {
            _userList=new List<User>();
            ReadFromFile();
        }

        public void Add(string newUser)
        {
           _userList.Add(new User(newUser));
        }

        public bool ExistUser(string user)
        {
                return _userList.Exists(p => p.Name == user);           
        }

        public User Find(string username)
        {
            return _userList.Find(p => p.Name == username);
        }

        public void Save()
        {
            String text = UserListToText();
            System.IO.File.WriteAllText(FileRepo, text);
          
        }

        private string UserListToText()
        {
            string Text = string.Empty;
            foreach (User user in _userList)
            {
                Text += user.Name;
                foreach (string follower in user.GetFollowers())
                {
                    Text += "," + follower;
                }
                Text += "\r\n";
            }
            return Text;
        }

        private void ReadFromFile()
        {
            if (File.Exists(FileRepo))
            {
                var Text = File.ReadAllLines(FileRepo);
                FileToList(Text);
            }
        }

        private void FileToList(string[] Text)
        {
            foreach (string line in Text)
            {
                var userInfo = line.Split(',');
                User user = new User(userInfo[0]);
                for (int i = 1; i <= userInfo.Length - 1; i++)
                {
                    user.AddFollower(userInfo[i]);
                }
                _userList.Add(user);
            }
        }
    }
}
