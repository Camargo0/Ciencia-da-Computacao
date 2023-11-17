class Program
{
    static void Main()
    {
        StackManager minhaStack = new StackManager();

        minhaStack.Push("Item 1");
        minhaStack.Push("Item 2");
        minhaStack.Push("Item 3");

        minhaStack.PrintStack();

        Console.WriteLine($"Peek: {minhaStack.Peek()}");

        Console.WriteLine($"Pop: {minhaStack.Pop()}");
        minhaStack.PrintStack();

        Console.WriteLine($"A pilha está vazia? {minhaStack.IsEmpty()}");
    }
}
