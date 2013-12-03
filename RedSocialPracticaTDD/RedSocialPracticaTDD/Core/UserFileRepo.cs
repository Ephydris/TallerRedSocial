using System;
using System.IO;

namespace Core
{
    public class UserFileRepo : IUserRepo
    {
        private const string FileRepo = "UserRepo.txt";

        public void Add(string newUser)
        {
            using (StreamWriter writer = File.AppendText(FileRepo))
            {
                writer.WriteLine(newUser);
            }
        }

        public bool ExistUser(string user)
        {
            try
            {
                return !string.IsNullOrEmpty(SearchUserLineInFile(user));
            }
            catch (Exception)
            {
                throw new Exception("Error reading Repo File");
            }
        }

        public User Find(string username)
        {
            try
            {
                User user;
                var userInfo = SearchUserLineInFile(username).Split(',');
                user = new User(username);
                for (int i = 1; i <= userInfo.Length - 1; i++)
                {
                    user.AddFollower(userInfo[i]);
                }

                return user;
            }
            catch (Exception)
            {

                throw new Exception("Error reading Repo File");
            }
        }


        private static String SearchUserLineInFile(string user)
       {
           if (File.Exists(FileRepo))
           {
               using (StreamReader sr = new StreamReader(FileRepo))
               {
                   while (sr.Peek() >= 0)
                   {
                       string line = sr.ReadLine();
                       if (line.Split(',')[0] == user)
                           return line;
                   }
               }
           }
           return null;
       }
    }
}
