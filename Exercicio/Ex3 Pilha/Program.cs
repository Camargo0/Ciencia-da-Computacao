}

class Program
{
    static void Main()
    {
        CustomStack<string> customStack = new CustomStack<string>();

        // Adiciona alguns valores à pilha
        customStack.Push("Primeiro item");
        customStack.Push("Segundo item");
        customStack.Push("Terceiro item");

        Console.WriteLine("Elementos na pilha:");
        customStack.PrintStack();

        // Verifica se a pilha está vazia
        Console.WriteLine($"A pilha está vazia? {customStack.IsEmpty()}");

        // Remove um elemento da pilha e o exibe
        string poppedItem = customStack.Pop();
        Console.WriteLine($"Elemento removido: {poppedItem}");

        // Exibe o elemento no topo da pilha sem removê-lo
        string topItem = customStack.Peek();
        Console.WriteLine($"Elemento no topo da pilha: {topItem}");

        // Exibe os elementos restantes na pilha
        Console.WriteLine("Elementos na pilha após pop e peek:");
        customStack.PrintStack();
    }
}
