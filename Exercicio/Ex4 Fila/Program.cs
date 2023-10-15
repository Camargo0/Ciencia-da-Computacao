﻿using QueueClass;

class Program
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();

        fila.Enqueue(14);
        fila.Enqueue(31);
        fila.Enqueue(22);
        fila.Enqueue(1);
        fila.Enqueue(12);

        fila.Print();

        int startItem = fila.PeekStart();
        int endItem = fila.PeekEnd();
        int length = fila.Comprimento();

        Console.WriteLine($"Primeiro item da fila: {startItem}");
        Console.WriteLine($"Último item da fila: {endItem}");
        Console.WriteLine($"Comprimento da fila: {length}");
    }
}