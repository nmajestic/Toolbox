namespace Lib.Parse;

public static class Parser
{

    public static void ParseCommand(string unparsedCommand)
    {
        var parsedCommand = Command.Command.CreateCommand(unparsedCommand);
        
        var commands = Command.Command.LookupCommand();
  
        foreach (var command in commands)
        {
            if (parsedCommand.Keys.Contains(command.Key.Name.ToLower()))
            {
                if (command.Key.HasOptions)
                {
                    foreach (var parsedCommandOption in parsedCommand.Values) command.Key.ExecuteOptions(parsedCommandOption);
                }
                else
                {
                    command.Key.Execute();
                }
            }
        }
        
    }
}