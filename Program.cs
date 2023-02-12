using ExtendableConsoleApplication;

bool isOpened = true;

while (isOpened)
{
    CommandManager.GetCommands();
    CommandManager.Invite();
    CommandManager.GetUserInput();
    CommandManager.ExecuteCommand();
}
