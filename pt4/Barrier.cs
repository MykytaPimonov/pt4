namespace pt4;

public class Barrier
{
    public delegate void Operation();

    public static event Operation Event1;
    public static event Operation Event2;

    private Random random = new Random();

    public void MoveThrough(int i)
    {
        if ((i & 1) == (random.Next(1, 10) & 1))
        {
            Event1();
        }
        else
        {
            Event2();
        }
    }

    public void Close()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Закрыто");
    }

    public void Open()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Открыто");
    }
}