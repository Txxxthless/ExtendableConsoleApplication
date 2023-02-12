using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal static class CommandManager
    {
        private static List<ICommand> Commands = new List<ICommand>();

        public static void GetCommands()
        {
            foreach (var command in Commands)
            {

            }
        }
    }
}
