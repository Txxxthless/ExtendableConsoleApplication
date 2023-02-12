using ExtendableConsoleApplication;

bool isOpened = true;

while (isOpened)
{
    CommandManager.Invite();
    CommandManager.GetCommands();
    CommandManager.GetUserInput();
    CommandManager.ExecuteCommand();
}
