namespace pt4;

public class Man
{
    private String name;

    public Man(string name)
    {
        this.name = name;
    }

    public void Stand()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(name + ", стою");
    }
    
    public void Go()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(name + ", иду");
        Barrier.Event1 -= Stand;
        Barrier.Event2 -= Go;
    }
}