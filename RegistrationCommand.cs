using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableConsoleApplication
{
    internal class RegistrationCommand : ICommand
    {
        public void Execute()
        {
            RegisterUser();
        }

        public void RegisterUser()
        {
            string login, password;
            Console.WriteLine("Enter your login");
            while ((login = Console.ReadLine()).Length < 5)
            {
                Console.WriteLine("Minimal length of login is 5!");
            }
            Console.WriteLine("Enter your password:");
            while ((password = Console.ReadLine()).Length < 7)
            {
                Console.WriteLine("Minimal length of password is 7!");
            }

            string[] data = new string[] { $"Login: {login}", $"Password: {password}", $"Registration time: {DateTime.Now}" };
            File.WriteAllLines("New_User.txt", data);
        }

        public string GetCommandDescription()
        {
            return "Command - USER REGISTRATION: You will be asked to enter your data, which will be saved in a file";
        }
    }
}
