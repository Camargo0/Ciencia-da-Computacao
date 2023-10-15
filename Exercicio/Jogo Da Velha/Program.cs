using System;

class Programx
{
    static void Main()
    {
        char[,] b = {{' ',' ',' '},{' ',' ',' '},{' ',' ',' '}};
        char p = 'X';
        bool g = false;
        for(int m=0;m<9&&!g;m++) {
            Console.Clear();
            Console.WriteLine("  0 1 2");
            for(int r=0;r<3;r++) {
                Console.Write(r + " ");
                for(int c=0;c<3;c++) {
                    Console.Write(b[r, c]);
                    if(c<2) Console.Write("|");
                }
                Console.WriteLine();
                if(r<2) Console.WriteLine("  -----");
            }
            int i, j;
            do {
                Console.Write($"Jogador '{p}', linha (0, 1, 2) e coluna (0, 1, 2): ");
                string[] s = Console.ReadLine().Split();
                i = int.Parse(s[0]);
                j = int.Parse(s[1]);
            } while(b[i, j] != ' ');
            b[i, j] = p;
            if(b[i, 0] == p && b[i, 1] == p && b[i, 2] == p || b[0, j] == p && b[1, j] == p && b[2, j] == p || i == j && b[0, 0] == p && b[1, 1] == p && b[2, 2] == p || i + j == 2 && b[0, 2] == p && b[1, 1] == p && b[2, 0] == p) {
                g = true;
                Console.Clear();
                Console.WriteLine("  0 1 2");
                for(int r=0;r<3;r++) {
                    Console.Write(r + " ");
                    for(int c=0;c<3;c++) {
                        Console.Write(b[r, c]);
                        if(c<2) Console.Write("|");
                    }
                    Console.WriteLine();
                    if(r<2) Console.WriteLine("  -----");
                }
                Console.WriteLine($"Jogador '{p}' venceu!");
            }
            p = p == 'X' ? 'O' : 'X';
        }
        if(!g) Console.WriteLine("O jogo empatou!");
    }
}