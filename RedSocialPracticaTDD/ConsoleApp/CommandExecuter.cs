
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class CommandExecuter
    {
        private IUserServiceProxy _proxy;
        public CommandExecuter(IUserServiceProxy proxy)
        {
            _proxy = proxy;
        }
        public void ExecuteCommand(string command)
        {
            var commandExtracted = SplitCommand(command);
            if (commandExtracted[0].Equals("add"))
            {
                try
                {
                    _proxy.Register(commandExtracted[1]);
                }
                catch (Exception e)
                {

                    Console.Write(e.Message + "\r\n");
                }

            }
            if (commandExtracted[0].Equals("follow"))
            {
                _proxy.Follow(commandExtracted[1], commandExtracted[2]);
            }
            if (commandExtracted[0].Equals("followers"))
            {
                List<string> followers = _proxy.GetFollowers(commandExtracted[1]);
                if (followers !=null && followers.Count > 0)
                {
                    Console.Write(string.Join(" ", followers.ToArray()));
                }
                else
                {
                    Console.Write("No followers found");
                }
            }
        }

        private static string[] SplitCommand(string command)
        {
            return command.Split(' ');
        }
    }
}
