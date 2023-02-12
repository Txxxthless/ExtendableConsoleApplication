using ExtendableConsoleApplication;

bool isOpened = true;

while (isOpened)
{
    CommandManager.GetCommands();
    CommandManager.Invite();
    try { CommandManager.ExecuteCommand(); } 
    catch (Exception ex) { Console.WriteLine(ex.Message); }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Press E to exit the application\nPress any other key to continue...");
    if (Console.ReadKey().Key == ConsoleKey.E) isOpened = false;
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}   
