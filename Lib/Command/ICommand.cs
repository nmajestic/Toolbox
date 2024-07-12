namespace Lib.Command;

public interface ICommand
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<char> Options { get; set; }
    
    public bool HasOptions { get; set; }
    public void Execute();
    public void ExecuteOptions(char option);
}