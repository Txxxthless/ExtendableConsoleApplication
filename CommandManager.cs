using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal static class CommandManager
    {
        private static List<ICommand> Commands = new List<ICommand>() { };
        private static ConsoleKeyInfo? UserInput;

        public static void Invite()
        {
            Console.WriteLine("Please, choose the needed command!");
        }

        public static void GetCommands()
        {
            foreach (var command in Commands)
            {
                command.GetCommandDescription();
            }
        }

        public static void GetUserInput()
        {
            UserInput = Console.ReadKey();
        }

        public static void ExecuteCommand()
        {

        }
    }
}
