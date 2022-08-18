namespace scratchpackage;

public class Class1
{
    public void ViewStack()
    {
        Console.WriteLine("Hello, World!");

        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        foreach (var i in stack)
        {
            Console.WriteLine(i);
        }

        if (stack.TryPeek(out var n))
        {
            Console.WriteLine(n);
        }
    }
}
