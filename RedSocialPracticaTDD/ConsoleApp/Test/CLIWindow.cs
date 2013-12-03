

using System;

namespace ConsoleApp.Test
{
    static class CLIWindow
    {
        private static CommandExecuter commandExecuter;
        public static void Main()
        {
            commandExecuter = new CommandExecuter(new UserServiceProxy());
            string command=Console.ReadLine();
            while (command != "exit")
            {
                commandExecuter.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}
