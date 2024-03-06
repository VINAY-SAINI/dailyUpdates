namespace file1
{
    public delegate void SomethingWillHappened(int a, int b);

public class Publisher : Subscriber
{

    public void sum(int a, int b)
    {
        Console.WriteLine($"the sum of {a} + {b} = {a + b}");
    }
}
public class Subscriber
{
    public void substract(int a, int b)
    {
        Console.WriteLine($"the sum of { a} - {b} = {a - b}");
    }
}
}