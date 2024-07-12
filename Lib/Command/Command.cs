namespace Lib.Command;

public static class Command
{
    private static Dictionary<ICommand, char> Commands { get; set; }
    
    private static Dictionary<ICommand, char> commands = new();
    
    public static Dictionary<ICommand, char> Register(ICommand command, char option)
    {
        Commands = commands;
        commands.Add(command, option);

        return commands;
    }
    
    public static Dictionary<string, char> CreateCommand(string unformattedCommand)
    {
        Dictionary<string, char> formmatedCommand = new Dictionary<string, char>();

        if (!string.IsNullOrWhiteSpace(unformattedCommand))
        {
            var words = unformattedCommand.Split(' ');

            for (int i = 0; i < words.Length - 1; i++)
            {
                var key = words[i];
                var value = words[i+1][0];

                if (!formmatedCommand.ContainsKey(key))
                {
                    formmatedCommand.Add(key, value);
                }
            }
        }

        return formmatedCommand;
    }

    public static Dictionary<ICommand, char> LookupCommand()
    {
        return commands;
    }
}