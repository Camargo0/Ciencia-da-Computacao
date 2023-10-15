using System;
using System.Collections.Generic;

namespace QueueClass
{
    public class Queue<T>
    {
        private LinkedList<T> queueList = new LinkedList<T>();

        // Adicionar um item ao final da fila
        public void Enqueue(T item)
        {
            queueList.AddLast(item);
        }

        // Mostrar todos os elementos na fila
        public void Print()
        {
            foreach (T item in queueList)
            {
                Console.WriteLine(item);
            }
        }

        // Obter o primeiro elemento da fila sem removê-lo
        public T PeekStart()
        {
            if (queueList.Count > 0)
            {
                return queueList.First.Value;
            }
            throw new InvalidOperationException("A fila está vazia.");
        }

        // Obter o último elemento da fila sem removê-lo
        public T PeekEnd()
        {
            if (queueList.Count > 0)
            {
                return queueList.Last.Value;
            }
            throw new InvalidOperationException("A fila está vazia.");
        }

        // Obter o comprimento da fila
        public int Comprimento()
        {
            return queueList.Count;
        }
    }
}