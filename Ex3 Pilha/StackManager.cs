using System;
using System.Collections.Generic;

public class StackManager
{
    private Stack<string> minhaPilha;

    public StackManager()
    {
        minhaPilha = new Stack<string>();
    }

    public void Push(string valor)
    {
        minhaPilha.Push(valor);
    }

    public string Pop()
    {
        if (minhaPilha.Count > 0)
            return minhaPilha.Pop();
        else
            throw new InvalidOperationException("A pilha está vazia. Não é possível realizar a operação Pop.");
    }

    public string Peek()
    {
        if (minhaPilha.Count > 0)
            return minhaPilha.Peek();
        else
            throw new InvalidOperationException("A pilha está vazia. Não é possível realizar a operação Peek.");
    }

    public bool IsEmpty()
    {
        return minhaPilha.Count == 0;
    }

    public void PrintStack()
    {
        Console.WriteLine("Conteúdo da Pilha:");
        foreach (var item in minhaPilha)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
