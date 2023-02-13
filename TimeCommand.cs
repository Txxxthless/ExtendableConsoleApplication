using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal class TimeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine(GetCurrentTime());
        }

        private string GetCurrentTime()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString();
        }

        public string GetCommandDescription()
        {
            return "Command - GET TIME: Choose this command to get current time."; ;
        }
    }
}
