using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal static class CommandManager
    {
        private static List<ICommand> Commands = new List<ICommand>() {new SumCommand() };
        private static int UserInput;
        private static ICommand? ExecutableCommand;

        public static void Invite()
        {
            Console.WriteLine("Please, choose the needed command!");
            GetUserInput();
        }

        public static void GetCommands()
        {
            Console.WriteLine("Available Commands: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Commands.Count; i++)
            {
                Console.WriteLine("COMMAND INDEX: {0} \nDESCRIPTION: {1}\n" ,i ,Commands[i].GetCommandDescription());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GetUserInput()
        {
            while (
                !int.TryParse(Console.ReadLine(), out UserInput) || (UserInput < 0) || UserInput > Commands.Count - 1
                ) 
            { 
                Console.WriteLine("INCORRECT INDEX UNPUT!");
            }
            ExecutableCommand = Commands[UserInput];
            Console.WriteLine();
        }

        public static void ExecuteCommand()
        {
            if (ExecutableCommand != null) ExecutableCommand.Execute();
            else throw new Exception("Executable command is null!");
        }
    }
}
