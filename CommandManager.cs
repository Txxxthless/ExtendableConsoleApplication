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

        public static void Invite()
        {
            Console.WriteLine("Please, choose the needed command!");
        }

        public static void GetCommands()
        {
            Console.WriteLine("Available Commands: ");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Commands.Count; i++)
            {
                Console.WriteLine("\tCOMMAND INDEX: {0} \n\tDESCRIPTION: {1}\n" ,i ,Commands[i].GetCommandDescription());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GetUserInput()
        {
            while (
                !int.TryParse(Console.ReadLine(), out UserInput) || (UserInput < 0) || UserInput > Commands.Count
                ) 
            { 
                Console.WriteLine("INCORRECT INDEX UNPUT!");
            }
            Console.WriteLine();
        }

        public static void ExecuteCommand()
        {

        }
    }
}
